namespace BF_2009
{
    partial class Game
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.takimEkr = new System.Windows.Forms.Button();
            this.taktikEkr = new System.Windows.Forms.Button();
            this.antrenman = new System.Windows.Forms.Button();
            this.Fikstür = new System.Windows.Forms.Button();
            this.oyuncuAra = new System.Windows.Forms.Button();
            this.anaMenu = new System.Windows.Forms.Button();
            this.virGun = new System.Windows.Forms.Label();
            this.virAy = new System.Windows.Forms.Label();
            this.virYil = new System.Windows.Forms.Label();
            this.haberler = new System.Windows.Forms.RichTextBox();
            this.devam = new System.Windows.Forms.Button();
            this.gazete = new System.Windows.Forms.PictureBox();
            this.match = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gazete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 100);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(0, 57);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 36);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(909, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(6, 8);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(627, 46);
            this.textBox1.TabIndex = 7;
            this.textBox1.WordWrap = false;
            // 
            // takimEkr
            // 
            this.takimEkr.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.takimEkr.Location = new System.Drawing.Point(35, 101);
            this.takimEkr.Name = "takimEkr";
            this.takimEkr.Size = new System.Drawing.Size(160, 45);
            this.takimEkr.TabIndex = 1;
            this.takimEkr.Text = "TAKIM";
            this.takimEkr.UseVisualStyleBackColor = true;
            this.takimEkr.Click += new System.EventHandler(this.takimEkr_Click);
            // 
            // taktikEkr
            // 
            this.taktikEkr.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.taktikEkr.Location = new System.Drawing.Point(194, 101);
            this.taktikEkr.Name = "taktikEkr";
            this.taktikEkr.Size = new System.Drawing.Size(160, 45);
            this.taktikEkr.TabIndex = 2;
            this.taktikEkr.Text = "TAKTİK";
            this.taktikEkr.UseVisualStyleBackColor = true;
            this.taktikEkr.Click += new System.EventHandler(this.taktikEkr_Click);
            // 
            // antrenman
            // 
            this.antrenman.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.antrenman.Location = new System.Drawing.Point(353, 101);
            this.antrenman.Name = "antrenman";
            this.antrenman.Size = new System.Drawing.Size(160, 45);
            this.antrenman.TabIndex = 3;
            this.antrenman.Text = "ANTRENMAN";
            this.antrenman.UseVisualStyleBackColor = true;
            this.antrenman.Click += new System.EventHandler(this.antrenman_Click);
            // 
            // Fikstür
            // 
            this.Fikstür.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Fikstür.Location = new System.Drawing.Point(512, 101);
            this.Fikstür.Name = "Fikstür";
            this.Fikstür.Size = new System.Drawing.Size(160, 45);
            this.Fikstür.TabIndex = 4;
            this.Fikstür.Text = "FİKSTÜR";
            this.Fikstür.UseVisualStyleBackColor = true;
            this.Fikstür.Click += new System.EventHandler(this.Fikstür_Click);
            // 
            // oyuncuAra
            // 
            this.oyuncuAra.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyuncuAra.Location = new System.Drawing.Point(671, 101);
            this.oyuncuAra.Name = "oyuncuAra";
            this.oyuncuAra.Size = new System.Drawing.Size(160, 45);
            this.oyuncuAra.TabIndex = 5;
            this.oyuncuAra.Text = "OYUNCU ARA";
            this.oyuncuAra.UseVisualStyleBackColor = true;
            this.oyuncuAra.Click += new System.EventHandler(this.oyuncuAra_Click);
            // 
            // anaMenu
            // 
            this.anaMenu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anaMenu.Location = new System.Drawing.Point(830, 101);
            this.anaMenu.Name = "anaMenu";
            this.anaMenu.Size = new System.Drawing.Size(160, 45);
            this.anaMenu.TabIndex = 6;
            this.anaMenu.Text = "ANA MENÜ";
            this.anaMenu.UseVisualStyleBackColor = true;
            this.anaMenu.Click += new System.EventHandler(this.anaMenu_Click);
            // 
            // virGun
            // 
            this.virGun.AutoSize = true;
            this.virGun.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.virGun.ForeColor = System.Drawing.Color.Yellow;
            this.virGun.Location = new System.Drawing.Point(50, 149);
            this.virGun.Name = "virGun";
            this.virGun.Size = new System.Drawing.Size(19, 14);
            this.virGun.TabIndex = 7;
            this.virGun.Text = "dd";
            // 
            // virAy
            // 
            this.virAy.AutoSize = true;
            this.virAy.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.virAy.ForeColor = System.Drawing.Color.Yellow;
            this.virAy.Location = new System.Drawing.Point(77, 149);
            this.virAy.Name = "virAy";
            this.virAy.Size = new System.Drawing.Size(27, 14);
            this.virAy.TabIndex = 8;
            this.virAy.Text = "mm";
            // 
            // virYil
            // 
            this.virYil.AutoSize = true;
            this.virYil.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.virYil.ForeColor = System.Drawing.Color.Yellow;
            this.virYil.Location = new System.Drawing.Point(112, 149);
            this.virYil.Name = "virYil";
            this.virYil.Size = new System.Drawing.Size(31, 14);
            this.virYil.TabIndex = 9;
            this.virYil.Text = "yyyy";
            // 
            // haberler
            // 
            this.haberler.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.haberler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.haberler.Cursor = System.Windows.Forms.Cursors.Default;
            this.haberler.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.haberler.Location = new System.Drawing.Point(263, 213);
            this.haberler.Name = "haberler";
            this.haberler.ReadOnly = true;
            this.haberler.Size = new System.Drawing.Size(702, 343);
            this.haberler.TabIndex = 7;
            this.haberler.Text = "";
            // 
            // devam
            // 
            this.devam.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.devam.Location = new System.Drawing.Point(134, 685);
            this.devam.Name = "devam";
            this.devam.Size = new System.Drawing.Size(757, 45);
            this.devam.TabIndex = 8;
            this.devam.Text = "Devam";
            this.devam.UseVisualStyleBackColor = true;
            this.devam.Click += new System.EventHandler(this.devam_Click);
            // 
            // gazete
            // 
            this.gazete.Image = global::BF_2009.Properties.Resources.gazete;
            this.gazete.Location = new System.Drawing.Point(60, 213);
            this.gazete.Name = "gazete";
            this.gazete.Size = new System.Drawing.Size(197, 152);
            this.gazete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gazete.TabIndex = 10;
            this.gazete.TabStop = false;
            // 
            // match
            // 
            this.match.Enabled = false;
            this.match.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.match.Location = new System.Drawing.Point(134, 640);
            this.match.Name = "match";
            this.match.Size = new System.Drawing.Size(757, 45);
            this.match.TabIndex = 11;
            this.match.Text = "Maça başla";
            this.match.UseVisualStyleBackColor = true;
            this.match.Click += new System.EventHandler(this.match_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(133, 453);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(13, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(152, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "puan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(133, 487);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(13, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(152, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "maç";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(113, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "bir sonraki maç";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(80, 404);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(167, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "...";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(390, 87);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(245, 506);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.DoubleClick += new System.EventHandler(this.richTextBox1_DoubleClick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.match);
            this.Controls.Add(this.virYil);
            this.Controls.Add(this.devam);
            this.Controls.Add(this.virAy);
            this.Controls.Add(this.haberler);
            this.Controls.Add(this.virGun);
            this.Controls.Add(this.anaMenu);
            this.Controls.Add(this.oyuncuAra);
            this.Controls.Add(this.Fikstür);
            this.Controls.Add(this.antrenman);
            this.Controls.Add(this.taktikEkr);
            this.Controls.Add(this.takimEkr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gazete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BF 2009";
            this.Load += new System.EventHandler(this.Game_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gazete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button takimEkr;
        private System.Windows.Forms.Button taktikEkr;
        private System.Windows.Forms.Button antrenman;
        private System.Windows.Forms.Button Fikstür;
        private System.Windows.Forms.Button oyuncuAra;
        private System.Windows.Forms.Button anaMenu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label virGun;
        private System.Windows.Forms.Label virYil;
        private System.Windows.Forms.Label virAy;
        private System.Windows.Forms.RichTextBox haberler;
        private System.Windows.Forms.Button devam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox gazete;
        private System.Windows.Forms.Label linkLabel1;
        private System.Windows.Forms.Button match;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}