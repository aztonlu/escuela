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
            this.txtnumerogrupo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.Día = new DevComponents.AdvTree.ColumnHeader();
            this.Tarde = new DevComponents.AdvTree.ColumnHeader();
            this.Noche = new DevComponents.AdvTree.ColumnHeader();
            this.cbhorario = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
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
            this.txtnumerogrupo.Location = new System.Drawing.Point(168, 46);
            this.txtnumerogrupo.Name = "txtnumerogrupo";
            this.txtnumerogrupo.PreventEnterBeep = true;
            this.txtnumerogrupo.Size = new System.Drawing.Size(100, 22);
            this.txtnumerogrupo.TabIndex = 24;
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
            // cbhorario
            // 
            this.cbhorario.DisplayMember = "Text";
            this.cbhorario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbhorario.ForeColor = System.Drawing.Color.Black;
            this.cbhorario.FormattingEnabled = true;
            this.cbhorario.ItemHeight = 16;
            this.cbhorario.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.cbhorario.Location = new System.Drawing.Point(168, 108);
            this.cbhorario.Name = "cbhorario";
            this.cbhorario.Size = new System.Drawing.Size(121, 22);
            this.cbhorario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbhorario.TabIndex = 29;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Día";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Tarde";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Noche";
            // 
            // Registrargrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 257);
            this.Controls.Add(this.cbhorario);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtnumerogrupo);
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
        private DevComponents.DotNetBar.Controls.TextBoxX txtnumerogrupo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.AdvTree.ColumnHeader Día;
        private DevComponents.AdvTree.ColumnHeader Tarde;
        private DevComponents.AdvTree.ColumnHeader Noche;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbhorario;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
    }
}