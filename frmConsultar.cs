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
        clsLocalidades objLocalidades = new clsLocalidades();
        clsEncuestas objEncuestas = new clsEncuestas();
        clsProfesiones objProfesiones = new clsProfesiones();

        public frmConsultar()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvGrilla.Rows.Clear();
            dgvGrilla.Columns.Clear();
            DataTable tablaProfesiones = objProfesiones.getAll();
            foreach (DataRow filaProfesiones in tablaProfesiones.Rows)
            {
                string nombre = filaProfesiones["nombre"].ToString();
                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                columna.Name = nombre;
                columna.HeaderText = nombre;
                dgvGrilla.Columns.Add(columna);
            }


            DataTable tablaLocalidades = objLocalidades.getAll();
            foreach (DataRow filaLocalidades in tablaLocalidades.Rows)
            {
                string nombre = filaLocalidades["nombre"].ToString();
                DataGridViewRow filas = new DataGridViewRow();
                filas.HeaderCell.Value = nombre;
                dgvGrilla.Rows.Add(filas);

            }
            dgvGrilla.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            DataTable tablaEncuesta = objEncuestas.getAll();
            foreach (DataRow filaEncuestas in tablaEncuesta.Rows)
            {
                string nombreProduccion = filaEncuestas["localidad"].ToString();
                string nombreCultivoProduccion = filaEncuestas["profesion"].ToString();
                string cantidadProduccion = filaEncuestas["cantidad"].ToString();


                for (int ifila = 0; ifila < dgvGrilla.Rows.Count + 1; ifila++)
                {
                    for (int iColumna = 0; iColumna < dgvGrilla.Columns.Count + 1; iColumna++)
                    {
                        if (Convert.ToInt32(filaEncuestas["localidad"]) == ifila && Convert.ToInt32(filaEncuestas["profesion"]) == iColumna)
                        {
                            dgvGrilla.Rows[ifila - 1].Cells[iColumna - 1].Value = filaEncuestas["cantidad"];
                        }
                    }
                }
            }
        }
    }
}
