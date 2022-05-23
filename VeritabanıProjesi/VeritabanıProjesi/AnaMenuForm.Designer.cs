
namespace VeritabanıProjesi
{
    partial class AnaMenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenuForm));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btncalisan = new System.Windows.Forms.Button();
            this.btnmüşteri = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kayitol.png");
            this.ımageList1.Images.SetKeyName(1, "girişbutomu.png");
            this.ımageList1.Images.SetKeyName(2, "yoneticigiris.png");
            this.ımageList1.Images.SetKeyName(3, "personelgiris.png");
            this.ımageList1.Images.SetKeyName(4, "reservation en ligne taxipascher.png");
            this.ımageList1.Images.SetKeyName(5, "indir.png");
            this.ımageList1.Images.SetKeyName(6, "5158472.png");
            this.ımageList1.Images.SetKeyName(7, "345736.png");
            this.ımageList1.Images.SetKeyName(8, "aaaaaa.png");
            // 
            // btncalisan
            // 
            this.btncalisan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalisan.ForeColor = System.Drawing.Color.Black;
            this.btncalisan.Location = new System.Drawing.Point(562, 331);
            this.btncalisan.Name = "btncalisan";
            this.btncalisan.Size = new System.Drawing.Size(99, 38);
            this.btncalisan.TabIndex = 7;
            this.btncalisan.Text = "GÖREVLİ";
            this.btncalisan.UseVisualStyleBackColor = true;
            // 
            // btnmüşteri
            // 
            this.btnmüşteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmüşteri.Location = new System.Drawing.Point(210, 331);
            this.btnmüşteri.Name = "btnmüşteri";
            this.btnmüşteri.Size = new System.Drawing.Size(104, 38);
            this.btnmüşteri.TabIndex = 6;
            this.btnmüşteri.Text = "MÜŞTERİ";
            this.btnmüşteri.UseVisualStyleBackColor = true;
            this.btnmüşteri.Click += new System.EventHandler(this.btnmüşteri_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(176, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(527, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AnaMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.btncalisan);
            this.Controls.Add(this.btnmüşteri);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnaMenuForm";
            this.Text = "AnaMenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btncalisan;
        private System.Windows.Forms.Button btnmüşteri;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

