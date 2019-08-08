namespace Sorting
{
    partial class frm_qs
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
            this.lbl = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.lb_awal = new System.Windows.Forms.ListBox();
            this.lb_akhir = new System.Windows.Forms.ListBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.btn_htgpjgdata = new System.Windows.Forms.Button();
            this.btn_cekarr = new System.Windows.Forms.Button();
            this.lbl_arr = new System.Windows.Forms.Label();
            this.lbl_arrleft = new System.Windows.Forms.Label();
            this.lbl_arrright = new System.Windows.Forms.Label();
            this.lb_arr_A = new System.Windows.Forms.Label();
            this.lb_arr_L = new System.Windows.Forms.Label();
            this.lb_arr_R = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(51, 22);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(44, 17);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Input";
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(105, 22);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(151, 23);
            this.txt_input.TabIndex = 1;
            this.txt_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_input_KeyPress);
            // 
            // lb_awal
            // 
            this.lb_awal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_awal.FormattingEnabled = true;
            this.lb_awal.ItemHeight = 16;
            this.lb_awal.Location = new System.Drawing.Point(16, 69);
            this.lb_awal.Name = "lb_awal";
            this.lb_awal.Size = new System.Drawing.Size(178, 148);
            this.lb_awal.TabIndex = 2;
            // 
            // lb_akhir
            // 
            this.lb_akhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_akhir.FormattingEnabled = true;
            this.lb_akhir.ItemHeight = 16;
            this.lb_akhir.Location = new System.Drawing.Point(220, 69);
            this.lb_akhir.Name = "lb_akhir";
            this.lb_akhir.Size = new System.Drawing.Size(180, 148);
            this.lb_akhir.TabIndex = 2;
            // 
            // btn_input
            // 
            this.btn_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_input.Location = new System.Drawing.Point(275, 15);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(75, 33);
            this.btn_input.TabIndex = 3;
            this.btn_input.Text = "OK";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // btn_htgpjgdata
            // 
            this.btn_htgpjgdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_htgpjgdata.Location = new System.Drawing.Point(28, 223);
            this.btn_htgpjgdata.Name = "btn_htgpjgdata";
            this.btn_htgpjgdata.Size = new System.Drawing.Size(148, 27);
            this.btn_htgpjgdata.TabIndex = 4;
            this.btn_htgpjgdata.Text = "Panjang Data";
            this.btn_htgpjgdata.UseVisualStyleBackColor = true;
            this.btn_htgpjgdata.Click += new System.EventHandler(this.btn_htgpjgdata_Click);
            // 
            // btn_cekarr
            // 
            this.btn_cekarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cekarr.Location = new System.Drawing.Point(225, 223);
            this.btn_cekarr.Name = "btn_cekarr";
            this.btn_cekarr.Size = new System.Drawing.Size(103, 27);
            this.btn_cekarr.TabIndex = 4;
            this.btn_cekarr.Text = "Quick Sort";
            this.btn_cekarr.UseVisualStyleBackColor = true;
            this.btn_cekarr.Click += new System.EventHandler(this.btn_cekarr_Click);
            // 
            // lbl_arr
            // 
            this.lbl_arr.AutoSize = true;
            this.lbl_arr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arr.Location = new System.Drawing.Point(14, 280);
            this.lbl_arr.Name = "lbl_arr";
            this.lbl_arr.Size = new System.Drawing.Size(70, 17);
            this.lbl_arr.TabIndex = 5;
            this.lbl_arr.Text = "nArray= ";
            // 
            // lbl_arrleft
            // 
            this.lbl_arrleft.AutoSize = true;
            this.lbl_arrleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arrleft.Location = new System.Drawing.Point(14, 311);
            this.lbl_arrleft.Name = "lbl_arrleft";
            this.lbl_arrleft.Size = new System.Drawing.Size(59, 17);
            this.lbl_arrleft.TabIndex = 5;
            this.lbl_arrleft.Text = "nLeft= ";
            // 
            // lbl_arrright
            // 
            this.lbl_arrright.AutoSize = true;
            this.lbl_arrright.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arrright.Location = new System.Drawing.Point(14, 338);
            this.lbl_arrright.Name = "lbl_arrright";
            this.lbl_arrright.Size = new System.Drawing.Size(69, 17);
            this.lbl_arrright.TabIndex = 5;
            this.lbl_arrright.Text = "nRight= ";
            // 
            // lb_arr_A
            // 
            this.lb_arr_A.AutoSize = true;
            this.lb_arr_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_arr_A.Location = new System.Drawing.Point(170, 280);
            this.lb_arr_A.Name = "lb_arr_A";
            this.lb_arr_A.Size = new System.Drawing.Size(61, 17);
            this.lb_arr_A.TabIndex = 5;
            this.lb_arr_A.Text = "Array= ";
            // 
            // lb_arr_L
            // 
            this.lb_arr_L.AutoSize = true;
            this.lb_arr_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_arr_L.Location = new System.Drawing.Point(170, 311);
            this.lb_arr_L.Name = "lb_arr_L";
            this.lb_arr_L.Size = new System.Drawing.Size(94, 17);
            this.lb_arr_L.TabIndex = 5;
            this.lb_arr_L.Text = "Array Left= ";
            // 
            // lb_arr_R
            // 
            this.lb_arr_R.AutoSize = true;
            this.lb_arr_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_arr_R.Location = new System.Drawing.Point(170, 338);
            this.lb_arr_R.Name = "lb_arr_R";
            this.lb_arr_R.Size = new System.Drawing.Size(104, 17);
            this.lb_arr_R.TabIndex = 5;
            this.lb_arr_R.Text = "Array Right= ";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(334, 223);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(66, 27);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // frm_qs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(412, 369);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_arrright);
            this.Controls.Add(this.lbl_arrleft);
            this.Controls.Add(this.lb_arr_R);
            this.Controls.Add(this.lb_arr_L);
            this.Controls.Add(this.lb_arr_A);
            this.Controls.Add(this.lbl_arr);
            this.Controls.Add(this.btn_cekarr);
            this.Controls.Add(this.btn_htgpjgdata);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.lb_akhir);
            this.Controls.Add(this.lb_awal);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_qs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Sort";
            this.Load += new System.EventHandler(this.frm_qs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.ListBox lb_awal;
        private System.Windows.Forms.ListBox lb_akhir;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.Button btn_htgpjgdata;
        private System.Windows.Forms.Button btn_cekarr;
        private System.Windows.Forms.Label lbl_arr;
        private System.Windows.Forms.Label lbl_arrleft;
        private System.Windows.Forms.Label lbl_arrright;
        private System.Windows.Forms.Label lb_arr_A;
        private System.Windows.Forms.Label lb_arr_L;
        private System.Windows.Forms.Label lb_arr_R;
        private System.Windows.Forms.Button btn_clear;
    }
}