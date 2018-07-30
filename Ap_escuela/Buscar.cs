using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Ap_escuela
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        public Alumno AlumnoSeleccionado { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = AlumnoDAL.BuscarAlumnos(txtNombre.Text, txtApellido.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            /*if (dataGridView1.SelectedRows.Count == 1)
            {
                Int64 Id = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                AlumnoSeleccionado = AlumnoDAL.ObtenerAlumno(Id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado Ningun Alumno");
            }*/

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void exportargrilla(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable table = new PdfPTable(dgw.Columns.Count);  
            //PdfTable pdftable = new PdfTable(dgw.Columns.Count);
            table.DefaultCell.Padding = 3;
            table.WidthPercentage = 100;
            table.HorizontalAlignment = Element.ALIGN_LEFT;
            table.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            //cabecera
            foreach(DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                table.AddCell(cell);
            }

            //agregar el datarow
            foreach(DataGridViewRow row in dgw.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            
            }

            var savefildedialoge = new SaveFileDialog();
            savefildedialoge.FileName = filename;
            savefildedialoge.DefaultExt = ".pdf";
            if (savefildedialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefildedialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                                        
                    iTextSharp.text.Image img =  iTextSharp.text.Image.GetInstance("D://logo.png");                

                    //Resize image depend upon your need

                    img.ScaleToFit(140f, 120f);

                    //Give space before image

                    img.SpacingBefore = 10f;

                    //Give some space after the image

                    img.SpacingAfter = 1f;

                    img.Alignment = Element.ALIGN_LEFT;
                    //Imagen - Esquina inferior izquierda
                    img.SetAbsolutePosition(0, 0);
                    pdfdoc.Add(img);
                    pdfdoc.Add(table);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            exportargrilla(dataGridView1, "Alumnos");
        }

                   
        
    }
}
