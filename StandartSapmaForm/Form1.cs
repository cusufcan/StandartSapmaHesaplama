using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandartSapmaForm
{
    public partial class Form1 : Form
    {
        int[] array = new int[10];

        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(1, 100);
                view_degerler.Rows.Add((i + 1).ToString(), array[i].ToString());
            }

            txtSonucIteratif.Text = StandartSapmaHesaplaIteratif(array, ortHesaplaIteratif(array)).ToString();
            txtSonucRecursive.Text = StandartSapmaHesaplamaRecursive(array.Length - 1, ortHesaplaRecursive(array.Length - 1, 0), 0).ToString();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            CreateArray();
            txtSonucIteratif.Text = StandartSapmaHesaplaIteratif(array, ortHesaplaIteratif(array)).ToString();
            txtSonucRecursive.Text = StandartSapmaHesaplamaRecursive(array.Length - 1, ortHesaplaRecursive(array.Length - 1, 0), 0).ToString();
        }

        void CreateArray()
        {
            view_degerler.Rows.Clear();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(0, 100);
                view_degerler.Rows.Add((i + 1).ToString(), array[i].ToString());
            }
        }

        double StandartSapmaHesaplaIteratif(int[] arr, double avg)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += (arr[i] - avg) * (arr[i] - avg);
            }
            double standartSapma = Math.Sqrt(sum / (arr.Length - 1));
            return standartSapma;
        }

        double ortHesaplaIteratif(int[] arr)
        {
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                avg += arr[i];
            }
            return avg /= arr.Length;
        }

        double StandartSapmaHesaplamaRecursive(int i, double avg, double formul)
        {
            if (i < 0)
            {
                double standartSapma = Math.Sqrt(formul);
                formul = 0;
                return standartSapma;
            }
            formul += Math.Pow((array[i] - avg), 2) / (array.Length - 1);
            return StandartSapmaHesaplamaRecursive(i - 1, avg, formul);
        }

        double ortHesaplaRecursive(int i, double s)
        {
            if (i < 0)
            {
                return s / array.Length;
            }
            s += array[i];
            return ortHesaplaRecursive(i - 1, s);
        }
    }
}