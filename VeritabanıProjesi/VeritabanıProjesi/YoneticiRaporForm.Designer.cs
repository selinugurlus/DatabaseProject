
namespace VeritabanıProjesi
{
    partial class YoneticiRaporForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BeklenenDolulukLİstelebutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BeklenenGelirbutton = new System.Windows.Forms.Button();
            this.BeklenenGelirtextBox = new System.Windows.Forms.TextBox();
            this.BeklenenToplam = new System.Windows.Forms.Label();
            this.BeklenenORtGElirtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TesviktextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CiktiKaydetbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(810, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // BeklenenDolulukLİstelebutton
            // 
            this.BeklenenDolulukLİstelebutton.Location = new System.Drawing.Point(540, 228);
            this.BeklenenDolulukLİstelebutton.Name = "BeklenenDolulukLİstelebutton";
            this.BeklenenDolulukLİstelebutton.Size = new System.Drawing.Size(238, 51);
            this.BeklenenDolulukLİstelebutton.TabIndex = 1;
            this.BeklenenDolulukLİstelebutton.Text = "Beklenen Doluluğu Listele";
            this.BeklenenDolulukLİstelebutton.UseVisualStyleBackColor = true;
            this.BeklenenDolulukLİstelebutton.Click += new System.EventHandler(this.BeklenenDolulukLİstelebutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dolu Oda Sayısı:";
            // 
            // BeklenenGelirbutton
            // 
            this.BeklenenGelirbutton.Location = new System.Drawing.Point(540, 311);
            this.BeklenenGelirbutton.Name = "BeklenenGelirbutton";
            this.BeklenenGelirbutton.Size = new System.Drawing.Size(238, 53);
            this.BeklenenGelirbutton.TabIndex = 4;
            this.BeklenenGelirbutton.Text = "Beklenen Geliri Listele";
            this.BeklenenGelirbutton.UseVisualStyleBackColor = true;
            this.BeklenenGelirbutton.Click += new System.EventHandler(this.BeklenenGelirbutton_Click);
            // 
            // BeklenenGelirtextBox
            // 
            this.BeklenenGelirtextBox.Location = new System.Drawing.Point(223, 311);
            this.BeklenenGelirtextBox.Name = "BeklenenGelirtextBox";
            this.BeklenenGelirtextBox.Size = new System.Drawing.Size(261, 26);
            this.BeklenenGelirtextBox.TabIndex = 5;
            // 
            // BeklenenToplam
            // 
            this.BeklenenToplam.AutoSize = true;
            this.BeklenenToplam.Location = new System.Drawing.Point(12, 314);
            this.BeklenenToplam.Name = "BeklenenToplam";
            this.BeklenenToplam.Size = new System.Drawing.Size(173, 20);
            this.BeklenenToplam.TabIndex = 6;
            this.BeklenenToplam.Text = "Beklenen Toplam Gelir:";
            // 
            // BeklenenORtGElirtextBox
            // 
            this.BeklenenORtGElirtextBox.Location = new System.Drawing.Point(223, 341);
            this.BeklenenORtGElirtextBox.Name = "BeklenenORtGElirtextBox";
            this.BeklenenORtGElirtextBox.Size = new System.Drawing.Size(261, 26);
            this.BeklenenORtGElirtextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Beklenen Ortalama Gelir:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Teşvik Rezervasyonları Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TesviktextBox
            // 
            this.TesviktextBox.Location = new System.Drawing.Point(223, 411);
            this.TesviktextBox.Name = "TesviktextBox";
            this.TesviktextBox.Size = new System.Drawing.Size(261, 26);
            this.TesviktextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 40);
            this.label3.TabIndex = 11;
            this.label3.Text = "Teşvik Rez.\'den \r\nKaydebilecek Miktar:\r\n";
            // 
            // CiktiKaydetbutton
            // 
            this.CiktiKaydetbutton.Location = new System.Drawing.Point(273, 463);
            this.CiktiKaydetbutton.Name = "CiktiKaydetbutton";
            this.CiktiKaydetbutton.Size = new System.Drawing.Size(149, 86);
            this.CiktiKaydetbutton.TabIndex = 12;
            this.CiktiKaydetbutton.Text = "ÇIKTI KAYDET";
            this.CiktiKaydetbutton.UseVisualStyleBackColor = true;
            this.CiktiKaydetbutton.Click += new System.EventHandler(this.CiktiKaydetbutton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "<-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // YoneticiRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CiktiKaydetbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TesviktextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BeklenenORtGElirtextBox);
            this.Controls.Add(this.BeklenenToplam);
            this.Controls.Add(this.BeklenenGelirtextBox);
            this.Controls.Add(this.BeklenenGelirbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BeklenenDolulukLİstelebutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "YoneticiRaporForm";
            this.Text = "YoneticiRaporForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BeklenenDolulukLİstelebutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BeklenenGelirbutton;
        private System.Windows.Forms.TextBox BeklenenGelirtextBox;
        private System.Windows.Forms.Label BeklenenToplam;
        private System.Windows.Forms.TextBox BeklenenORtGElirtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TesviktextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CiktiKaydetbutton;
        private System.Windows.Forms.Button button2;
    }
}