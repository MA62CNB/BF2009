namespace BF_2009
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
            this.yeniO = new System.Windows.Forms.PictureBox();
            this.eskiO = new System.Windows.Forms.PictureBox();
            this.cikis = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yeniO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eskiO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).BeginInit();
            this.SuspendLayout();
            // 
            // yeniO
            // 
            this.yeniO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yeniO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yeniO.Location = new System.Drawing.Point(322, 341);
            this.yeniO.Name = "yeniO";
            this.yeniO.Size = new System.Drawing.Size(100, 50);
            this.yeniO.TabIndex = 0;
            this.yeniO.TabStop = false;
            this.yeniO.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // eskiO
            // 
            this.eskiO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eskiO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eskiO.Location = new System.Drawing.Point(462, 341);
            this.eskiO.Name = "eskiO";
            this.eskiO.Size = new System.Drawing.Size(100, 50);
            this.eskiO.TabIndex = 1;
            this.eskiO.TabStop = false;
            // 
            // cikis
            // 
            this.cikis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis.Location = new System.Drawing.Point(602, 341);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(100, 50);
            this.cikis.TabIndex = 2;
            this.cikis.TabStop = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "yeni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "yükle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(638, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "çıkış";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.eskiO);
            this.Controls.Add(this.yeniO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BF 2009";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yeniO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eskiO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox yeniO;
        private System.Windows.Forms.PictureBox eskiO;
        private System.Windows.Forms.PictureBox cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

