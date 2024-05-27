namespace kursovaya
{
    partial class addeq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addeq));
            this.addbutton = new Nevron.Nov.WinFormControls.NButtonControl();
            this.logtext = new MetroFramework.Controls.MetroTextBox();
            this.logtext2 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // addbutton
            // 
            this.addbutton.AutoSize = false;
            this.addbutton.DesignTimeState = resources.GetString("addbutton.DesignTimeState");
            this.addbutton.Location = new System.Drawing.Point(99, 152);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(168, 51);
            this.addbutton.TabIndex = 10;
            this.addbutton.Click += new Nevron.Nov.Function<Nevron.Nov.Dom.NEventArgs>(this.addbutton_Click);
            // 
            // logtext
            // 
            // 
            // 
            // 
            this.logtext.CustomButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logtext.CustomButton.Image = null;
            this.logtext.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.logtext.CustomButton.Name = "";
            this.logtext.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.logtext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.logtext.CustomButton.TabIndex = 1;
            this.logtext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.logtext.CustomButton.UseSelectable = true;
            this.logtext.CustomButton.Visible = false;
            this.logtext.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.logtext.Lines = new string[0];
            this.logtext.Location = new System.Drawing.Point(23, 76);
            this.logtext.MaxLength = 32767;
            this.logtext.Name = "logtext";
            this.logtext.PasswordChar = '\0';
            this.logtext.PromptText = "Название оборудования";
            this.logtext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.logtext.SelectedText = "";
            this.logtext.SelectionLength = 0;
            this.logtext.SelectionStart = 0;
            this.logtext.ShortcutsEnabled = true;
            this.logtext.Size = new System.Drawing.Size(244, 40);
            this.logtext.Style = MetroFramework.MetroColorStyle.Red;
            this.logtext.TabIndex = 16;
            this.logtext.UseSelectable = true;
            this.logtext.WaterMark = "Название оборудования";
            this.logtext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.logtext.WaterMarkFont = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // logtext2
            // 
            // 
            // 
            // 
            this.logtext2.CustomButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logtext2.CustomButton.Image = null;
            this.logtext2.CustomButton.Location = new System.Drawing.Point(39, 2);
            this.logtext2.CustomButton.Name = "";
            this.logtext2.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.logtext2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.logtext2.CustomButton.TabIndex = 1;
            this.logtext2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.logtext2.CustomButton.UseSelectable = true;
            this.logtext2.CustomButton.Visible = false;
            this.logtext2.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.logtext2.Lines = new string[0];
            this.logtext2.Location = new System.Drawing.Point(284, 76);
            this.logtext2.MaxLength = 32767;
            this.logtext2.Name = "logtext2";
            this.logtext2.PasswordChar = '\0';
            this.logtext2.PromptText = "Кол-во";
            this.logtext2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.logtext2.SelectedText = "";
            this.logtext2.SelectionLength = 0;
            this.logtext2.SelectionStart = 0;
            this.logtext2.ShortcutsEnabled = true;
            this.logtext2.Size = new System.Drawing.Size(77, 40);
            this.logtext2.Style = MetroFramework.MetroColorStyle.Red;
            this.logtext2.TabIndex = 17;
            this.logtext2.UseSelectable = true;
            this.logtext2.WaterMark = "Кол-во";
            this.logtext2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.logtext2.WaterMarkFont = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // addeq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 242);
            this.Controls.Add(this.logtext2);
            this.Controls.Add(this.logtext);
            this.Controls.Add(this.addbutton);
            this.MaximizeBox = false;
            this.Name = "addeq";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Добавление";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.addeq_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Nevron.Nov.WinFormControls.NButtonControl addbutton;
        private MetroFramework.Controls.MetroTextBox logtext;
        private MetroFramework.Controls.MetroTextBox logtext2;
    }
}