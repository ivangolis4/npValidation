namespace Validation
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
            TBFIRSTNAE = new TextBox();
            TBCPASSWORD = new TextBox();
            TBPASSWORD = new TextBox();
            TBEMAIL = new TextBox();
            TBUSERNAME = new TextBox();
            TBLASTNAME = new TextBox();
            RBREGISTER = new Button();
            RBMALE = new RadioButton();
            RBFEMALE = new RadioButton();
            lbfirstname = new Label();
            lbconfirmpassword = new Label();
            lbpassword = new Label();
            lbemail = new Label();
            lbusername = new Label();
            lblastname = new Label();
            lbgender = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(138, 31);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 0;
            label1.Text = "REGISTIATION";
            // 
            // TBFIRSTNAE
            // 
            TBFIRSTNAE.Location = new Point(65, 95);
            TBFIRSTNAE.Name = "TBFIRSTNAE";
            TBFIRSTNAE.PlaceholderText = "FIRSTNAME";
            TBFIRSTNAE.Size = new Size(141, 23);
            TBFIRSTNAE.TabIndex = 1;
            TBFIRSTNAE.TextChanged += TBFIRSTNAE_TextChanged;
            // 
            // TBCPASSWORD
            // 
            TBCPASSWORD.Location = new Point(65, 267);
            TBCPASSWORD.Name = "TBCPASSWORD";
            TBCPASSWORD.PasswordChar = '•';
            TBCPASSWORD.PlaceholderText = "CONFIRM PASSWORD";
            TBCPASSWORD.Size = new Size(293, 23);
            TBCPASSWORD.TabIndex = 2;
            TBCPASSWORD.TextChanged += TBCPASSWORD_TextChanged;
            // 
            // TBPASSWORD
            // 
            TBPASSWORD.Location = new Point(65, 226);
            TBPASSWORD.Name = "TBPASSWORD";
            TBPASSWORD.PasswordChar = '•';
            TBPASSWORD.PlaceholderText = "PASSWORD";
            TBPASSWORD.Size = new Size(293, 23);
            TBPASSWORD.TabIndex = 3;
            TBPASSWORD.TextChanged += TBPASSWORD_TextChanged;
            // 
            // TBEMAIL
            // 
            TBEMAIL.Location = new Point(65, 184);
            TBEMAIL.Name = "TBEMAIL";
            TBEMAIL.PlaceholderText = "EXAMPLE@GMAIL.COM";
            TBEMAIL.Size = new Size(293, 23);
            TBEMAIL.TabIndex = 4;
            TBEMAIL.TextChanged += TBEMAIL_TextChanged;
            // 
            // TBUSERNAME
            // 
            TBUSERNAME.Location = new Point(65, 139);
            TBUSERNAME.Name = "TBUSERNAME";
            TBUSERNAME.PlaceholderText = "USERNAME";
            TBUSERNAME.Size = new Size(293, 23);
            TBUSERNAME.TabIndex = 5;
            TBUSERNAME.TextChanged += TBUSERNAME_TextChanged;
            // 
            // TBLASTNAME
            // 
            TBLASTNAME.Location = new Point(212, 95);
            TBLASTNAME.Name = "TBLASTNAME";
            TBLASTNAME.PlaceholderText = "LASTNAME";
            TBLASTNAME.Size = new Size(146, 23);
            TBLASTNAME.TabIndex = 6;
            TBLASTNAME.TextChanged += TBLASTNAME_TextChanged;
            // 
            // RBREGISTER
            // 
            RBREGISTER.FlatStyle = FlatStyle.Flat;
            RBREGISTER.ForeColor = Color.Cornsilk;
            RBREGISTER.Location = new Point(159, 342);
            RBREGISTER.Name = "RBREGISTER";
            RBREGISTER.Size = new Size(75, 23);
            RBREGISTER.TabIndex = 7;
            RBREGISTER.Text = "REGISTER";
            RBREGISTER.UseVisualStyleBackColor = true;
            RBREGISTER.Click += RBREGISTER_Click;
            // 
            // RBMALE
            // 
            RBMALE.AutoSize = true;
            RBMALE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RBMALE.ForeColor = SystemColors.Control;
            RBMALE.Location = new Point(86, 305);
            RBMALE.Name = "RBMALE";
            RBMALE.Size = new Size(56, 19);
            RBMALE.TabIndex = 8;
            RBMALE.TabStop = true;
            RBMALE.Text = "MALE";
            RBMALE.UseVisualStyleBackColor = true;
            RBMALE.CheckedChanged += RBMALE_CheckedChanged;
            // 
            // RBFEMALE
            // 
            RBFEMALE.AutoSize = true;
            RBFEMALE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RBFEMALE.ForeColor = SystemColors.Control;
            RBFEMALE.Location = new Point(221, 305);
            RBFEMALE.Name = "RBFEMALE";
            RBFEMALE.Size = new Size(68, 19);
            RBFEMALE.TabIndex = 9;
            RBFEMALE.TabStop = true;
            RBFEMALE.Text = "FEMALE";
            RBFEMALE.UseVisualStyleBackColor = true;
            RBFEMALE.CheckedChanged += RBFEMALE_CheckedChanged;
            // 
            // lbfirstname
            // 
            lbfirstname.AutoSize = true;
            lbfirstname.ForeColor = Color.Red;
            lbfirstname.Location = new Point(68, 119);
            lbfirstname.Name = "lbfirstname";
            lbfirstname.Size = new Size(0, 15);
            lbfirstname.TabIndex = 10;
            // 
            // lbconfirmpassword
            // 
            lbconfirmpassword.AutoSize = true;
            lbconfirmpassword.ForeColor = Color.Red;
            lbconfirmpassword.Location = new Point(68, 293);
            lbconfirmpassword.Name = "lbconfirmpassword";
            lbconfirmpassword.Size = new Size(0, 15);
            lbconfirmpassword.TabIndex = 11;
            // 
            // lbpassword
            // 
            lbpassword.AutoSize = true;
            lbpassword.ForeColor = Color.Red;
            lbpassword.Location = new Point(68, 249);
            lbpassword.Name = "lbpassword";
            lbpassword.Size = new Size(0, 15);
            lbpassword.TabIndex = 12;
            // 
            // lbemail
            // 
            lbemail.AutoSize = true;
            lbemail.ForeColor = Color.Red;
            lbemail.Location = new Point(65, 208);
            lbemail.Name = "lbemail";
            lbemail.Size = new Size(0, 15);
            lbemail.TabIndex = 13;
            // 
            // lbusername
            // 
            lbusername.AutoSize = true;
            lbusername.ForeColor = Color.Red;
            lbusername.Location = new Point(68, 166);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(0, 15);
            lbusername.TabIndex = 14;
            // 
            // lblastname
            // 
            lblastname.AutoSize = true;
            lblastname.ForeColor = Color.Red;
            lblastname.Location = new Point(215, 119);
            lblastname.Name = "lblastname";
            lblastname.Size = new Size(0, 15);
            lblastname.TabIndex = 15;
            // 
            // lbgender
            // 
            lbgender.AutoSize = true;
            lbgender.ForeColor = Color.Red;
            lbgender.Location = new Point(86, 327);
            lbgender.Name = "lbgender";
            lbgender.Size = new Size(0, 15);
            lbgender.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(420, 450);
            Controls.Add(lbgender);
            Controls.Add(lblastname);
            Controls.Add(lbusername);
            Controls.Add(lbemail);
            Controls.Add(lbpassword);
            Controls.Add(lbconfirmpassword);
            Controls.Add(lbfirstname);
            Controls.Add(RBFEMALE);
            Controls.Add(RBMALE);
            Controls.Add(RBREGISTER);
            Controls.Add(TBLASTNAME);
            Controls.Add(TBUSERNAME);
            Controls.Add(TBEMAIL);
            Controls.Add(TBPASSWORD);
            Controls.Add(TBCPASSWORD);
            Controls.Add(TBFIRSTNAE);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBFIRSTNAE;
        private TextBox TBCPASSWORD;
        private TextBox TBPASSWORD;
        private TextBox TBEMAIL;
        private TextBox TBUSERNAME;
        private TextBox TBLASTNAME;
        private Button RBREGISTER;
        private RadioButton RBMALE;
        private RadioButton RBFEMALE;
        private Label lbfirstname;
        private Label lbconfirmpassword;
        private Label lbpassword;
        private Label lbemail;
        private Label lbusername;
        private Label lblastname;
        private Label lbgender;
    }
}
