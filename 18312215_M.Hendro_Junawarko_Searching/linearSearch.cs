using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting
{
    public partial class frm_linear : Form
    {
        int count = 0;
        int x;
        public frm_linear()
        {
            InitializeComponent();
        }

        private void txt_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private static int search(int[] arr, int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;

            }
            return -1;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // 1. Simpan data dari listbox kedalam array
                
            int data_lstinput = lst_data.Items.Count;
            int[] data = new int[data_lstinput];

             // pindahkan data kedalam array
            for (int i = 0; i < data_lstinput; i++)
            {
                data[i] = int.Parse(lst_data.Items[i].ToString());
            }

            // cari data
            int cari = int.Parse(txt_search.Text);

            // 2. Panggil fungsi search
            int result = search(data, cari);

            // buat array index
            int[] index = new int[data_lstinput];

            // hitung posisi indexnya dan jumlah data 
            for (int i = 0; i < data_lstinput; i++)
            {
                if (data[i] == cari)  {
                    index[count] = i;
                    count++;
                }
            }
            // tampilkan hasil jumlah data dan index di label 
            if (result == -1)
            {
                lbl_hasil.Text = lbl_hasil.Text +"Data " + cari + " tidak ditemukan!";
                lbl_jumlahdata.Text = "";
                lbl_index.Text = "";
            }
            else
            {
                lbl_hasil.Text = lbl_hasil.Text +"Data " + cari + " ditemukan!";
                lbl_jumlahdata.Text = lbl_jumlahdata.Text + count;
                for (x = 0; x < count; x++)
                {
                    lbl_index.Text = lbl_index.Text + index[x] + ", ";
                }
            }
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            if (txt_input.Text != "")
            {      
                lst_data.Items.Add(txt_input.Text);
                txt_input.Clear();
                txt_input.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lst_data.Items.Clear();
            txt_search.Clear();
            count = 0;
            x = 0;
            
            lbl_hasil.Text = "Hasil Pencarian: ";
            lbl_jumlahdata.Text = "Jumlah Data: ";
            lbl_index.Text = "Data berada pada index ke: ";
        }
    }
}
