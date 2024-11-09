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
    public partial class VerTurnos : Form
    {
        Turno[] turnos;
        
        public VerTurnos(Turno[] listadoturnos)
        {
            turnos = listadoturnos;
            InitializeComponent();
            mostrarTurnos();

            
        }

        private void mostrarTurnos()
        { 
            
            for (int i = 0; i < turnos.Length; i++)
            {
                if (turnos[i] != null)
                {
                    label1.Text += $"Nombre: {turnos[i].Nombre}\n";
                    label1.Text += $"Especie: {turnos[i].Especie}\n";
                    label1.Text += $"Fecha: {turnos[i].Fecha:dd/MM/yyyy}\n";
                    label1.Text += $"Horario: {turnos[i].Horario}\n";
                    label1.Text += "-----------------------------\n";
                }
                
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
