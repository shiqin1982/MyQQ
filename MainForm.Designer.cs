namespace MyQQ
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sbFriends = new Aptech.UI.SideBar();
            this.tsOperation = new System.Windows.Forms.ToolStrip();
            this.tsbtnPersonalInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearchFriend = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpdateFriendlist = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMessageReading = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.ilFaces = new System.Windows.Forms.ImageList(this.components);
            this.tmrMessage = new System.Windows.Forms.Timer(this.components);
            this.tmrAddFriend = new System.Windows.Forms.Timer(this.components);
            this.tmrChatRequest = new System.Windows.Forms.Timer(this.components);
            this.cmsFriendList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ilMessage = new System.Windows.Forms.ImageList(this.components);
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddFriend = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.cmsFriendList.SuspendLayout();
            this.SuspendLayout();
            // 
            // sbFriends
            // 
            this.sbFriends.AllowDragItem = false;
            this.sbFriends.BackColor = System.Drawing.Color.AliceBlue;
            this.sbFriends.FlatStyle = Aptech.UI.SbFlatStyle.Normal;
            this.sbFriends.GroupHeaderBackColor = System.Drawing.Color.LightSkyBlue;
            this.sbFriends.GroupTextColor = System.Drawing.Color.Black;
            this.sbFriends.ImageList = null;
            this.sbFriends.ItemContextMenuStrip = null;
            this.sbFriends.ItemStyle = Aptech.UI.SbItemStyle.PushButton;
            this.sbFriends.ItemTextColor = System.Drawing.Color.Navy;
            this.sbFriends.Location = new System.Drawing.Point(0, 60);
            this.sbFriends.Name = "sbFriends";
            this.sbFriends.RadioSelectedItem = null;
            this.sbFriends.Size = new System.Drawing.Size(201, 331);
            this.sbFriends.TabIndex = 6;
            this.sbFriends.View = Aptech.UI.SbView.LargeIcon;
            this.sbFriends.VisibleGroup = null;
            this.sbFriends.VisibleGroupIndex = -1;
            // 
            // tsOperation
            // 
            this.tsOperation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsOperation.BackgroundImage")));
            this.tsOperation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsOperation.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsOperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnPersonalInfo,
            this.tsbtnSearchFriend,
            this.tsbtnUpdateFriendlist,
            this.tsbtnMessageReading,
            this.tsbtnExit});
            this.tsOperation.Location = new System.Drawing.Point(0, 389);
            this.tsOperation.Name = "tsOperation";
            this.tsOperation.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsOperation.Size = new System.Drawing.Size(201, 25);
            this.tsOperation.TabIndex = 7;
            this.tsOperation.Text = "toolStrip1";
            // 
            // tsbtnPersonalInfo
            // 
            this.tsbtnPersonalInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPersonalInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPersonalInfo.Image")));
            this.tsbtnPersonalInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPersonalInfo.Name = "tsbtnPersonalInfo";
            this.tsbtnPersonalInfo.Size = new System.Drawing.Size(23, 22);
            this.tsbtnPersonalInfo.Text = "toolStripButton1";
            this.tsbtnPersonalInfo.ToolTipText = "个人信息";
            // 
            // tsbtnSearchFriend
            // 
            this.tsbtnSearchFriend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSearchFriend.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearchFriend.Image")));
            this.tsbtnSearchFriend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearchFriend.Name = "tsbtnSearchFriend";
            this.tsbtnSearchFriend.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSearchFriend.Text = "toolStripButton2";
            this.tsbtnSearchFriend.ToolTipText = "查找好友";
            // 
            // tsbtnUpdateFriendlist
            // 
            this.tsbtnUpdateFriendlist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnUpdateFriendlist.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUpdateFriendlist.Image")));
            this.tsbtnUpdateFriendlist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpdateFriendlist.Name = "tsbtnUpdateFriendlist";
            this.tsbtnUpdateFriendlist.Size = new System.Drawing.Size(23, 22);
            this.tsbtnUpdateFriendlist.Text = "toolStripButton3";
            this.tsbtnUpdateFriendlist.ToolTipText = "更新好友列表";
            // 
            // tsbtnMessageReading
            // 
            this.tsbtnMessageReading.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnMessageReading.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMessageReading.Image")));
            this.tsbtnMessageReading.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMessageReading.Name = "tsbtnMessageReading";
            this.tsbtnMessageReading.Size = new System.Drawing.Size(23, 22);
            this.tsbtnMessageReading.Text = "toolStripButton4";
            this.tsbtnMessageReading.ToolTipText = "系统消息";
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(23, 22);
            this.tsbtnExit.Text = "toolStripButton5";
            this.tsbtnExit.ToolTipText = "退出";
            // 
            // picFace
            // 
            this.picFace.BackColor = System.Drawing.Color.Transparent;
            this.picFace.Location = new System.Drawing.Point(10, 10);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(40, 40);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFace.TabIndex = 8;
            this.picFace.TabStop = false;
            // 
            // ilFaces
            // 
            this.ilFaces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilFaces.ImageStream")));
            this.ilFaces.TransparentColor = System.Drawing.Color.Transparent;
            this.ilFaces.Images.SetKeyName(0, "1.bmp");
            this.ilFaces.Images.SetKeyName(1, "2.bmp");
            this.ilFaces.Images.SetKeyName(2, "3.bmp");
            this.ilFaces.Images.SetKeyName(3, "4.bmp");
            this.ilFaces.Images.SetKeyName(4, "5.bmp");
            this.ilFaces.Images.SetKeyName(5, "6.bmp");
            this.ilFaces.Images.SetKeyName(6, "7.bmp");
            this.ilFaces.Images.SetKeyName(7, "8.bmp");
            this.ilFaces.Images.SetKeyName(8, "9.bmp");
            this.ilFaces.Images.SetKeyName(9, "10.bmp");
            this.ilFaces.Images.SetKeyName(10, "11.bmp");
            this.ilFaces.Images.SetKeyName(11, "12.bmp");
            this.ilFaces.Images.SetKeyName(12, "13.bmp");
            this.ilFaces.Images.SetKeyName(13, "14.bmp");
            this.ilFaces.Images.SetKeyName(14, "15.bmp");
            this.ilFaces.Images.SetKeyName(15, "16.bmp");
            this.ilFaces.Images.SetKeyName(16, "17.bmp");
            this.ilFaces.Images.SetKeyName(17, "18.bmp");
            this.ilFaces.Images.SetKeyName(18, "19.bmp");
            this.ilFaces.Images.SetKeyName(19, "20.bmp");
            this.ilFaces.Images.SetKeyName(20, "21.bmp");
            this.ilFaces.Images.SetKeyName(21, "22.bmp");
            this.ilFaces.Images.SetKeyName(22, "23.bmp");
            this.ilFaces.Images.SetKeyName(23, "24.bmp");
            this.ilFaces.Images.SetKeyName(24, "25.bmp");
            this.ilFaces.Images.SetKeyName(25, "26.bmp");
            this.ilFaces.Images.SetKeyName(26, "27.bmp");
            this.ilFaces.Images.SetKeyName(27, "28.bmp");
            this.ilFaces.Images.SetKeyName(28, "29.bmp");
            this.ilFaces.Images.SetKeyName(29, "30.bmp");
            this.ilFaces.Images.SetKeyName(30, "31.bmp");
            this.ilFaces.Images.SetKeyName(31, "32.bmp");
            this.ilFaces.Images.SetKeyName(32, "33.bmp");
            this.ilFaces.Images.SetKeyName(33, "34.bmp");
            this.ilFaces.Images.SetKeyName(34, "35.bmp");
            this.ilFaces.Images.SetKeyName(35, "36.bmp");
            this.ilFaces.Images.SetKeyName(36, "37.bmp");
            this.ilFaces.Images.SetKeyName(37, "38.bmp");
            this.ilFaces.Images.SetKeyName(38, "39.bmp");
            this.ilFaces.Images.SetKeyName(39, "40.bmp");
            this.ilFaces.Images.SetKeyName(40, "41.bmp");
            this.ilFaces.Images.SetKeyName(41, "42.bmp");
            this.ilFaces.Images.SetKeyName(42, "43.bmp");
            this.ilFaces.Images.SetKeyName(43, "44.bmp");
            this.ilFaces.Images.SetKeyName(44, "45.bmp");
            this.ilFaces.Images.SetKeyName(45, "46.bmp");
            this.ilFaces.Images.SetKeyName(46, "47.bmp");
            this.ilFaces.Images.SetKeyName(47, "48.bmp");
            this.ilFaces.Images.SetKeyName(48, "49.bmp");
            this.ilFaces.Images.SetKeyName(49, "50.bmp");
            this.ilFaces.Images.SetKeyName(50, "51.bmp");
            this.ilFaces.Images.SetKeyName(51, "52.bmp");
            this.ilFaces.Images.SetKeyName(52, "53.bmp");
            this.ilFaces.Images.SetKeyName(53, "54.bmp");
            this.ilFaces.Images.SetKeyName(54, "55.bmp");
            this.ilFaces.Images.SetKeyName(55, "56.bmp");
            this.ilFaces.Images.SetKeyName(56, "57.bmp");
            this.ilFaces.Images.SetKeyName(57, "58.bmp");
            this.ilFaces.Images.SetKeyName(58, "59.bmp");
            this.ilFaces.Images.SetKeyName(59, "60.bmp");
            this.ilFaces.Images.SetKeyName(60, "61.bmp");
            this.ilFaces.Images.SetKeyName(61, "62.bmp");
            this.ilFaces.Images.SetKeyName(62, "63.bmp");
            this.ilFaces.Images.SetKeyName(63, "64.bmp");
            this.ilFaces.Images.SetKeyName(64, "65.bmp");
            this.ilFaces.Images.SetKeyName(65, "66.bmp");
            this.ilFaces.Images.SetKeyName(66, "67.bmp");
            this.ilFaces.Images.SetKeyName(67, "68.bmp");
            this.ilFaces.Images.SetKeyName(68, "69.bmp");
            this.ilFaces.Images.SetKeyName(69, "70.bmp");
            this.ilFaces.Images.SetKeyName(70, "71.bmp");
            this.ilFaces.Images.SetKeyName(71, "72.bmp");
            this.ilFaces.Images.SetKeyName(72, "73.bmp");
            this.ilFaces.Images.SetKeyName(73, "74.bmp");
            this.ilFaces.Images.SetKeyName(74, "75.bmp");
            this.ilFaces.Images.SetKeyName(75, "76.bmp");
            this.ilFaces.Images.SetKeyName(76, "77.bmp");
            this.ilFaces.Images.SetKeyName(77, "78.bmp");
            this.ilFaces.Images.SetKeyName(78, "79.bmp");
            this.ilFaces.Images.SetKeyName(79, "80.bmp");
            this.ilFaces.Images.SetKeyName(80, "81.bmp");
            this.ilFaces.Images.SetKeyName(81, "82.bmp");
            this.ilFaces.Images.SetKeyName(82, "83.bmp");
            this.ilFaces.Images.SetKeyName(83, "84.bmp");
            this.ilFaces.Images.SetKeyName(84, "85.bmp");
            this.ilFaces.Images.SetKeyName(85, "86.bmp");
            this.ilFaces.Images.SetKeyName(86, "87.bmp");
            this.ilFaces.Images.SetKeyName(87, "88.bmp");
            this.ilFaces.Images.SetKeyName(88, "89.bmp");
            this.ilFaces.Images.SetKeyName(89, "90.bmp");
            this.ilFaces.Images.SetKeyName(90, "91.bmp");
            this.ilFaces.Images.SetKeyName(91, "92.bmp");
            this.ilFaces.Images.SetKeyName(92, "93.bmp");
            this.ilFaces.Images.SetKeyName(93, "94.bmp");
            this.ilFaces.Images.SetKeyName(94, "95.bmp");
            this.ilFaces.Images.SetKeyName(95, "96.bmp");
            this.ilFaces.Images.SetKeyName(96, "97.bmp");
            this.ilFaces.Images.SetKeyName(97, "98.bmp");
            this.ilFaces.Images.SetKeyName(98, "99.bmp");
            this.ilFaces.Images.SetKeyName(99, "100.bmp");
            // 
            // tmrMessage
            // 
            this.tmrMessage.Interval = 2000;
            // 
            // tmrAddFriend
            // 
            this.tmrAddFriend.Interval = 500;
            // 
            // tmrChatRequest
            // 
            this.tmrChatRequest.Interval = 500;
            // 
            // cmsFriendList
            // 
            this.cmsFriendList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiView,
            this.tsmiAddFriend,
            this.tsmiDelete});
            this.cmsFriendList.Name = "cmsFriendList";
            this.cmsFriendList.Size = new System.Drawing.Size(125, 70);
            // 
            // ilMessage
            // 
            this.ilMessage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMessage.ImageStream")));
            this.ilMessage.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMessage.Images.SetKeyName(0, "MessageReading.gif");
            this.ilMessage.Images.SetKeyName(1, "Message.gif");
            // 
            // tsmiView
            // 
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(124, 22);
            this.tsmiView.Text = "小头像";
            // 
            // tsmiAddFriend
            // 
            this.tsmiAddFriend.Name = "tsmiAddFriend";
            this.tsmiAddFriend.Size = new System.Drawing.Size(124, 22);
            this.tsmiAddFriend.Text = "加为好友";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(124, 22);
            this.tsmiDelete.Text = "删除";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(201, 414);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.tsOperation);
            this.Controls.Add(this.sbFriends);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(800, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tsOperation.ResumeLayout(false);
            this.tsOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.cmsFriendList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Aptech.UI.SideBar sbFriends;
        private System.Windows.Forms.ToolStrip tsOperation;
        private System.Windows.Forms.ToolStripButton tsbtnPersonalInfo;
        private System.Windows.Forms.ToolStripButton tsbtnSearchFriend;
        private System.Windows.Forms.ToolStripButton tsbtnUpdateFriendlist;
        private System.Windows.Forms.ToolStripButton tsbtnMessageReading;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.ImageList ilFaces;
        private System.Windows.Forms.Timer tmrMessage;
        private System.Windows.Forms.Timer tmrAddFriend;
        private System.Windows.Forms.Timer tmrChatRequest;
        private System.Windows.Forms.ContextMenuStrip cmsFriendList;
        private System.Windows.Forms.ImageList ilMessage;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddFriend;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}