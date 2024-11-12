using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BA;

namespace Turnero_veterinaria
{
    public partial class VerTurnos : Form
    {
        //Turno[] turnos;

        //
        public Turnos Turnoss = new Turnos();
        public VerTurnos()
        {
            
            InitializeComponent();
            mostrarTurnos();

            //
            DGV.DataSource = Turnoss.Lista;
        }

        private void mostrarTurnos()
        { 
            
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ///////////

   

      
    }
}
