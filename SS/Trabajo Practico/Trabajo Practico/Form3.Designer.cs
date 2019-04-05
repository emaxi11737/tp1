namespace Trabajo_Practico
{
    partial class frmPersonas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonas));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblcolorFav = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.rbtHombre = new System.Windows.Forms.RadioButton();
            this.rbtMujer = new System.Windows.Forms.RadioButton();
            this.rbtND = new System.Windows.Forms.RadioButton();
            this.rbtHeli = new System.Windows.Forms.RadioButton();
            this.dtpNac = new System.Windows.Forms.DateTimePicker();
            this.cbbColor = new System.Windows.Forms.ComboBox();
            this.btnSubir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.chkGen = new System.Windows.Forms.CheckedListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnelTodo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 84);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(12, 162);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(60, 13);
            this.lblNacimiento.TabIndex = 2;
            this.lblNacimiento.Text = "Nacimiento";
            // 
            // lblcolorFav
            // 
            this.lblcolorFav.AutoSize = true;
            this.lblcolorFav.Location = new System.Drawing.Point(12, 420);
            this.lblcolorFav.Name = "lblcolorFav";
            this.lblcolorFav.Size = new System.Drawing.Size(69, 13);
            this.lblcolorFav.TabIndex = 3;
            this.lblcolorFav.Text = "Color favorito";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(12, 124);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(384, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(104, 77);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(384, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // rbtHombre
            // 
            this.rbtHombre.AutoSize = true;
            this.rbtHombre.Checked = true;
            this.rbtHombre.Location = new System.Drawing.Point(133, 119);
            this.rbtHombre.Name = "rbtHombre";
            this.rbtHombre.Size = new System.Drawing.Size(62, 17);
            this.rbtHombre.TabIndex = 7;
            this.rbtHombre.TabStop = true;
            this.rbtHombre.Text = "Hombre";
            this.rbtHombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtHombre.UseVisualStyleBackColor = true;
            // 
            // rbtMujer
            // 
            this.rbtMujer.AutoSize = true;
            this.rbtMujer.Location = new System.Drawing.Point(259, 119);
            this.rbtMujer.Name = "rbtMujer";
            this.rbtMujer.Size = new System.Drawing.Size(51, 17);
            this.rbtMujer.TabIndex = 8;
            this.rbtMujer.Text = "Mujer";
            this.rbtMujer.UseVisualStyleBackColor = true;
            // 
            // rbtND
            // 
            this.rbtND.AutoSize = true;
            this.rbtND.Location = new System.Drawing.Point(349, 119);
            this.rbtND.Name = "rbtND";
            this.rbtND.Size = new System.Drawing.Size(126, 17);
            this.rbtND.TabIndex = 9;
            this.rbtND.Text = "Prefiero no responder";
            this.rbtND.UseVisualStyleBackColor = true;
            // 
            // rbtHeli
            // 
            this.rbtHeli.AutoSize = true;
            this.rbtHeli.Location = new System.Drawing.Point(504, 119);
            this.rbtHeli.Name = "rbtHeli";
            this.rbtHeli.Size = new System.Drawing.Size(119, 17);
            this.rbtHeli.TabIndex = 10;
            this.rbtHeli.Text = "Helicoptero Apache";
            this.rbtHeli.UseVisualStyleBackColor = true;
            // 
            // dtpNac
            // 
            this.dtpNac.Checked = false;
            this.dtpNac.CustomFormat = "dd/MM/yyyy";
            this.dtpNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNac.Location = new System.Drawing.Point(104, 156);
            this.dtpNac.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpNac.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNac.Name = "dtpNac";
            this.dtpNac.Size = new System.Drawing.Size(200, 20);
            this.dtpNac.TabIndex = 11;
            this.dtpNac.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpNac.ValueChanged += new System.EventHandler(this.dtpNac_ValueChanged);
            // 
            // cbbColor
            // 
            this.cbbColor.FormattingEnabled = true;
            this.cbbColor.Items.AddRange(new object[] {
            "Rojo",
            "Negro",
            "Azul",
            "Amarillo",
            "Blanco",
            "Rosa",
            "Verde"});
            this.cbbColor.Location = new System.Drawing.Point(87, 417);
            this.cbbColor.Name = "cbbColor";
            this.cbbColor.Size = new System.Drawing.Size(121, 21);
            this.cbbColor.TabIndex = 13;
            // 
            // btnSubir
            // 
            this.btnSubir.Image = ((System.Drawing.Image)(resources.GetObject("btnSubir.Image")));
            this.btnSubir.Location = new System.Drawing.Point(538, 29);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(73, 68);
            this.btnSubir.TabIndex = 14;
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(388, 156);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 17;
            this.txtEdad.Text = "0";
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(674, 29);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.Size = new System.Drawing.Size(456, 349);
            this.dgvPersonas.TabIndex = 18;
            // 
            // chkGen
            // 
            this.chkGen.FormattingEnabled = true;
            this.chkGen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkGen.Items.AddRange(new object[] {
            "Rock",
            "Pop",
            "Jazz",
            "Rap",
            "Trap",
            "Reggeae",
            "Reggeaton",
            "Blues",
            "Metal",
            "Tan Bionica",
            "Folclore",
            "Clasico",
            "Tango"});
            this.chkGen.Location = new System.Drawing.Point(15, 200);
            this.chkGen.Name = "chkGen";
            this.chkGen.Size = new System.Drawing.Size(633, 199);
            this.chkGen.TabIndex = 19;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(755, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnelTodo
            // 
            this.btnelTodo.Location = new System.Drawing.Point(674, 0);
            this.btnelTodo.Name = "btnelTodo";
            this.btnelTodo.Size = new System.Drawing.Size(75, 23);
            this.btnelTodo.TabIndex = 21;
            this.btnelTodo.Text = "Limpiar";
            this.btnelTodo.UseVisualStyleBackColor = true;
            this.btnelTodo.Click += new System.EventHandler(this.btnelTodo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AccessibleDescription = "";
            this.btnModificar.Location = new System.Drawing.Point(836, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btnModificar, "Seleccione la columna ,escriba los datos en la izquierda y toque modificar");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // frmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnelTodo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.chkGen);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.cbbColor);
            this.Controls.Add(this.dtpNac);
            this.Controls.Add(this.rbtHeli);
            this.Controls.Add(this.rbtND);
            this.Controls.Add(this.rbtMujer);
            this.Controls.Add(this.rbtHombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblcolorFav);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmPersonas";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblcolorFav;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.RadioButton rbtHombre;
        private System.Windows.Forms.RadioButton rbtMujer;
        private System.Windows.Forms.RadioButton rbtND;
        private System.Windows.Forms.RadioButton rbtHeli;
        private System.Windows.Forms.DateTimePicker dtpNac;
        private System.Windows.Forms.ComboBox cbbColor;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.CheckedListBox chkGen;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnelTodo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}