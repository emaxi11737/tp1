namespace Trabajo_Practico
{
    partial class frmObjetos
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
            this.lblnmbObj = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lvObjetos1 = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvObjetos2 = new System.Windows.Forms.ListView();
            this.Nombres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblcr1 = new System.Windows.Forms.Label();
            this.lblcr2 = new System.Windows.Forms.Label();
            this.lblcantlbl1 = new System.Windows.Forms.Label();
            this.lblcantlbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnmbObj
            // 
            this.lblnmbObj.AutoSize = true;
            this.lblnmbObj.Location = new System.Drawing.Point(12, 52);
            this.lblnmbObj.Name = "lblnmbObj";
            this.lblnmbObj.Size = new System.Drawing.Size(78, 13);
            this.lblnmbObj.TabIndex = 0;
            this.lblnmbObj.Text = "Nombre Objeto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(368, 49);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lvObjetos1
            // 
            this.lvObjetos1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvObjetos1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre});
            this.lvObjetos1.Location = new System.Drawing.Point(15, 110);
            this.lvObjetos1.Name = "lvObjetos1";
            this.lvObjetos1.Size = new System.Drawing.Size(342, 328);
            this.lvObjetos1.TabIndex = 3;
            this.lvObjetos1.UseCompatibleStateImageBehavior = false;
            this.lvObjetos1.View = System.Windows.Forms.View.List;
            this.lvObjetos1.SelectedIndexChanged += new System.EventHandler(this.lvObjetos1_SelectedIndexChanged);
            // 
            // lvObjetos2
            // 
            this.lvObjetos2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombres});
            this.lvObjetos2.Location = new System.Drawing.Point(446, 110);
            this.lvObjetos2.Name = "lvObjetos2";
            this.lvObjetos2.Size = new System.Drawing.Size(342, 328);
            this.lvObjetos2.TabIndex = 4;
            this.lvObjetos2.UseCompatibleStateImageBehavior = false;
            this.lvObjetos2.View = System.Windows.Forms.View.List;
            this.lvObjetos2.SelectedIndexChanged += new System.EventHandler(this.lvObjetos2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(383, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblcr1
            // 
            this.lblcr1.AutoSize = true;
            this.lblcr1.Location = new System.Drawing.Point(12, 441);
            this.lblcr1.Name = "lblcr1";
            this.lblcr1.Size = new System.Drawing.Size(114, 13);
            this.lblcr1.TabIndex = 9;
            this.lblcr1.Text = "Cantidad de Registros:";
            // 
            // lblcr2
            // 
            this.lblcr2.AutoSize = true;
            this.lblcr2.Location = new System.Drawing.Point(443, 441);
            this.lblcr2.Name = "lblcr2";
            this.lblcr2.Size = new System.Drawing.Size(114, 13);
            this.lblcr2.TabIndex = 10;
            this.lblcr2.Text = "Cantidad de Registros:";
            // 
            // lblcantlbl1
            // 
            this.lblcantlbl1.AutoSize = true;
            this.lblcantlbl1.Location = new System.Drawing.Point(132, 441);
            this.lblcantlbl1.Name = "lblcantlbl1";
            this.lblcantlbl1.Size = new System.Drawing.Size(0, 13);
            this.lblcantlbl1.TabIndex = 11;
            // 
            // lblcantlbl2
            // 
            this.lblcantlbl2.AutoSize = true;
            this.lblcantlbl2.Location = new System.Drawing.Point(563, 441);
            this.lblcantlbl2.Name = "lblcantlbl2";
            this.lblcantlbl2.Size = new System.Drawing.Size(0, 13);
            this.lblcantlbl2.TabIndex = 12;
            // 
            // frmObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.lblcantlbl2);
            this.Controls.Add(this.lblcantlbl1);
            this.Controls.Add(this.lblcr2);
            this.Controls.Add(this.lblcr1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvObjetos2);
            this.Controls.Add(this.lvObjetos1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblnmbObj);
            this.Name = "frmObjetos";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmObjetos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnmbObj;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lvObjetos1;
        private System.Windows.Forms.ListView lvObjetos2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblcr1;
        private System.Windows.Forms.Label lblcr2;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Nombres;
        private System.Windows.Forms.Label lblcantlbl1;
        private System.Windows.Forms.Label lblcantlbl2;
    }
}