using Patrones.Strategy.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronesStrategyUI
{
    public partial class Form1 : Form
    {

        List<Arma> _estrategiasDisparo;
        Jugador jugador;
        public Form1()
        {
            InitializeComponent();

            _estrategiasDisparo = new List<Arma>();

            _estrategiasDisparo.Add(new EspadaTipo1());
            _estrategiasDisparo.Add(new FrancotiradorSRS99());
            _estrategiasDisparo.Add(new RifleBR55HB());
            //Nueva clase agregada
            _estrategiasDisparo.Add(new AntiBlindaje58());


            this.cboEstrategias.DataSource = _estrategiasDisparo;


            jugador = new Jugador();
            jugador.Nombre = "Master Cheif";
            this.lblJugador.Text = jugador.Nombre;

        }

        private void cmdDisparar_Click(object sender, EventArgs e)
        {
          
                MessageBox.Show(jugador.Disparar());
           
         
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            Arma arma = (Arma)this.cboEstrategias.SelectedItem;
            jugador.CambiarEstrategia(arma);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
