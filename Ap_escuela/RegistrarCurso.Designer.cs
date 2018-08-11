namespace Ap_escuela
{
    partial class RegistrarCurso
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtnombrecurso = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtdni = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtidcurso = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbnumerogrupo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtcosto = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.btnguardar = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnbuscar = new DevComponents.DotNetBar.ButtonX();
            this.cbsemestre = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.btnbuscarsemestre = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(45, 42);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(106, 23);
            this.labelX1.TabIndex = 30;
            this.labelX1.Text = "Id Curso:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(45, 89);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(106, 23);
            this.labelX2.TabIndex = 35;
            this.labelX2.Text = "Nombre Curso:";
            // 
            // txtnombrecurso
            // 
            this.txtnombrecurso.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtnombrecurso.Border.Class = "TextBoxBorder";
            this.txtnombrecurso.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnombrecurso.DisabledBackColor = System.Drawing.Color.White;
            this.txtnombrecurso.ForeColor = System.Drawing.Color.Black;
            this.txtnombrecurso.Location = new System.Drawing.Point(179, 92);
            this.txtnombrecurso.Name = "txtnombrecurso";
            this.txtnombrecurso.PreventEnterBeep = true;
            this.txtnombrecurso.Size = new System.Drawing.Size(100, 22);
            this.txtnombrecurso.TabIndex = 38;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(45, 168);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(106, 23);
            this.labelX3.TabIndex = 37;
            this.labelX3.Text = "Numero de Grupo:";
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
            this.txtdni.Location = new System.Drawing.Point(179, 246);
            this.txtdni.Name = "txtdni";
            this.txtdni.PreventEnterBeep = true;
            this.txtdni.Size = new System.Drawing.Size(100, 22);
            this.txtdni.TabIndex = 40;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(45, 243);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(106, 23);
            this.labelX4.TabIndex = 39;
            this.labelX4.Text = "Dni Docente:";
            // 
            // txtidcurso
            // 
            this.txtidcurso.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtidcurso.Border.Class = "TextBoxBorder";
            this.txtidcurso.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtidcurso.DisabledBackColor = System.Drawing.Color.Gray;
            this.txtidcurso.Enabled = false;
            this.txtidcurso.ForeColor = System.Drawing.Color.Black;
            this.txtidcurso.Location = new System.Drawing.Point(179, 45);
            this.txtidcurso.Name = "txtidcurso";
            this.txtidcurso.PreventEnterBeep = true;
            this.txtidcurso.Size = new System.Drawing.Size(100, 22);
            this.txtidcurso.TabIndex = 41;
            // 
            // cbnumerogrupo
            // 
            this.cbnumerogrupo.DisplayMember = "Text";
            this.cbnumerogrupo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbnumerogrupo.ForeColor = System.Drawing.Color.Black;
            this.cbnumerogrupo.FormattingEnabled = true;
            this.cbnumerogrupo.ItemHeight = 16;
            this.cbnumerogrupo.Location = new System.Drawing.Point(179, 168);
            this.cbnumerogrupo.Name = "cbnumerogrupo";
            this.cbnumerogrupo.Size = new System.Drawing.Size(121, 22);
            this.cbnumerogrupo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbnumerogrupo.TabIndex = 42;
            // 
            // txtcosto
            // 
            this.txtcosto.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcosto.Border.Class = "TextBoxBorder";
            this.txtcosto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcosto.DisabledBackColor = System.Drawing.Color.White;
            this.txtcosto.ForeColor = System.Drawing.Color.Black;
            this.txtcosto.Location = new System.Drawing.Point(179, 211);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.PreventEnterBeep = true;
            this.txtcosto.Size = new System.Drawing.Size(100, 22);
            this.txtcosto.TabIndex = 45;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(45, 208);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(106, 23);
            this.labelX5.TabIndex = 44;
            this.labelX5.Text = "Costo curso:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.Image = global::Ap_escuela.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(460, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 54);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnguardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnguardar.Image = global::Ap_escuela.Properties.Resources.Guardar;
            this.btnguardar.Location = new System.Drawing.Point(460, 71);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(150, 54);
            this.btnguardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnguardar.TabIndex = 33;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
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
            this.dataGridViewX1.Location = new System.Drawing.Point(45, 301);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.Size = new System.Drawing.Size(565, 94);
            this.dataGridViewX1.TabIndex = 46;
            // 
            // btnbuscar
            // 
            this.btnbuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnbuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnbuscar.Location = new System.Drawing.Point(323, 246);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnbuscar.TabIndex = 47;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // cbsemestre
            // 
            this.cbsemestre.DisplayMember = "Text";
            this.cbsemestre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbsemestre.ForeColor = System.Drawing.Color.Black;
            this.cbsemestre.FormattingEnabled = true;
            this.cbsemestre.ItemHeight = 16;
            this.cbsemestre.Location = new System.Drawing.Point(179, 131);
            this.cbsemestre.Name = "cbsemestre";
            this.cbsemestre.Size = new System.Drawing.Size(121, 22);
            this.cbsemestre.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbsemestre.TabIndex = 49;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(45, 131);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(106, 23);
            this.labelX6.TabIndex = 48;
            this.labelX6.Text = "Semestre";
            // 
            // btnbuscarsemestre
            // 
            this.btnbuscarsemestre.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnbuscarsemestre.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnbuscarsemestre.Location = new System.Drawing.Point(333, 131);
            this.btnbuscarsemestre.Name = "btnbuscarsemestre";
            this.btnbuscarsemestre.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarsemestre.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnbuscarsemestre.TabIndex = 50;
            this.btnbuscarsemestre.Text = "Buscar";
            this.btnbuscarsemestre.Click += new System.EventHandler(this.btnbuscarsemestre_Click);
            // 
            // RegistrarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 425);
            this.Controls.Add(this.btnbuscarsemestre);
            this.Controls.Add(this.cbsemestre);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbnumerogrupo);
            this.Controls.Add(this.txtidcurso);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtnombrecurso);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RegistrarCurso";
            this.Text = "Agregar Curso";
            this.Load += new System.EventHandler(this.RegistrarCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnguardar;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnombrecurso;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdni;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtidcurso;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbnumerogrupo;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcosto;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.ButtonX btnbuscar;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbsemestre;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX btnbuscarsemestre;
    }
}