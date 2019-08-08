namespace Sorting
{
    partial class frm_ss
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
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.btn_hasil = new System.Windows.Forms.Button();
            this.lb_awal = new System.Windows.Forms.ListBox();
            this.lb_akhir = new System.Windows.Forms.ListBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_hasil2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(113, 17);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(133, 23);
            this.txt_input.TabIndex = 1;
            this.txt_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_input_KeyPress);
            // 
            // btn_input
            // 
            this.btn_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_input.Location = new System.Drawing.Point(252, 14);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(75, 29);
            this.btn_input.TabIndex = 2;
            this.btn_input.Text = "OK";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // btn_hasil
            // 
            this.btn_hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hasil.Location = new System.Drawing.Point(151, 92);
            this.btn_hasil.Name = "btn_hasil";
            this.btn_hasil.Size = new System.Drawing.Size(104, 35);
            this.btn_hasil.TabIndex = 2;
            this.btn_hasil.Text = "Ascending";
            this.btn_hasil.UseVisualStyleBackColor = true;
            this.btn_hasil.Click += new System.EventHandler(this.btn_hasil_Click);
            // 
            // lb_awal
            // 
            this.lb_awal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_awal.FormattingEnabled = true;
            this.lb_awal.ItemHeight = 16;
            this.lb_awal.Location = new System.Drawing.Point(12, 81);
            this.lb_awal.Name = "lb_awal";
            this.lb_awal.Size = new System.Drawing.Size(133, 180);
            this.lb_awal.TabIndex = 3;
            // 
            // lb_akhir
            // 
            this.lb_akhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_akhir.FormattingEnabled = true;
            this.lb_akhir.ItemHeight = 16;
            this.lb_akhir.Location = new System.Drawing.Point(261, 81);
            this.lb_akhir.Name = "lb_akhir";
            this.lb_akhir.Size = new System.Drawing.Size(138, 180);
            this.lb_akhir.TabIndex = 3;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(152, 210);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(103, 34);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_hasil2
            // 
            this.btn_hasil2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hasil2.Location = new System.Drawing.Point(151, 149);
            this.btn_hasil2.Name = "btn_hasil2";
            this.btn_hasil2.Size = new System.Drawing.Size(104, 37);
            this.btn_hasil2.TabIndex = 5;
            this.btn_hasil2.Text = "Descending";
            this.btn_hasil2.UseVisualStyleBackColor = true;
            this.btn_hasil2.Click += new System.EventHandler(this.btn_hasil2_Click);
            // 
            // frm_ss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(408, 273);
            this.Controls.Add(this.btn_hasil2);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lb_akhir);
            this.Controls.Add(this.lb_awal);
            this.Controls.Add(this.btn_hasil);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.Button btn_hasil;
        private System.Windows.Forms.ListBox lb_awal;
        private System.Windows.Forms.ListBox lb_akhir;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_hasil2;
    }
}