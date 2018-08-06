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
            
            
            
            
            
            /*ESTE ES EL CODIGO ORIGINAL -- FUNCIONA
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
            */




            //Exporting to PDF
            string folderPath = @"D:\Log\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Compromisopago.pdf", FileMode.Create))
            {

                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);

                //Creating iTextSharp Table from the DataTable data
                PdfPTable pdfTable = new PdfPTable(dgw.ColumnCount);

                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;

                iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.HELVETICA, 8, iTextSharp.text.Font.NORMAL);
                
                Document doc = new Document(PageSize.A4, 80f, 100f, 100f, 0f);
                // Escribimos el encabezamiento en el documento
                doc.Open();
                //doc.Add(new Paragraph("Mi primer documento PDF"));
                //doc.Add(Chunk.NEWLINE);

                // Creamos una tabla que contendrá el nombre, apellido y país
                // de nuestros visitante.
                PdfPTable tblPrueba = new PdfPTable(3);
                tblPrueba.WidthPercentage = 100;

                // Configuramos el título de las columnas de la tabla
                PdfPCell clDni = new PdfPCell(new Phrase("dni", _standardFont));
                clDni.BorderWidth = 0;
                clDni.BorderWidthBottom = 0.75f;

                PdfPCell clNombre = new PdfPCell(new Phrase("nombre", _standardFont));
                clNombre.BorderWidth = 0;
                clNombre.BorderWidthBottom = 0.75f;

                PdfPCell clAppat = new PdfPCell(new Phrase("Appat", _standardFont));
                clAppat.BorderWidth = 0;
                clAppat.BorderWidthBottom = 0.75f;

                PdfPCell clApmat = new PdfPCell(new Phrase("apmat", _standardFont));
                clApmat.BorderWidth = 0;
                clApmat.BorderWidthBottom = 0.75f;

                PdfPCell clfecha_nac = new PdfPCell(new Phrase("fecha_nac", _standardFont));
                clfecha_nac.BorderWidth = 0;
                clfecha_nac.BorderWidthBottom = 0.75f;

                PdfPCell clTelefono = new PdfPCell(new Phrase("telefono", _standardFont));
                clTelefono.BorderWidth = 0;
                clTelefono.BorderWidthBottom = 0.75f;

                PdfPCell clCorreo = new PdfPCell(new Phrase("correo", _standardFont));
                clCorreo.BorderWidth = 0;
                clCorreo.BorderWidthBottom = 0.75f;


                PdfPCell clDireccion = new PdfPCell(new Phrase("direccion", _standardFont));
                clDireccion.BorderWidth = 0;
                clDireccion.BorderWidthBottom = 0.75f;

                // Añadimos las celdas a la tabla
                tblPrueba.AddCell(clDni);
                tblPrueba.AddCell(clNombre);
                tblPrueba.AddCell(clAppat);
                tblPrueba.AddCell(clApmat);
                tblPrueba.AddCell(clfecha_nac);
                tblPrueba.AddCell(clTelefono);
                tblPrueba.AddCell(clCorreo);
                tblPrueba.AddCell(clDireccion);

                // Llenamos la tabla con información
                clDni = new PdfPCell(new Phrase(dni, _standardFont));
                clDni.BorderWidth = 0;

                clNombre = new PdfPCell(new Phrase(nombre, _standardFont));
                clNombre.BorderWidth = 0;

                clAppat = new PdfPCell(new Phrase(appat, _standardFont));
                clAppat.BorderWidth = 0;

                clApmat = new PdfPCell(new Phrase(apmat, _standardFont));
                clApmat.BorderWidth = 0;

                clfecha_nac = new PdfPCell(new Phrase(fecha_nac, _standardFont));
                clfecha_nac.BorderWidth = 0;

                clTelefono = new PdfPCell(new Phrase(telefono, _standardFont));
                clTelefono.BorderWidth = 0;

                clCorreo = new PdfPCell(new Phrase(correo, _standardFont));
                clCorreo.BorderWidth = 0;

                clDireccion = new PdfPCell(new Phrase(direccion, _standardFont));
                clDireccion.BorderWidth = 0;

                // Añadimos las celdas a la tabla
                tblPrueba.AddCell(clDni);
                tblPrueba.AddCell(clNombre);
                tblPrueba.AddCell(clAppat);
                tblPrueba.AddCell(clApmat);
                tblPrueba.AddCell(clfecha_nac);
                tblPrueba.AddCell(clTelefono);
                tblPrueba.AddCell(clCorreo);
                tblPrueba.AddCell(clDireccion);


                doc.Add(tblPrueba);
                doc.Close();

                //writer.Close();
                stream.Close();

            }












                /*Document pdfDoc = new Document(PageSize.A4, 80f, 100f, 100f, 0f);
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
            }*/
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
            //exportargrilla(dataGridViewX1, "Alumnos");


            //PdfPTable pdfTable = new PdfPTable(dataGridViewX1.ColumnCount);
            PdfPTable tblPrueba = new PdfPTable(8);

            tblPrueba.DefaultCell.Padding = 3;
            tblPrueba.WidthPercentage = 100;
            tblPrueba.HorizontalAlignment = Element.ALIGN_LEFT;
            tblPrueba.DefaultCell.BorderWidth = 1;

            //iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.HELVETICA, 8, iTextSharp.text.Font.NORMAL);

            Document doc = new Document(PageSize.A4, 80f, 100f, 100f, 0f);
            // Escribimos el encabezamiento en el documento
            //Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc,
                                        new FileStream(@"D:\log\prueba.pdf", FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento

            // Abrimos el archivo
            doc.Open();
            doc.Add(new Paragraph("TITULO"));
            //doc.Add(Chunk.NEWLINE);

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            //PdfPTable tblPrueba = new PdfPTable(6);
            tblPrueba.WidthPercentage = 75;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clDni = new PdfPCell(new Phrase("dni", _standardFont));
            clDni.BorderWidth = 0;
            clDni.BorderWidthBottom = 0.75f;
            
            PdfPCell clNombre = new PdfPCell(new Phrase("nombre", _standardFont));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell clAppat = new PdfPCell(new Phrase("Appat", _standardFont));
            clAppat.BorderWidth = 0;
            clAppat.BorderWidthBottom = 0.75f;

            PdfPCell clApmat = new PdfPCell(new Phrase("apmat", _standardFont));
            clApmat.BorderWidth = 0;
            clApmat.BorderWidthBottom = 0.75f;

            PdfPCell clfecha_nac = new PdfPCell(new Phrase("fecha_nac", _standardFont));
            clfecha_nac.BorderWidth = 0;
            clfecha_nac.BorderWidthBottom = 0.75f;

            PdfPCell clTelefono = new PdfPCell(new Phrase("telefono", _standardFont));
            clTelefono.BorderWidth = 0;
            clTelefono.BorderWidthBottom = 0.75f;

            PdfPCell clCorreo = new PdfPCell(new Phrase("correo", _standardFont));
            clCorreo.BorderWidth = 0;
            clCorreo.BorderWidthBottom = 0.75f;


            PdfPCell clDireccion = new PdfPCell(new Phrase("direccion", _standardFont));
            clDireccion.BorderWidth = 0;
            clDireccion.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clDni);
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clAppat);
            tblPrueba.AddCell(clApmat);
            tblPrueba.AddCell(clfecha_nac);
            tblPrueba.AddCell(clTelefono);
            tblPrueba.AddCell(clCorreo);
            tblPrueba.AddCell(clDireccion);

            // Llenamos la tabla con información
            clDni = new PdfPCell(new Phrase(dni, _standardFont));
            clDni.BorderWidth = 0;

            clNombre = new PdfPCell(new Phrase(nombre, _standardFont));
            clNombre.BorderWidth = 0;

            clAppat = new PdfPCell(new Phrase(appat, _standardFont));
            clAppat.BorderWidth = 0;

            clApmat = new PdfPCell(new Phrase(apmat, _standardFont));
            clApmat.BorderWidth = 0;

            clfecha_nac = new PdfPCell(new Phrase(fecha_nac, _standardFont));
            clfecha_nac.BorderWidth = 0;

            clTelefono = new PdfPCell(new Phrase(telefono, _standardFont));
            clTelefono.BorderWidth = 0;

            clCorreo = new PdfPCell(new Phrase(correo, _standardFont));
            clCorreo.BorderWidth = 0;

            clDireccion = new PdfPCell(new Phrase(direccion, _standardFont));
            clDireccion.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clDni);
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clAppat);
            tblPrueba.AddCell(clApmat);
            tblPrueba.AddCell(clfecha_nac);
            tblPrueba.AddCell(clTelefono);
            tblPrueba.AddCell(clCorreo);
            tblPrueba.AddCell(clDireccion);


            doc.Add(tblPrueba);
            doc.Close();
            writer.Close();



        }

        string dni;
        string nombre;
        string appat;
        string apmat;
        string fecha_nac;
        string telefono;
        string correo;
        string direccion;

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*string dni;
            string nombre;
            string appat;
            string apmat;
            string fecha_nac;
            string telefono;
            string correo;
            string direccion;*/
            dni = Convert.ToString((String)dataGridViewX1.CurrentRow.Cells[0].Value.ToString()); //CurrentCell.Value.ToString(); //Rows[0].Cells[0].Value.ToString();
            nombre = (String)dataGridViewX1.CurrentRow.Cells[1].Value; //.CurrentCell.Value.ToString();
            appat = (String)dataGridViewX1.CurrentRow.Cells[2].Value;
            apmat = (String)dataGridViewX1.CurrentRow.Cells[3].Value;
            fecha_nac = Convert.ToString((String)dataGridViewX1.CurrentRow.Cells[4].Value.ToString());
            telefono = Convert.ToString((String)dataGridViewX1.CurrentRow.Cells[5].Value.ToString());
            correo = (String)dataGridViewX1.CurrentRow.Cells[6].Value;
            direccion = (String)dataGridViewX1.CurrentRow.Cells[7].Value;

            txtnombre.Text = (String)dataGridViewX1.CurrentRow.Cells[1].Value;
            /*txtidcurso.Text = dato;
            txtnombrecurso.Text = dato2;
            txtnumerogrupo.Text = dato3;*/
        }
    }
}