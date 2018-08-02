using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Ap_escuela
{
    public partial class Compromisopago : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Compromisopago()
        {
            InitializeComponent();
        }

        public void exportargrilla(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);

            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dgw.ColumnCount);

            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            //Adding Header row
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }

            int row = dgw.Rows.Count;
            int cell2 = dgw.Rows[1].Cells.Count;
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < cell2; j++)
                {
                    if (dgw.Rows[i].Cells[j].Value == null)
                    {

                        dgw.Rows[i].Cells[j].Value = "null";
                    }
                    pdfTable.AddCell(dgw.Rows[i].Cells[j].Value.ToString());
                }
            }

            //Exporting to PDF
            string folderPath = @"D:\Log\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Compromisopago.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 80f, 100f, 100f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("D://logo.png");
                iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance("D://CEAlogo.png");
                //Resize image depend upon your need

                img.ScaleToFit(100f, 80f);
                img2.ScaleToFit(350f, 330f);
                //Give space before image

                img.SpacingBefore = 20f;
                img2.SpacingBefore = 20f;

                //Give some space after the image

                img.SpacingAfter = 1f;
                img2.SpacingAfter = 1f;

                //img.Alignment = Element.ALIGN_LEFT;
                img.Alignment = Element.ALIGN_CENTER;
                img2.Alignment = Element.ALIGN_CENTER;
                //Imagen - Esquina inferior izquierda
                img.SetAbsolutePosition(50, 800);
                img2.SetAbsolutePosition(150, 750);
                //pdfDoc.Add(img);
                pdfDoc.Add(img2);

                //CellHeight generadorTablas = new CellHeight();
                //Table tablaChica = generadorTablas.crearTablaConAtura(12f);
                // Cambiamos el tamaño de texto
                //tablaChica.setFontSize(8f);

                pdfDoc.Add(new Paragraph("CARTA DE COMPROMISO"));
                pdfDoc.Add(new Paragraph("------------------------"));
                pdfDoc.Add(new Paragraph(""));
                //doc.add(tablaChica);

                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
            MessageBox.Show("Done");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //dataGridViewX1.DataSource =  AlumnoDAL.BuscarAlumnos(txtdni.Text);
            //int dni = 85245;
            int dni = Convert.ToInt32(txtdni.Text);
            AlumnoDAL alu = new AlumnoDAL();
            alu.Buscar(dni, dataGridViewX1); //AlumnoDAL.Buscar(dataGridViewX1);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            exportargrilla(dataGridViewX1, "Alumnos");
        }
    }
}