using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class Form1 : Form
    {
        List<Jugador> jugadores = new List<Jugador>();
        
        List<Resultado> resultadoPartido = new List<Resultado>();

        public Form1()
        {
            InitializeComponent();

            ReadTxtDataJugador();
            ReadTxtGolesAnotados();
        }
        void ReadTxtDataJugador()
        {
            FileStream stream = new FileStream(@"Jugador.txt", FileMode.Open, FileAccess.Read);
          
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Jugador();
                dato.idJugador = partes[0];
                dato.Nombre = partes[1];
                dato.EquipoJu = partes[2];

                jugadores.Add(dato);
            }
            reader.Close();

            comboBoxID.DataSource = jugadores;
            comboBoxID.DisplayMember = "IDjugador";
            comboBoxID.Refresh();

            comboBoxEquipoGol.DataSource = jugadores;
            comboBoxEquipoGol.DisplayMember = "Equipo";
            comboBoxEquipoGol.Refresh();
        }
        private void SaveTxtGolesAnotados()
        {
            FileStream stream = new FileStream(@"GolesAnotados.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (Resultado dato in resultadoPartido)
            {
                var AgregarDatoTxt = dato.idJugador + "|" + dato.FechaDeJuego 
                                         + "|" + dato.NombreOtroEquipo + "|" + dato.Anotaciones;
                writer.WriteLine(AgregarDatoTxt);

                Propiedad propiedad = new Propiedad();
                propiedad.idJudor = reader.ReadLine();
                propiedad.FechaDeJuego = reader.ReadLine();
                propiedad.CuotaMantenimiento = Convert.ToDecimal(reader.ReadLine());

                propiedades.Add(propiedad);
            }
            writer.Close();
        }
        void ReadTxtGolesAnotados()
        {
            FileStream stream = new FileStream(@"GolesAnotados.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Resultado();

                dato.idJugador = partes[0];
                dato.FechaDeJuego = DateTime.Parse(partes[1]);
                dato.NombreOtroEquipo = partes[2];
                dato.Anotaciones = Convert.ToInt32(partes[3]);

                resultadoPartido.Add(dato);
            }
            reader.Close();
        }
        void ActualizarGred()
        {
            dataGridViewMostrar.DataSource = null;
           
            dataGridViewMostrar.Refresh();
           
            dataGridViewMostrar.DataSource = resultadoPartido;
           
            dataGridViewMostrar.Refresh();
        }
        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            Resultado dato = new Resultado();
            dato.idJugador = comboBoxID.Text;
            
            dato.FechaDeJuego = dateTPFechaJuego.Value;
          
            dato.NombreOtroEquipo = comboBoxEquipoGol.Text;
            
            dato.Anotaciones = Convert.ToInt32(numericUDGolesAnotados.Value);

            resultadoPartido.Add(dato);

            SaveTxtGolesAnotados();
            ActualizarGred();
        }

        private void buttonNextForm_Click(object sender, EventArgs e)
        {
            DataFutbolistas form2 = new DataFutbolistas();
            form2.Show();

            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
