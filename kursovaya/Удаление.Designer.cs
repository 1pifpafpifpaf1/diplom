namespace kursovaya
{
    partial class Удаление
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Удаление));
            this.deletebutton = new Nevron.Nov.WinFormControls.NButtonControl();
            this.boxcount = new MetroFramework.Controls.MetroComboBox();
            this.eqbox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // deletebutton
            // 
            this.deletebutton.AutoSize = false;
            this.deletebutton.DesignTimeState = resources.GetString("deletebutton.DesignTimeState");
            this.deletebutton.Location = new System.Drawing.Point(99, 152);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(168, 51);
            this.deletebutton.TabIndex = 13;
            this.deletebutton.Click += new Nevron.Nov.Function<Nevron.Nov.Dom.NEventArgs>(this.deletebutton_Click);
            // 
            // boxcount
            // 
            this.boxcount.FormattingEnabled = true;
            this.boxcount.ItemHeight = 23;
            this.boxcount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.boxcount.Location = new System.Drawing.Point(299, 87);
            this.boxcount.Name = "boxcount";
            this.boxcount.PromptText = "Кол-во";
            this.boxcount.Size = new System.Drawing.Size(73, 29);
            this.boxcount.Style = MetroFramework.MetroColorStyle.Red;
            this.boxcount.TabIndex = 12;
            this.boxcount.UseSelectable = true;
            // 
            // eqbox
            // 
            this.eqbox.FormattingEnabled = true;
            this.eqbox.ItemHeight = 23;
            this.eqbox.Location = new System.Drawing.Point(13, 89);
            this.eqbox.Name = "eqbox";
            this.eqbox.PromptText = "Код оборудования";
            this.eqbox.Size = new System.Drawing.Size(265, 29);
            this.eqbox.Style = MetroFramework.MetroColorStyle.Red;
            this.eqbox.TabIndex = 11;
            this.eqbox.UseSelectable = true;
            // 
            // Удаление
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 242);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.boxcount);
            this.Controls.Add(this.eqbox);
            this.Name = "Удаление";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Удаление";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Удаление_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Nevron.Nov.WinFormControls.NButtonControl deletebutton;
        private MetroFramework.Controls.MetroComboBox boxcount;
        private MetroFramework.Controls.MetroComboBox eqbox;
    }
}