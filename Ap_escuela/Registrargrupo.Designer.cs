namespace Ap_escuela
{
    partial class Registrargrupo
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
            this.btnguardar = new DevComponents.DotNetBar.ButtonX();
            this.txtdni = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.comboTree1 = new DevComponents.DotNetBar.Controls.ComboTree();
            this.Día = new DevComponents.AdvTree.ColumnHeader();
            this.Tarde = new DevComponents.AdvTree.ColumnHeader();
            this.Noche = new DevComponents.AdvTree.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnguardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnguardar.Location = new System.Drawing.Point(393, 89);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(150, 54);
            this.btnguardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnguardar.TabIndex = 27;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
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
            this.txtdni.Location = new System.Drawing.Point(168, 46);
            this.txtdni.Name = "txtdni";
            this.txtdni.PreventEnterBeep = true;
            this.txtdni.Size = new System.Drawing.Size(100, 22);
            this.txtdni.TabIndex = 24;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(34, 107);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(106, 23);
            this.labelX2.TabIndex = 22;
            this.labelX2.Text = "Horario de grupo:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(34, 43);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(106, 23);
            this.labelX1.TabIndex = 21;
            this.labelX1.Text = "Numero de Grupo:";
            // 
            // comboTree1
            // 
            this.comboTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.comboTree1.BackgroundStyle.Class = "TextBoxBorder";
            this.comboTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.comboTree1.ButtonDropDown.Visible = true;
            this.comboTree1.Columns.Add(this.Día);
            this.comboTree1.Columns.Add(this.Tarde);
            this.comboTree1.Columns.Add(this.Noche);
            this.comboTree1.Location = new System.Drawing.Point(168, 107);
            this.comboTree1.Name = "comboTree1";
            this.comboTree1.Size = new System.Drawing.Size(141, 23);
            this.comboTree1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboTree1.TabIndex = 28;
            // 
            // Día
            // 
            this.Día.Name = "Día";
            this.Día.Text = "Column";
            this.Día.Width.Absolute = 150;
            // 
            // Tarde
            // 
            this.Tarde.Name = "Tarde";
            this.Tarde.Text = "Column";
            this.Tarde.Width.Absolute = 150;
            // 
            // Noche
            // 
            this.Noche.Name = "Noche";
            this.Noche.Text = "Column";
            this.Noche.Width.Absolute = 150;
            // 
            // Registrargrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 257);
            this.Controls.Add(this.comboTree1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Registrargrupo";
            this.Text = "MetroForm";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnguardar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdni;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboTree comboTree1;
        private DevComponents.AdvTree.ColumnHeader Día;
        private DevComponents.AdvTree.ColumnHeader Tarde;
        private DevComponents.AdvTree.ColumnHeader Noche;
    }
}