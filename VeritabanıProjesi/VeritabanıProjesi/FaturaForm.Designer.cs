
namespace VeritabanıProjesi
{
    partial class FaturaForm
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
            this.FaturaTCtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FaturaGetirbutton = new System.Windows.Forms.Button();
            this.FaturaBasbutton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(743, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // FaturaTCtextBox
            // 
            this.FaturaTCtextBox.Location = new System.Drawing.Point(216, 79);
            this.FaturaTCtextBox.Name = "FaturaTCtextBox";
            this.FaturaTCtextBox.Size = new System.Drawing.Size(229, 26);
            this.FaturaTCtextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müşteri TC No Giriniz:";
            // 
            // FaturaGetirbutton
            // 
            this.FaturaGetirbutton.Location = new System.Drawing.Point(492, 62);
            this.FaturaGetirbutton.Name = "FaturaGetirbutton";
            this.FaturaGetirbutton.Size = new System.Drawing.Size(142, 60);
            this.FaturaGetirbutton.TabIndex = 3;
            this.FaturaGetirbutton.Text = "Fatura Bilgilerini Getir";
            this.FaturaGetirbutton.UseVisualStyleBackColor = true;
            this.FaturaGetirbutton.Click += new System.EventHandler(this.FaturaGetirbutton_Click);
            // 
            // FaturaBasbutton
            // 
            this.FaturaBasbutton.Location = new System.Drawing.Point(319, 333);
            this.FaturaBasbutton.Name = "FaturaBasbutton";
            this.FaturaBasbutton.Size = new System.Drawing.Size(145, 74);
            this.FaturaBasbutton.TabIndex = 4;
            this.FaturaBasbutton.Text = "FATURA BAS";
            this.FaturaBasbutton.UseVisualStyleBackColor = true;
            this.FaturaBasbutton.Click += new System.EventHandler(this.FaturaBasbutton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FaturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FaturaBasbutton);
            this.Controls.Add(this.FaturaGetirbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FaturaTCtextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FaturaForm";
            this.Text = "FaturaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox FaturaTCtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FaturaGetirbutton;
        private System.Windows.Forms.Button FaturaBasbutton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}