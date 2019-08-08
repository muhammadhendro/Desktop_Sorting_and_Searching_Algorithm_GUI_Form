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
    public partial class frm_qs : Form
    {
        int[] data = new int[10];
        int x = 0;
        int nA, nL, nR;
        public frm_qs()
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

        private void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
                lb_akhir.Items.Add(arr[i]);
        } 
       
        static int partition(int[] arr, int low,
                                   int high)
        {
            int pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        } 

        private void frm_qs_Load(object sender, EventArgs e)
        {
            nA = 0;
            nL = 0;
            nR = 0;
            lbl_arr.Text = "nArray = ";
            lbl_arrleft.Text = "nLeft = ";
            lbl_arrright.Text = "nRight = ";
        }

        private void txt_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false   && (int)e.KeyChar != (int)Keys.Back)     
            {
                e.Handled = true;                                
            }
        }

        private void btn_htgpjgdata_Click(object sender, EventArgs e)
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

        private void btn_cekarr_Click(object sender, EventArgs e)
        {
            quickSort(data, 0, x - 1);
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
                    lb_arr_L.Text = lb_arr_L.Text + value + ", ";
                }
                else
                {
                    arr_R[right] = int.Parse(value);
                    right++;
                    lb_arr_R.Text = lb_arr_R.Text + value + ", ";
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
