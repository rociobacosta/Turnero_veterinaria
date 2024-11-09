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
    public partial class FormTurno : Form
    {
        Turno[] turnos;
        int contador;
        
        public FormTurno(Turno[] listadoturnos, ref int contador)
        {
            turnos = listadoturnos;
            this.contador = contador;
            InitializeComponent();
            txtNombPaciente.Focus();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombPaciente.Text))
            {
                MessageBox.Show("El nombre del paciente es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombPaciente.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEspecie.Text))
            {
                MessageBox.Show("Debe ingresar la especie del paciente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEspecie.Focus();
                return false;
            }

            if (dateFecha.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("La fecha del turno no puede ser anterior a hoy.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateFecha.Focus();
                return false;
            }

            if (comboHora.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una hora para el turno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboHora.Focus();
                return false;
            }


            return true; 
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string paciente = txtNombPaciente.Text;
                string hora = comboHora.SelectedItem.ToString();
                string especie = txtEspecie.Text;
                DateTime fechaturno = dateFecha.Value;
                Turno turnoAgregado = new Turno(paciente, especie, fechaturno, hora);
                turnos[contador] = turnoAgregado;
                contador++;
                MessageBox.Show("Turno agragado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnVolverAtrasTurno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
