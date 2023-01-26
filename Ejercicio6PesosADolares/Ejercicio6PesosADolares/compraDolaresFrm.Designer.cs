
namespace Ejercicio6PesosADolares
{
    partial class compraDolaresFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dolaresTextBox = new System.Windows.Forms.TextBox();
            this.totalAPagarTextBox = new System.Windows.Forms.TextBox();
            this.reiniciarButton = new System.Windows.Forms.Button();
            this.salirButton = new System.Windows.Forms.Button();
            this.mostrarListaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dolaresRestantesTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cotizacionOficialTextBox = new System.Windows.Forms.TextBox();
            this.comprarButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.operacionesDataGridView = new System.Windows.Forms.DataGridView();
            this.colDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDolaresAPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImpPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImpGanancias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dolaresTextBox
            // 
            this.dolaresTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dolaresTextBox.Location = new System.Drawing.Point(129, 87);
            this.dolaresTextBox.MaxLength = 50;
            this.dolaresTextBox.Name = "dolaresTextBox";
            this.dolaresTextBox.Size = new System.Drawing.Size(104, 20);
            this.dolaresTextBox.TabIndex = 1;
            // 
            // totalAPagarTextBox
            // 
            this.totalAPagarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.totalAPagarTextBox.Enabled = false;
            this.totalAPagarTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAPagarTextBox.Location = new System.Drawing.Point(91, 239);
            this.totalAPagarTextBox.MaxLength = 100;
            this.totalAPagarTextBox.Name = "totalAPagarTextBox";
            this.totalAPagarTextBox.ReadOnly = true;
            this.totalAPagarTextBox.Size = new System.Drawing.Size(204, 43);
            this.totalAPagarTextBox.TabIndex = 0;
            // 
            // reiniciarButton
            // 
            this.reiniciarButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.reiniciarButton.Location = new System.Drawing.Point(170, 335);
            this.reiniciarButton.Name = "reiniciarButton";
            this.reiniciarButton.Size = new System.Drawing.Size(124, 26);
            this.reiniciarButton.TabIndex = 5;
            this.reiniciarButton.Text = "Reiniciar operaciones";
            this.reiniciarButton.UseVisualStyleBackColor = true;
            this.reiniciarButton.Click += new System.EventHandler(this.reiniciarButton_Click);
            // 
            // salirButton
            // 
            this.salirButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.salirButton.Location = new System.Drawing.Point(297, 335);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(78, 26);
            this.salirButton.TabIndex = 6;
            this.salirButton.Text = "Salir";
            this.salirButton.UseVisualStyleBackColor = true;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // mostrarListaButton
            // 
            this.mostrarListaButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mostrarListaButton.BackColor = System.Drawing.Color.Transparent;
            this.mostrarListaButton.Location = new System.Drawing.Point(12, 335);
            this.mostrarListaButton.Name = "mostrarListaButton";
            this.mostrarListaButton.Size = new System.Drawing.Size(153, 26);
            this.mostrarListaButton.TabIndex = 4;
            this.mostrarListaButton.Text = "Mostrar lista de operaciones";
            this.mostrarListaButton.UseVisualStyleBackColor = false;
            this.mostrarListaButton.Click += new System.EventHandler(this.mostrarListaButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolares a comprar:";
            // 
            // dolaresRestantesTextBox
            // 
            this.dolaresRestantesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dolaresRestantesTextBox.Enabled = false;
            this.dolaresRestantesTextBox.Location = new System.Drawing.Point(153, 309);
            this.dolaresRestantesTextBox.MaxLength = 10;
            this.dolaresRestantesTextBox.Name = "dolaresRestantesTextBox";
            this.dolaresRestantesTextBox.ReadOnly = true;
            this.dolaresRestantesTextBox.Size = new System.Drawing.Size(104, 20);
            this.dolaresRestantesTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dolares restantes en banco:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total en Pesos Argentinos mas impuestos:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Compra de dolares";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cotizacion Oficial:";
            // 
            // cotizacionOficialTextBox
            // 
            this.cotizacionOficialTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cotizacionOficialTextBox.Location = new System.Drawing.Point(129, 140);
            this.cotizacionOficialTextBox.MaxLength = 50;
            this.cotizacionOficialTextBox.Name = "cotizacionOficialTextBox";
            this.cotizacionOficialTextBox.Size = new System.Drawing.Size(104, 20);
            this.cotizacionOficialTextBox.TabIndex = 2;
            // 
            // comprarButton
            // 
            this.comprarButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comprarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprarButton.Image = global::Ejercicio6PesosADolares.Properties.Resources.bank_35px;
            this.comprarButton.Location = new System.Drawing.Point(252, 79);
            this.comprarButton.Name = "comprarButton";
            this.comprarButton.Size = new System.Drawing.Size(114, 93);
            this.comprarButton.TabIndex = 3;
            this.comprarButton.Text = "Comprar";
            this.comprarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.comprarButton.UseVisualStyleBackColor = true;
            this.comprarButton.Click += new System.EventHandler(this.comprarButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // operacionesDataGridView
            // 
            this.operacionesDataGridView.AllowUserToAddRows = false;
            this.operacionesDataGridView.AllowUserToDeleteRows = false;
            this.operacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operacionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDolares,
            this.colDolaresAPeso,
            this.colImpPais,
            this.colImpGanancias,
            this.colTotal});
            this.operacionesDataGridView.Location = new System.Drawing.Point(423, 76);
            this.operacionesDataGridView.Name = "operacionesDataGridView";
            this.operacionesDataGridView.ReadOnly = true;
            this.operacionesDataGridView.Size = new System.Drawing.Size(503, 285);
            this.operacionesDataGridView.TabIndex = 7;
            // 
            // colDolares
            // 
            this.colDolares.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDolares.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDolares.HeaderText = "Dolares a comprar";
            this.colDolares.Name = "colDolares";
            this.colDolares.ReadOnly = true;
            // 
            // colDolaresAPeso
            // 
            this.colDolaresAPeso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDolaresAPeso.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDolaresAPeso.HeaderText = "Monto Pesos sin Imp.";
            this.colDolaresAPeso.Name = "colDolaresAPeso";
            this.colDolaresAPeso.ReadOnly = true;
            // 
            // colImpPais
            // 
            this.colImpPais.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colImpPais.DefaultCellStyle = dataGridViewCellStyle8;
            this.colImpPais.HeaderText = "Impuesto Pais(AR$)";
            this.colImpPais.Name = "colImpPais";
            this.colImpPais.ReadOnly = true;
            // 
            // colImpGanancias
            // 
            this.colImpGanancias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colImpGanancias.DefaultCellStyle = dataGridViewCellStyle9;
            this.colImpGanancias.HeaderText = "Retencion a las ganancias(AR$)";
            this.colImpGanancias.Name = "colImpGanancias";
            this.colImpGanancias.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle10;
            this.colTotal.HeaderText = "Total en pesos con imp.";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Historial de compras";
            // 
            // compraDolaresFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(387, 373);
            this.ControlBox = false;
            this.Controls.Add(this.operacionesDataGridView);
            this.Controls.Add(this.dolaresRestantesTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salirButton);
            this.Controls.Add(this.reiniciarButton);
            this.Controls.Add(this.mostrarListaButton);
            this.Controls.Add(this.comprarButton);
            this.Controls.Add(this.totalAPagarTextBox);
            this.Controls.Add(this.cotizacionOficialTextBox);
            this.Controls.Add(this.dolaresTextBox);
            this.MaximumSize = new System.Drawing.Size(954, 412);
            this.MinimumSize = new System.Drawing.Size(403, 412);
            this.Name = "compraDolaresFrm";
            this.Text = "Banco";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dolaresTextBox;
        private System.Windows.Forms.TextBox totalAPagarTextBox;
        private System.Windows.Forms.Button comprarButton;
        private System.Windows.Forms.Button reiniciarButton;
        private System.Windows.Forms.Button salirButton;
        private System.Windows.Forms.Button mostrarListaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dolaresRestantesTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cotizacionOficialTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridView operacionesDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDolaresAPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImpPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImpGanancias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}

