namespace PrimerParcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewMostrar = new System.Windows.Forms.DataGridView();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.dateTPFechaJuego = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUDGolesAnotados = new System.Windows.Forms.NumericUpDown();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonNextForm = new System.Windows.Forms.Button();
            this.comboBoxEquipoGol = new System.Windows.Forms.ComboBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMenor = new System.Windows.Forms.Label();
            this.labelMayor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonPropietarioCuotaAlta = new System.Windows.Forms.Button();
            this.buttonOrdanar3alta3Baja = new System.Windows.Forms.Button();
            this.buttonCuotaxMantenimiento = new System.Windows.Forms.Button();
            this.dataGridViewPropietarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDGolesAnotados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropietarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMostrar
            // 
            this.dataGridViewMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrar.Location = new System.Drawing.Point(75, 196);
            this.dataGridViewMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMostrar.Name = "dataGridViewMostrar";
            this.dataGridViewMostrar.RowHeadersWidth = 51;
            this.dataGridViewMostrar.Size = new System.Drawing.Size(533, 215);
            this.dataGridViewMostrar.TabIndex = 11;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(496, 70);
            this.buttonMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(167, 62);
            this.buttonMostrar.TabIndex = 12;
            this.buttonMostrar.Text = "Mostrar Datos";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // dateTPFechaJuego
            // 
            this.dateTPFechaJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTPFechaJuego.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPFechaJuego.Location = new System.Drawing.Point(255, 65);
            this.dateTPFechaJuego.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTPFechaJuego.Name = "dateTPFechaJuego";
            this.dateTPFechaJuego.Size = new System.Drawing.Size(231, 26);
            this.dateTPFechaJuego.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Goles anotados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Número de Identificación";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha del Juego";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Equipo que Metio Gol";
            // 
            // numericUDGolesAnotados
            // 
            this.numericUDGolesAnotados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUDGolesAnotados.Location = new System.Drawing.Point(255, 132);
            this.numericUDGolesAnotados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUDGolesAnotados.Name = "numericUDGolesAnotados";
            this.numericUDGolesAnotados.Size = new System.Drawing.Size(232, 26);
            this.numericUDGolesAnotados.TabIndex = 20;
            // 
            // comboBoxID
            // 
            this.comboBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(255, 31);
            this.comboBoxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(231, 28);
            this.comboBoxID.TabIndex = 21;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(75, 460);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(167, 62);
            this.buttonExit.TabIndex = 22;
            this.buttonExit.Text = "Salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonNextForm
            // 
            this.buttonNextForm.Location = new System.Drawing.Point(441, 460);
            this.buttonNextForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNextForm.Name = "buttonNextForm";
            this.buttonNextForm.Size = new System.Drawing.Size(167, 62);
            this.buttonNextForm.TabIndex = 23;
            this.buttonNextForm.Text = "IR a Resultados";
            this.buttonNextForm.UseVisualStyleBackColor = true;
            this.buttonNextForm.Click += new System.EventHandler(this.buttonNextForm_Click);
            // 
            // comboBoxEquipoGol
            // 
            this.comboBoxEquipoGol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEquipoGol.FormattingEnabled = true;
            this.comboBoxEquipoGol.Location = new System.Drawing.Point(255, 98);
            this.comboBoxEquipoGol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEquipoGol.Name = "comboBoxEquipoGol";
            this.comboBoxEquipoGol.Size = new System.Drawing.Size(231, 28);
            this.comboBoxEquipoGol.TabIndex = 24;
            // 
            // comboBoxName
            // 
            this.comboBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(975, 63);
            this.comboBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(180, 28);
            this.comboBoxName.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(787, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Nombre Futbolista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1217, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 40);
            this.label6.TabIndex = 51;
            this.label6.Text = "Mostrar Propietario \r\n  Con Cuota Mayor";
            // 
            // labelMenor
            // 
            this.labelMenor.AutoSize = true;
            this.labelMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenor.Location = new System.Drawing.Point(1208, 171);
            this.labelMenor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMenor.Name = "labelMenor";
            this.labelMenor.Size = new System.Drawing.Size(187, 20);
            this.labelMenor.TabIndex = 50;
            this.labelMenor.Text = "Mostrar Cuota Menor";
            // 
            // labelMayor
            // 
            this.labelMayor.AutoSize = true;
            this.labelMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMayor.Location = new System.Drawing.Point(1208, 150);
            this.labelMayor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMayor.Name = "labelMayor";
            this.labelMayor.Size = new System.Drawing.Size(186, 20);
            this.labelMayor.TabIndex = 49;
            this.labelMayor.Text = "Mostrar Cuota Mayor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1105, 128);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 42);
            this.button1.TabIndex = 48;
            this.button1.Text = "Mostrar Datos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1105, 394);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 40);
            this.button2.TabIndex = 47;
            this.button2.Text = "salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonPropietarioCuotaAlta
            // 
            this.buttonPropietarioCuotaAlta.Location = new System.Drawing.Point(1105, 325);
            this.buttonPropietarioCuotaAlta.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPropietarioCuotaAlta.Name = "buttonPropietarioCuotaAlta";
            this.buttonPropietarioCuotaAlta.Size = new System.Drawing.Size(95, 52);
            this.buttonPropietarioCuotaAlta.TabIndex = 46;
            this.buttonPropietarioCuotaAlta.Text = "Ordenar por Propietario con Cuota mas Alta";
            this.buttonPropietarioCuotaAlta.UseVisualStyleBackColor = true;
            // 
            // buttonOrdanar3alta3Baja
            // 
            this.buttonOrdanar3alta3Baja.Location = new System.Drawing.Point(1105, 267);
            this.buttonOrdanar3alta3Baja.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOrdanar3alta3Baja.Name = "buttonOrdanar3alta3Baja";
            this.buttonOrdanar3alta3Baja.Size = new System.Drawing.Size(95, 41);
            this.buttonOrdanar3alta3Baja.TabIndex = 45;
            this.buttonOrdanar3alta3Baja.Text = "Mostrar Mayor Menor";
            this.buttonOrdanar3alta3Baja.UseVisualStyleBackColor = true;
            // 
            // buttonCuotaxMantenimiento
            // 
            this.buttonCuotaxMantenimiento.Location = new System.Drawing.Point(1105, 197);
            this.buttonCuotaxMantenimiento.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCuotaxMantenimiento.Name = "buttonCuotaxMantenimiento";
            this.buttonCuotaxMantenimiento.Size = new System.Drawing.Size(95, 42);
            this.buttonCuotaxMantenimiento.TabIndex = 44;
            this.buttonCuotaxMantenimiento.Text = "Ordanar por Cuota";
            this.buttonCuotaxMantenimiento.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPropietarios
            // 
            this.dataGridViewPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPropietarios.Location = new System.Drawing.Point(685, 157);
            this.dataGridViewPropietarios.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPropietarios.Name = "dataGridViewPropietarios";
            this.dataGridViewPropietarios.RowHeadersWidth = 51;
            this.dataGridViewPropietarios.Size = new System.Drawing.Size(397, 277);
            this.dataGridViewPropietarios.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 594);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelMenor);
            this.Controls.Add(this.labelMayor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonPropietarioCuotaAlta);
            this.Controls.Add(this.buttonOrdanar3alta3Baja);
            this.Controls.Add(this.buttonCuotaxMantenimiento);
            this.Controls.Add(this.dataGridViewPropietarios);
            this.Controls.Add(this.comboBoxEquipoGol);
            this.Controls.Add(this.buttonNextForm);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.numericUDGolesAnotados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTPFechaJuego);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.dataGridViewMostrar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDGolesAnotados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropietarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewMostrar;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.DateTimePicker dateTPFechaJuego;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUDGolesAnotados;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonNextForm;
        private System.Windows.Forms.ComboBox comboBoxEquipoGol;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMenor;
        private System.Windows.Forms.Label labelMayor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonPropietarioCuotaAlta;
        private System.Windows.Forms.Button buttonOrdanar3alta3Baja;
        private System.Windows.Forms.Button buttonCuotaxMantenimiento;
        private System.Windows.Forms.DataGridView dataGridViewPropietarios;
    }
}

