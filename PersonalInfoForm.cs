﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyQQ
{
    /// <summary>
    /// 个人设置页面
    /// </summary>
    public partial class PersonalInfoForm : Form
    {
        public MainForm mainForm;//主窗体
        private string[] stars = new string[12];//星座Id数组
        private string[] bloodTypes = new string[4];//血型Id数组
        public PersonalInfoForm()
        {
            InitializeComponent();
        }
        //窗体加载，从数据库读取信息显示
        private void PersonalInfoForm_Load(object sender, EventArgs e)
        {
            //让个人资料Panel可见，安全设置Panel不可见
            pnlDetails.Visible = true;
            pnlSecurity.Visible = false;
            //设置左侧两个导航图片按钮的图片
            picDetails.Image = ilLink.Images[1];//选中的
            picSecurity.Image = ilLink.Images[2];//未选中的
            int starId = -1;             //星座Id
            int bloodTypeId = -1;        //血型Id
            int faceId = 0;              //头像Id
            int friendshipPolicyId = 0;  //好友策略Id
            bool error = false;          //用来标识操作数据库是否出错
            //查询用的sql语句
            string sql = string.Format(
                "SELECT*FROM User WHERE id={0}", UserHelper.loginId);
            try
            {
                //执行查询
                SqlCommand command = new SqlCommand(sql, DBHelper.connection);
                DBHelper.connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //将查出的数据显示在窗体上
                if (reader.Read())
                {
                    this.txtLoginId.Text = Convert.ToString(reader["Id"]);          //号码
                    this.txtNickName.Text = Convert.ToString(reader["NickName"]);   //昵称
                    this.cboSex.Text = Convert.ToString(reader["Sex"]) == "男" ? "男" : "女";   //性别
                    if (!(reader["Name"] is DBNull)) //要告诉学生如何判断
                    {
                        this.txtName.Text = reader["Name"].ToString();
                    }
                    this.txtAge.Text = Convert.ToString(reader["Age"]);
                    this.txtoldPwd.Text = Convert.ToString(reader["LoginPwd"]);//密码

                    if (!(reader["StarId"] is DBNull))
                    {
                        starId = Convert.ToInt32(reader["StarId"]);   //星座Id
                    }
                    if (!(reader["StarId"] is DBNull))
                    {
                        bloodTypeId = Convert.ToInt32(reader["BloodTypeId"]);  //血型Id                                              
                    }
                    faceId = Convert.ToInt32(reader["FaceId"]);  //头像Id
                    friendshipPolicyId = Convert.ToInt32(reader["FriendshipPolicyId"]);  //好友策略Id
                }
            }
            catch (Exception ex)
            {
                error = true;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.connection.Close();
            }
            //出错了
            if (error)
            {
                MessageBox.Show("显示个人信息出错！", "抱歉", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //处理星座组合框
                FillStarsComboBox(starId);
                //处理血型组合框
                FillBloodTypesComboBox(bloodTypeId);
                //处理头像显示
                ShowFace(faceId);
                //处理好友策略
                switch (friendshipPolicyId)
                {
                    case 1:
                        rdoAnybody.Checked = true;
                        break;
                    case 2:
                        rdoValidation.Checked = true;
                        break;
                    case 3:
                        rdoNobody.Checked = true;
                        break;
                }
            }
        }
        //点击个人信息，显示个人信息Panel,其他的Panel不可见
        private void picDetails_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = true;    //个人信息部分可见
            pnlSecurity.Visible = false;  //安全设置部分不可见

            //左侧导航按钮的图片
            picDetails.Image = ilLink.Images[1];
            picSecurity.Image = ilLink.Images[2];
        }
        //显示安全设置Panel
        private void picSecurity_Click(object sender, EventArgs e)
        {
            pnlSecurity.Location = pnlDetails.Location;
            pnlSecurity.Visible = true;     //安全设置部分不可见
            pnlDetails.Visible = false;    //个人信息部分不可见

            //设置左侧导航按钮的图片
            picDetails.Image = ilLink.Images[0];
            picSecurity.Image = ilLink.Images[3];
        }
        //选择头像
        private void btnShowFaces_MouseClick(object sender, EventArgs e)
        {
            FacesForm facesForm = new MyQQ.FacesForm();
            facesForm.personalInfoForm = this;
            facesForm.Show();
        }
        //点击确定，更新数据到数据库
        private void btnOK_Click(object sender, EventArgs e)
        {
            //输入验证
            if (ValidataInput())
            {
                string sql = GetSQL();   //获取更新用的SQL语句
                int result = -1;         //数据库擦偶偶结果
                try
                {
                    //执行命令
                    SqlCommand command = new SqlCommand(sql, DBHelper.connection);
                    DBHelper.connection.Open();
                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    DBHelper.connection.Close();
                }
                //根据执行结果，显示不同的消息
                if (result == 1)
                {
                    MessageBox.Show("服务器已经接受你的请求!", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("服务器操作失败", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                mainForm.ShowSelfInfo();  //更新主窗体中的个人信息
                this.Close();//关闭窗体
            }
        }
        //点击取消，关闭窗体
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ///<summary>
        ///向星座组合框中显示内容
        ///</summary>
        private void FillStarsComboBox(int currentStarId)
        {
            string sql = "SELECT*FROM Star";  //产讯用SQL语句
            try
            {
                //创建Command对象
                SqlCommand command = new SqlCommand(sql, DBHelper.connection);
                DBHelper.connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                //初始化星座数组
                int i = 0;
                while (dataReader.Read())
                {
                    //将星座存放在星座数组中
                    this.stars[i] = Convert.ToString(dataReader["Star"]);
                    i++;
                }
                //将星座数组中的星座添加到星座组合框中
                for (i = 0; i < stars.Length; i++)
                {
                    cboStar.Items.Add(stars[i]);
                    if (currentStarId == i + 1)
                    {
                        cboStar.SelectedIndex = i;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("读星座出错");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.connection.Close();
            }
        }
        ///<summary>
        ///向血型组合框中显示内容
        ///</summary>
        private void FillBloodTypesComboBox(int currentBloodTypeId)
        {
            string sql = "SELECT*FROM BloodType";
            try
            {
                //闯将Command对象
                SqlCommand command = new SqlCommand(sql, DBHelper.connection);
                DBHelper.connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                //初始化血型数组
                int i = 0;
                while (dataReader.Read())
                {
                    //将血型存放在血型数组中
                    this.bloodTypes[i] = Convert.ToString(dataReader["BloodType"]);
                    i++;
                }
                //将血型数组中中的血型添加到血型组合框中
                for (i = 0; i < bloodTypes.Length; i++)
                {
                    cboBloodType.Items.Add(bloodTypes[i]);
                    if (currentBloodTypeId == i + 1)
                    {
                        cboBloodType.SelectedIndex = i;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("度血型出错");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.connection.Close();
            }
        }
        ///<summary>
        ///处理显示的头像
        ///</summary>
        public void ShowFace(int currentFaceId)
        {
            picFace.Image = ilFaces.Images[currentFaceId];
            picFace.Tag = currentFaceId;
        }
        ///<summary>
        ///验证用户是否填写了必填信息、密码是否一致
        ///</summary>
        ///<returns></returns>
        private bool ValidataInput()
        {
            if (txtNickName.Text.Trim() == "")  //昵称不能为空
            {
                MessageBox.Show("你忘了写昵称了!", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNickName.Focus();
                return false;
            }
            if(txtAge.Text.Trim()=="")  //年龄不能为空
            {
                MessageBox.Show("你忘了写年龄了!", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAge.Focus();
                return false;
            }
            if(cboSex.Text.Trim()=="")   //性别必选
            {
                MessageBox.Show("你忘了选性别了!", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSex.Focus();
                return false;
            }
            if(txtNewPwd.Text.Trim()!=txtNewPwdAgain.Text.Trim())   //两次输入的密码是否一致
            {
                MessageBox.Show("新密码和确认密码不一致", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPwdAgain.Focus();
                return false;
            }
            return true;
        }
        ///<summary>
        ///获得更新数据哭的SQL语句
        ///</summary>
        ///<returns></returns>
        private string GetSQL()
        {
            //更新用的sql语句，分成段拼凑
            string sql = string.Format("UPDATE Users SET NICKName='{0}',FaceId={1},Sex='{2}',Age={3}",
                txtNickName.Text.Trim(), Convert.ToInt32(picFace.Tag), cboSex.Text.Trim(), Convert.ToInt32(txtAge.Text.Trim()));
            if(txtNewPwd.Text.Trim()!="") //如果修改了密码就更新密码字段
            {
                sql = string.Format("{0},LoginPwd='{1}", sql, txtNewPwd.Text.Trim());
            }
            //添加好友策略，判断哪个待选按钮被选中
            int friendshipPolicyId = 0;
            if(rdoAnybody.Checked)
            {
                friendshipPolicyId = Convert.ToInt32(rdoAnybody.Tag);
            }
            else if(rdoValidation.Checked)
            {
                friendshipPolicyId = Convert.ToInt32(rdoValidation.Tag);
            }
            else if(rdoNobody.Checked)
            {
                friendshipPolicyId = Convert.ToInt32(rdoNobody.Tag);
            }
            //完整的sql
            sql=string.Format("{0},FriendshipPolicyId={1},Name='{2}',starId={3},BloodTypeId={4}WHRER Id= {5}",
                sql,friendshipPolicyId,txtName.Text.Trim(),cboStar.SelectedIndex+1,cboBloodType.SelectedIndex+1,cboBloodType.SelectedIndex+1,UserHelper.loginId);
            return sql;
        }
    }
}
