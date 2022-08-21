namespace OnEgitim6
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.lstList = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnDiziyeAktar = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnElemanSayisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(37, 25);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(259, 20);
            this.txtPName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÜRÜN ADI";
            // 
            // txtPQuantity
            // 
            this.txtPQuantity.Location = new System.Drawing.Point(37, 65);
            this.txtPQuantity.Name = "txtPQuantity";
            this.txtPQuantity.Size = new System.Drawing.Size(259, 20);
            this.txtPQuantity.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÜRÜN ADEDİ";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(37, 104);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(259, 20);
            this.txtPrice.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ÜRÜN FİYATI / Double";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(37, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 48);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(178, 130);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(118, 48);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "LİSTELE";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.Location = new System.Drawing.Point(37, 184);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(259, 251);
            this.lstList.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(360, 25);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(259, 142);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // btnDiziyeAktar
            // 
            this.btnDiziyeAktar.Location = new System.Drawing.Point(360, 184);
            this.btnDiziyeAktar.Name = "btnDiziyeAktar";
            this.btnDiziyeAktar.Size = new System.Drawing.Size(259, 36);
            this.btnDiziyeAktar.TabIndex = 2;
            this.btnDiziyeAktar.Text = "DİZİYE AKTAR";
            this.btnDiziyeAktar.UseVisualStyleBackColor = true;
            this.btnDiziyeAktar.Click += new System.EventHandler(this.btnDiziyeAktar_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(360, 239);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(259, 153);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // btnElemanSayisi
            // 
            this.btnElemanSayisi.Location = new System.Drawing.Point(360, 398);
            this.btnElemanSayisi.Name = "btnElemanSayisi";
            this.btnElemanSayisi.Size = new System.Drawing.Size(259, 36);
            this.btnElemanSayisi.TabIndex = 2;
            this.btnElemanSayisi.Text = "DİZİNİN ELEMAN SAYISINI GÖSTER";
            this.btnElemanSayisi.UseVisualStyleBackColor = true;
            this.btnElemanSayisi.Click += new System.EventHandler(this.btnElemanSayisi_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.btnElemanSayisi);
            this.Controls.Add(this.btnDiziyeAktar);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPQuantity);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtPName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnDiziyeAktar;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnElemanSayisi;
    }
}