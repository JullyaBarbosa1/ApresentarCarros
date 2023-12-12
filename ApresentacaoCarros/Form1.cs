using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApresentacaoCarros
{
    public partial class Form1 : Form
    {
        public struct Carro
        {
            public string marca;
            public string modelo;
            public short ano;
            public short portas;
            public string foto;
        }
        public Carro[] ListaCarros = new Carro[17];
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dados_Enter(object sender, EventArgs e)
        {

        }
        private void ApresentarDataHora()
        {


            DateTime DiaSemaa = DateTime.Today;
            lbDiaSemana.Text = DiaSemaa.DayOfWeek.ToString();
            lbData.Text = DateTime.Now.ToShortDateString();
            lbHora.Text = DateTime.Today.ToShortDateString();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            ApresentarDataHora();
            timer1.Interval = 5000;
            timer1.Enabled = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = 17;

            ListaCarros[0] = new Carro();
            ListaCarros[0].marca = "Jaguar";
            ListaCarros[0].modelo = "E-Type";
            ListaCarros[0].ano = 1964;
            ListaCarros[0].portas = 2;
            ListaCarros[0].foto = "JaguarEType";

            ListaCarros[1] = new Carro();
            ListaCarros[1].marca = "Chevrolet";
            ListaCarros[1].modelo = "Corvette";
            ListaCarros[1].ano = 1953;
            ListaCarros[1].portas = 2;
            ListaCarros[1].foto = "Chevrolet";

            ListaCarros[2] = new Carro();
            ListaCarros[2].marca = "Lamborghini";
            ListaCarros[2].modelo = "Miura";
            ListaCarros[2].ano = 1967;
            ListaCarros[2].portas = 2;
            ListaCarros[2].foto = "Lamborghini";

            ListaCarros[3] = new Carro();
            ListaCarros[3].marca = "Porsche";
            ListaCarros[3].modelo = "911";
            ListaCarros[3].ano = 1964;
            ListaCarros[3].portas = 2;
            ListaCarros[3].foto = "Porsche911";

            ListaCarros[4] = new Carro();
            ListaCarros[4].marca = "Rolls-Royce";
            ListaCarros[4].modelo = "Dawn Drophead";
            ListaCarros[4].ano = 1949;
            ListaCarros[4].portas = 2;
            ListaCarros[4].foto = "RollsRoyce";

            ListaCarros[5] = new Carro();
            ListaCarros[5].marca = "Mercedes";
            ListaCarros[5].modelo = "300 SL";
            ListaCarros[5].ano = 1954;
            ListaCarros[5].portas = 2;
            ListaCarros[5].foto = "Mercedes";

            ListaCarros[6] = new Carro();
            ListaCarros[6].marca = "Ferrari";
            ListaCarros[6].modelo = "250 GTO";
            ListaCarros[6].ano = 1962;
            ListaCarros[6].portas = 2;
            ListaCarros[6].foto = "Ferrari";

            ListaCarros[7] = new Carro();
            ListaCarros[7].marca = "Honda";
            ListaCarros[7].modelo = "NSX";
            ListaCarros[7].ano = 1990;
            ListaCarros[7].portas = 2;
            ListaCarros[7].foto = "HondaNSX";

            ListaCarros[8] = new Carro();
            ListaCarros[8].marca = "Ford";
            ListaCarros[8].modelo = "Shelby GT350";
            ListaCarros[8].ano = 1960;
            ListaCarros[8].portas = 2;
            ListaCarros[8].foto = "FordShelb";

            ListaCarros[9] = new Carro();
            ListaCarros[9].marca = "Ford";
            ListaCarros[9].modelo = "T";
            ListaCarros[9].ano = 1908;
            ListaCarros[9].portas = 2;
            ListaCarros[9].foto = "FordT";

            ListaCarros[10] = new Carro();
            ListaCarros[10].marca = "Volkswagen";
            ListaCarros[10].modelo = "Fusca";
            ListaCarros[10].ano = 1938;
            ListaCarros[10].portas = 2;
            ListaCarros[10].foto = "Fusca";

            ListaCarros[11] = new Carro();
            ListaCarros[11].marca = "Volvo";
            ListaCarros[11].modelo = "P1800";
            ListaCarros[11].ano = 1968;
            ListaCarros[11].portas = 2;
            ListaCarros[11].foto = "Volvo";

            ListaCarros[12] = new Carro();
            ListaCarros[12].marca = "Dodge";
            ListaCarros[12].modelo = "Viper GTS";
            ListaCarros[12].ano = 1990;
            ListaCarros[12].portas = 2;
            ListaCarros[12].foto = "Dodge";

            ListaCarros[13] = new Carro();
            ListaCarros[13].marca = "Porsche";
            ListaCarros[13].modelo = "356";
            ListaCarros[13].ano = 1960;
            ListaCarros[13].portas = 2;
            ListaCarros[13].foto = "Porsche356";

            ListaCarros[14] = new Carro();
            ListaCarros[14].marca = "Chevrolet";
            ListaCarros[14].modelo = "Camaro";
            ListaCarros[14].ano = 1967;
            ListaCarros[14].portas = 2;
            ListaCarros[14].foto = "Camaro";

            ListaCarros[15] = new Carro();
            ListaCarros[15].marca = "Fiat";
            ListaCarros[15].modelo = "124 Spider";
            ListaCarros[15].ano = 1968;
            ListaCarros[15].portas = 2;
            ListaCarros[15].foto = "Fiat";

            ListaCarros[16] = new Carro();
            ListaCarros[16].marca = "Jeep";
            ListaCarros[16].modelo = "Willys";
            ListaCarros[16].ano = 1945;
            ListaCarros[16].portas = 2;
            ListaCarros[16].foto = "Jeep";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int pos = progressBar1.Value;
            MarcaTB.Text = ListaCarros[pos].marca;
            ModeloTB.Text = ListaCarros[pos].modelo;
            AnoTB.Text = ListaCarros[pos].ano.ToString();
            PortasTB.Text = ListaCarros[pos].portas.ToString();
            string fLocal = ListaCarros[pos].foto;
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(fLocal);
            progressBar1.Value = pos + 1;
            if (progressBar1.Value == 17) progressBar1.Value = 0;
        }

        private void PortasTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
