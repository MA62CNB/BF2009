namespace BF_2009
{
    partial class Taktik
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
            this.formation = new System.Windows.Forms.PictureBox();
            this.tactices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.formation)).BeginInit();
            this.SuspendLayout();
            // 
            // formation
            // 
            this.formation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formation.Location = new System.Drawing.Point(120, 195);
            this.formation.Name = "formation";
            this.formation.Size = new System.Drawing.Size(544, 274);
            this.formation.TabIndex = 0;
            this.formation.TabStop = false;
            // 
            // tactices
            // 
            this.tactices.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tactices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tactices.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tactices.FormattingEnabled = true;
            this.tactices.Items.AddRange(new object[] {
            "3-5-2",
            "4-2-4",
            "4-3-3",
            "4-4-2",
            "4-5-1",
            "5-4-1"});
            this.tactices.Location = new System.Drawing.Point(543, 146);
            this.tactices.Name = "tactices";
            this.tactices.Size = new System.Drawing.Size(121, 22);
            this.tactices.Sorted = true;
            this.tactices.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(305, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Formasyon";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(342, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Seçimi onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(358, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "rakip takım";
            // 
            // Taktik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 577);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tactices);
            this.Controls.Add(this.formation);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 613);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 613);
            this.Name = "Taktik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taktik";
            ((System.ComponentModel.ISupportInitialize)(this.formation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox formation;
        private System.Windows.Forms.ComboBox tactices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}