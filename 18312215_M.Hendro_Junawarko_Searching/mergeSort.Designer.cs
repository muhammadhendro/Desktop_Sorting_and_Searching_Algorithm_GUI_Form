namespace Sorting
{
    partial class frm_ms
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
            this.btn_input = new System.Windows.Forms.Button();
            this.lb_awal = new System.Windows.Forms.ListBox();
            this.lb_akhir = new System.Windows.Forms.ListBox();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_arr = new System.Windows.Forms.Label();
            this.lbl_arrleft = new System.Windows.Forms.Label();
            this.lbl_arrright = new System.Windows.Forms.Label();
            this.btn_hitungpjgdata = new System.Windows.Forms.Button();
            this.lb_arr_A = new System.Windows.Forms.Label();
            this.btn_merge = new System.Windows.Forms.Button();
            this.lb_arr_L = new System.Windows.Forms.Label();
            this.lb_arr_R = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_input
            // 
            this.btn_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_input.Location = new System.Drawing.Point(270, 13);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(75, 33);
            this.btn_input.TabIndex = 0;
            this.btn_input.Text = "OK";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // lb_awal
            // 
            this.lb_awal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_awal.FormattingEnabled = true;
            this.lb_awal.ItemHeight = 16;
            this.lb_awal.Location = new System.Drawing.Point(12, 69);
            this.lb_awal.Name = "lb_awal";
            this.lb_awal.Size = new System.Drawing.Size(176, 148);
            this.lb_awal.TabIndex = 2;
            // 
            // lb_akhir
            // 
            this.lb_akhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_akhir.FormattingEnabled = true;
            this.lb_akhir.ItemHeight = 16;
            this.lb_akhir.Location = new System.Drawing.Point(207, 69);
            this.lb_akhir.Name = "lb_akhir";
            this.lb_akhir.Size = new System.Drawing.Size(179, 148);
            this.lb_akhir.TabIndex = 3;
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(118, 21);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(129, 23);
            this.txt_input.TabIndex = 4;
            this.txt_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_input_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input";
            // 
            // lbl_arr
            // 
            this.lbl_arr.AutoSize = true;
            this.lbl_arr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arr.Location = new System.Drawing.Point(13, 276);
            this.lbl_arr.Name = "lbl_arr";
            this.lbl_arr.Size = new System.Drawing.Size(52, 17);
            this.lbl_arr.TabIndex = 6;
            this.lbl_arr.Text = "label2";
            // 
            // lbl_arrleft
            // 
            this.lbl_arrleft.AutoSize = true;
            this.lbl_arrleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arrleft.Location = new System.Drawing.Point(13, 310);
            this.lbl_arrleft.Name = "lbl_arrleft";
            this.lbl_arrleft.Size = new System.Drawing.Size(52, 17);
            this.lbl_arrleft.TabIndex = 7;
            this.lbl_arrleft.Text = "label3";
            // 
            // lbl_arrright
            // 
            this.lbl_arrright.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arrright.Location = new System.Drawing.Point(13, 338);
            this.lbl_arrright.Name = "lbl_arrright";
            this.lbl_arrright.Size = new System.Drawing.Size(175, 17);
            this.lbl_arrright.TabIndex = 0;
            this.lbl_arrright.Text = "label4";
            // 
            // btn_hitungpjgdata
            // 
            this.btn_hitungpjgdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hitungpjgdata.Location = new System.Drawing.Point(31, 227);
            this.btn_hitungpjgdata.Name = "btn_hitungpjgdata";
            this.btn_hitungpjgdata.Size = new System.Drawing.Size(117, 36);
            this.btn_hitungpjgdata.TabIndex = 8;
            this.btn_hitungpjgdata.Text = "Panjang Data";
            this.btn_hitungpjgdata.UseVisualStyleBackColor = true;
            this.btn_hitungpjgdata.Click += new System.EventHandler(this.btn_hitungpjgdata_Click);
            // 
            // lb_arr_A
            // 
            this.lb_arr_A.AutoSize = true;
            this.lb_arr_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_arr_A.Location = new System.Drawing.Point(174, 276);
            this.lb_arr_A.Name = "lb_arr_A";
            this.lb_arr_A.Size = new System.Drawing.Size(61, 17);
            this.lb_arr_A.TabIndex = 9;
            this.lb_arr_A.Text = "Array= ";
            // 
            // btn_merge
            // 
            this.btn_merge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_merge.Location = new System.Drawing.Point(207, 227);
            this.btn_merge.Name = "btn_merge";
            this.btn_merge.Size = new System.Drawing.Size(98, 36);
            this.btn_merge.TabIndex = 10;
            this.btn_merge.Text = "Merge Sort";
            this.btn_merge.UseVisualStyleBackColor = true;
            this.btn_merge.Click += new System.EventHandler(this.btn_merge_Click);
            // 
            // lb_arr_L
            // 
            this.lb_arr_L.AutoSize = true;
            this.lb_arr_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_arr_L.Location = new System.Drawing.Point(174, 310);
            this.lb_arr_L.Name = "lb_arr_L";
            this.lb_arr_L.Size = new System.Drawing.Size(94, 17);
            this.lb_arr_L.TabIndex = 11;
            this.lb_arr_L.Text = "Array Left= ";
            // 
            // lb_arr_R
            // 
            this.lb_arr_R.AutoSize = true;
            this.lb_arr_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_arr_R.Location = new System.Drawing.Point(174, 338);
            this.lb_arr_R.Name = "lb_arr_R";
            this.lb_arr_R.Size = new System.Drawing.Size(104, 17);
            this.lb_arr_R.TabIndex = 12;
            this.lb_arr_R.Text = "Array Right= ";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(311, 227);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 36);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // frm_ms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(408, 373);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lb_arr_R);
            this.Controls.Add(this.lb_arr_L);
            this.Controls.Add(this.btn_merge);
            this.Controls.Add(this.lb_arr_A);
            this.Controls.Add(this.btn_hitungpjgdata);
            this.Controls.Add(this.lbl_arrright);
            this.Controls.Add(this.lbl_arrleft);
            this.Controls.Add(this.lbl_arr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lb_akhir);
            this.Controls.Add(this.lb_awal);
            this.Controls.Add(this.btn_input);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge Sort";
            this.Load += new System.EventHandler(this.frm_ms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.ListBox lb_awal;
        private System.Windows.Forms.ListBox lb_akhir;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_arr;
        private System.Windows.Forms.Label lbl_arrleft;
        private System.Windows.Forms.Label lbl_arrright;
        private System.Windows.Forms.Button btn_hitungpjgdata;
        private System.Windows.Forms.Label lb_arr_A;
        private System.Windows.Forms.Button btn_merge;
        private System.Windows.Forms.Label lb_arr_L;
        private System.Windows.Forms.Label lb_arr_R;
        private System.Windows.Forms.Button btn_clear;
    }
}