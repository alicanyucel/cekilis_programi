namespace CekilisProgrami
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.rtxtAdaylar = new System.Windows.Forms.RichTextBox();
            this.nMiktar = new System.Windows.Forms.NumericUpDown();
            this.btnCekilis = new System.Windows.Forms.Button();
            this.btnYeniCekilis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSayi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(815, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KATILIMCILAR";
            // 
            // dtgList
            // 
            this.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgList.Location = new System.Drawing.Point(12, 68);
            this.dtgList.Name = "dtgList";
            this.dtgList.Size = new System.Drawing.Size(686, 252);
            this.dtgList.TabIndex = 1;
            // 
            // rtxtAdaylar
            // 
            this.rtxtAdaylar.Location = new System.Drawing.Point(727, 68);
            this.rtxtAdaylar.Name = "rtxtAdaylar";
            this.rtxtAdaylar.Size = new System.Drawing.Size(276, 252);
            this.rtxtAdaylar.TabIndex = 2;
            this.rtxtAdaylar.Text = "";
            this.rtxtAdaylar.TextChanged += new System.EventHandler(this.rtxtAdaylar_TextChanged);
            // 
            // nMiktar
            // 
            this.nMiktar.Location = new System.Drawing.Point(23, 27);
            this.nMiktar.Name = "nMiktar";
            this.nMiktar.Size = new System.Drawing.Size(120, 20);
            this.nMiktar.TabIndex = 3;
            this.nMiktar.ValueChanged += new System.EventHandler(this.nMiktar_ValueChanged);
            // 
            // btnCekilis
            // 
            this.btnCekilis.Location = new System.Drawing.Point(167, 27);
            this.btnCekilis.Name = "btnCekilis";
            this.btnCekilis.Size = new System.Drawing.Size(112, 23);
            this.btnCekilis.TabIndex = 4;
            this.btnCekilis.Text = "ÇEKİLİŞİ BAŞLAT";
            this.btnCekilis.UseVisualStyleBackColor = true;
            this.btnCekilis.Click += new System.EventHandler(this.btnCekilis_Click);
            // 
            // btnYeniCekilis
            // 
            this.btnYeniCekilis.Location = new System.Drawing.Point(300, 27);
            this.btnYeniCekilis.Name = "btnYeniCekilis";
            this.btnYeniCekilis.Size = new System.Drawing.Size(116, 23);
            this.btnYeniCekilis.TabIndex = 5;
            this.btnYeniCekilis.Text = "YENİ ÇEKİLİŞ YAP";
            this.btnYeniCekilis.UseVisualStyleBackColor = true;
            this.btnYeniCekilis.Click += new System.EventHandler(this.btnYeniCekilis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(436, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Katılımcı Sayısı";
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi.Location = new System.Drawing.Point(609, 27);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(24, 25);
            this.lblSayi.TabIndex = 7;
            this.lblSayi.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnYeniCekilis);
            this.Controls.Add(this.btnCekilis);
            this.Controls.Add(this.nMiktar);
            this.Controls.Add(this.rtxtAdaylar);
            this.Controls.Add(this.dtgList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ÇEKİLİŞ PROGRAMI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgList;
        private System.Windows.Forms.RichTextBox rtxtAdaylar;
        private System.Windows.Forms.NumericUpDown nMiktar;
        private System.Windows.Forms.Button btnCekilis;
        private System.Windows.Forms.Button btnYeniCekilis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSayi;
    }
}

