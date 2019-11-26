namespace Calculator___Delegate_Event
{
    partial class FormHitung
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.b_hitung = new System.Windows.Forms.Button();
            this.cb_operasi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nilai B";
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(55, 40);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(165, 20);
            this.tb_a.TabIndex = 1;
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(56, 68);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(165, 20);
            this.tb_b.TabIndex = 1;
            // 
            // b_hitung
            // 
            this.b_hitung.Location = new System.Drawing.Point(13, 103);
            this.b_hitung.Name = "b_hitung";
            this.b_hitung.Size = new System.Drawing.Size(208, 23);
            this.b_hitung.TabIndex = 2;
            this.b_hitung.Text = "PROSESS HITUNG";
            this.b_hitung.UseVisualStyleBackColor = true;
            this.b_hitung.Click += new System.EventHandler(this.b_hitung_Click);
            // 
            // cb_operasi
            // 
            this.cb_operasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_operasi.FormattingEnabled = true;
            this.cb_operasi.Items.AddRange(new object[] {
            "( + ) Penjumlahan",
            "( - ) Penguranan",
            "( : ) Pembagian",
            "( X ) Perkalian"});
            this.cb_operasi.Location = new System.Drawing.Point(63, 13);
            this.cb_operasi.Name = "cb_operasi";
            this.cb_operasi.Size = new System.Drawing.Size(157, 21);
            this.cb_operasi.TabIndex = 3;
            // 
            // FormHitung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 141);
            this.Controls.Add(this.cb_operasi);
            this.Controls.Add(this.b_hitung);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHitung";
            this.Text = "Hitung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.Button b_hitung;
        private System.Windows.Forms.ComboBox cb_operasi;
    }
}