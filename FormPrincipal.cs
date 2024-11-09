using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnero_veterinaria
{
    public partial class FormPrincipal : Form
    {
        public Turno[] listadoDeTurnos = new Turno[19];
        public int contador = 0;
        public FormPrincipal()
        {
            InitializeComponent();
        }

     
        private void btnCrearTurno_Click(object sender, EventArgs e)
        {
           FormTurno formularioTurno = new FormTurno(listadoDeTurnos,ref contador);
           formularioTurno.ShowDialog();
        }

        private void btnVerTurnos_Click(object sender, EventArgs e)
        {
            VerTurnos formularioVerTurnos = new VerTurnos(listadoDeTurnos);
            formularioVerTurnos.ShowDialog();   
        }
    }
}
