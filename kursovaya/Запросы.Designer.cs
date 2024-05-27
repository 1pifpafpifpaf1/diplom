namespace kursovaya
{
    partial class Запросы
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Запросы));
            this.listButtonControl1 = new Nevron.Nov.WinFormControls.NButtonControl();
            this.reqbutton = new Nevron.Nov.WinFormControls.NButtonControl();
            this.eqbox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // listButtonControl1
            // 
            this.listButtonControl1.AutoSize = false;
            this.listButtonControl1.DesignTimeState = resources.GetString("listButtonControl1.DesignTimeState");
            this.listButtonControl1.Location = new System.Drawing.Point(204, 155);
            this.listButtonControl1.Name = "listButtonControl1";
            this.listButtonControl1.Size = new System.Drawing.Size(168, 51);
            this.listButtonControl1.TabIndex = 21;
            this.listButtonControl1.Click += new Nevron.Nov.Function<Nevron.Nov.Dom.NEventArgs>(this.listButtonControl1_Click);
            // 
            // reqbutton
            // 
            this.reqbutton.AutoSize = false;
            this.reqbutton.DesignTimeState = resources.GetString("reqbutton.DesignTimeState");
            this.reqbutton.Location = new System.Drawing.Point(13, 155);
            this.reqbutton.Name = "reqbutton";
            this.reqbutton.Size = new System.Drawing.Size(168, 51);
            this.reqbutton.TabIndex = 20;
            this.reqbutton.Click += new Nevron.Nov.Function<Nevron.Nov.Dom.NEventArgs>(this.reqbutton_Click);
            // 
            // eqbox
            // 
            this.eqbox.FormattingEnabled = true;
            this.eqbox.ItemHeight = 23;
            this.eqbox.Location = new System.Drawing.Point(63, 90);
            this.eqbox.Name = "eqbox";
            this.eqbox.PromptText = "Код запроса";
            this.eqbox.Size = new System.Drawing.Size(265, 29);
            this.eqbox.Style = MetroFramework.MetroColorStyle.Red;
            this.eqbox.TabIndex = 18;
            this.eqbox.UseSelectable = true;
            this.eqbox.SelectedIndexChanged += new System.EventHandler(this.eqbox_SelectedIndexChanged);
            // 
            // Запросы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 242);
            this.Controls.Add(this.listButtonControl1);
            this.Controls.Add(this.reqbutton);
            this.Controls.Add(this.eqbox);
            this.MaximizeBox = false;
            this.Name = "Запросы";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Запросы";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Запросы_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Nevron.Nov.WinFormControls.NButtonControl listButtonControl1;
        private Nevron.Nov.WinFormControls.NButtonControl reqbutton;
        private MetroFramework.Controls.MetroComboBox eqbox;
    }
}