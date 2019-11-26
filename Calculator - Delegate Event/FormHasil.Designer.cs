namespace Calculator___Delegate_Event
{
    partial class FormHasil
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
            this.b_hitung = new System.Windows.Forms.Button();
            this.lv_hasil = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // b_hitung
            // 
            this.b_hitung.Location = new System.Drawing.Point(103, 270);
            this.b_hitung.Name = "b_hitung";
            this.b_hitung.Size = new System.Drawing.Size(254, 23);
            this.b_hitung.TabIndex = 1;
            this.b_hitung.Text = "Hitung";
            this.b_hitung.UseVisualStyleBackColor = true;
            this.b_hitung.Click += new System.EventHandler(this.b_hitung_Click);
            // 
            // lv_hasil
            // 
            this.lv_hasil.Location = new System.Drawing.Point(13, 13);
            this.lv_hasil.Name = "lv_hasil";
            this.lv_hasil.Size = new System.Drawing.Size(448, 239);
            this.lv_hasil.TabIndex = 2;
            this.lv_hasil.UseCompatibleStateImageBehavior = false;
            // 
            // FormHasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 305);
            this.Controls.Add(this.lv_hasil);
            this.Controls.Add(this.b_hitung);
            this.Name = "FormHasil";
            this.Text = "Hasil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_hitung;
        private System.Windows.Forms.ListView lv_hasil;
    }
}

