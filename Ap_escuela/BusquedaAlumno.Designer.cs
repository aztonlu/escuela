namespace Ap_escuela
{
    partial class BusquedaAlumno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtnombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdni = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnbuscar = new DevComponents.DotNetBar.ButtonX();
            this.btnExportar = new DevComponents.DotNetBar.ButtonX();
            this.cbsemestre = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtidcurso = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtnumerogrupo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX2 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtnombre.Border.Class = "TextBoxBorder";
            this.txtnombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnombre.DisabledBackColor = System.Drawing.Color.White;
            this.txtnombre.ForeColor = System.Drawing.Color.Black;
            this.txtnombre.Location = new System.Drawing.Point(685, 205);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PreventEnterBeep = true;
            this.txtnombre.Size = new System.Drawing.Size(100, 22);
            this.txtnombre.TabIndex = 15;
            // 
            // txtdni
            // 
            this.txtdni.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtdni.Border.Class = "TextBoxBorder";
            this.txtdni.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdni.DisabledBackColor = System.Drawing.Color.White;
            this.txtdni.ForeColor = System.Drawing.Color.Black;
            this.txtdni.Location = new System.Drawing.Point(266, 80);
            this.txtdni.Name = "txtdni";
            this.txtdni.PreventEnterBeep = true;
            this.txtdni.Size = new System.Drawing.Size(100, 22);
            this.txtdni.TabIndex = 14;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(551, 205);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "Nombre";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(135, 77);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "Dni Alumno:";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(93, 263);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(692, 330);
            this.dataGridViewX1.TabIndex = 16;
            // 
            // btnbuscar
            // 
            this.btnbuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnbuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnbuscar.Location = new System.Drawing.Point(392, 79);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnbuscar.TabIndex = 17;
            this.btnbuscar.Text = "buscar";
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExportar.Location = new System.Drawing.Point(402, 122);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExportar.TabIndex = 18;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // cbsemestre
            // 
            this.cbsemestre.DisplayMember = "Text";
            this.cbsemestre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbsemestre.ForeColor = System.Drawing.Color.Black;
            this.cbsemestre.FormattingEnabled = true;
            this.cbsemestre.ItemHeight = 16;
            this.cbsemestre.Location = new System.Drawing.Point(266, 49);
            this.cbsemestre.Name = "cbsemestre";
            this.cbsemestre.Size = new System.Drawing.Size(121, 22);
            this.cbsemestre.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbsemestre.TabIndex = 19;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(135, 48);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 20;
            this.labelX3.Text = "Semestre:";
            // 
            // txtidcurso
            // 
            this.txtidcurso.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtidcurso.Border.Class = "TextBoxBorder";
            this.txtidcurso.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtidcurso.DisabledBackColor = System.Drawing.Color.White;
            this.txtidcurso.Enabled = false;
            this.txtidcurso.ForeColor = System.Drawing.Color.Black;
            this.txtidcurso.Location = new System.Drawing.Point(266, 162);
            this.txtidcurso.Name = "txtidcurso";
            this.txtidcurso.PreventEnterBeep = true;
            this.txtidcurso.Size = new System.Drawing.Size(100, 22);
            this.txtidcurso.TabIndex = 54;
            // 
            // txtnumerogrupo
            // 
            this.txtnumerogrupo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtnumerogrupo.Border.Class = "TextBoxBorder";
            this.txtnumerogrupo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnumerogrupo.DisabledBackColor = System.Drawing.Color.White;
            this.txtnumerogrupo.Enabled = false;
            this.txtnumerogrupo.ForeColor = System.Drawing.Color.Black;
            this.txtnumerogrupo.Location = new System.Drawing.Point(266, 122);
            this.txtnumerogrupo.Name = "txtnumerogrupo";
            this.txtnumerogrupo.PreventEnterBeep = true;
            this.txtnumerogrupo.Size = new System.Drawing.Size(100, 22);
            this.txtnumerogrupo.TabIndex = 53;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(132, 119);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(106, 23);
            this.labelX4.TabIndex = 52;
            this.labelX4.Text = "Numero de Grupo:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(132, 159);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(106, 23);
            this.labelX5.TabIndex = 51;
            this.labelX5.Text = "Id Curso:";
            // 
            // dataGridViewX2
            // 
            this.dataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewX2.Location = new System.Drawing.Point(573, 32);
            this.dataGridViewX2.Name = "dataGridViewX2";
            this.dataGridViewX2.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewX2.TabIndex = 55;
            // 
            // BusquedaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 605);
            this.Controls.Add(this.dataGridViewX2);
            this.Controls.Add(this.txtidcurso);
            this.Controls.Add(this.txtnumerogrupo);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.cbsemestre);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BusquedaAlumno";
            this.Text = "Reporte Asistencia de alumnos";
            this.Load += new System.EventHandler(this.BusquedaAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtnombre;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdni;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.ButtonX btnbuscar;
        private DevComponents.DotNetBar.ButtonX btnExportar;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbsemestre;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtidcurso;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnumerogrupo;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX2;
    }
}