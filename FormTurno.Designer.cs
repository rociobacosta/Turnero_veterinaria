namespace Turnero_veterinaria
{
    partial class FormTurno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombPaciente = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.comboHora = new System.Windows.Forms.ComboBox();
            this.btnAgregarTurno = new System.Windows.Forms.Button();
            this.btnVolverAtrasTurno = new System.Windows.Forms.Button();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(218, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(284, 32);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del paciente:";
            // 
            // txtNombPaciente
            // 
            this.txtNombPaciente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNombPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombPaciente.Location = new System.Drawing.Point(560, 52);
            this.txtNombPaciente.Name = "txtNombPaciente";
            this.txtNombPaciente.Size = new System.Drawing.Size(332, 34);
            this.txtNombPaciente.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(401, 204);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(101, 32);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(418, 274);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(83, 32);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora:";
            // 
            // dateFecha
            // 
            this.dateFecha.CalendarMonthBackground = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dateFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFecha.Location = new System.Drawing.Point(560, 204);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(332, 34);
            this.dateFecha.TabIndex = 8;
            // 
            // comboHora
            // 
            this.comboHora.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboHora.DisplayMember = "hola!";
            this.comboHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboHora.FormattingEnabled = true;
            this.comboHora.Items.AddRange(new object[] {
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30"});
            this.comboHora.Location = new System.Drawing.Point(560, 274);
            this.comboHora.Name = "comboHora";
            this.comboHora.Size = new System.Drawing.Size(332, 37);
            this.comboHora.TabIndex = 9;
            this.comboHora.Text = "Elija un horario de la lista";
            // 
            // btnAgregarTurno
            // 
            this.btnAgregarTurno.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTurno.Location = new System.Drawing.Point(188, 433);
            this.btnAgregarTurno.Name = "btnAgregarTurno";
            this.btnAgregarTurno.Size = new System.Drawing.Size(269, 63);
            this.btnAgregarTurno.TabIndex = 10;
            this.btnAgregarTurno.Text = "Agregar turno";
            this.btnAgregarTurno.UseVisualStyleBackColor = false;
            this.btnAgregarTurno.Click += new System.EventHandler(this.btnAgregarTurno_Click);
            // 
            // btnVolverAtrasTurno
            // 
            this.btnVolverAtrasTurno.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVolverAtrasTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverAtrasTurno.Location = new System.Drawing.Point(640, 433);
            this.btnVolverAtrasTurno.Name = "btnVolverAtrasTurno";
            this.btnVolverAtrasTurno.Size = new System.Drawing.Size(269, 63);
            this.btnVolverAtrasTurno.TabIndex = 11;
            this.btnVolverAtrasTurno.Text = "Volver atras";
            this.btnVolverAtrasTurno.UseVisualStyleBackColor = false;
            this.btnVolverAtrasTurno.Click += new System.EventHandler(this.btnVolverAtrasTurno_Click);
            // 
            // txtEspecie
            // 
            this.txtEspecie.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecie.Location = new System.Drawing.Point(560, 125);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(332, 34);
            this.txtEspecie.TabIndex = 13;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(377, 127);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(124, 32);
            this.lblEspecie.TabIndex = 12;
            this.lblEspecie.Text = "Especie:";
            // 
            // FormTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Turnero_veterinaria.Properties.Resources.fuz_fondo;
            this.ClientSize = new System.Drawing.Size(1084, 558);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.btnVolverAtrasTurno);
            this.Controls.Add(this.btnAgregarTurno);
            this.Controls.Add(this.comboHora);
            this.Controls.Add(this.dateFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtNombPaciente);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormTurno";
            this.Text = "Veterinaria Fuz - Agregar turno ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombPaciente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.ComboBox comboHora;
        private System.Windows.Forms.Button btnAgregarTurno;
        private System.Windows.Forms.Button btnVolverAtrasTurno;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label lblEspecie;
    }
}