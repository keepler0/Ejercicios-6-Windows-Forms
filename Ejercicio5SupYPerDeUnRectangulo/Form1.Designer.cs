namespace Ejercicios5
{
    partial class superficiePerimetroFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(superficiePerimetroFRM));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ladoMayortTextBox = new System.Windows.Forms.TextBox();
            this.LadoMenorTextBox = new System.Windows.Forms.TextBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colLadoMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadoMenor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuperficie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculador de superficie y perimetro del rectangulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado mayor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lado menor:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ladoMayortTextBox
            // 
            this.ladoMayortTextBox.Location = new System.Drawing.Point(105, 57);
            this.ladoMayortTextBox.Name = "ladoMayortTextBox";
            this.ladoMayortTextBox.Size = new System.Drawing.Size(100, 23);
            this.ladoMayortTextBox.TabIndex = 1;
            // 
            // LadoMenorTextBox
            // 
            this.LadoMenorTextBox.Location = new System.Drawing.Point(105, 107);
            this.LadoMenorTextBox.Name = "LadoMenorTextBox";
            this.LadoMenorTextBox.Size = new System.Drawing.Size(100, 23);
            this.LadoMenorTextBox.TabIndex = 2;
            // 
            // calcularButton
            // 
            this.calcularButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calcularButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calcularButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.calcularButton.Image = ((System.Drawing.Image)(resources.GetObject("calcularButton.Image")));
            this.calcularButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.calcularButton.Location = new System.Drawing.Point(234, 51);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(84, 88);
            this.calcularButton.TabIndex = 3;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.calcularButton.UseVisualStyleBackColor = false;
            this.calcularButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLadoMayor,
            this.colLadoMenor,
            this.colSuperficie,
            this.colPerimetro});
            this.dataGridView1.Location = new System.Drawing.Point(3, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(315, 252);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colLadoMayor
            // 
            this.colLadoMayor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLadoMayor.HeaderText = "Lado mayor";
            this.colLadoMayor.Name = "colLadoMayor";
            this.colLadoMayor.ReadOnly = true;
            // 
            // colLadoMenor
            // 
            this.colLadoMenor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLadoMenor.HeaderText = "Lado menor";
            this.colLadoMenor.Name = "colLadoMenor";
            this.colLadoMenor.ReadOnly = true;
            // 
            // colSuperficie
            // 
            this.colSuperficie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSuperficie.HeaderText = "Superficie";
            this.colSuperficie.Name = "colSuperficie";
            this.colSuperficie.ReadOnly = true;
            // 
            // colPerimetro
            // 
            this.colPerimetro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPerimetro.HeaderText = "Perimetro";
            this.colPerimetro.Name = "colPerimetro";
            this.colPerimetro.ReadOnly = true;
            // 
            // superficiePerimetroFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.LadoMenorTextBox);
            this.Controls.Add(this.ladoMayortTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(336, 489);
            this.MinimumSize = new System.Drawing.Size(336, 489);
            this.Name = "superficiePerimetroFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.superficiePerimetroFRM_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ladoMayortTextBox;
        private TextBox LadoMenorTextBox;
        private Button calcularButton;
        private ErrorProvider errorProvider;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colLadoMayor;
        private DataGridViewTextBoxColumn colLadoMenor;
        private DataGridViewTextBoxColumn colSuperficie;
        private DataGridViewTextBoxColumn colPerimetro;
    }
}