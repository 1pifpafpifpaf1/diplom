namespace kursovaya
{
    partial class Запрос
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Запрос));
            this.reqbutton = new Nevron.Nov.WinFormControls.NButtonControl();
            this.boxcount = new MetroFramework.Controls.MetroComboBox();
            this.eqbox = new MetroFramework.Controls.MetroComboBox();
            this.listButtonControl1 = new Nevron.Nov.WinFormControls.NButtonControl();
            this.SuspendLayout();
            // 
            // reqbutton
            // 
            this.reqbutton.AutoSize = false;
            this.reqbutton.DesignTimeState = resources.GetString("reqbutton.DesignTimeState");
            this.reqbutton.Location = new System.Drawing.Point(13, 155);
            this.reqbutton.Name = "reqbutton";
            this.reqbutton.Size = new System.Drawing.Size(168, 51);
            this.reqbutton.TabIndex = 16;
            this.reqbutton.Click += new Nevron.Nov.Function<Nevron.Nov.Dom.NEventArgs>(this.reqbutton_Click);
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
            this.boxcount.TabIndex = 15;
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
            this.eqbox.TabIndex = 14;
            this.eqbox.UseSelectable = true;
            // 
            // listButtonControl1
            // 
            this.listButtonControl1.AutoSize = false;
            this.listButtonControl1.DesignTimeState = resources.GetString("listButtonControl1.DesignTimeState");
            this.listButtonControl1.Location = new System.Drawing.Point(204, 155);
            this.listButtonControl1.Name = "listButtonControl1";
            this.listButtonControl1.Size = new System.Drawing.Size(168, 51);
            this.listButtonControl1.TabIndex = 17;
            this.listButtonControl1.Click += new Nevron.Nov.Function<Nevron.Nov.Dom.NEventArgs>(this.listButtonControl1_Click);
            // 
            // Запрос
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 242);
            this.Controls.Add(this.listButtonControl1);
            this.Controls.Add(this.reqbutton);
            this.Controls.Add(this.boxcount);
            this.Controls.Add(this.eqbox);
            this.MaximizeBox = false;
            this.Name = "Запрос";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Запрос";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Запрос_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Nevron.Nov.WinFormControls.NButtonControl reqbutton;
        private MetroFramework.Controls.MetroComboBox boxcount;
        private MetroFramework.Controls.MetroComboBox eqbox;
        private Nevron.Nov.WinFormControls.NButtonControl listButtonControl1;
    }
}