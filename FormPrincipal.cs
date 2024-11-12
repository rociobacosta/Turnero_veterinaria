using System;
using System.Windows.Forms;
using BA;

namespace Turnero_veterinaria
{
    public partial class FormPrincipal : Form
    {
        //public Turno[] listadoDeTurnos = new Turno[19];
        //public int contador = 0;
        public FormPrincipal()
        {
            InitializeComponent();
        }

     
        private void btnCrearTurno_Click(object sender, EventArgs e)
        {
           FormTurno formularioTurno = new FormTurno();
           formularioTurno.ShowDialog();
        }

        private void btnVerTurnos_Click(object sender, EventArgs e)
        {
            VerTurnos formularioVerTurnos = new VerTurnos();
            formularioVerTurnos.ShowDialog();   
        }
    }
}
