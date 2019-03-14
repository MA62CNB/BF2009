namespace BF_2009
{
    partial class Fix
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
            this.label1 = new System.Windows.Forms.Label();
            this.seri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.program = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(239, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fikstür";
            // 
            // seri
            // 
            this.seri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.seri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.seri.Cursor = System.Windows.Forms.Cursors.Default;
            this.seri.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seri.Location = new System.Drawing.Point(138, 151);
            this.seri.Name = "seri";
            this.seri.ReadOnly = true;
            this.seri.Size = new System.Drawing.Size(316, 23);
            this.seri.TabIndex = 4;
            this.seri.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(182, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // program
            // 
            this.program.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.program.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.program.Cursor = System.Windows.Forms.Cursors.Default;
            this.program.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.program.Location = new System.Drawing.Point(174, 208);
            this.program.Multiline = true;
            this.program.Name = "program";
            this.program.ReadOnly = true;
            this.program.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.program.Size = new System.Drawing.Size(245, 317);
            this.program.TabIndex = 6;
            this.program.TabStop = false;
            this.program.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.program.WordWrap = false;
            // 
            // Fix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 577);
            this.Controls.Add(this.program);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seri);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(608, 613);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(608, 613);
            this.Name = "Fix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fikstür";
            this.Load += new System.EventHandler(this.Fix_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox seri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox program;
    }
}