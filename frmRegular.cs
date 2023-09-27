using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaExam
{
    public partial class frmRegular : Form
    {
        public frmRegular()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Promedio promedio = new Promedio();
            promedio.Evaluacion1 = double.Parse(txtEva1.Text);
            promedio.Evaluacion2 = double.Parse(txtEva2.Text);
            promedio.Evaluacion3 = double.Parse(txtEva3.Text);
            promedio.NotaActitudinal = double.Parse(txtActitudinal.Text);

            double r = promedio.CalcularPromedio();
            string c = promedio.Condicion();

            ListViewItem lista = new ListViewItem(txtNombre.Text);
            lista.SubItems.Add(txtEva1.Text);
            lista.SubItems.Add(txtEva2.Text);
            lista.SubItems.Add(txtEva3.Text);
            lista.SubItems.Add(txtActitudinal.Text);
            lista.SubItems.Add(r.ToString());
            lista.SubItems.Add(c.ToString());
            lvDetalles.Items.Add(lista);

            double sumaPromedios = CalculaSumaPromedio();

            // Datos en el ListBox
            if(lbEstadisticas.Items.Count == 0)
            {
                lbEstadisticas.Items.Add("Suma de promedios: " +sumaPromedios.ToString());
            }
            else
            {
                lbEstadisticas.Items[0]= "Suma de promedios: " +sumaPromedios.ToString();
            }

            double promedioMasAlto = DeterminarPromedioAlto();
            if (lbEstadisticas.Items.Count == 1)
            {
                lbEstadisticas.Items.Add("Promedio mas alto: " + promedioMasAlto.ToString());
            }
            else
            {
                lbEstadisticas.Items[1] = "Promedio mas alto: " + promedioMasAlto.ToString();
            }

            double promedioMasBajo = DeterminarPromedioBajo();
            if (lbEstadisticas.Items.Count == 2)
            {
                lbEstadisticas.Items.Add("Promedio mas bajo: " + promedioMasBajo.ToString());
            }
            else
            {
                lbEstadisticas.Items[2] = "Promedio mas bajo: " + promedioMasBajo.ToString();
            }

            double totalAprobados = DeterminarTotalAprobados();
            if (lbEstadisticas.Items.Count == 3)
            {
                lbEstadisticas.Items.Add("Total de Aprobados: " + totalAprobados.ToString());
            }
            else
            {
                lbEstadisticas.Items[3] = "Total de Aprobados: " + totalAprobados.ToString();
            }


            double totalReprobados = DeterminarTotalReprobados();
            if (lbEstadisticas.Items.Count == 4)
            {
                lbEstadisticas.Items.Add("Total de Reprobados: " + totalReprobados.ToString());
            }
            else
            {
                lbEstadisticas.Items[4] = "Total de Reprobados: " + totalReprobados.ToString();
            }





        }

        private double DeterminarTotalReprobados()
        {
            int contadorReprobados = 0;

            foreach (ListViewItem item in lvDetalles.Items)
            {

                double promedio = double.Parse(item.SubItems[5].Text);
                string condicion = item.SubItems[6].Text; ;


                if (condicion == "REPROBADO")
                {
                    contadorReprobados++;
                }

            }

            return contadorReprobados;
        }

        private double DeterminarTotalAprobados()
        {
            int contadorAprobados = 0;

            foreach (ListViewItem item in lvDetalles.Items)
            {

                double promedio = double.Parse(item.SubItems[5].Text);
                string condicion = item.SubItems[6].Text; ;


                if (condicion != "REPROBADO")
                {
                    contadorAprobados++;
                }

            }

            return contadorAprobados;
        }

        private double DeterminarPromedioBajo()
        {
            double promedioMasBajo = double.MaxValue;

            foreach (ListViewItem item in lvDetalles.Items)
            {
                double promedio = double.Parse(item.SubItems[5].Text);
                if (promedio < promedioMasBajo)
                {
                    promedioMasBajo = promedio;
                }
            }
            return promedioMasBajo;
        }

        private double DeterminarPromedioAlto()
        {

            double promedioMasAlto = double.MinValue;

            foreach (ListViewItem item in lvDetalles.Items)
            {
                double promedio = double.Parse(item.SubItems[5].Text);
                if (promedio > promedioMasAlto)
                {
                    promedioMasAlto = promedio;
                }
            }

            return promedioMasAlto;
        }

        private double CalculaSumaPromedio()
        {
            double total = 0;
            for (int i = 0; i < lvDetalles.Items.Count; i++)
            {
                total += double.Parse(lvDetalles.Items[i].SubItems[5].Text);
            }
            return total;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEva1.Clear();
            txtEva2.Clear();
            txtEva3.Clear();
            txtActitudinal.Clear();
            txtNombre.Focus();
        }
    }
}
