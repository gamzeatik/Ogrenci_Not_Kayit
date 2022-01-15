
namespace Ogrenci_Not_Kayit
{
    partial class FrmMesajlar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGelenKutusu = new System.Windows.Forms.TabPage();
            this.dataGridViewGelenKutusu = new System.Windows.Forms.DataGridView();
            this.tabPageGidenKutusu = new System.Windows.Forms.TabPage();
            this.dataGridViewGidenKutusu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGonder = new System.Windows.Forms.Button();
            this.richTextBoxIcerik = new System.Windows.Forms.RichTextBox();
            this.textBoxKonu = new System.Windows.Forms.TextBox();
            this.maskedTextBoxAlici = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxGonderen = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageGelenKutusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGelenKutusu)).BeginInit();
            this.tabPageGidenKutusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGidenKutusu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGelenKutusu);
            this.tabControl1.Controls.Add(this.tabPageGidenKutusu);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(20, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1774, 429);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageGelenKutusu
            // 
            this.tabPageGelenKutusu.Controls.Add(this.dataGridViewGelenKutusu);
            this.tabPageGelenKutusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPageGelenKutusu.Location = new System.Drawing.Point(4, 29);
            this.tabPageGelenKutusu.Name = "tabPageGelenKutusu";
            this.tabPageGelenKutusu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGelenKutusu.Size = new System.Drawing.Size(1766, 396);
            this.tabPageGelenKutusu.TabIndex = 0;
            this.tabPageGelenKutusu.Text = "Gelen Kutusu";
            this.tabPageGelenKutusu.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGelenKutusu
            // 
            this.dataGridViewGelenKutusu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGelenKutusu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGelenKutusu.Location = new System.Drawing.Point(1, 2);
            this.dataGridViewGelenKutusu.Name = "dataGridViewGelenKutusu";
            this.dataGridViewGelenKutusu.Size = new System.Drawing.Size(1762, 393);
            this.dataGridViewGelenKutusu.TabIndex = 0;
            this.dataGridViewGelenKutusu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGelenKutusu_CellContentClick);
            // 
            // tabPageGidenKutusu
            // 
            this.tabPageGidenKutusu.Controls.Add(this.dataGridViewGidenKutusu);
            this.tabPageGidenKutusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPageGidenKutusu.Location = new System.Drawing.Point(4, 29);
            this.tabPageGidenKutusu.Name = "tabPageGidenKutusu";
            this.tabPageGidenKutusu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGidenKutusu.Size = new System.Drawing.Size(1766, 396);
            this.tabPageGidenKutusu.TabIndex = 1;
            this.tabPageGidenKutusu.Text = "Giden Kutusu";
            this.tabPageGidenKutusu.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGidenKutusu
            // 
            this.dataGridViewGidenKutusu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGidenKutusu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGidenKutusu.Location = new System.Drawing.Point(2, 0);
            this.dataGridViewGidenKutusu.Name = "dataGridViewGidenKutusu";
            this.dataGridViewGidenKutusu.Size = new System.Drawing.Size(1761, 395);
            this.dataGridViewGidenKutusu.TabIndex = 0;
            this.dataGridViewGidenKutusu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGidenKutusu_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGonder);
            this.groupBox1.Controls.Add(this.richTextBoxIcerik);
            this.groupBox1.Controls.Add(this.textBoxKonu);
            this.groupBox1.Controls.Add(this.maskedTextBoxAlici);
            this.groupBox1.Controls.Add(this.maskedTextBoxGonderen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(22, 449);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1750, 370);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // buttonGonder
            // 
            this.buttonGonder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGonder.Location = new System.Drawing.Point(1599, 332);
            this.buttonGonder.Name = "buttonGonder";
            this.buttonGonder.Size = new System.Drawing.Size(145, 32);
            this.buttonGonder.TabIndex = 8;
            this.buttonGonder.Text = "Gönder";
            this.buttonGonder.UseVisualStyleBackColor = false;
            this.buttonGonder.Click += new System.EventHandler(this.buttonGonder_Click);
            // 
            // richTextBoxIcerik
            // 
            this.richTextBoxIcerik.Location = new System.Drawing.Point(817, 23);
            this.richTextBoxIcerik.Name = "richTextBoxIcerik";
            this.richTextBoxIcerik.Size = new System.Drawing.Size(914, 303);
            this.richTextBoxIcerik.TabIndex = 7;
            this.richTextBoxIcerik.Text = "";
            // 
            // textBoxKonu
            // 
            this.textBoxKonu.Location = new System.Drawing.Point(213, 146);
            this.textBoxKonu.Name = "textBoxKonu";
            this.textBoxKonu.Size = new System.Drawing.Size(183, 24);
            this.textBoxKonu.TabIndex = 6;
            // 
            // maskedTextBoxAlici
            // 
            this.maskedTextBoxAlici.Location = new System.Drawing.Point(213, 86);
            this.maskedTextBoxAlici.Mask = "0000";
            this.maskedTextBoxAlici.Name = "maskedTextBoxAlici";
            this.maskedTextBoxAlici.Size = new System.Drawing.Size(183, 24);
            this.maskedTextBoxAlici.TabIndex = 5;
            this.maskedTextBoxAlici.ValidatingType = typeof(int);
            // 
            // maskedTextBoxGonderen
            // 
            this.maskedTextBoxGonderen.Location = new System.Drawing.Point(213, 29);
            this.maskedTextBoxGonderen.Mask = "0000";
            this.maskedTextBoxGonderen.Name = "maskedTextBoxGonderen";
            this.maskedTextBoxGonderen.Size = new System.Drawing.Size(183, 24);
            this.maskedTextBoxGonderen.TabIndex = 4;
            this.maskedTextBoxGonderen.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(758, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mesaj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Konu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alıcı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gönderen";
            // 
            // FrmMesajlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1806, 831);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMesajlar";
            this.Text = "FrmMesajlar";
            this.Load += new System.EventHandler(this.FrmMesajlar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageGelenKutusu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGelenKutusu)).EndInit();
            this.tabPageGidenKutusu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGidenKutusu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGelenKutusu;
        private System.Windows.Forms.TabPage tabPageGidenKutusu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGonder;
        private System.Windows.Forms.RichTextBox richTextBoxIcerik;
        private System.Windows.Forms.TextBox textBoxKonu;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAlici;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxGonderen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewGelenKutusu;
        private System.Windows.Forms.DataGridView dataGridViewGidenKutusu;
    }
}