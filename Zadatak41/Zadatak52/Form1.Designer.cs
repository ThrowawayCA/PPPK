namespace Zadatak52
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
            this.lstPjesme = new System.Windows.Forms.ListBox();
            this.cbAlbumi = new System.Windows.Forms.ComboBox();
            this.txtPjesma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPjesme
            // 
            this.lstPjesme.FormattingEnabled = true;
            this.lstPjesme.Location = new System.Drawing.Point(62, 54);
            this.lstPjesme.Name = "lstPjesme";
            this.lstPjesme.Size = new System.Drawing.Size(500, 225);
            this.lstPjesme.TabIndex = 3;
            this.lstPjesme.SelectedIndexChanged += new System.EventHandler(this.lstPjesme_SelectedIndexChanged);
            // 
            // cbAlbumi
            // 
            this.cbAlbumi.FormattingEnabled = true;
            this.cbAlbumi.Location = new System.Drawing.Point(62, 27);
            this.cbAlbumi.Name = "cbAlbumi";
            this.cbAlbumi.Size = new System.Drawing.Size(500, 21);
            this.cbAlbumi.TabIndex = 2;
            this.cbAlbumi.SelectedIndexChanged += new System.EventHandler(this.cbAlbumi_SelectedIndexChanged);
            // 
            // txtPjesma
            // 
            this.txtPjesma.Location = new System.Drawing.Point(62, 328);
            this.txtPjesma.Name = "txtPjesma";
            this.txtPjesma.Size = new System.Drawing.Size(100, 20);
            this.txtPjesma.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(200, 328);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(200, 357);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(200, 386);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 426);
            this.Controls.Add(this.txtPjesma);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPjesme);
            this.Controls.Add(this.cbAlbumi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPjesme;
        private System.Windows.Forms.ComboBox cbAlbumi;
        private System.Windows.Forms.TextBox txtPjesma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

