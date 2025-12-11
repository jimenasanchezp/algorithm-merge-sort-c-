using MergeSortDyNForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MergeSortDyNForms
{
    public partial class Form1 : Form
    {
        MergeSort sorter = new MergeSort();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDirecta_Click(object sender, EventArgs e)
        {
            EjecutarMergeSort("directo");
        }

        private void BtnNatural_Click(object sender, EventArgs e)
        {
            EjecutarMergeSort("natural");
        }

        private void EjecutarMergeSort(string modo)
        {
            int size = (int)nudSize.Value;
            List<int> lista = GenerarLista(size);

            lbOriginal.Items.Clear();
            lbSorted.Items.Clear();
            lblStats.Text = "Procesando...";

            foreach (int n in lista)
                lbOriginal.Items.Add(n);

           // sorter.MoveCount = 0;
            //sorter.ComparisonCount = 0;

            Stopwatch t = new Stopwatch();
            t.Start();

            if (modo == "directo")
                sorter.SortRecursivo(lista);
            else
                sorter.SortNatural(lista);

            t.Stop();

            foreach (int n in lista)
                lbSorted.Items.Add(n);

            lblStats.Text =
                $"Método usado: Merge Sort {modo.ToUpper()}\n" +
                $"Tiempo: {t.Elapsed.TotalMilliseconds:F4} ms\n" +
              //  $"Movimientos: {sorter.MoveCount}\n" +
            //    $"Comparaciones: {sorter.ComparisonCount}\n" +
                $"Tamaño: {size}";
        }

        private List<int> GenerarLista(int size)
        {
            Random rnd = new Random();
            List<int> lista = new List<int>();

            for (int i = 0; i < size; i++)
                lista.Add(rnd.Next(0, 101));

            return lista;
        }
    }
}



