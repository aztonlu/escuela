namespace Ap_escuela
{
    partial class AgregarMatricula
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
            this.txtdni = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnguardar = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbnumerogrupo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbidcurso = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.cbnombrecurso = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtidcurso = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtnombrecurso = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtnumerogrupo = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
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
            this.txtdni.Location = new System.Drawing.Point(167, 203);
            this.txtdni.Name = "txtdni";
            this.txtdni.PreventEnterBeep = true;
            this.txtdni.Size = new System.Drawing.Size(100, 22);
            this.txtdni.TabIndex = 49;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(33, 200);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(106, 23);
            this.labelX4.TabIndex = 48;
            this.labelX4.Text = "Dni Alumno:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(33, 52);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(106, 23);
            this.labelX3.TabIndex = 46;
            this.labelX3.Text = "Numero de Grupo:";
            // 
            // btnguardar
            // 
            this.btnguardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnguardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnguardar.Location = new System.Drawing.Point(486, 91);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(150, 54);
            this.btnguardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnguardar.TabIndex = 43;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(33, 93);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(106, 23);
            this.labelX1.TabIndex = 42;
            this.labelX1.Text = "Id Curso:";
            // 
            // cbnumerogrupo
            // 
            this.cbnumerogrupo.DisplayMember = "Text";
            this.cbnumerogrupo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbnumerogrupo.ForeColor = System.Drawing.Color.Black;
            this.cbnumerogrupo.FormattingEnabled = true;
            this.cbnumerogrupo.ItemHeight = 16;
            this.cbnumerogrupo.Location = new System.Drawing.Point(167, 52);
            this.cbnumerogrupo.Name = "cbnumerogrupo";
            this.cbnumerogrupo.Size = new System.Drawing.Size(121, 22);
            this.cbnumerogrupo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbnumerogrupo.TabIndex = 51;
            // 
            // cbidcurso
            // 
            this.cbidcurso.DisplayMember = "Text";
            this.cbidcurso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbidcurso.ForeColor = System.Drawing.Color.Black;
            this.cbidcurso.FormattingEnabled = true;
            this.cbidcurso.ItemHeight = 16;
            this.cbidcurso.Location = new System.Drawing.Point(167, 93);
            this.cbidcurso.Name = "cbidcurso";
            this.cbidcurso.Size = new System.Drawing.Size(121, 22);
            this.cbidcurso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbidcurso.TabIndex = 52;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpiar.Location = new System.Drawing.Point(486, 167);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 54);
            this.btnLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpiar.TabIndex = 53;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cbnombrecurso
            // 
            this.cbnombrecurso.DisplayMember = "Text";
            this.cbnombrecurso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbnombrecurso.ForeColor = System.Drawing.Color.Black;
            this.cbnombrecurso.FormattingEnabled = true;
            this.cbnombrecurso.ItemHeight = 16;
            this.cbnombrecurso.Location = new System.Drawing.Point(167, 133);
            this.cbnombrecurso.Name = "cbnombrecurso";
            this.cbnombrecurso.Size = new System.Drawing.Size(121, 22);
            this.cbnombrecurso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbnombrecurso.TabIndex = 55;
            this.cbnombrecurso.SelectedIndexChanged += new System.EventHandler(this.cbnombrecurso_SelectedIndexChanged);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(33, 133);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(106, 23);
            this.labelX2.TabIndex = 54;
            this.labelX2.Text = "Nombre Curso:";
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
            this.dataGridViewX1.Location = new System.Drawing.Point(75, 249);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(517, 154);
            this.dataGridViewX1.TabIndex = 56;
            this.dataGridViewX1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellClick);
            this.dataGridViewX1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellContentClick);
            this.dataGridViewX1.SelectionChanged += new System.EventHandler(this.dataGridViewX1_SelectionChanged);
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
            this.txtidcurso.ForeColor = System.Drawing.Color.Black;
            this.txtidcurso.Location = new System.Drawing.Point(337, 96);
            this.txtidcurso.Name = "txtidcurso";
            this.txtidcurso.PreventEnterBeep = true;
            this.txtidcurso.Size = new System.Drawing.Size(100, 22);
            this.txtidcurso.TabIndex = 57;
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
            this.txtnombrecurso.Location = new System.Drawing.Point(337, 133);
            this.txtnombrecurso.Name = "txtnombrecurso";
            this.txtnombrecurso.PreventEnterBeep = true;
            this.txtnombrecurso.ReadOnly = true;
            this.txtnombrecurso.Size = new System.Drawing.Size(100, 22);
            this.txtnombrecurso.TabIndex = 58;
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
            this.txtnumerogrupo.ForeColor = System.Drawing.Color.Black;
            this.txtnumerogrupo.Location = new System.Drawing.Point(337, 52);
            this.txtnumerogrupo.Name = "txtnumerogrupo";
            this.txtnumerogrupo.PreventEnterBeep = true;
            this.txtnumerogrupo.Size = new System.Drawing.Size(100, 22);
            this.txtnumerogrupo.TabIndex = 59;
            // 
            // AgregarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 449);
            this.Controls.Add(this.txtnumerogrupo);
            this.Controls.Add(this.txtnombrecurso);
            this.Controls.Add(this.txtidcurso);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.cbnombrecurso);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cbidcurso);
            this.Controls.Add(this.cbnumerogrupo);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AgregarMatricula";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.AgregarMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtdni;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnguardar;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbnumerogrupo;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbidcurso;
        private DevComponents.DotNetBar.ButtonX btnLimpiar;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbnombrecurso;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtidcurso;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnombrecurso;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnumerogrupo;
    }
}