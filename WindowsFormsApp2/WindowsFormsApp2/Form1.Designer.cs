
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnstock = new FontAwesome.Sharp.IconButton();
            this.btnver = new FontAwesome.Sharp.IconButton();
            this.btndonar = new FontAwesome.Sharp.IconButton();
            this.btnregistro = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.panel2.Controls.Add(this.btnstock);
            this.panel2.Controls.Add(this.btnver);
            this.panel2.Controls.Add(this.btndonar);
            this.panel2.Controls.Add(this.btnregistro);
            this.panel2.Location = new System.Drawing.Point(-4, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 510);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.panel3.Controls.Add(this.lbl_fecha);
            this.panel3.Controls.Add(this.lblhora);
            this.panel3.Location = new System.Drawing.Point(-4, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel3.Size = new System.Drawing.Size(1132, 60);
            this.panel3.TabIndex = 2;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha.Location = new System.Drawing.Point(802, 29);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(73, 28);
            this.lbl_fecha.TabIndex = 1;
            this.lbl_fecha.Text = "label1";
            this.lbl_fecha.Click += new System.EventHandler(this.lbl_fecha_Click);
            // 
            // lblhora
            // 
            this.lblhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.White;
            this.lblhora.Location = new System.Drawing.Point(801, 0);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(92, 35);
            this.lblhora.TabIndex = 0;
            this.lblhora.Text = "label1";
            this.lblhora.Click += new System.EventHandler(this.lblhora_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnstock
            // 
            this.btnstock.FlatAppearance.BorderSize = 0;
            this.btnstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstock.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstock.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.btnstock.IconColor = System.Drawing.Color.White;
            this.btnstock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnstock.Location = new System.Drawing.Point(0, 228);
            this.btnstock.Margin = new System.Windows.Forms.Padding(0);
            this.btnstock.Name = "btnstock";
            this.btnstock.Size = new System.Drawing.Size(220, 75);
            this.btnstock.TabIndex = 3;
            this.btnstock.Text = "Stock";
            this.btnstock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnstock.UseVisualStyleBackColor = true;
            this.btnstock.Click += new System.EventHandler(this.btnstock_Click);
            // 
            // btnver
            // 
            this.btnver.FlatAppearance.BorderSize = 0;
            this.btnver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnver.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnver.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnver.IconColor = System.Drawing.Color.White;
            this.btnver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnver.Location = new System.Drawing.Point(0, 153);
            this.btnver.Margin = new System.Windows.Forms.Padding(0);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(220, 75);
            this.btnver.TabIndex = 2;
            this.btnver.Text = "Ver Donantes";
            this.btnver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnver.UseVisualStyleBackColor = true;
            this.btnver.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btndonar
            // 
            this.btndonar.FlatAppearance.BorderSize = 0;
            this.btndonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndonar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndonar.IconChar = FontAwesome.Sharp.IconChar.Burn;
            this.btndonar.IconColor = System.Drawing.Color.White;
            this.btndonar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndonar.Location = new System.Drawing.Point(0, 78);
            this.btndonar.Margin = new System.Windows.Forms.Padding(0);
            this.btndonar.Name = "btndonar";
            this.btndonar.Size = new System.Drawing.Size(220, 75);
            this.btndonar.TabIndex = 1;
            this.btndonar.Text = "Realizar Donacion";
            this.btndonar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndonar.UseVisualStyleBackColor = true;
            this.btndonar.Click += new System.EventHandler(this.btndonar_Click);
            // 
            // btnregistro
            // 
            this.btnregistro.FlatAppearance.BorderSize = 0;
            this.btnregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistro.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistro.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnregistro.IconColor = System.Drawing.Color.White;
            this.btnregistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnregistro.Location = new System.Drawing.Point(0, 3);
            this.btnregistro.Margin = new System.Windows.Forms.Padding(0);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(220, 75);
            this.btnregistro.TabIndex = 0;
            this.btnregistro.Text = "Registrar Donante";
            this.btnregistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnregistro.UseVisualStyleBackColor = true;
            this.btnregistro.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._125575692_logotipo_de_donación_de_sangre_una_gota_de_sangre;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(216, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 512);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem2.Text = "iconMenuItem2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 566);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(10, 50);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconButton btnregistro;
        private FontAwesome.Sharp.IconButton btnstock;
        private FontAwesome.Sharp.IconButton btnver;
        private FontAwesome.Sharp.IconButton btndonar;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_fecha;
    }
}

