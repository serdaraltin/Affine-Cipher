namespace Dogrusal_Sifreleme
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
            this.tx_a = new System.Windows.Forms.TextBox();
            this.tx_b = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_acikmesaj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_sifrelimesaj = new System.Windows.Forms.TextBox();
            this.btn_sifrele = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_a
            // 
            this.tx_a.Location = new System.Drawing.Point(187, 22);
            this.tx_a.Name = "tx_a";
            this.tx_a.Size = new System.Drawing.Size(41, 20);
            this.tx_a.TabIndex = 0;
            // 
            // tx_b
            // 
            this.tx_b.Location = new System.Drawing.Point(304, 21);
            this.tx_b.Name = "tx_b";
            this.tx_b.Size = new System.Drawing.Size(41, 20);
            this.tx_b.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "b =";
            // 
            // tx_acikmesaj
            // 
            this.tx_acikmesaj.Location = new System.Drawing.Point(162, 48);
            this.tx_acikmesaj.Name = "tx_acikmesaj";
            this.tx_acikmesaj.Size = new System.Drawing.Size(183, 20);
            this.tx_acikmesaj.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Açık Mesaj - x (plain text) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifreli Metin - y (cipher text) :";
            // 
            // tx_sifrelimesaj
            // 
            this.tx_sifrelimesaj.Location = new System.Drawing.Point(162, 74);
            this.tx_sifrelimesaj.Name = "tx_sifrelimesaj";
            this.tx_sifrelimesaj.Size = new System.Drawing.Size(183, 20);
            this.tx_sifrelimesaj.TabIndex = 6;
            // 
            // btn_sifrele
            // 
            this.btn_sifrele.Location = new System.Drawing.Point(351, 47);
            this.btn_sifrele.Name = "btn_sifrele";
            this.btn_sifrele.Size = new System.Drawing.Size(75, 23);
            this.btn_sifrele.TabIndex = 8;
            this.btn_sifrele.Text = "Şifrele";
            this.btn_sifrele.UseVisualStyleBackColor = true;
            this.btn_sifrele.Click += new System.EventHandler(this.btn_sifrele_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(44, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "y = ax + b";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 118);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_sifrele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_sifrelimesaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_acikmesaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_b);
            this.Controls.Add(this.tx_a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_a;
        private System.Windows.Forms.TextBox tx_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_acikmesaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_sifrelimesaj;
        private System.Windows.Forms.Button btn_sifrele;
        private System.Windows.Forms.Label label5;
    }
}

