
namespace VeritabanıProjesi
{
    partial class CalisanGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanGiris));
            this.CalisanKAditextBox = new System.Windows.Forms.TextBox();
            this.CalisanSİfretextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalisanGİrisbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CalisanKAditextBox
            // 
            this.CalisanKAditextBox.Location = new System.Drawing.Point(195, 137);
            this.CalisanKAditextBox.Name = "CalisanKAditextBox";
            this.CalisanKAditextBox.Size = new System.Drawing.Size(280, 26);
            this.CalisanKAditextBox.TabIndex = 0;
            // 
            // CalisanSİfretextBox
            // 
            this.CalisanSİfretextBox.Location = new System.Drawing.Point(195, 215);
            this.CalisanSİfretextBox.Name = "CalisanSİfretextBox";
            this.CalisanSİfretextBox.Size = new System.Drawing.Size(280, 26);
            this.CalisanSİfretextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // CalisanGİrisbutton
            // 
            this.CalisanGİrisbutton.Location = new System.Drawing.Point(271, 283);
            this.CalisanGİrisbutton.Name = "CalisanGİrisbutton";
            this.CalisanGİrisbutton.Size = new System.Drawing.Size(109, 52);
            this.CalisanGİrisbutton.TabIndex = 4;
            this.CalisanGİrisbutton.Text = "GİRİŞ YAP";
            this.CalisanGİrisbutton.UseVisualStyleBackColor = true;
            this.CalisanGİrisbutton.Click += new System.EventHandler(this.CalisanGİrisbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(556, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // CalisanGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 556);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CalisanGİrisbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalisanSİfretextBox);
            this.Controls.Add(this.CalisanKAditextBox);
            this.Name = "CalisanGiris";
            this.Text = "CalisanGiris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CalisanKAditextBox;
        private System.Windows.Forms.TextBox CalisanSİfretextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalisanGİrisbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}