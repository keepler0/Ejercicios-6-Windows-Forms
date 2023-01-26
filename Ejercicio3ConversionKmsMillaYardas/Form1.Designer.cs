
namespace Ejercicio3ConversionKmsMillaYardas
{
    partial class conversorFrm
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
            this.KmsTextBox = new System.Windows.Forms.TextBox();
            this.MillasTextBox = new System.Windows.Forms.TextBox();
            this.YardasTextBox = new System.Windows.Forms.TextBox();
            this.KmsLabel = new System.Windows.Forms.Label();
            this.MillasLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConversionesDataGridView = new System.Windows.Forms.DataGridView();
            this.colKms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMillas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYardas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.convertirButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.historialButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConversionesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // KmsTextBox
            // 
            this.KmsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.KmsTextBox.Location = new System.Drawing.Point(42, 80);
            this.KmsTextBox.Name = "KmsTextBox";
            this.KmsTextBox.Size = new System.Drawing.Size(126, 23);
            this.KmsTextBox.TabIndex = 1;
            this.KmsTextBox.TextChanged += new System.EventHandler(this.KmsTextBox_TextChanged);
            // 
            // MillasTextBox
            // 
            this.MillasTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MillasTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MillasTextBox.Location = new System.Drawing.Point(42, 133);
            this.MillasTextBox.Name = "MillasTextBox";
            this.MillasTextBox.ReadOnly = true;
            this.MillasTextBox.Size = new System.Drawing.Size(126, 23);
            this.MillasTextBox.TabIndex = 0;
            this.MillasTextBox.TabStop = false;
            // 
            // YardasTextBox
            // 
            this.YardasTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YardasTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.YardasTextBox.Location = new System.Drawing.Point(42, 189);
            this.YardasTextBox.Name = "YardasTextBox";
            this.YardasTextBox.ReadOnly = true;
            this.YardasTextBox.Size = new System.Drawing.Size(126, 23);
            this.YardasTextBox.TabIndex = 0;
            this.YardasTextBox.TabStop = false;
            // 
            // KmsLabel
            // 
            this.KmsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.KmsLabel.AutoSize = true;
            this.KmsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KmsLabel.Location = new System.Drawing.Point(42, 57);
            this.KmsLabel.Name = "KmsLabel";
            this.KmsLabel.Size = new System.Drawing.Size(82, 20);
            this.KmsLabel.TabIndex = 1;
            this.KmsLabel.Text = "Kilometros";
            this.KmsLabel.Click += new System.EventHandler(this.KmsLabel_Click);
            // 
            // MillasLabel
            // 
            this.MillasLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MillasLabel.AutoSize = true;
            this.MillasLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MillasLabel.Location = new System.Drawing.Point(42, 110);
            this.MillasLabel.Name = "MillasLabel";
            this.MillasLabel.Size = new System.Drawing.Size(49, 20);
            this.MillasLabel.TabIndex = 2;
            this.MillasLabel.Text = "Millas";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yardas";
            // 
            // ConversionesDataGridView
            // 
            this.ConversionesDataGridView.AllowUserToAddRows = false;
            this.ConversionesDataGridView.AllowUserToDeleteRows = false;
            this.ConversionesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConversionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConversionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKms,
            this.colMillas,
            this.colYardas});
            this.ConversionesDataGridView.Location = new System.Drawing.Point(328, 53);
            this.ConversionesDataGridView.MultiSelect = false;
            this.ConversionesDataGridView.Name = "ConversionesDataGridView";
            this.ConversionesDataGridView.ReadOnly = true;
            this.ConversionesDataGridView.RowTemplate.Height = 25;
            this.ConversionesDataGridView.Size = new System.Drawing.Size(310, 292);
            this.ConversionesDataGridView.TabIndex = 0;
            // 
            // colKms
            // 
            this.colKms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.colKms.DefaultCellStyle = dataGridViewCellStyle1;
            this.colKms.HeaderText = "Kilometros";
            this.colKms.Name = "colKms";
            this.colKms.ReadOnly = true;
            // 
            // colMillas
            // 
            this.colMillas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMillas.HeaderText = "Millas";
            this.colMillas.Name = "colMillas";
            this.colMillas.ReadOnly = true;
            // 
            // colYardas
            // 
            this.colYardas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colYardas.HeaderText = "Yardas";
            this.colYardas.Name = "colYardas";
            this.colYardas.ReadOnly = true;
            // 
            // convertirButton
            // 
            this.convertirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.convertirButton.BackColor = System.Drawing.Color.Transparent;
            this.convertirButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.convertirButton.Location = new System.Drawing.Point(42, 229);
            this.convertirButton.Name = "convertirButton";
            this.convertirButton.Size = new System.Drawing.Size(88, 85);
            this.convertirButton.TabIndex = 3;
            this.convertirButton.Text = "Convertir";
            this.convertirButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.convertirButton.UseVisualStyleBackColor = false;
            this.convertirButton.Click += new System.EventHandler(this.convertirButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(174, 229);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(88, 85);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor Kilometros a Millas y Yardas";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // historialButton
            // 
            this.historialButton.BackColor = System.Drawing.Color.Transparent;
            this.historialButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.historialButton.Location = new System.Drawing.Point(174, 80);
            this.historialButton.Name = "historialButton";
            this.historialButton.Size = new System.Drawing.Size(108, 132);
            this.historialButton.TabIndex = 2;
            this.historialButton.Text = "Historial de conversiones";
            this.historialButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.historialButton.UseVisualStyleBackColor = false;
            this.historialButton.Click += new System.EventHandler(this.historialButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(417, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Historial";
            // 
            // conversorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.historialButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.convertirButton);
            this.Controls.Add(this.ConversionesDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MillasLabel);
            this.Controls.Add(this.KmsLabel);
            this.Controls.Add(this.YardasTextBox);
            this.Controls.Add(this.MillasTextBox);
            this.Controls.Add(this.KmsTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(666, 396);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(310, 396);
            this.Name = "conversorFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion kilometros-millas-yardas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.conversorFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ConversionesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KmsTextBox;
        private System.Windows.Forms.TextBox MillasTextBox;
        private System.Windows.Forms.TextBox YardasTextBox;
        private System.Windows.Forms.Label KmsLabel;
        private System.Windows.Forms.Label MillasLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ConversionesDataGridView;
        private System.Windows.Forms.Button convertirButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button historialButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMillas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYardas;
    }
}

