namespace Final_Project
{
    partial class Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxdepart = new System.Windows.Forms.TextBox();
            this.textBoxarrive = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxseat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxtime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Final_Project.Properties.Resources.airabc1;
            this.pictureBox3.Location = new System.Drawing.Point(58, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Project.Properties.Resources.airabc1;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(963, 47);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.airabc1;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(963, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(638, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "BOARDING PASS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name of passenger :";
            // 
            // textboxname
            // 
            this.textboxname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxname.Location = new System.Drawing.Point(28, 139);
            this.textboxname.Name = "textboxname";
            this.textboxname.ReadOnly = true;
            this.textboxname.Size = new System.Drawing.Size(212, 31);
            this.textboxname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "From :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "To :";
            // 
            // textBoxdepart
            // 
            this.textBoxdepart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdepart.Location = new System.Drawing.Point(453, 98);
            this.textBoxdepart.Name = "textBoxdepart";
            this.textBoxdepart.ReadOnly = true;
            this.textBoxdepart.Size = new System.Drawing.Size(212, 31);
            this.textBoxdepart.TabIndex = 8;
            // 
            // textBoxarrive
            // 
            this.textBoxarrive.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxarrive.Location = new System.Drawing.Point(453, 139);
            this.textBoxarrive.Name = "textBoxarrive";
            this.textBoxarrive.ReadOnly = true;
            this.textBoxarrive.Size = new System.Drawing.Size(212, 31);
            this.textBoxarrive.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(740, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Class :  Economy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date :";
            // 
            // textboxdate
            // 
            this.textboxdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxdate.Location = new System.Drawing.Point(101, 230);
            this.textboxdate.Name = "textboxdate";
            this.textboxdate.ReadOnly = true;
            this.textboxdate.Size = new System.Drawing.Size(168, 31);
            this.textboxdate.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Seat :";
            // 
            // textBoxseat
            // 
            this.textBoxseat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxseat.Location = new System.Drawing.Point(453, 230);
            this.textBoxseat.Name = "textBoxseat";
            this.textBoxseat.ReadOnly = true;
            this.textBoxseat.Size = new System.Drawing.Size(64, 31);
            this.textBoxseat.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(670, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "BOARDING TIME";
            // 
            // textBoxtime
            // 
            this.textBoxtime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtime.ForeColor = System.Drawing.Color.Red;
            this.textBoxtime.Location = new System.Drawing.Point(692, 233);
            this.textBoxtime.Name = "textBoxtime";
            this.textBoxtime.ReadOnly = true;
            this.textBoxtime.Size = new System.Drawing.Size(168, 39);
            this.textBoxtime.TabIndex = 16;
            this.textBoxtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxtime.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 363);
            this.Controls.Add(this.textBoxtime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxseat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textboxdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxarrive);
            this.Controls.Add(this.textBoxdepart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxdepart;
        private System.Windows.Forms.TextBox textBoxarrive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxseat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxtime;
    }
}