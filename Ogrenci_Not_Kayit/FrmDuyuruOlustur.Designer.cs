
namespace Ogrenci_Not_Kayit
{
    partial class FrmDuyuruOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuyuruOlustur));
            this.richTextBoxDuyuru = new System.Windows.Forms.RichTextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxDuyuru
            // 
            this.richTextBoxDuyuru.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxDuyuru.Name = "richTextBoxDuyuru";
            this.richTextBoxDuyuru.Size = new System.Drawing.Size(1461, 136);
            this.richTextBoxDuyuru.TabIndex = 0;
            this.richTextBoxDuyuru.Text = "";
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEkle.Location = new System.Drawing.Point(12, 160);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(444, 42);
            this.buttonEkle.TabIndex = 1;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSil.Location = new System.Drawing.Point(1029, 160);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(444, 42);
            this.buttonSil.TabIndex = 2;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGüncelle.Location = new System.Drawing.Point(518, 160);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(444, 42);
            this.buttonGüncelle.TabIndex = 3;
            this.buttonGüncelle.Text = "Güncelle";
            this.buttonGüncelle.UseVisualStyleBackColor = false;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(1523, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 190);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1778, 556);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmDuyuruOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1802, 828);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.richTextBoxDuyuru);
            this.Name = "FrmDuyuruOlustur";
            this.Text = "FrmDuyuruOlustur";
            this.Load += new System.EventHandler(this.FrmDuyuruOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDuyuru;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}