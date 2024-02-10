namespace Login_new
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtUser = new TextBox();
            TxtPassword = new TextBox();
            BtnSubmit = new Button();
            BtnRegister = new Button();
            BtnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bauhaus 93", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(162, 97);
            label1.Name = "label1";
            label1.Size = new Size(326, 50);
            label1.TabIndex = 0;
            label1.Text = "Welcome back";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bauhaus 93", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(267, 61);
            label2.Name = "label2";
            label2.Size = new Size(102, 36);
            label2.TabIndex = 1;
            label2.Text = "Log in";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bauhaus 93", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(224, 307);
            label3.Name = "label3";
            label3.Size = new Size(145, 32);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bauhaus 93", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(224, 428);
            label4.Name = "label4";
            label4.Size = new Size(140, 32);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // TxtUser
            // 
            TxtUser.BackColor = Color.FromArgb(133, 97, 135);
            TxtUser.BorderStyle = BorderStyle.None;
            TxtUser.Location = new Point(284, 357);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(150, 24);
            TxtUser.TabIndex = 4;
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.FromArgb(133, 97, 135);
            TxtPassword.BorderStyle = BorderStyle.None;
            TxtPassword.Location = new Point(284, 474);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(150, 24);
            TxtPassword.TabIndex = 5;
            TxtPassword.TextChanged += TxtPassword_TextChanged;
            // 
            // BtnSubmit
            // 
            BtnSubmit.BackColor = SystemColors.Desktop;
            BtnSubmit.Font = new Font("Bauhaus 93", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnSubmit.ForeColor = SystemColors.ControlLight;
            BtnSubmit.Location = new Point(146, 623);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(112, 34);
            BtnSubmit.TabIndex = 6;
            BtnSubmit.Text = "Play";
            BtnSubmit.UseVisualStyleBackColor = false;
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // BtnRegister
            // 
            BtnRegister.BackColor = SystemColors.Desktop;
            BtnRegister.Font = new Font("Bauhaus 93", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnRegister.ForeColor = SystemColors.ControlLight;
            BtnRegister.Location = new Point(267, 623);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(125, 34);
            BtnRegister.TabIndex = 7;
            BtnRegister.Text = "Register";
            BtnRegister.UseVisualStyleBackColor = false;
            BtnRegister.Click += BtnRegister_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = SystemColors.Desktop;
            BtnExit.Font = new Font("Bauhaus 93", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnExit.ForeColor = SystemColors.ControlLight;
            BtnExit.Location = new Point(398, 623);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(112, 34);
            BtnExit.TabIndex = 14;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.blurred_face;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(645, 816);
            Controls.Add(BtnExit);
            Controls.Add(BtnRegister);
            Controls.Add(BtnSubmit);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtUser;
        private TextBox TxtPassword;
        private Button BtnSubmit;
        private Button BtnRegister;
        private Button BtnExit;
    }
}
