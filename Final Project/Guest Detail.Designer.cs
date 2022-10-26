namespace Final_Project
{
    partial class Guest_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest_Detail));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.email = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Guest Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Guest Detail";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // firstname
            // 
            this.firstname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.firstname.Location = new System.Drawing.Point(200, 169);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(235, 34);
            this.firstname.TabIndex = 5;
            this.firstname.Text = "First name";
            this.firstname.Click += new System.EventHandler(this.textBox1_Click);
            this.firstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstname_keypress);
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.surname.Location = new System.Drawing.Point(505, 169);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(235, 34);
            this.surname.TabIndex = 6;
            this.surname.Text = "Surname";
            this.surname.Click += new System.EventHandler(this.textBox2_Click);
            this.surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surname_keypress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date of birth";
            // 
            // birth
            // 
            this.birth.Font = new System.Drawing.Font("AngsanaUPC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth.Location = new System.Drawing.Point(200, 255);
            this.birth.MaxDate = new System.DateTime(2010, 6, 28, 0, 0, 0, 0);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(185, 39);
            this.birth.TabIndex = 12;
            this.birth.Value = new System.DateTime(2010, 6, 28, 0, 0, 0, 0);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(541, 236);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 27);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(541, 278);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 27);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ControlText;
            this.email.Location = new System.Drawing.Point(152, 409);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(299, 34);
            this.email.TabIndex = 15;
            this.email.Text = " E-mail address";
            this.email.Click += new System.EventHandler(this.email_click);
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // tel
            // 
            this.tel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tel.Location = new System.Drawing.Point(505, 360);
            this.tel.MaxLength = 10;
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(235, 34);
            this.tel.TabIndex = 16;
            this.tel.Text = " Tel.";
            this.tel.Click += new System.EventHandler(this.tel_click);
            this.tel.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_keypress);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(708, 461);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 47);
            this.button3.TabIndex = 17;
            this.button3.Text = "continue";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(483, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 47);
            this.button1.TabIndex = 18;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.id.Location = new System.Drawing.Point(152, 360);
            this.id.MaxLength = 13;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(299, 34);
            this.id.TabIndex = 19;
            this.id.Text = " ID / Passport";
            this.id.Click += new System.EventHandler(this.id_Click);
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Guest_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(996, 546);
            this.Controls.Add(this.id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Guest_Detail";
            this.Text = "Guest Detail";
            this.Load += new System.EventHandler(this.Guest_Detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker birth;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox id;
    }
}