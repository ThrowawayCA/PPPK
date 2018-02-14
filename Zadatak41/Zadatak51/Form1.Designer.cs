namespace Zadatak51
{
    partial class Form1
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
            this.cbAlbumi = new System.Windows.Forms.ComboBox();
            this.lstPjesme = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbAlbumi
            // 
            this.cbAlbumi.FormattingEnabled = true;
            this.cbAlbumi.Location = new System.Drawing.Point(28, 12);
            this.cbAlbumi.Name = "cbAlbumi";
            this.cbAlbumi.Size = new System.Drawing.Size(500, 21);
            this.cbAlbumi.TabIndex = 0;
            this.cbAlbumi.SelectedIndexChanged += new System.EventHandler(this.cbAlbumi_SelectedIndexChanged);
            // 
            // lstPjesme
            // 
            this.lstPjesme.FormattingEnabled = true;
            this.lstPjesme.Location = new System.Drawing.Point(28, 50);
            this.lstPjesme.Name = "lstPjesme";
            this.lstPjesme.Size = new System.Drawing.Size(500, 303);
            this.lstPjesme.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 368);
            this.Controls.Add(this.lstPjesme);
            this.Controls.Add(this.cbAlbumi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAlbumi;
        private System.Windows.Forms.ListBox lstPjesme;
    }
}

