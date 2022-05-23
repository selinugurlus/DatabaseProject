
namespace VeritabanıProjesi
{
    partial class YoneticiGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiGirisForm));
            this.YoneticiGirisbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.YoneticiSifretextBox = new System.Windows.Forms.TextBox();
            this.YoneticiKAditextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // YoneticiGirisbutton
            // 
            this.YoneticiGirisbutton.Location = new System.Drawing.Point(272, 265);
            this.YoneticiGirisbutton.Name = "YoneticiGirisbutton";
            this.YoneticiGirisbutton.Size = new System.Drawing.Size(109, 52);
            this.YoneticiGirisbutton.TabIndex = 9;
            this.YoneticiGirisbutton.Text = "GİRİŞ YAP";
            this.YoneticiGirisbutton.UseVisualStyleBackColor = true;
            this.YoneticiGirisbutton.Click += new System.EventHandler(this.YoneticiGirisbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // YoneticiSifretextBox
            // 
            this.YoneticiSifretextBox.Location = new System.Drawing.Point(196, 197);
            this.YoneticiSifretextBox.Name = "YoneticiSifretextBox";
            this.YoneticiSifretextBox.Size = new System.Drawing.Size(280, 26);
            this.YoneticiSifretextBox.TabIndex = 6;
            // 
            // YoneticiKAditextBox
            // 
            this.YoneticiKAditextBox.Location = new System.Drawing.Point(196, 119);
            this.YoneticiKAditextBox.Name = "YoneticiKAditextBox";
            this.YoneticiKAditextBox.Size = new System.Drawing.Size(280, 26);
            this.YoneticiKAditextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 70);
            this.button1.TabIndex = 10;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(546, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // YoneticiGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.YoneticiGirisbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YoneticiSifretextBox);
            this.Controls.Add(this.YoneticiKAditextBox);
            this.Name = "YoneticiGirisForm";
            this.Text = "YoneticiGirisForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YoneticiGirisbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YoneticiSifretextBox;
        private System.Windows.Forms.TextBox YoneticiKAditextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}