using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Timers;

namespace SortingAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Credential> CredentialList = new List<Credential>();
        public List<Credential> newCredentialList = new List<Credential>();
        Random rnd = new Random();
        Stopwatch timer = new Stopwatch();
        public void dataByind(List<Credential> CredentialList)
        {
            recordGrid.DataSource = null;
            recordGrid.DataSource = CredentialList;
            recordGrid.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            //timedisplaybar.Visible = false;
            //timeLbl.Visible = false;
        }
      
        public void Record100Btn_Click(object sender, EventArgs e)
        {
            timer.Restart();
            CredentialList = CredentialDL.readData("organizations-100.csv");
            timer.Stop();
            timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
            dataByind(CredentialList);
        
        }

        private void record1000Btn_Click(object sender, EventArgs e)
        {
            timer.Restart();
            CredentialList = CredentialDL.readData("organizations-1000.csv");
            timer.Stop();
            timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
            dataByind(CredentialList);
            
        }

        private void record10000Btn_Click(object sender, EventArgs e)
        {
            timer.Restart();
            CredentialList = CredentialDL.readData("organizations-10000.csv");
            timer.Stop();
            timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
            dataByind(CredentialList);
          
        }

        private void record100000Btn_Click(object sender, EventArgs e)
        {
            timer.Restart();
            CredentialList = CredentialDL.readData("organizations-100000.csv");
            timer.Stop();
            timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
            dataByind(CredentialList);
           
        }

        private void record500000Btn_Click(object sender, EventArgs e)
        {
            timer.Restart();
            CredentialList = CredentialDL.readData("organizations-500000.csv");
            timer.Stop();
            timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
            dataByind(CredentialList);
            
            
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miniButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Normal;
        }

        public static void Exap()
        {

        }
        private void sortBtn_Click(object sender, EventArgs e)
        {
            string algorithm = algorComBox.Text;
            string basis = basisComBox.Text;
            if(algorithm == "Bubble Sort")
            {
                if(basis == "Basis On No.Of Employees")
                {
                    timer.Restart();
                    newCredentialList = CredentialDL.bubbleSort(CredentialList, false);
                    
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(newCredentialList);
                }
                else if(basis == "Basis On Index")
                {
                    timer.Restart();
                    newCredentialList = CredentialDL.bubbleSort(CredentialList, true);
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(newCredentialList);
                }
            }
            else if(algorithm == "Insertion Sort")
            {
                if (basis == "Basis On No.Of Employees")
                {
                    timer.Restart();
                    newCredentialList = CredentialDL.insertionSort(CredentialList, false);
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(newCredentialList);
                }
                else if (basis == "Basis On Index")
                {
                    timer.Restart();
                    newCredentialList = CredentialDL.insertionSort(CredentialList, true);
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(newCredentialList);
                }
            }
            else if(algorithm == "Selection Sort")
            {
                if (basis == "Basis On No.Of Employees")
                {
                    timer.Restart();
                    newCredentialList = CredentialDL.selectionSort(CredentialList, false);
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(newCredentialList);
                }
                else if (basis == "Basis On Index")
                {
                    timer.Restart();
                    newCredentialList = CredentialDL.selectionSort(CredentialList, true);
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(newCredentialList);
                }
            }
            else if (algorithm == "Merge Sort")
            {
                
                int size = CredentialList.Count-1;
                if (basis == "Basis On No.Of Employees")
                {
                    timer.Restart();
                    CredentialDL.mergeSort(ref CredentialList,0, size, false);
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(CredentialList);
                }
                else if (basis == "Basis On Index")
                {
                    timer.Restart();
                    CredentialDL.mergeSort(ref CredentialList,0, size, true);
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(CredentialList);
                }
            }
            else if (algorithm == "Quick Sort")
            {
                int size = CredentialList.Count - 1;
                if (basis == "Basis On No.Of Employees")
                {
                    timer.Restart();
                    CredentialDL.quickSort(ref CredentialList, 0, size, false);
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(CredentialList);

                }
                else if (basis == "Basis On Index")
                {
                    timer.Restart();
                    CredentialDL.quickSort(ref CredentialList, 0, size, true);
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(CredentialList);
                }
            }
            else if (algorithm == "Heap Sort")
            {
                int size = CredentialList.Count;
                if (basis == "Basis On No.Of Employees")
                {
                    timer.Restart();
                    CredentialDL.heapSort(ref CredentialList,size, false);
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(CredentialList);
                }
                else if (basis == "Basis On Index")
                {
                    timer.Restart();
                    CredentialDL.heapSort(ref CredentialList,size, true);
                    Thread test = new Thread(() =>CredentialDL.heapSort(ref CredentialList, size, true));
                    test.Start();
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(CredentialList);
                }
            }
            else if (algorithm == "Counting Sort")
            {
                timer.Restart();
                int size = CredentialList.Count;
                if (basis == "Basis On No.Of Employees")
                {
                    CredentialDL.countingSortEmployee(ref CredentialList,0, false,false);
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(CredentialList);
                }
                else if (basis == "Basis On Index")
                {
                    timer.Restart();
                    CredentialDL.countingSortIndex(ref CredentialList,0, true,false);
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(CredentialList);
                }
            }
            else if (algorithm == "Radix Sort")
            {
                int size = CredentialList.Count;
                if (basis == "Basis On No.Of Employees")
                {
                    timer.Restart();
                    CredentialDL.radixSortEmployee(ref CredentialList);
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(CredentialList);
                }
                else if (basis == "Basis On Index")
                {
                    timer.Restart();
                    CredentialDL.radixSortIndex(ref CredentialList);
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(CredentialList);
                }
            }
            else if (algorithm == "Bucket Sort")
            {
                int size = CredentialList.Count;
                if (basis == "Basis On No.Of Employees")
                {
                    timer.Restart();
                    CredentialDL.bucketSort(ref CredentialList, false);
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(CredentialList);
                }
                else if (basis == "Basis On Index")
                {
                    timer.Restart();
                    CredentialDL.bucketSort(ref CredentialList, true);
                    timer.Stop();
                    timedisplaybar.Value = ((int)timer.ElapsedMilliseconds);
                    dataByind(CredentialList);
                }
            }
        }

        private void recordGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
