using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPractico
{
    public partial class frmConsultar : Form
    {
        clsLocalidades objLocalidades;
        clsEncuestas objEncuestas;
        clsProfesiones objProfesiones;
        int i = 0;
        int c = 0;
        public frmConsultar()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvGrilla.Rows.Clear();
            dgvGrilla.Columns.Clear();

            DataTable tablaProfesiones = objProfesiones.getAll();
            int[] vecProfesiones = new int[0];
            foreach (DataRow filaProfesiones in tablaProfesiones.Rows)
            {
                string nombre = filaProfesiones["nombre"].ToString();
                int numero = (int)filaProfesiones["profesion"];
                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                columna.Name = nombre;
                columna.HeaderText = nombre;
                dgvGrilla.Columns.Add(columna);

                Array.Resize(ref vecProfesiones, vecProfesiones.Length + 1);
                vecProfesiones[vecProfesiones.Length - 1] = numero;
            }


            DataTable tablaLocalidades = objLocalidades.getAll();
            int[] vecLocalidad = new int[0];
            foreach (DataRow filaLocalidades in tablaLocalidades.Rows)
            {
                string nombre = filaLocalidades["nombre"].ToString();
                int numeronombre = (int)filaLocalidades["localidad"];
                DataGridViewRow filas = new DataGridViewRow();
                filas.HeaderCell.Value = nombre;
                dgvGrilla.Rows.Add(filas);

                Array.Resize(ref vecLocalidad, vecLocalidad.Length + 1);
                vecLocalidad[vecLocalidad.Length - 1] = numeronombre;
            }

            dgvGrilla.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            DataTable tablaEncuesta = objEncuestas.getAll();
            foreach (DataRow filaEncuestas in tablaEncuesta.Rows)
            {
                string nombreProduccion = filaEncuestas["localidad"].ToString();
                string nombreCultivoProduccion = filaEncuestas["profesion"].ToString();
                string cantidadProduccion = filaEncuestas["cantidad"].ToString();


                for (int ifila = 0; ifila <= (int)filaEncuestas["localidad"]; ifila++)
                {
                    for (int iColumna = 0; iColumna <= (int)filaEncuestas["profesion"]; iColumna++)
                    {
                        if (Convert.ToInt32(filaEncuestas["localidad"]) == ifila && Convert.ToInt32(filaEncuestas["profesion"]) == iColumna)
                        {
                            while ((int)filaEncuestas["profesion"] != vecProfesiones[c])
                            {
                                c = c + 1;
                            }
                            while ((int)filaEncuestas["localidad"] != vecLocalidad[i])
                            {
                                i = i + 1;
                            }
                            dgvGrilla.Rows[i].Cells[c].Value = filaEncuestas["cantidad"];
                            c = 0;
                            i = 0;

                        }
                    }
                }
            }
        }

        private void frmConsultar_Load(object sender, EventArgs e)
        {
            try
            {
                objLocalidades = new clsLocalidades();
                objEncuestas = new clsEncuestas();
                objProfesiones = new clsProfesiones();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw;
            }
        }
    }
}
