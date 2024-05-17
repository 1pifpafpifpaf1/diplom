namespace kursovaya
{
    partial class Удаление_Админ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Удаление_Админ));
            this.deletebutton = new Nevron.Nov.WinFormControls.NButtonControl();
            this.logtext = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // deletebutton
            // 
            this.deletebutton.AutoSize = false;
            this.deletebutton.DesignTimeState = resources.GetString("deletebutton.DesignTimeState");
            this.deletebutton.Location = new System.Drawing.Point(121, 133);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(168, 51);
            this.deletebutton.TabIndex = 14;
            this.deletebutton.Click += new Nevron.Nov.Function<Nevron.Nov.Dom.NEventArgs>(this.deletebutton_Click);
            // 
            // logtext
            // 
            // 
            // 
            // 
            this.logtext.CustomButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logtext.CustomButton.Image = null;
            this.logtext.CustomButton.Location = new System.Drawing.Point(272, 2);
            this.logtext.CustomButton.Name = "";
            this.logtext.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.logtext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.logtext.CustomButton.TabIndex = 1;
            this.logtext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.logtext.CustomButton.UseSelectable = true;
            this.logtext.CustomButton.Visible = false;
            this.logtext.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.logtext.Lines = new string[0];
            this.logtext.Location = new System.Drawing.Point(55, 76);
            this.logtext.MaxLength = 32767;
            this.logtext.Name = "logtext";
            this.logtext.PasswordChar = '\0';
            this.logtext.PromptText = "Название оборудования";
            this.logtext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.logtext.SelectedText = "";
            this.logtext.SelectionLength = 0;
            this.logtext.SelectionStart = 0;
            this.logtext.ShortcutsEnabled = true;
            this.logtext.Size = new System.Drawing.Size(310, 40);
            this.logtext.Style = MetroFramework.MetroColorStyle.Red;
            this.logtext.TabIndex = 15;
            this.logtext.UseSelectable = true;
            this.logtext.WaterMark = "Название оборудования";
            this.logtext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.logtext.WaterMarkFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logtext.Click += new System.EventHandler(this.logtext_Click);
            // 
            // Удаление_Админ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 220);
            this.Controls.Add(this.logtext);
            this.Controls.Add(this.deletebutton);
            this.Name = "Удаление_Админ";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Удаление оборудования";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Удаление_Админ_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Nevron.Nov.WinFormControls.NButtonControl deletebutton;
        private MetroFramework.Controls.MetroTextBox logtext;
    }
}