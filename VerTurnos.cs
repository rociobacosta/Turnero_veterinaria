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
   
        public Turnos Turnoss = new Turnos();
        public VerTurnos()
        {
            
            InitializeComponent();


            //
            DGV.DataSource = Turnoss.Lista;
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
