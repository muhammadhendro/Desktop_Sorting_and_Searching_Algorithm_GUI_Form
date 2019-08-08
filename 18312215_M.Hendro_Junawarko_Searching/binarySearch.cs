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
    public partial class frm_binary : Form
    {
        int count = 0;
        int x;
        public frm_binary()
        {
            InitializeComponent();
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

        private void txt_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // 1. Simpan data dari listbox kedalam array

            int n = lst_data.Items.Count;
            int[] data = new int[n];

            // pindahkan data kedalam array
            for (int i = 0; i < n; i++)
            {
                data[i] = int.Parse(lst_data.Items[i].ToString());
            }

            //sort data pada array dan tampilkan
            Array.Sort(data);
            for (int i = 0; i < n; i++)
            {
                lst_datasort.Items.Add(data[i]);
            }

            // cari data
            int cari = int.Parse(txt_search.Text);

            // 2. Panggil fungsi binary search
            int result = binarySearch(data, 0, n - 1, cari);

            // buat array index
            int[] index = new int[n];

            // hitung posisi indexnya dan jumlah data 
            for (int i = 0; i < n; i++)
            {
                if (data[i] == cari)
                {
                    index[count] = i;
                    count++;
                }
            }
            // tampilkan hasil jumlah data dan index di label 
            if (result == -1)
            {
                lbl_hasil.Text = lbl_hasil.Text + "Data " + cari + " tidak ditemukan!";
                lbl_jumlahdata.Text = "";
                lbl_index.Text = "";
            }
            else
            {
                lbl_hasil.Text = lbl_hasil.Text + "Data " + cari + " ditemukan!";
                lbl_jumlahdata.Text = lbl_jumlahdata.Text + count;
                for (x = 0; x < count; x++)
                {
                    lbl_index.Text = lbl_index.Text + index[x] + ", ";
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lst_data.Items.Clear();
            lst_datasort.Items.Clear();
            txt_search.Clear();
            count = 0;
            x = 0;
            lbl_hasil.Text = "Hasil Pencarian: ";
            lbl_jumlahdata.Text = "Jumlah Data: ";
            lbl_index.Text = "Data berada pada index ke: ";
        }

        // Returns index of x if it is present in 
        // arr[l..r], else return -1 
        static int binarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // If the element is present at the 
                // middle itself 
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then 
                // it can only be present in left subarray 
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                // Else the element can only be present 
                // in right subarray 
                return binarySearch(arr, mid + 1, r, x);
            }

            // We reach here when element is not present 
            // in array 
            return -1;
        }
    }
}
