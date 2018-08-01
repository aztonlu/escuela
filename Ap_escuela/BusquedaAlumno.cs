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
    public partial class BusquedaAlumno : DevComponents.DotNetBar.Metro.MetroForm
    {
        public BusquedaAlumno()
        {
            InitializeComponent();
        }
        public Alumno AlumnoSeleccionado { get; set; }
        public Persona personaSeleccionado { get; set; }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //dataGridViewX1.DataSource =  AlumnoDAL.BuscarAlumnos(txtdni.Text);
            //int dni = 85245;
            int dni = Convert.ToInt32(txtdni.Text);
            AlumnoDAL alu = new AlumnoDAL();
            alu.Buscar(dni, dataGridViewX1); //AlumnoDAL.Buscar(dataGridViewX1);
        }

        public void exportargrilla(DataGridView dgw, string filename)
        {
             //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dgw.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        pdfTable.AddCell(cell.Value.ToString());
            //    }
            //}
            int row = dgw.Rows.Count;
            int cell2 = dgw.Rows[1].Cells.Count; 
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < cell2; j++)
                {
                    if (dgw.Rows[i].Cells[j].Value == null)
                    {
                        //return directly
                        //return;
                        //or set a value for the empty data
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
            using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
            MessageBox.Show("Done");
        }
            
            /*{
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable table = new PdfPTable(dgw.Columns.Count);
            //PdfTable pdftable = new PdfTable(dgw.Columns.Count);
            table.DefaultCell.Padding = 3;
            table.WidthPercentage = 100;
            table.HorizontalAlignment = Element.ALIGN_LEFT;
            table.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            //cabecera
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                table.AddCell(cell);
            }

            //agregar el datarow


            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
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

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("D://logo.png");

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
        }*/




        private void btnExportar_Click(object sender, EventArgs e)
        {
            exportargrilla(dataGridViewX1, "Alumnos");
            
            
            /*string FilePath = MapPath("~/File/MyReport.pdf");

            iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 20f, 20f, 20f, 20f);
            PdfWriter.GetInstance(pdfDoc, new FileStream(FilePath, FileMode.Create));
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);

            GridView1.AllowPaging = false;
            GridView1.HeaderRow.Cells[1].Text = "Message";
            GridView1.HeaderRow.Font.Bold = true;
            GridView1.RenderControl(hw);

            StringReader sr = new StringReader(sw.ToString());
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();

            Response.Write(pdfDoc);

            Response.ContentType = "Application/pdf";
            Response.WriteFile(FilePath);
            Response.End();*/

            /*Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("d:\\Test.pdf", FileMode.Create));

            doc.Open();//Open Document to write


                Paragraph paragraph = new Paragraph("data Exported From DataGridview!");

                //Create table by setting table value

                Table t1 = new Table(2);
                DataTable dt = (DataTable)dataGridViewX1.DataSource;

                //Create Table Header

                Cell cid = new Cell("ID");
                Cell cname = new Cell("Name");

                t1.AddCell(cid);
                t1.AddCell(cname);

                foreach (DataGridViewRow rows in dataGridViewX1.Rows)
                {

                string id = dataGridViewX1.Rows[rows.Index].Cells["empid"].Value.ToString();
                string name = dataGridViewX1.Rows[rows.Index].Cells["ename"].Value.ToString();
                //Create Cells
                Cell c2 = new Cell(id);
                Cell c1 = new Cell(name);
                //Adding cells
                t1.AddCell(c1);
                t1.AddCell(c2);

                } 
                doc.Add(paragraph);
                doc.Add(t1);
                doc.Close(); //Close document
                //
                MessageBox.Show("PDF Created!");*/


        }
    }
}