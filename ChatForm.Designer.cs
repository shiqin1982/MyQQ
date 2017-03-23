namespace MyQQ
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.lblMessages = new System.Windows.Forms.Label();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.lblFriend = new System.Windows.Forms.Label();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessages
            // 
            this.lblMessages.Location = new System.Drawing.Point(12, 32);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(355, 173);
            this.lblMessages.TabIndex = 4;
            this.lblMessages.Text = "v";
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(14, 214);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(355, 101);
            this.txtChat.TabIndex = 5;
            // 
            // lblFriend
            // 
            this.lblFriend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFriend.BackColor = System.Drawing.Color.AliceBlue;
            this.lblFriend.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFriend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFriend.Location = new System.Drawing.Point(42, 8);
            this.lblFriend.Name = "lblFriend";
            this.lblFriend.Size = new System.Drawing.Size(324, 24);
            this.lblFriend.TabIndex = 6;
            this.lblFriend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picFace
            // 
            this.picFace.BackColor = System.Drawing.Color.AliceBlue;
            this.picFace.Location = new System.Drawing.Point(12, 8);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(30, 24);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFace.TabIndex = 7;
            this.picFace.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Location = new System.Drawing.Point(211, 325);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.Location = new System.Drawing.Point(292, 325);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(391, 360);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.lblFriend);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.lblMessages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ChatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Label lblFriend;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSend;
    }
}