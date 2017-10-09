namespace SIAM
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pbGambar = new System.Windows.Forms.PictureBox();
            this.lblNIM = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblJenjang = new System.Windows.Forms.Label();
            this.lblJurusan = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblProgstud = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnKRS = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGambar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGambar
            // 
            this.pbGambar.Location = new System.Drawing.Point(18, 153);
            this.pbGambar.Name = "pbGambar";
            this.pbGambar.Size = new System.Drawing.Size(111, 119);
            this.pbGambar.TabIndex = 0;
            this.pbGambar.TabStop = false;
            // 
            // lblNIM
            // 
            this.lblNIM.AutoSize = true;
            this.lblNIM.Location = new System.Drawing.Point(135, 153);
            this.lblNIM.Name = "lblNIM";
            this.lblNIM.Size = new System.Drawing.Size(0, 13);
            this.lblNIM.TabIndex = 1;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(135, 174);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(0, 13);
            this.lblNama.TabIndex = 2;
            // 
            // lblJenjang
            // 
            this.lblJenjang.AutoSize = true;
            this.lblJenjang.Location = new System.Drawing.Point(135, 195);
            this.lblJenjang.Name = "lblJenjang";
            this.lblJenjang.Size = new System.Drawing.Size(101, 13);
            this.lblJenjang.TabIndex = 3;
            this.lblJenjang.Text = "Jenjang/Fakultas > ";
            // 
            // lblJurusan
            // 
            this.lblJurusan.AutoSize = true;
            this.lblJurusan.Location = new System.Drawing.Point(135, 216);
            this.lblJurusan.Name = "lblJurusan";
            this.lblJurusan.Size = new System.Drawing.Size(56, 13);
            this.lblJurusan.TabIndex = 4;
            this.lblJurusan.Text = "Jurusan > ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(135, 258);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status Aktif";
            // 
            // lblProgstud
            // 
            this.lblProgstud.AutoSize = true;
            this.lblProgstud.Location = new System.Drawing.Point(135, 237);
            this.lblProgstud.Name = "lblProgstud";
            this.lblProgstud.Size = new System.Drawing.Size(85, 13);
            this.lblProgstud.TabIndex = 5;
            this.lblProgstud.Text = "Program Studi > ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(729, 136);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnKRS
            // 
            this.btnKRS.Location = new System.Drawing.Point(18, 293);
            this.btnKRS.Name = "btnKRS";
            this.btnKRS.Size = new System.Drawing.Size(161, 70);
            this.btnKRS.TabIndex = 8;
            this.btnKRS.Text = "Kartu Rencana Studi";
            this.btnKRS.UseVisualStyleBackColor = true;
            this.btnKRS.Click += new System.EventHandler(this.btnKRS_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 70);
            this.button2.TabIndex = 9;
            this.button2.Text = "Rekap Hasil Studi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(376, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 70);
            this.button3.TabIndex = 10;
            this.button3.Text = "Jadwal Kuliah";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(555, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 70);
            this.button4.TabIndex = 11;
            this.button4.Text = "Absensi";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 375);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnKRS);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblProgstud);
            this.Controls.Add(this.lblJurusan);
            this.Controls.Add(this.lblJenjang);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNIM);
            this.Controls.Add(this.pbGambar);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGambar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGambar;
        private System.Windows.Forms.Label lblNIM;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblJenjang;
        private System.Windows.Forms.Label lblJurusan;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblProgstud;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnKRS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}