
namespace Ogrenci_Not_Kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxOgretmen = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxOgretmenNumara = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxOgretmen = new System.Windows.Forms.PictureBox();
            this.textBoxOgretmenSifre = new System.Windows.Forms.TextBox();
            this.buttonOgretmenGiris = new System.Windows.Forms.Button();
            this.labelOgretmenSıfre = new System.Windows.Forms.Label();
            this.labelOgretmenNumara = new System.Windows.Forms.Label();
            this.groupBoxOgrenci = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxOgrenciNumara = new System.Windows.Forms.MaskedTextBox();
            this.textBoxOgrenciSifre = new System.Windows.Forms.TextBox();
            this.buttonOgrenciGiris = new System.Windows.Forms.Button();
            this.labelOgrenciSifre = new System.Windows.Forms.Label();
            this.labelOgrenciNumara = new System.Windows.Forms.Label();
            this.groupBoxOgretmen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgretmen)).BeginInit();
            this.groupBoxOgrenci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOgretmen
            // 
            this.groupBoxOgretmen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxOgretmen.Controls.Add(this.maskedTextBoxOgretmenNumara);
            this.groupBoxOgretmen.Controls.Add(this.pictureBoxOgretmen);
            this.groupBoxOgretmen.Controls.Add(this.textBoxOgretmenSifre);
            this.groupBoxOgretmen.Controls.Add(this.buttonOgretmenGiris);
            this.groupBoxOgretmen.Controls.Add(this.labelOgretmenSıfre);
            this.groupBoxOgretmen.Controls.Add(this.labelOgretmenNumara);
            this.groupBoxOgretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxOgretmen.Location = new System.Drawing.Point(536, 100);
            this.groupBoxOgretmen.Name = "groupBoxOgretmen";
            this.groupBoxOgretmen.Size = new System.Drawing.Size(692, 244);
            this.groupBoxOgretmen.TabIndex = 0;
            this.groupBoxOgretmen.TabStop = false;
            this.groupBoxOgretmen.Text = "Öğretmen";
            // 
            // maskedTextBoxOgretmenNumara
            // 
            this.maskedTextBoxOgretmenNumara.Location = new System.Drawing.Point(363, 30);
            this.maskedTextBoxOgretmenNumara.Mask = "0000";
            this.maskedTextBoxOgretmenNumara.Name = "maskedTextBoxOgretmenNumara";
            this.maskedTextBoxOgretmenNumara.Size = new System.Drawing.Size(243, 31);
            this.maskedTextBoxOgretmenNumara.TabIndex = 6;
            this.maskedTextBoxOgretmenNumara.ValidatingType = typeof(int);
            // 
            // pictureBoxOgretmen
            // 
            this.pictureBoxOgretmen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxOgretmen.BackgroundImage")));
            this.pictureBoxOgretmen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxOgretmen.Location = new System.Drawing.Point(15, 36);
            this.pictureBoxOgretmen.Name = "pictureBoxOgretmen";
            this.pictureBoxOgretmen.Size = new System.Drawing.Size(199, 132);
            this.pictureBoxOgretmen.TabIndex = 5;
            this.pictureBoxOgretmen.TabStop = false;
            // 
            // textBoxOgretmenSifre
            // 
            this.textBoxOgretmenSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOgretmenSifre.Location = new System.Drawing.Point(363, 89);
            this.textBoxOgretmenSifre.Name = "textBoxOgretmenSifre";
            this.textBoxOgretmenSifre.Size = new System.Drawing.Size(243, 31);
            this.textBoxOgretmenSifre.TabIndex = 3;
            this.textBoxOgretmenSifre.UseSystemPasswordChar = true;
            // 
            // buttonOgretmenGiris
            // 
            this.buttonOgretmenGiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOgretmenGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOgretmenGiris.Location = new System.Drawing.Point(363, 137);
            this.buttonOgretmenGiris.Name = "buttonOgretmenGiris";
            this.buttonOgretmenGiris.Size = new System.Drawing.Size(243, 31);
            this.buttonOgretmenGiris.TabIndex = 2;
            this.buttonOgretmenGiris.Text = "Giriş";
            this.buttonOgretmenGiris.UseVisualStyleBackColor = false;
            this.buttonOgretmenGiris.Click += new System.EventHandler(this.buttonOgretmenGiris_Click);
            // 
            // labelOgretmenSıfre
            // 
            this.labelOgretmenSıfre.AutoSize = true;
            this.labelOgretmenSıfre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOgretmenSıfre.Location = new System.Drawing.Point(256, 89);
            this.labelOgretmenSıfre.Name = "labelOgretmenSıfre";
            this.labelOgretmenSıfre.Size = new System.Drawing.Size(61, 25);
            this.labelOgretmenSıfre.TabIndex = 1;
            this.labelOgretmenSıfre.Text = "Şifre";
            // 
            // labelOgretmenNumara
            // 
            this.labelOgretmenNumara.AutoSize = true;
            this.labelOgretmenNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOgretmenNumara.Location = new System.Drawing.Point(256, 36);
            this.labelOgretmenNumara.Name = "labelOgretmenNumara";
            this.labelOgretmenNumara.Size = new System.Drawing.Size(93, 25);
            this.labelOgretmenNumara.TabIndex = 0;
            this.labelOgretmenNumara.Text = "Numara";
            // 
            // groupBoxOgrenci
            // 
            this.groupBoxOgrenci.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxOgrenci.Controls.Add(this.pictureBox2);
            this.groupBoxOgrenci.Controls.Add(this.maskedTextBoxOgrenciNumara);
            this.groupBoxOgrenci.Controls.Add(this.textBoxOgrenciSifre);
            this.groupBoxOgrenci.Controls.Add(this.buttonOgrenciGiris);
            this.groupBoxOgrenci.Controls.Add(this.labelOgrenciSifre);
            this.groupBoxOgrenci.Controls.Add(this.labelOgrenciNumara);
            this.groupBoxOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxOgrenci.Location = new System.Drawing.Point(536, 430);
            this.groupBoxOgrenci.Name = "groupBoxOgrenci";
            this.groupBoxOgrenci.Size = new System.Drawing.Size(693, 264);
            this.groupBoxOgrenci.TabIndex = 1;
            this.groupBoxOgrenci.TabStop = false;
            this.groupBoxOgrenci.Text = "Öğrenci";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(16, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 130);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // maskedTextBoxOgrenciNumara
            // 
            this.maskedTextBoxOgrenciNumara.Location = new System.Drawing.Point(364, 55);
            this.maskedTextBoxOgrenciNumara.Mask = "0000";
            this.maskedTextBoxOgrenciNumara.Name = "maskedTextBoxOgrenciNumara";
            this.maskedTextBoxOgrenciNumara.Size = new System.Drawing.Size(243, 31);
            this.maskedTextBoxOgrenciNumara.TabIndex = 6;
            this.maskedTextBoxOgrenciNumara.ValidatingType = typeof(int);
            // 
            // textBoxOgrenciSifre
            // 
            this.textBoxOgrenciSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOgrenciSifre.Location = new System.Drawing.Point(364, 108);
            this.textBoxOgrenciSifre.Name = "textBoxOgrenciSifre";
            this.textBoxOgrenciSifre.Size = new System.Drawing.Size(243, 31);
            this.textBoxOgrenciSifre.TabIndex = 3;
            this.textBoxOgrenciSifre.UseSystemPasswordChar = true;
            // 
            // buttonOgrenciGiris
            // 
            this.buttonOgrenciGiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOgrenciGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOgrenciGiris.Location = new System.Drawing.Point(364, 157);
            this.buttonOgrenciGiris.Name = "buttonOgrenciGiris";
            this.buttonOgrenciGiris.Size = new System.Drawing.Size(243, 31);
            this.buttonOgrenciGiris.TabIndex = 2;
            this.buttonOgrenciGiris.Text = "Giriş";
            this.buttonOgrenciGiris.UseVisualStyleBackColor = false;
            this.buttonOgrenciGiris.Click += new System.EventHandler(this.buttonOgrenciGiris_Click);
            // 
            // labelOgrenciSifre
            // 
            this.labelOgrenciSifre.AutoSize = true;
            this.labelOgrenciSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOgrenciSifre.Location = new System.Drawing.Point(257, 108);
            this.labelOgrenciSifre.Name = "labelOgrenciSifre";
            this.labelOgrenciSifre.Size = new System.Drawing.Size(61, 25);
            this.labelOgrenciSifre.TabIndex = 1;
            this.labelOgrenciSifre.Text = "Şifre";
            // 
            // labelOgrenciNumara
            // 
            this.labelOgrenciNumara.AutoSize = true;
            this.labelOgrenciNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOgrenciNumara.Location = new System.Drawing.Point(257, 58);
            this.labelOgrenciNumara.Name = "labelOgrenciNumara";
            this.labelOgrenciNumara.Size = new System.Drawing.Size(93, 25);
            this.labelOgrenciNumara.TabIndex = 0;
            this.labelOgrenciNumara.Text = "Numara";
            this.labelOgrenciNumara.Click += new System.EventHandler(this.labelOgrenciNumara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1799, 820);
            this.Controls.Add(this.groupBoxOgrenci);
            this.Controls.Add(this.groupBoxOgretmen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxOgretmen.ResumeLayout(false);
            this.groupBoxOgretmen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgretmen)).EndInit();
            this.groupBoxOgrenci.ResumeLayout(false);
            this.groupBoxOgrenci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOgretmen;
        private System.Windows.Forms.GroupBox groupBoxOgrenci;
        private System.Windows.Forms.TextBox textBoxOgretmenSifre;
        private System.Windows.Forms.Button buttonOgretmenGiris;
        private System.Windows.Forms.Label labelOgretmenSıfre;
        private System.Windows.Forms.Label labelOgretmenNumara;
        private System.Windows.Forms.TextBox textBoxOgrenciSifre;
        private System.Windows.Forms.Button buttonOgrenciGiris;
        private System.Windows.Forms.Label labelOgrenciSifre;
        private System.Windows.Forms.Label labelOgrenciNumara;
        private System.Windows.Forms.PictureBox pictureBoxOgretmen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOgrenciNumara;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOgretmenNumara;
    }
}

