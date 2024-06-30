namespace CSM_Project
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.exitBtn = new System.Windows.Forms.Button();
            this.pinBox = new System.Windows.Forms.TextBox();
            this.pinPnl = new System.Windows.Forms.Panel();
            this.lockImage = new System.Windows.Forms.PictureBox();
            this.pinErrorIcon = new System.Windows.Forms.PictureBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.namePnl = new System.Windows.Forms.Panel();
            this.nameErrorIcon = new System.Windows.Forms.PictureBox();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.logBtn = new System.Windows.Forms.Button();
            this.button_dangki = new System.Windows.Forms.Button();
            this.circularPictureBox1 = new CSM_Project.CircularPictureBox();
            this.pinPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinErrorIcon)).BeginInit();
            this.namePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(733, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(61, 49);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseClick);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // pinBox
            // 
            this.pinBox.BackColor = System.Drawing.Color.White;
            this.pinBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pinBox.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.pinBox.ForeColor = System.Drawing.Color.Black;
            this.pinBox.Location = new System.Drawing.Point(77, 14);
            this.pinBox.Margin = new System.Windows.Forms.Padding(4);
            this.pinBox.Multiline = true;
            this.pinBox.Name = "pinBox";
            this.pinBox.Size = new System.Drawing.Size(305, 32);
            this.pinBox.TabIndex = 18;
            this.pinBox.Text = "Mật khẩu";
            this.pinBox.Enter += new System.EventHandler(this.pinBox_Enter);
            this.pinBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pinBox_KeyPress);
            this.pinBox.Leave += new System.EventHandler(this.pinBox_Leave);
            // 
            // pinPnl
            // 
            this.pinPnl.BackColor = System.Drawing.Color.White;
            this.pinPnl.Controls.Add(this.pinErrorIcon);
            this.pinPnl.Controls.Add(this.lockImage);
            this.pinPnl.Controls.Add(this.pinBox);
            this.pinPnl.Location = new System.Drawing.Point(203, 415);
            this.pinPnl.Margin = new System.Windows.Forms.Padding(4);
            this.pinPnl.Name = "pinPnl";
            this.pinPnl.Size = new System.Drawing.Size(387, 59);
            this.pinPnl.TabIndex = 37;
            // 
            // lockImage
            // 
            this.lockImage.BackColor = System.Drawing.Color.White;
            this.lockImage.Image = global::CSM_Project.Properties.Resources.padlock;
            this.lockImage.Location = new System.Drawing.Point(0, 0);
            this.lockImage.Margin = new System.Windows.Forms.Padding(4);
            this.lockImage.Name = "lockImage";
            this.lockImage.Size = new System.Drawing.Size(69, 59);
            this.lockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lockImage.TabIndex = 24;
            this.lockImage.TabStop = false;
            // 
            // pinErrorIcon
            // 
            this.pinErrorIcon.BackColor = System.Drawing.Color.White;
            this.pinErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pinErrorIcon.BackgroundImage")));
            this.pinErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pinErrorIcon.Location = new System.Drawing.Point(351, 14);
            this.pinErrorIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pinErrorIcon.Name = "pinErrorIcon";
            this.pinErrorIcon.Size = new System.Drawing.Size(25, 36);
            this.pinErrorIcon.TabIndex = 42;
            this.pinErrorIcon.TabStop = false;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.White;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.Black;
            this.nameBox.Location = new System.Drawing.Point(77, 14);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(305, 32);
            this.nameBox.TabIndex = 25;
            this.nameBox.Text = "Tài khoản";
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox_KeyPress);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // namePnl
            // 
            this.namePnl.BackColor = System.Drawing.Color.White;
            this.namePnl.Controls.Add(this.nameErrorIcon);
            this.namePnl.Controls.Add(this.userImage);
            this.namePnl.Controls.Add(this.nameBox);
            this.namePnl.Location = new System.Drawing.Point(203, 332);
            this.namePnl.Margin = new System.Windows.Forms.Padding(4);
            this.namePnl.Name = "namePnl";
            this.namePnl.Size = new System.Drawing.Size(387, 59);
            this.namePnl.TabIndex = 36;
            // 
            // nameErrorIcon
            // 
            this.nameErrorIcon.BackColor = System.Drawing.Color.Transparent;
            this.nameErrorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nameErrorIcon.BackgroundImage")));
            this.nameErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nameErrorIcon.Location = new System.Drawing.Point(351, 11);
            this.nameErrorIcon.Margin = new System.Windows.Forms.Padding(4);
            this.nameErrorIcon.Name = "nameErrorIcon";
            this.nameErrorIcon.Size = new System.Drawing.Size(25, 36);
            this.nameErrorIcon.TabIndex = 41;
            this.nameErrorIcon.TabStop = false;
            // 
            // userImage
            // 
            this.userImage.BackColor = System.Drawing.Color.Transparent;
            this.userImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.userImage.Image = global::CSM_Project.Properties.Resources.people;
            this.userImage.Location = new System.Drawing.Point(0, 0);
            this.userImage.Margin = new System.Windows.Forms.Padding(4);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(69, 59);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 24;
            this.userImage.TabStop = false;
            // 
            // logBtn
            // 
            this.logBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.logBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logBtn.FlatAppearance.BorderSize = 0;
            this.logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtn.ForeColor = System.Drawing.Color.White;
            this.logBtn.Location = new System.Drawing.Point(203, 534);
            this.logBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(172, 49);
            this.logBtn.TabIndex = 38;
            this.logBtn.Text = "Đăng nhập";
            this.logBtn.UseVisualStyleBackColor = false;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            this.logBtn.MouseEnter += new System.EventHandler(this.logBtn_MouseEnter);
            this.logBtn.MouseLeave += new System.EventHandler(this.logBtn_MouseLeave);
            // 
            // button_dangki
            // 
            this.button_dangki.BackColor = System.Drawing.Color.Red;
            this.button_dangki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_dangki.FlatAppearance.BorderSize = 0;
            this.button_dangki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dangki.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dangki.ForeColor = System.Drawing.Color.White;
            this.button_dangki.Location = new System.Drawing.Point(418, 534);
            this.button_dangki.Margin = new System.Windows.Forms.Padding(4);
            this.button_dangki.Name = "button_dangki";
            this.button_dangki.Size = new System.Drawing.Size(172, 49);
            this.button_dangki.TabIndex = 41;
            this.button_dangki.Text = "Đăng kí";
            this.button_dangki.UseVisualStyleBackColor = false;
            this.button_dangki.Click += new System.EventHandler(this.button1_Click);
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.circularPictureBox1.BackgroundImage = global::CSM_Project.Properties.Resources.car_care_removebg_preview;
            this.circularPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circularPictureBox1.Location = new System.Drawing.Point(224, 90);
            this.circularPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(355, 234);
            this.circularPictureBox1.TabIndex = 40;
            this.circularPictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(186)))), ((int)(((byte)(253)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 682);
            this.Controls.Add(this.button_dangki);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.namePnl);
            this.Controls.Add(this.pinPnl);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.pinPnl.ResumeLayout(false);
            this.pinPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinErrorIcon)).EndInit();
            this.namePnl.ResumeLayout(false);
            this.namePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitBtn;
        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.TextBox pinBox;
        private System.Windows.Forms.PictureBox lockImage;
        private System.Windows.Forms.Panel pinPnl;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.Panel namePnl;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.PictureBox nameErrorIcon;
        private System.Windows.Forms.Button button_dangki;
        public System.Windows.Forms.PictureBox pinErrorIcon;
    }
}

