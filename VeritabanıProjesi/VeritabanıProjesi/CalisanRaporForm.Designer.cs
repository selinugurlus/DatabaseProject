
namespace VeritabanıProjesi
{
    partial class CalisanRaporForm
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
            this.Bugungeleceklerlistelebutton = new System.Windows.Forms.Button();
            this.GunlukDolulukbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CiktiKaydetbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bugungeleceklerlistelebutton
            // 
            this.Bugungeleceklerlistelebutton.Location = new System.Drawing.Point(90, 322);
            this.Bugungeleceklerlistelebutton.Name = "Bugungeleceklerlistelebutton";
            this.Bugungeleceklerlistelebutton.Size = new System.Drawing.Size(156, 66);
            this.Bugungeleceklerlistelebutton.TabIndex = 0;
            this.Bugungeleceklerlistelebutton.Text = "Bugün Gelecekleri Listele\r\n";
            this.Bugungeleceklerlistelebutton.UseVisualStyleBackColor = true;
            this.Bugungeleceklerlistelebutton.Click += new System.EventHandler(this.Bugungeleceklerlistelebutton_Click);
            // 
            // GunlukDolulukbutton
            // 
            this.GunlukDolulukbutton.Location = new System.Drawing.Point(487, 322);
            this.GunlukDolulukbutton.Name = "GunlukDolulukbutton";
            this.GunlukDolulukbutton.Size = new System.Drawing.Size(156, 66);
            this.GunlukDolulukbutton.TabIndex = 1;
            this.GunlukDolulukbutton.Text = "Günlük Doluluk Listele\r\n\r\n";
            this.GunlukDolulukbutton.UseVisualStyleBackColor = true;
            this.GunlukDolulukbutton.Click += new System.EventHandler(this.GunlukDolulukbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(761, 220);
            this.dataGridView1.TabIndex = 2;
            // 
            // CiktiKaydetbutton
            // 
            this.CiktiKaydetbutton.Location = new System.Drawing.Point(298, 414);
            this.CiktiKaydetbutton.Name = "CiktiKaydetbutton";
            this.CiktiKaydetbutton.Size = new System.Drawing.Size(139, 89);
            this.CiktiKaydetbutton.TabIndex = 3;
            this.CiktiKaydetbutton.Text = "ÇIKTI KAYDET";
            this.CiktiKaydetbutton.UseVisualStyleBackColor = true;
            this.CiktiKaydetbutton.Click += new System.EventHandler(this.CiktiKaydetbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalisanRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CiktiKaydetbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GunlukDolulukbutton);
            this.Controls.Add(this.Bugungeleceklerlistelebutton);
            this.Name = "CalisanRaporForm";
            this.Text = "CalisanRaporForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bugungeleceklerlistelebutton;
        private System.Windows.Forms.Button GunlukDolulukbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CiktiKaydetbutton;
        private System.Windows.Forms.Button button1;
    }
}