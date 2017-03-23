using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aptech.UI;
using System.Media;
using System.Data.SqlClient;

namespace MyQQ
{
    /// <summary>
    /// 登陆后的主窗体
    /// </summary>
    public partial class MainForm : Form
    {
        int fromUserId;//消息的发起者
        int friendFaceId;//发消息的好友的头像Id

        int messageImageIndex = 0;//工具栏中的消息图标的索引

        public MainForm()
        {
            InitializeComponent();
        }
        //窗体加载时发生
        private void MainForm_Load(object sender, EventArgs e)
        {
            //工具栏的消息图标
            tsbtnMessageReading.Image = ilMessage.Images[0];
            //显示个人信息
            ShowSelfInfo();
            //添加SideBar的两个组
            sbFriends.AddGroup("我的好友");
            sbFriends.AddGroup("陌生人");
            //想我的好友组中添加我的好友列表
            ShowFriendList();
        }
        //窗体关闭后，退出应用程序
        private void MainForm_FormClosed(object sender,FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //显示个人信息窗体
        private void tsbtnPersonalInfo_Click(object dender,EventArgs e)
        {

        }
        //显示查找好友窗体       
        private void tsbnSearchFriend_Click(object dender, EventArgs e)
        {
            SearchFriendForm searchFriendForm = new SearchFriendForm();
            searchFriendForm.Show();

        }
        //双击一项，弹出聊天对话框
        private void sbFriends_ItemDoubleClick(SbItemEventArgs e)
        {
            //消息timer停止运行
            if(tmrChatRequest.Enabled==true)
            {
                tmrChatRequest.Stop();
                e.Item.ImageIndex = this.friendFaceId;
            }
            //显示聊天窗体
            ChatForm chatForm = new ChatForm();
            chatForm.friendId = Convert.ToInt32(e.Item.Tag);//号码
            chatForm.nickName = e.Item.Text;//昵称
            chatForm.faceId = e.Item.ImageIndex;//头像
            chatForm.Show();
        }
        //点击刷新好友列表
        private void tsbtnUpdataFriendList_Click(object sender,EventArgs e)
        {
            ShowFriendList();
        }
        //定时扫描数据库，找到未读信息
        private void tmrMessage_Tick(object sender,EventArgs e)
        {
            ShowFriendList();//刷新好友列表
            int messageTypeId = 1;//消息类型
            int messageState = 1;//消息状态
            //找出未读消息对应的好友Id
            string sql = string.Format("SELECT Top 1 FromUserId,MessageTypeId,MessageState FROM Messages WHERE ToUserId={0}AND MessageState=0", UserHelper.LoginId);
            SqlCommand command;
            //消息有两种类型:聊天消息、添加好友消息
            try
            {
                command = new SqlCommand(sql, DBHelper.connection);
                DBHelper.connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                //循环读出一个未读消息
                if(dataReader.Read())
                {
                    this.fromUserId = (int)dataReader["FromUserId"];
                    messageTypeId = (int)dataReader["MessageTypeId"];
                    messageState = (int)dataReader["MessageState"];
                }
                dataReader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.message);
            }
            finally
            {
                DBHelper.connection.Close();
            }
            //判断消息类型，如果是添加好友消息，就启动喇叭timer,让小喇叭闪烁
            if(messageTypeId==2&&messageState==0)
            {
                SoundPlayer player = new SoundPlayer("sysytem.wav");
                player.Play();
                tmrAddFriend.Start();
            }
            //如果是聊天消息，就启动聊天timer，让好友头像闪烁
            else if(messageTypeId==1&& messageState==0)
            {
                //获取发消息人的头像Id
                sql = "SELECT FaceId FROM Users WHEREId=" + this.fromUserId;
                try
                {
                    command = new SqlCommand(sql, DBHelper.connection);
                    DBHelper.connection.Open();
                    this.friendFaceId = Convert.ToInt32(command.ExecuteScalar());//设置发消息的好友的头像索引

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    DBHelper.connection.Close();
                }
                //如果发消息的人没有在列表中就添加到陌生人列表中
                if(!HasShowUser(fromUserId))
                {
                    UpdateStranger(fromUserId);

                }
                SoundPlayer player = new SoundPlayer("msg.wav");
                player.Play();
                tmrChatRequest.Start();//启动闪烁头像定时器
            }
        }
        //控制喇叭闪烁
        private void tmrAddFriend_Tick(object sender,EventArgs e)
        {
            //反复修改它的图像
            messageImageIndex=messageImageIndex == 0 ? 1:0;
            tsbtnMessageReading.Image = ilMessage.Images[messageImageIndex];
        }
    }
}
