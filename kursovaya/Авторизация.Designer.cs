namespace kursovaya
{
    partial class Авторизация
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Авторизация));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hashtext = new MetroFramework.Controls.MetroTextBox();
            this.logtext = new MetroFramework.Controls.MetroTextBox();
            this.passtext = new MetroFramework.Controls.MetroTextBox();
            this.loginbutton = new Nevron.Nov.WinFormControls.NButtonControl();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(20, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(276, 113);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 206);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.hashtext);
            this.panel1.Controls.Add(this.logtext);
            this.panel1.Controls.Add(this.passtext);
            this.panel1.Controls.Add(this.loginbutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 406);
            this.panel1.TabIndex = 4;
            // 
            // hashtext
            // 
            // 
            // 
            // 
            this.hashtext.CustomButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hashtext.CustomButton.Image = null;
            this.hashtext.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.hashtext.CustomButton.Name = "";
            this.hashtext.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.hashtext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hashtext.CustomButton.TabIndex = 1;
            this.hashtext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hashtext.CustomButton.UseSelectable = true;
            this.hashtext.CustomButton.Visible = false;
            this.hashtext.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.hashtext.Lines = new string[0];
            this.hashtext.Location = new System.Drawing.Point(73, 291);
            this.hashtext.MaxLength = 32767;
            this.hashtext.Name = "hashtext";
            this.hashtext.PasswordChar = '\0';
            this.hashtext.ReadOnly = true;
            this.hashtext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hashtext.SelectedText = "";
            this.hashtext.SelectionLength = 0;
            this.hashtext.SelectionStart = 0;
            this.hashtext.ShortcutsEnabled = true;
            this.hashtext.Size = new System.Drawing.Size(230, 29);
            this.hashtext.Style = MetroFramework.MetroColorStyle.Red;
            this.hashtext.TabIndex = 12;
            this.hashtext.UseSelectable = true;
            this.hashtext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hashtext.WaterMarkFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // logtext
            // 
            // 
            // 
            // 
            this.logtext.CustomButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logtext.CustomButton.Image = null;
            this.logtext.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.logtext.CustomButton.Name = "";
            this.logtext.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.logtext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.logtext.CustomButton.TabIndex = 1;
            this.logtext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.logtext.CustomButton.UseSelectable = true;
            this.logtext.CustomButton.Visible = false;
            this.logtext.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.logtext.Lines = new string[0];
            this.logtext.Location = new System.Drawing.Point(73, 127);
            this.logtext.MaxLength = 32767;
            this.logtext.Name = "logtext";
            this.logtext.PasswordChar = '\0';
            this.logtext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.logtext.SelectedText = "";
            this.logtext.SelectionLength = 0;
            this.logtext.SelectionStart = 0;
            this.logtext.ShortcutsEnabled = true;
            this.logtext.Size = new System.Drawing.Size(230, 40);
            this.logtext.Style = MetroFramework.MetroColorStyle.Red;
            this.logtext.TabIndex = 11;
            this.logtext.UseSelectable = true;
            this.logtext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.logtext.WaterMarkFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // passtext
            // 
            // 
            // 
            // 
            this.passtext.CustomButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passtext.CustomButton.Image = null;
            this.passtext.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.passtext.CustomButton.Name = "";
            this.passtext.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.passtext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passtext.CustomButton.TabIndex = 1;
            this.passtext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passtext.CustomButton.UseSelectable = true;
            this.passtext.CustomButton.Visible = false;
            this.passtext.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.passtext.Lines = new string[0];
            this.passtext.Location = new System.Drawing.Point(73, 215);
            this.passtext.MaxLength = 32767;
            this.passtext.Name = "passtext";
            this.passtext.PasswordChar = '●';
            this.passtext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passtext.SelectedText = "";
            this.passtext.SelectionLength = 0;
            this.passtext.SelectionStart = 0;
            this.passtext.ShortcutsEnabled = true;
            this.passtext.Size = new System.Drawing.Size(230, 40);
            this.passtext.Style = MetroFramework.MetroColorStyle.Red;
            this.passtext.TabIndex = 10;
            this.passtext.UseSelectable = true;
            this.passtext.UseSystemPasswordChar = true;
            this.passtext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passtext.WaterMarkFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // loginbutton
            // 
            this.loginbutton.AutoSize = false;
            this.loginbutton.DesignTimeState = resources.GetString("loginbutton.DesignTimeState");
            this.loginbutton.Location = new System.Drawing.Point(42, 348);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(230, 55);
            this.loginbutton.TabIndex = 9;
            this.loginbutton.Click += new Nevron.Nov.Function<Nevron.Nov.Dom.NEventArgs>(this.loginbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Хэш";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Авторизация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 486);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Авторизация";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Авторизация";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Авторизация_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private Nevron.Nov.WinFormControls.NButtonControl loginbutton;
        private MetroFramework.Controls.MetroTextBox passtext;
        private MetroFramework.Controls.MetroTextBox logtext;
        private MetroFramework.Controls.MetroTextBox hashtext;
    }
}