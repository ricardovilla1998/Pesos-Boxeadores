using SbsSW.SwiPlCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaProlog_VillaOsuna
{
    public partial class Form1 : Form
    {
        String consulta = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ruta de instalacion de prolog
            Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\bin");
            //Cargar archivo prilig
            string[] p = { "-q", "-f", @"boxeador.pl" };
            PlEngine.Initialize(p);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox_boxeadores.Items.Clear();
            // "cargar" fue declarado en el archivo de prolog YA NO SE USA
           /* PlQuery cargar = new PlQuery("cargar('boxeador.bd')");
            cargar.NextSolution();*/

    
            switch (Convert.ToString(combo_boxeadores.SelectedItem))
            {

                case "Peso Welter":
                    PlQuery peso_welter = peso_welter = new PlQuery(compruebaWelter());
                    foreach (PlQueryVariables v in peso_welter.SolutionVariables)
                        listBox_boxeadores.Items.Add(v["X"].ToString());
                    break;

                case "Peso Medio":
                    PlQuery peso_medio = new PlQuery(compruebaMedio());
                    foreach (PlQueryVariables v in peso_medio.SolutionVariables)
                        listBox_boxeadores.Items.Add(v["X"].ToString());
                    break;

                case "Peso Pesado":
                    PlQuery peso_pesado = new PlQuery(compruebaPesado());
                    foreach (PlQueryVariables v in peso_pesado.SolutionVariables)
                        listBox_boxeadores.Items.Add(v["X"].ToString());
                    break;

                default:
                    PlQuery todos = new PlQuery(compruebaTodo());
                    foreach (PlQueryVariables v in todos.SolutionVariables)
                        listBox_boxeadores.Items.Add(v["X"].ToString());
                    break;

            }

           


        }
        //METODOS
        public String compruebaWelter()
        {

            if (radio_mex.Checked == true)
            {
                consulta = "peso_welter_mexicano(X)";

            }
            else if (radio_eua.Checked == true)
            {
                consulta = "peso_welter_americano(X)";
            }
            else
            {
                consulta = "peso_welter(X)";
            }
            return consulta;
        }

        public String compruebaMedio()
        {

            if (radio_mex.Checked == true)
            {
                consulta = "peso_medio_mexicano(X)";

            }
            else if (radio_eua.Checked == true)
            {
                consulta = "peso_medio_americano(X)";
            }
            else
            {
                consulta = "peso_medio(X)";
            }
            return consulta;
        }

        public String compruebaPesado()
        {

            if (radio_eua.Checked == true)
            {
                consulta = "peso_pesado_americano(X)";
            }
            else
            {
                consulta = "peso_pesado(X)";
            }
            return consulta;
        }
        public String compruebaTodo()
        {

            if (radio_mex.Checked == true)
            {
                consulta = "mexicano(X)";

            }
            else if (radio_eua.Checked == true)
            {
                consulta = "americano(X)";
            }
            else
            {
                consulta = "boxeador(X)";
            }
            return consulta;
        }

    }
}
