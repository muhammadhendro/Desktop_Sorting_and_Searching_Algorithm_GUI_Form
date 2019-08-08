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
    public partial class frm_is : Form
    {
        int[] data = new int[10];
        int x=0;
        public frm_is()
        {
            InitializeComponent();
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            if (txt_input.Text != "")
            {
                data[x] = int.Parse(txt_input.Text);
                lb_awal.Items.Add(txt_input.Text);
                x++;
                txt_input.Clear();
                txt_input.Focus();
            }    
        }

        private void btn_hasil_Click(object sender, EventArgs e)
        {

            frm_is ob = new frm_is(); 
            ob.sort(data, x);
            printArray(data, x);
        }
        void sort(int[] arr, int n)
        {
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        } 
        private void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
                lb_akhir.Items.Add(arr[i]);
        }

        private void txt_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && (int)e.KeyChar != (int)Keys.Back)   
            {
                e.Handled = true;                                
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lb_awal.Items.Clear();
            lb_akhir.Items.Clear();
            x = 0;
        } 
    }
}
