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
    public partial class frm_ms : Form
    {
        int[] data =new int [10]  ;
        int x=0;
        int nA, nL, nR;
        public frm_ms()
        {
            InitializeComponent();
        }

        private void btn_input_Click(object sender, EventArgs e)
        {   
            if (txt_input.Text != "")
            {
                data[x] = int.Parse(txt_input.Text);
                x++;
                lb_awal.Items.Add(txt_input.Text);
                txt_input.Clear();
                txt_input.Focus();
            }
        }

        private void frm_ms_Load(object sender, EventArgs e)
        {
           nA = 0;
           nL = 0;
           nR = 0;
            
           lbl_arr.Text = "nArray = ";
           lbl_arrleft.Text = "nLeft = ";
           lbl_arrright.Text = "nRight = ";
        }

        private void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
                lb_akhir.Items.Add(arr[i]);
        } 

        private void merge(int[] data, int l, int m, int r) 
    { 
        // Find sizes of two subarrays to be merged 
        int n1 = m - l + 1; 
        int n2 = r - m; 
  
        /* Create temp arrays */
        int[] L = new int [n1]; 
        int[] R = new int [n2]; 
  
        /*Copy data to temp arrays*/
        for (int a = 0; a < n1; ++a)
         L[a] = data[l + a]; 
        for (int b = 0; b < n2; ++b)
        R[b] = data[m + 1 + b]; 
  
  
        /* Merge the temp arrays */
  
        // Initial indexes of first and second subarrays 
        int i = 0;
        int j = 0; 
  
        // Initial index of merged subarry array 
        int k = l; 
        while (i < n1 && j < n2) 
        { 
            if (L[i] <= R[j]) 
            { 
                data[k] = L[i]; 
                i++; 
            } 
            else
            { 
                data[k] = R[j]; 
                j++; 
            } 
            k++; 
        } 
  
        /* Copy remaining elements of L[] if any */
        while (i < n1) 
        { 
            data[k] = L[i]; 
            i++; 
            k++; 
        } 
  
        /* Copy remaining elements of R[] if any */
        while (j < n2) 
        { 
            data[k] = R[j]; 
            j++; 
            k++; 
        }
       // lbl_arr.Text = "Jumlah Array= " + x;
        //lbl_left.Text = "Array Left= " + n1;
        //lblright.Text = "Array Right= " + n2;
    } 
        private void sort(int[] data, int l, int r) 
    { 
        if (l < r) 
        { 
            // Find the middle point 
            int m = (l+r)/2; 
  
            // Sort first and second halves 
            sort(data, l, m); 
            sort(data, m+1, r); 
  
            // Merge the sorted halves 
            merge(data, l, m, r); 
        } 
    }

        private void btn_hitungpjgdata_Click(object sender, EventArgs e)
        {
            nA = lb_awal.Items.Count;
            lbl_arr.Text = "nArray = " + nA.ToString();

            if (nA % 2 == 1)
                nL = (nA / 2) + 1;
            else
                nL = (nA / 2);

            lbl_arrleft.Text = "nLeft = " + nL.ToString();

            nR = nA - nL;
            lbl_arrright.Text = "nRight = " + nR.ToString();
        }

        private void txt_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && (int)e.KeyChar != (int)Keys.Back)     
            {
                e.Handled = true;                              
            }
        }

        private void btn_merge_Click(object sender, EventArgs e)
        {
            sort(data, 0, x - 1);

            printArray(data, x);
            
            int[] arr_A = new int[nA];
            int[] arr_L = new int[nL];
            int[] arr_R = new int[nR];
            int left = 0;
            int right = 0;

            for (int i = 0; i < nA; i++)
            {
                string value = lb_awal.Items[i].ToString();
                arr_A[i] = int.Parse(value);
                lb_arr_A.Text = lb_arr_A.Text + value + ", ";
                if (i < nL)
                {
                    arr_L[left] = int.Parse(value);
                    left++;
                    lb_arr_L.Text = lb_arr_L.Text +  value+", ";
                }
                else
                {
                    arr_R[right] = int.Parse(value);
                    right++;
                    lb_arr_R.Text = lb_arr_R.Text +  value+", ";
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

            lb_awal.Items.Clear();
            lb_akhir.Items.Clear();
            x = 0;
            lbl_arr.Text = "nArray = ";
            lbl_arrleft.Text = "nLeft = ";
            lbl_arrright.Text = "nRight = ";
            lb_arr_A.Text = "Array= ";
            lb_arr_L.Text = "Array Left= ";
            lb_arr_R.Text = "Array Right= ";

        }

    }
}
