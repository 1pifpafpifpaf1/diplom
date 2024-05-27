namespace kursovaya
{
    partial class Админ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Админ));
            this.button1 = new Nevron.Nov.WinFormControls.NButtonControl();
            this.button2 = new Nevron.Nov.WinFormControls.NButtonControl();
            this.button3 = new Nevron.Nov.WinFormControls.NButtonControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = false;
            this.button1.DesignTimeState = resources.GetString("button1.DesignTimeState");
            this.button1.Location = new System.Drawing.Point(72, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 55);
            this.button1.TabIndex = 10;
            this.button1.Click += new Nevron.Nov.Function<Nevron.Nov.Dom.NEventArgs>(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = false;
            this.button2.DesignTimeState = resources.GetString("button2.DesignTimeState");
            this.button2.Location = new System.Drawing.Point(72, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(306, 55);
            this.button2.TabIndex = 11;
            this.button2.Click += new Nevron.Nov.Function<Nevron.Nov.Dom.NEventArgs>(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = false;
            this.button3.DesignTimeState = resources.GetString("button3.DesignTimeState");
            this.button3.Location = new System.Drawing.Point(72, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(306, 55);
            this.button3.TabIndex = 12;
            this.button3.Click += new Nevron.Nov.Function<Nevron.Nov.Dom.NEventArgs>(this.button3_Click);
            // 
            // Админ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 347);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Админ";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Админ панель";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Админ_FormClosing);
            this.Load += new System.EventHandler(this.Админ_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Nevron.Nov.WinFormControls.NButtonControl button1;
        private Nevron.Nov.WinFormControls.NButtonControl button2;
        private Nevron.Nov.WinFormControls.NButtonControl button3;
    }
}