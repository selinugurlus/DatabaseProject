namespace VeritabanıProjesi
{
    partial class AnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenu));
            this.btncalisan = new System.Windows.Forms.Button();
            this.btnmüşteri = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Faturabutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncalisan
            // 
            this.btncalisan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalisan.ForeColor = System.Drawing.Color.Black;
            this.btncalisan.Location = new System.Drawing.Point(780, 486);
            this.btncalisan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncalisan.Name = "btncalisan";
            this.btncalisan.Size = new System.Drawing.Size(148, 59);
            this.btncalisan.TabIndex = 11;
            this.btncalisan.Text = "GÖREVLİ";
            this.btncalisan.UseVisualStyleBackColor = true;
            this.btncalisan.Click += new System.EventHandler(this.btncalisan_Click);
            // 
            // btnmüşteri
            // 
            this.btnmüşteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmüşteri.Location = new System.Drawing.Point(252, 486);
            this.btnmüşteri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmüşteri.Name = "btnmüşteri";
            this.btnmüşteri.Size = new System.Drawing.Size(156, 59);
            this.btnmüşteri.TabIndex = 10;
            this.btnmüşteri.Text = "MÜŞTERİ";
            this.btnmüşteri.UseVisualStyleBackColor = true;
            this.btnmüşteri.Click += new System.EventHandler(this.btnmüşteri_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(201, 148);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(728, 154);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Faturabutton
            // 
            this.Faturabutton.Location = new System.Drawing.Point(531, 612);
            this.Faturabutton.Name = "Faturabutton";
            this.Faturabutton.Size = new System.Drawing.Size(154, 68);
            this.Faturabutton.TabIndex = 12;
            this.Faturabutton.Text = "FATURA AL";
            this.Faturabutton.UseVisualStyleBackColor = true;
            this.Faturabutton.Click += new System.EventHandler(this.Faturabutton_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.Faturabutton);
            this.Controls.Add(this.btncalisan);
            this.Controls.Add(this.btnmüşteri);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnaMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncalisan;
        private System.Windows.Forms.Button btnmüşteri;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Faturabutton;
    }
}