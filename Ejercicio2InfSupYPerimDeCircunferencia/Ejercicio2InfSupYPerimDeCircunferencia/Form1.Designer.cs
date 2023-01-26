
namespace Ejercicio2InfSupYPerimDeCircunferencia
{
    partial class Ejercicio2Form
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
            this.RadioLabel = new System.Windows.Forms.Label();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuperficie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenerarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioLabel
            // 
            this.RadioLabel.AutoSize = true;
            this.RadioLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RadioLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioLabel.Location = new System.Drawing.Point(12, 75);
            this.RadioLabel.Name = "RadioLabel";
            this.RadioLabel.Size = new System.Drawing.Size(68, 23);
            this.RadioLabel.TabIndex = 1;
            this.RadioLabel.Text = "Radio";
            this.RadioLabel.Click += new System.EventHandler(this.RadioLabel_Click);
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPerimetro,
            this.colSuperficie});
            this.DatosDataGridView.Location = new System.Drawing.Point(12, 121);
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.Size = new System.Drawing.Size(240, 258);
            this.DatosDataGridView.TabIndex = 2;
            // 
            // colPerimetro
            // 
            this.colPerimetro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPerimetro.HeaderText = "Perimetro";
            this.colPerimetro.Name = "colPerimetro";
            this.colPerimetro.ReadOnly = true;
            // 
            // colSuperficie
            // 
            this.colSuperficie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSuperficie.HeaderText = "Superficie";
            this.colSuperficie.Name = "colSuperficie";
            this.colSuperficie.ReadOnly = true;
            // 
            // GenerarButton
            // 
            this.GenerarButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GenerarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerarButton.Location = new System.Drawing.Point(187, 71);
            this.GenerarButton.Name = "GenerarButton";
            this.GenerarButton.Size = new System.Drawing.Size(65, 27);
            this.GenerarButton.TabIndex = 3;
            this.GenerarButton.Text = "Generar";
            this.GenerarButton.UseVisualStyleBackColor = true;
            this.GenerarButton.Click += new System.EventHandler(this.GenerarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Se calculara la superficie y perimetro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "de una circunferencia";
            // 
            // radioTextBox
            // 
            this.radioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTextBox.Location = new System.Drawing.Point(81, 72);
            this.radioTextBox.Name = "radioTextBox";
            this.radioTextBox.Size = new System.Drawing.Size(69, 26);
            this.radioTextBox.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Ejercicio2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(265, 391);
            this.Controls.Add(this.radioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerarButton);
            this.Controls.Add(this.DatosDataGridView);
            this.Controls.Add(this.RadioLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(281, 430);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(281, 430);
            this.Name = "Ejercicio2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Superficie y Perimetro de una circunferencia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ejercicio2Form_FormClosing);
            this.Load += new System.EventHandler(this.Ejercicio2Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label RadioLabel;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.Button GenerarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerimetro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuperficie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox radioTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

