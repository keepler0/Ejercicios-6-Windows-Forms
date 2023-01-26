
namespace Ejercicio1
{
    partial class Ejercicio1GradosSexagesimalesARadianes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.GSexagesimalesTextBox = new System.Windows.Forms.TextBox();
            this.GSexagesimalLabel = new System.Windows.Forms.Label();
            this.EquivRadianesLabel = new System.Windows.Forms.Label();
            this.RadianesTextBox = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.HistorialButton = new System.Windows.Forms.Button();
            this.HistorialDataGridView = new System.Windows.Forms.DataGridView();
            this.colGSexagesimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRadianes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistorialDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TituloLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TituloLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TituloLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TituloLabel.Location = new System.Drawing.Point(12, 18);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(406, 28);
            this.TituloLabel.TabIndex = 0;
            this.TituloLabel.Text = "Conversor Grados sexagesimales a Radianes";
            // 
            // GSexagesimalesTextBox
            // 
            this.GSexagesimalesTextBox.Location = new System.Drawing.Point(12, 80);
            this.GSexagesimalesTextBox.Name = "GSexagesimalesTextBox";
            this.GSexagesimalesTextBox.Size = new System.Drawing.Size(165, 23);
            this.GSexagesimalesTextBox.TabIndex = 1;
            this.GSexagesimalesTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GSexagesimalLabel
            // 
            this.GSexagesimalLabel.AutoSize = true;
            this.GSexagesimalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GSexagesimalLabel.Location = new System.Drawing.Point(12, 57);
            this.GSexagesimalLabel.Name = "GSexagesimalLabel";
            this.GSexagesimalLabel.Size = new System.Drawing.Size(311, 20);
            this.GSexagesimalLabel.TabIndex = 0;
            this.GSexagesimalLabel.Text = "Ingrese Los Grados sexagesimales a calcular:";
            // 
            // EquivRadianesLabel
            // 
            this.EquivRadianesLabel.AutoSize = true;
            this.EquivRadianesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EquivRadianesLabel.Location = new System.Drawing.Point(12, 134);
            this.EquivRadianesLabel.Name = "EquivRadianesLabel";
            this.EquivRadianesLabel.Size = new System.Drawing.Size(179, 20);
            this.EquivRadianesLabel.TabIndex = 0;
            this.EquivRadianesLabel.Text = "Equivalente en Radianes:";
            // 
            // RadianesTextBox
            // 
            this.RadianesTextBox.Enabled = false;
            this.RadianesTextBox.Location = new System.Drawing.Point(12, 157);
            this.RadianesTextBox.Name = "RadianesTextBox";
            this.RadianesTextBox.Size = new System.Drawing.Size(165, 23);
            this.RadianesTextBox.TabIndex = 0;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalcularButton.Location = new System.Drawing.Point(197, 80);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(102, 100);
            this.CalcularButton.TabIndex = 2;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SalirButton.Location = new System.Drawing.Point(338, 230);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(75, 23);
            this.SalirButton.TabIndex = 4;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // HistorialButton
            // 
            this.HistorialButton.BackColor = System.Drawing.Color.Transparent;
            this.HistorialButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HistorialButton.Location = new System.Drawing.Point(235, 230);
            this.HistorialButton.Name = "HistorialButton";
            this.HistorialButton.Size = new System.Drawing.Size(77, 23);
            this.HistorialButton.TabIndex = 3;
            this.HistorialButton.Text = "Historial";
            this.HistorialButton.UseVisualStyleBackColor = false;
            this.HistorialButton.Click += new System.EventHandler(this.HistorialButton_Click);
            // 
            // HistorialDataGridView
            // 
            this.HistorialDataGridView.AllowUserToAddRows = false;
            this.HistorialDataGridView.AllowUserToDeleteRows = false;
            this.HistorialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistorialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGSexagesimal,
            this.colRadianes});
            this.HistorialDataGridView.Location = new System.Drawing.Point(451, 18);
            this.HistorialDataGridView.Name = "HistorialDataGridView";
            this.HistorialDataGridView.ReadOnly = true;
            this.HistorialDataGridView.RowTemplate.Height = 25;
            this.HistorialDataGridView.Size = new System.Drawing.Size(370, 235);
            this.HistorialDataGridView.TabIndex = 5;
            // 
            // colGSexagesimal
            // 
            this.colGSexagesimal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colGSexagesimal.DefaultCellStyle = dataGridViewCellStyle1;
            this.colGSexagesimal.HeaderText = "Grados sexagesimales";
            this.colGSexagesimal.Name = "colGSexagesimal";
            this.colGSexagesimal.ReadOnly = true;
            // 
            // colRadianes
            // 
            this.colRadianes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRadianes.HeaderText = "Equivalente en Radianes";
            this.colRadianes.Name = "colRadianes";
            this.colRadianes.ReadOnly = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.Location = new System.Drawing.Point(317, 80);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(101, 100);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Ejercicio1GradosSexagesimalesARadianes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 265);
            this.ControlBox = false;
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.HistorialDataGridView);
            this.Controls.Add(this.HistorialButton);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.RadianesTextBox);
            this.Controls.Add(this.GSexagesimalesTextBox);
            this.Controls.Add(this.EquivRadianesLabel);
            this.Controls.Add(this.GSexagesimalLabel);
            this.Controls.Add(this.TituloLabel);
            this.MaximumSize = new System.Drawing.Size(850, 304);
            this.MinimumSize = new System.Drawing.Size(441, 304);
            this.Name = "Ejercicio1GradosSexagesimalesARadianes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.Ejercicio1GradosSexagesimalesARadianes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistorialDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.TextBox GSexagesimalesTextBox;
        private System.Windows.Forms.Label GSexagesimalLabel;
        private System.Windows.Forms.Label EquivRadianesLabel;
        private System.Windows.Forms.TextBox RadianesTextBox;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button HistorialButton;
        private System.Windows.Forms.DataGridView HistorialDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGSexagesimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRadianes;
        private System.Windows.Forms.Button ResetButton;
    }
}

