namespace kursovaya
{
    partial class Админ_удаление_сотр
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Админ_удаление_сотр));
            this.logtext = new MetroFramework.Controls.MetroTextBox();
            this.deletebutton = new Nevron.Nov.WinFormControls.NButtonControl();
            this.SuspendLayout();
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
            this.logtext.Location = new System.Drawing.Point(70, 80);
            this.logtext.MaxLength = 32767;
            this.logtext.Name = "logtext";
            this.logtext.PasswordChar = '\0';
            this.logtext.PromptText = "ФИО сотрудника";
            this.logtext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.logtext.SelectedText = "";
            this.logtext.SelectionLength = 0;
            this.logtext.SelectionStart = 0;
            this.logtext.ShortcutsEnabled = true;
            this.logtext.Size = new System.Drawing.Size(310, 40);
            this.logtext.Style = MetroFramework.MetroColorStyle.Red;
            this.logtext.TabIndex = 17;
            this.logtext.UseSelectable = true;
            this.logtext.WaterMark = "ФИО сотрудника";
            this.logtext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.logtext.WaterMarkFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // deletebutton
            // 
            this.deletebutton.AutoSize = false;
            this.deletebutton.DesignTimeState = resources.GetString("deletebutton.DesignTimeState");
            this.deletebutton.Location = new System.Drawing.Point(136, 137);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(168, 51);
            this.deletebutton.TabIndex = 16;
            this.deletebutton.Click += new Nevron.Nov.Function<Nevron.Nov.Dom.NEventArgs>(this.deletebutton_Click);
            // 
            // Админ_удаление_сотр
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 236);
            this.Controls.Add(this.logtext);
            this.Controls.Add(this.deletebutton);
            this.Name = "Админ_удаление_сотр";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Удаление сотрудника";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Админ_удаление_сотр_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox logtext;
        private Nevron.Nov.WinFormControls.NButtonControl deletebutton;
    }
}