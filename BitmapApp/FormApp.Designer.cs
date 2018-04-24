namespace KyThuatGiauTin
{
    partial class KyThuatGiauTinApp
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.firstTabPage = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbConfirm = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.groupBoxAfter = new System.Windows.Forms.GroupBox();
            this.groupBoxBefore = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.secondTabPage = new System.Windows.Forms.TabPage();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.lbPasswordDec = new System.Windows.Forms.Label();
            this.txtPasswordDec = new System.Windows.Forms.TextBox();
            this.txtPathDec = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnChooseDec = new System.Windows.Forms.Button();
            this.groupBoxDecode = new System.Windows.Forms.GroupBox();
            this.pictureAfter = new System.Windows.Forms.PictureBox();
            this.pictureBefore = new System.Windows.Forms.PictureBox();
            this.pictureBoxDec = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.firstTabPage.SuspendLayout();
            this.groupBoxAfter.SuspendLayout();
            this.groupBoxBefore.SuspendLayout();
            this.secondTabPage.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxDecode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDec)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.firstTabPage);
            this.tabControl.Controls.Add(this.secondTabPage);
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1034, 652);
            this.tabControl.TabIndex = 0;
            // 
            // firstTabPage
            // 
            this.firstTabPage.BackColor = System.Drawing.Color.Honeydew;
            this.firstTabPage.Controls.Add(this.btnReset);
            this.firstTabPage.Controls.Add(this.lbConfirm);
            this.firstTabPage.Controls.Add(this.txtMessage);
            this.firstTabPage.Controls.Add(this.txtConfirm);
            this.firstTabPage.Controls.Add(this.txtPassword);
            this.firstTabPage.Controls.Add(this.lbPassword);
            this.firstTabPage.Controls.Add(this.groupBoxAfter);
            this.firstTabPage.Controls.Add(this.groupBoxBefore);
            this.firstTabPage.Controls.Add(this.txtPath);
            this.firstTabPage.Controls.Add(this.lbMessage);
            this.firstTabPage.Controls.Add(this.btnStart);
            this.firstTabPage.Controls.Add(this.btnChoose);
            this.firstTabPage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTabPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.firstTabPage.Location = new System.Drawing.Point(4, 28);
            this.firstTabPage.Name = "firstTabPage";
            this.firstTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.firstTabPage.Size = new System.Drawing.Size(1026, 620);
            this.firstTabPage.TabIndex = 0;
            this.firstTabPage.Text = "Hiding";
            this.firstTabPage.Click += new System.EventHandler(this.firstTabPage_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(528, 584);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 30);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbConfirm
            // 
            this.lbConfirm.AllowDrop = true;
            this.lbConfirm.AutoSize = true;
            this.lbConfirm.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbConfirm.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirm.ForeColor = System.Drawing.Color.Black;
            this.lbConfirm.Location = new System.Drawing.Point(524, 540);
            this.lbConfirm.Name = "lbConfirm";
            this.lbConfirm.Padding = new System.Windows.Forms.Padding(11, 1, 11, 2);
            this.lbConfirm.Size = new System.Drawing.Size(97, 26);
            this.lbConfirm.TabIndex = 18;
            this.lbConfirm.Text = "Confirm";
            this.lbConfirm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbConfirm.Click += new System.EventHandler(this.lbConfirm_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMessage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(151, 536);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(351, 30);
            this.txtMessage.TabIndex = 17;
            this.txtMessage.Text = "";
            // 
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtConfirm.Location = new System.Drawing.Point(666, 540);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(342, 27);
            this.txtConfirm.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPassword.Location = new System.Drawing.Point(666, 499);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(343, 27);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AllowDrop = true;
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.Black;
            this.lbPassword.Location = new System.Drawing.Point(525, 500);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Padding = new System.Windows.Forms.Padding(4, 1, 4, 2);
            this.lbPassword.Size = new System.Drawing.Size(96, 26);
            this.lbPassword.TabIndex = 12;
            this.lbPassword.Text = "Password";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbPassword.Click += new System.EventHandler(this.lbPassword_Click);
            // 
            // groupBoxAfter
            // 
            this.groupBoxAfter.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxAfter.Controls.Add(this.pictureAfter);
            this.groupBoxAfter.ForeColor = System.Drawing.Color.Red;
            this.groupBoxAfter.Location = new System.Drawing.Point(528, 15);
            this.groupBoxAfter.Name = "groupBoxAfter";
            this.groupBoxAfter.Size = new System.Drawing.Size(481, 474);
            this.groupBoxAfter.TabIndex = 11;
            this.groupBoxAfter.TabStop = false;
            this.groupBoxAfter.Text = "After hide";
            // 
            // groupBoxBefore
            // 
            this.groupBoxBefore.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxBefore.Controls.Add(this.pictureBefore);
            this.groupBoxBefore.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxBefore.Location = new System.Drawing.Point(19, 15);
            this.groupBoxBefore.Name = "groupBoxBefore";
            this.groupBoxBefore.Size = new System.Drawing.Size(485, 474);
            this.groupBoxBefore.TabIndex = 10;
            this.groupBoxBefore.TabStop = false;
            this.groupBoxBefore.Text = "Before hide";
            this.groupBoxBefore.Enter += new System.EventHandler(this.groupBoxBefore_Enter);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPath.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(151, 499);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(351, 27);
            this.txtPath.TabIndex = 8;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.BackColor = System.Drawing.Color.White;
            this.lbMessage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.Black;
            this.lbMessage.Location = new System.Drawing.Point(26, 540);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Padding = new System.Windows.Forms.Padding(4, 1, 4, 2);
            this.lbMessage.Size = new System.Drawing.Size(90, 26);
            this.lbMessage.TabIndex = 7;
            this.lbMessage.Text = "Message";
            this.lbMessage.Click += new System.EventHandler(this.lbMessage_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkGreen;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(407, 584);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 30);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Location = new System.Drawing.Point(19, 495);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(97, 31);
            this.btnChoose.TabIndex = 5;
            this.btnChoose.Text = "Open";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // secondTabPage
            // 
            this.secondTabPage.BackColor = System.Drawing.Color.Honeydew;
            this.secondTabPage.Controls.Add(this.textBox1);
            this.secondTabPage.Controls.Add(this.groupBoxResult);
            this.secondTabPage.Controls.Add(this.lbPasswordDec);
            this.secondTabPage.Controls.Add(this.txtPasswordDec);
            this.secondTabPage.Controls.Add(this.txtPathDec);
            this.secondTabPage.Controls.Add(this.btnDecode);
            this.secondTabPage.Controls.Add(this.btnChooseDec);
            this.secondTabPage.Controls.Add(this.groupBoxDecode);
            this.secondTabPage.Location = new System.Drawing.Point(4, 28);
            this.secondTabPage.Name = "secondTabPage";
            this.secondTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.secondTabPage.Size = new System.Drawing.Size(1026, 620);
            this.secondTabPage.TabIndex = 1;
            this.secondTabPage.Text = "Extract";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxResult.Controls.Add(this.txtResult);
            this.groupBoxResult.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxResult.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxResult.Location = new System.Drawing.Point(527, 124);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(484, 476);
            this.groupBoxResult.TabIndex = 8;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Hidden message";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(0, 25);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(484, 445);
            this.txtResult.TabIndex = 4;
            this.txtResult.Text = "";
            // 
            // lbPasswordDec
            // 
            this.lbPasswordDec.AutoSize = true;
            this.lbPasswordDec.BackColor = System.Drawing.Color.Honeydew;
            this.lbPasswordDec.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordDec.ForeColor = System.Drawing.Color.Black;
            this.lbPasswordDec.Location = new System.Drawing.Point(25, 71);
            this.lbPasswordDec.Name = "lbPasswordDec";
            this.lbPasswordDec.Padding = new System.Windows.Forms.Padding(4, 1, 4, 2);
            this.lbPasswordDec.Size = new System.Drawing.Size(96, 26);
            this.lbPasswordDec.TabIndex = 7;
            this.lbPasswordDec.Text = "Password";
            // 
            // txtPasswordDec
            // 
            this.txtPasswordDec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPasswordDec.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordDec.Location = new System.Drawing.Point(145, 71);
            this.txtPasswordDec.Name = "txtPasswordDec";
            this.txtPasswordDec.PasswordChar = '*';
            this.txtPasswordDec.Size = new System.Drawing.Size(364, 27);
            this.txtPasswordDec.TabIndex = 6;
            // 
            // txtPathDec
            // 
            this.txtPathDec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPathDec.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathDec.Location = new System.Drawing.Point(145, 25);
            this.txtPathDec.Name = "txtPathDec";
            this.txtPathDec.ReadOnly = true;
            this.txtPathDec.Size = new System.Drawing.Size(364, 27);
            this.txtPathDec.TabIndex = 3;
            // 
            // btnDecode
            // 
            this.btnDecode.BackColor = System.Drawing.Color.Red;
            this.btnDecode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecode.ForeColor = System.Drawing.Color.White;
            this.btnDecode.Location = new System.Drawing.Point(527, 67);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(218, 33);
            this.btnDecode.TabIndex = 2;
            this.btnDecode.Text = "Extract";
            this.btnDecode.UseVisualStyleBackColor = false;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnChooseDec
            // 
            this.btnChooseDec.BackColor = System.Drawing.Color.Red;
            this.btnChooseDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseDec.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseDec.ForeColor = System.Drawing.Color.White;
            this.btnChooseDec.Location = new System.Drawing.Point(25, 21);
            this.btnChooseDec.Name = "btnChooseDec";
            this.btnChooseDec.Size = new System.Drawing.Size(96, 33);
            this.btnChooseDec.TabIndex = 1;
            this.btnChooseDec.Text = "Open";
            this.btnChooseDec.UseVisualStyleBackColor = false;
            this.btnChooseDec.Click += new System.EventHandler(this.btnChooseDec_Click);
            // 
            // groupBoxDecode
            // 
            this.groupBoxDecode.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxDecode.Controls.Add(this.pictureBoxDec);
            this.groupBoxDecode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDecode.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxDecode.Location = new System.Drawing.Point(25, 124);
            this.groupBoxDecode.Name = "groupBoxDecode";
            this.groupBoxDecode.Size = new System.Drawing.Size(484, 476);
            this.groupBoxDecode.TabIndex = 0;
            this.groupBoxDecode.TabStop = false;
            this.groupBoxDecode.Text = "Image to extract";
            // 
            // pictureAfter
            // 
            this.pictureAfter.BackColor = System.Drawing.Color.White;
            this.pictureAfter.Image = global::BitmapApp.Properties.Resources.Roses;
            this.pictureAfter.Location = new System.Drawing.Point(0, 25);
            this.pictureAfter.Name = "pictureAfter";
            this.pictureAfter.Size = new System.Drawing.Size(480, 449);
            this.pictureAfter.TabIndex = 1;
            this.pictureAfter.TabStop = false;
            // 
            // pictureBefore
            // 
            this.pictureBefore.BackColor = System.Drawing.Color.White;
            this.pictureBefore.Image = global::BitmapApp.Properties.Resources._4;
            this.pictureBefore.Location = new System.Drawing.Point(0, 25);
            this.pictureBefore.Name = "pictureBefore";
            this.pictureBefore.Size = new System.Drawing.Size(483, 449);
            this.pictureBefore.TabIndex = 0;
            this.pictureBefore.TabStop = false;
            this.pictureBefore.Click += new System.EventHandler(this.pictureBefore_Click);
            // 
            // pictureBoxDec
            // 
            this.pictureBoxDec.BackColor = System.Drawing.Color.White;
            this.pictureBoxDec.Location = new System.Drawing.Point(0, 25);
            this.pictureBoxDec.Name = "pictureBoxDec";
            this.pictureBoxDec.Size = new System.Drawing.Size(483, 449);
            this.pictureBoxDec.TabIndex = 0;
            this.pictureBoxDec.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(527, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(218, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Pass mặc định 12345678";
            // 
            // KyThuatGiauTinApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1054, 695);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "KyThuatGiauTinApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kỹ thuật giấu tin";
            this.tabControl.ResumeLayout(false);
            this.firstTabPage.ResumeLayout(false);
            this.firstTabPage.PerformLayout();
            this.groupBoxAfter.ResumeLayout(false);
            this.groupBoxBefore.ResumeLayout(false);
            this.secondTabPage.ResumeLayout(false);
            this.secondTabPage.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxDecode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage firstTabPage;
        private System.Windows.Forms.TabPage secondTabPage;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox groupBoxBefore;
        private System.Windows.Forms.PictureBox pictureBefore;
        private System.Windows.Forms.GroupBox groupBoxAfter;
        private System.Windows.Forms.PictureBox pictureAfter;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.TextBox txtPathDec;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnChooseDec;
        private System.Windows.Forms.GroupBox groupBoxDecode;
        private System.Windows.Forms.PictureBox pictureBoxDec;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbPasswordDec;
        private System.Windows.Forms.TextBox txtPasswordDec;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Label lbConfirm;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.TextBox textBox1;
    }
}

