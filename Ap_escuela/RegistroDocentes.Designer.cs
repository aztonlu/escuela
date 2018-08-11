namespace Ap_escuela
{
    partial class RegistroDocentes
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
            this.btnlimpiar = new DevComponents.DotNetBar.ButtonX();
            this.monthCalendarAdv1 = new DevComponents.Editors.DateTimeAdv.MonthCalendarAdv();
            this.txtdireccion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtcorreo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txttelefono = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtapmat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtappat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtnombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdni = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btncancelar = new DevComponents.DotNetBar.ButtonX();
            this.btnguardar = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnlimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnlimpiar.Location = new System.Drawing.Point(654, 221);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(150, 54);
            this.btnlimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnlimpiar.TabIndex = 45;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // monthCalendarAdv1
            // 
            this.monthCalendarAdv1.AutoSize = true;
            // 
            // 
            // 
            this.monthCalendarAdv1.BackgroundStyle.Class = "MonthCalendarAdv";
            this.monthCalendarAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.monthCalendarAdv1.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.monthCalendarAdv1.ContainerControlProcessDialogKey = true;
            this.monthCalendarAdv1.DisplayMonth = new System.DateTime(2018, 7, 1, 0, 0, 0, 0);
            this.monthCalendarAdv1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.monthCalendarAdv1.Location = new System.Drawing.Point(488, 64);
            this.monthCalendarAdv1.Name = "monthCalendarAdv1";
            // 
            // 
            // 
            this.monthCalendarAdv1.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.monthCalendarAdv1.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.monthCalendarAdv1.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.monthCalendarAdv1.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.monthCalendarAdv1.Size = new System.Drawing.Size(170, 131);
            this.monthCalendarAdv1.TabIndex = 42;
            this.monthCalendarAdv1.Text = "monthCalendarAdv1";
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtdireccion.Border.Class = "TextBoxBorder";
            this.txtdireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdireccion.DisabledBackColor = System.Drawing.Color.White;
            this.txtdireccion.ForeColor = System.Drawing.Color.Black;
            this.txtdireccion.Location = new System.Drawing.Point(174, 234);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.PreventEnterBeep = true;
            this.txtdireccion.Size = new System.Drawing.Size(100, 22);
            this.txtdireccion.TabIndex = 39;
            // 
            // txtcorreo
            // 
            this.txtcorreo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcorreo.Border.Class = "TextBoxBorder";
            this.txtcorreo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcorreo.DisabledBackColor = System.Drawing.Color.White;
            this.txtcorreo.ForeColor = System.Drawing.Color.Black;
            this.txtcorreo.Location = new System.Drawing.Point(174, 205);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.PreventEnterBeep = true;
            this.txtcorreo.Size = new System.Drawing.Size(100, 22);
            this.txtcorreo.TabIndex = 38;
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txttelefono.Border.Class = "TextBoxBorder";
            this.txttelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttelefono.DisabledBackColor = System.Drawing.Color.White;
            this.txttelefono.ForeColor = System.Drawing.Color.Black;
            this.txttelefono.Location = new System.Drawing.Point(174, 176);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.PreventEnterBeep = true;
            this.txttelefono.Size = new System.Drawing.Size(100, 22);
            this.txttelefono.TabIndex = 37;
            // 
            // txtapmat
            // 
            this.txtapmat.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtapmat.Border.Class = "TextBoxBorder";
            this.txtapmat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtapmat.DisabledBackColor = System.Drawing.Color.White;
            this.txtapmat.ForeColor = System.Drawing.Color.Black;
            this.txtapmat.Location = new System.Drawing.Point(174, 147);
            this.txtapmat.Name = "txtapmat";
            this.txtapmat.PreventEnterBeep = true;
            this.txtapmat.Size = new System.Drawing.Size(100, 22);
            this.txtapmat.TabIndex = 36;
            // 
            // txtappat
            // 
            this.txtappat.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtappat.Border.Class = "TextBoxBorder";
            this.txtappat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtappat.DisabledBackColor = System.Drawing.Color.White;
            this.txtappat.ForeColor = System.Drawing.Color.Black;
            this.txtappat.Location = new System.Drawing.Point(174, 118);
            this.txtappat.Name = "txtappat";
            this.txtappat.PreventEnterBeep = true;
            this.txtappat.Size = new System.Drawing.Size(100, 22);
            this.txtappat.TabIndex = 35;
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
            this.txtnombre.Location = new System.Drawing.Point(174, 89);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PreventEnterBeep = true;
            this.txtnombre.Size = new System.Drawing.Size(100, 22);
            this.txtnombre.TabIndex = 34;
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
            this.txtdni.Location = new System.Drawing.Point(174, 60);
            this.txtdni.Name = "txtdni";
            this.txtdni.PreventEnterBeep = true;
            this.txtdni.Size = new System.Drawing.Size(100, 22);
            this.txtdni.TabIndex = 33;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(40, 231);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 30;
            this.labelX8.Text = "Dirección:";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(40, 202);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 29;
            this.labelX7.Text = "Correo:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(40, 173);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 28;
            this.labelX6.Text = "Telefono:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(376, 64);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(106, 23);
            this.labelX5.TabIndex = 27;
            this.labelX5.Text = "Fecha Nacimiento:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(40, 144);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(106, 23);
            this.labelX4.TabIndex = 26;
            this.labelX4.Text = "Apellido Materno: ";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(40, 115);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(106, 23);
            this.labelX3.TabIndex = 25;
            this.labelX3.Text = "Apellido paterno:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(40, 86);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 24;
            this.labelX2.Text = "Nombre";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(40, 57);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 23;
            this.labelX1.Text = "Dni:";
            // 
            // btncancelar
            // 
            this.btncancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btncancelar.Image = global::Ap_escuela.Properties.Resources.cancelar;
            this.btncancelar.Location = new System.Drawing.Point(488, 290);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(150, 54);
            this.btncancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btncancelar.TabIndex = 44;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnguardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnguardar.Image = global::Ap_escuela.Properties.Resources.Guardar;
            this.btnguardar.Location = new System.Drawing.Point(488, 221);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(150, 54);
            this.btnguardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnguardar.TabIndex = 43;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // RegistroDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 460);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.monthCalendarAdv1);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtapmat);
            this.Controls.Add(this.txtappat);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RegistroDocentes";
            this.Text = "Registro Docentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnlimpiar;
        private DevComponents.DotNetBar.ButtonX btncancelar;
        private DevComponents.DotNetBar.ButtonX btnguardar;
        private DevComponents.Editors.DateTimeAdv.MonthCalendarAdv monthCalendarAdv1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdireccion;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcorreo;
        private DevComponents.DotNetBar.Controls.TextBoxX txttelefono;
        private DevComponents.DotNetBar.Controls.TextBoxX txtapmat;
        private DevComponents.DotNetBar.Controls.TextBoxX txtappat;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnombre;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdni;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}