namespace kursovaya
{
    partial class Админ_удаление
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Админ_удаление));
            this.addbutton = new Nevron.Nov.WinFormControls.NButtonControl();
            this.eqbox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // addbutton
            // 
            this.addbutton.AutoSize = false;
            this.addbutton.DesignTimeState = resources.GetString("addbutton.DesignTimeState");
            this.addbutton.Location = new System.Drawing.Point(95, 151);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(168, 51);
            this.addbutton.TabIndex = 12;
            // 
            // eqbox
            // 
            this.eqbox.FormattingEnabled = true;
            this.eqbox.ItemHeight = 23;
            this.eqbox.Location = new System.Drawing.Point(59, 89);
            this.eqbox.Name = "eqbox";
            this.eqbox.PromptText = "Оборудование";
            this.eqbox.Size = new System.Drawing.Size(265, 29);
            this.eqbox.Style = MetroFramework.MetroColorStyle.Red;
            this.eqbox.TabIndex = 11;
            this.eqbox.UseSelectable = true;
            // 
            // Админ_удаление
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 242);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.eqbox);
            this.Name = "Админ_удаление";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Удаление";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Админ_удаление_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Nevron.Nov.WinFormControls.NButtonControl addbutton;
        private MetroFramework.Controls.MetroComboBox eqbox;
    }
}