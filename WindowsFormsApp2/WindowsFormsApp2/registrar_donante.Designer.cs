
namespace WindowsFormsApp2
{
    partial class registrar_donante
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbldatos = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lbldni = new System.Windows.Forms.Label();
            this.lblsangre = new System.Windows.Forms.Label();
            this.lblcalle = new System.Windows.Forms.Label();
            this.lblnnumcalle = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblcel = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtcel = new System.Windows.Forms.TextBox();
            this.txtcalle = new System.Windows.Forms.TextBox();
            this.txtnumcalle = new System.Windows.Forms.TextBox();
            this.txtfemenino = new System.Windows.Forms.CheckBox();
            this.txtmasculino = new System.Windows.Forms.CheckBox();
            this.txttiposangre = new System.Windows.Forms.ComboBox();
            this.guardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(71, 65);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(128, 35);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre:";
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatos.Location = new System.Drawing.Point(358, 23);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(108, 35);
            this.lbldatos.TabIndex = 1;
            this.lbldatos.Text = "DATOS";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.Location = new System.Drawing.Point(71, 109);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(128, 35);
            this.lblapellido.TabIndex = 2;
            this.lblapellido.Text = "Apellido:";
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldni.Location = new System.Drawing.Point(71, 153);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(87, 35);
            this.lbldni.TabIndex = 3;
            this.lbldni.Text = "D.N.I:";
            this.lbldni.Click += new System.EventHandler(this.lbldni_Click);
            // 
            // lblsangre
            // 
            this.lblsangre.AutoSize = true;
            this.lblsangre.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsangre.Location = new System.Drawing.Point(71, 388);
            this.lblsangre.Name = "lblsangre";
            this.lblsangre.Size = new System.Drawing.Size(216, 35);
            this.lblsangre.TabIndex = 4;
            this.lblsangre.Text = "Tipo de Sangre:";
            this.lblsangre.Click += new System.EventHandler(this.lblsangre_Click);
            // 
            // lblcalle
            // 
            this.lblcalle.AutoSize = true;
            this.lblcalle.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalle.Location = new System.Drawing.Point(74, 296);
            this.lblcalle.Name = "lblcalle";
            this.lblcalle.Size = new System.Drawing.Size(84, 35);
            this.lblcalle.TabIndex = 5;
            this.lblcalle.Text = "Calle:";
            // 
            // lblnnumcalle
            // 
            this.lblnnumcalle.AutoSize = true;
            this.lblnnumcalle.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnnumcalle.Location = new System.Drawing.Point(71, 343);
            this.lblnnumcalle.Name = "lblnnumcalle";
            this.lblnnumcalle.Size = new System.Drawing.Size(128, 35);
            this.lblnnumcalle.TabIndex = 6;
            this.lblnnumcalle.Text = "Numero:";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexo.Location = new System.Drawing.Point(71, 200);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(84, 35);
            this.lblsexo.TabIndex = 7;
            this.lblsexo.Text = "Sexo:";
            // 
            // lblcel
            // 
            this.lblcel.AutoSize = true;
            this.lblcel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcel.Location = new System.Drawing.Point(71, 248);
            this.lblcel.Name = "lblcel";
            this.lblcel.Size = new System.Drawing.Size(111, 35);
            this.lblcel.TabIndex = 8;
            this.lblcel.Text = "Celular:";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(216, 75);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(250, 24);
            this.txtnombre.TabIndex = 9;
            // 
            // txtapellido
            // 
            this.txtapellido.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(216, 119);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(250, 24);
            this.txtapellido.TabIndex = 10;
            this.txtapellido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtdni
            // 
            this.txtdni.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni.Location = new System.Drawing.Point(216, 163);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(250, 24);
            this.txtdni.TabIndex = 11;
            // 
            // txtcel
            // 
            this.txtcel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcel.Location = new System.Drawing.Point(216, 258);
            this.txtcel.Name = "txtcel";
            this.txtcel.Size = new System.Drawing.Size(250, 24);
            this.txtcel.TabIndex = 12;
            // 
            // txtcalle
            // 
            this.txtcalle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcalle.Location = new System.Drawing.Point(216, 306);
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.Size = new System.Drawing.Size(250, 24);
            this.txtcalle.TabIndex = 13;
            // 
            // txtnumcalle
            // 
            this.txtnumcalle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumcalle.Location = new System.Drawing.Point(216, 353);
            this.txtnumcalle.Name = "txtnumcalle";
            this.txtnumcalle.Size = new System.Drawing.Size(250, 24);
            this.txtnumcalle.TabIndex = 14;
            // 
            // txtfemenino
            // 
            this.txtfemenino.AutoSize = true;
            this.txtfemenino.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfemenino.Location = new System.Drawing.Point(216, 210);
            this.txtfemenino.Name = "txtfemenino";
            this.txtfemenino.Size = new System.Drawing.Size(105, 25);
            this.txtfemenino.TabIndex = 16;
            this.txtfemenino.Text = "Femenino";
            this.txtfemenino.UseVisualStyleBackColor = true;
            // 
            // txtmasculino
            // 
            this.txtmasculino.AutoSize = true;
            this.txtmasculino.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmasculino.Location = new System.Drawing.Point(359, 210);
            this.txtmasculino.Name = "txtmasculino";
            this.txtmasculino.Size = new System.Drawing.Size(107, 25);
            this.txtmasculino.TabIndex = 17;
            this.txtmasculino.Text = "Masculino";
            this.txtmasculino.UseVisualStyleBackColor = true;
            // 
            // txttiposangre
            // 
            this.txttiposangre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttiposangre.FormattingEnabled = true;
            this.txttiposangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.txttiposangre.Location = new System.Drawing.Point(293, 396);
            this.txttiposangre.Name = "txttiposangre";
            this.txttiposangre.Size = new System.Drawing.Size(243, 27);
            this.txttiposangre.TabIndex = 18;
            this.txttiposangre.SelectedIndexChanged += new System.EventHandler(this.txttiposangre_SelectedIndexChanged);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.guardar.FlatAppearance.BorderSize = 0;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(588, 451);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(127, 36);
            this.guardar.TabIndex = 19;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(229)))), ((int)(((byte)(209)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(741, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // registrar_donante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.txttiposangre);
            this.Controls.Add(this.txtmasculino);
            this.Controls.Add(this.txtfemenino);
            this.Controls.Add(this.txtnumcalle);
            this.Controls.Add(this.txtcalle);
            this.Controls.Add(this.txtcel);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblcel);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lblnnumcalle);
            this.Controls.Add(this.lblcalle);
            this.Controls.Add(this.lblsangre);
            this.Controls.Add(this.lbldni);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lbldatos);
            this.Controls.Add(this.lblnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registrar_donante";
            this.Text = "registrar_donante";
            this.Load += new System.EventHandler(this.registrar_donante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldatos;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.Label lblsangre;
        private System.Windows.Forms.Label lblcalle;
        private System.Windows.Forms.Label lblnnumcalle;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblcel;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtcel;
        private System.Windows.Forms.TextBox txtcalle;
        private System.Windows.Forms.TextBox txtnumcalle;
        private System.Windows.Forms.CheckBox txtfemenino;
        private System.Windows.Forms.CheckBox txtmasculino;
        private System.Windows.Forms.ComboBox txttiposangre;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button button1;
    }
}