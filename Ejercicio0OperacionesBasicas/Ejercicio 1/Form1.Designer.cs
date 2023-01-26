namespace Ejercicio_1
{
    partial class opBasicasForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SumaButton = new System.Windows.Forms.Button();
            this.RestaButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.num1TxtBox = new System.Windows.Forms.TextBox();
            this.num2TxtBox = new System.Windows.Forms.TextBox();
            this.ProductoButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ErroresErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErroresErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Número:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Segundo número:";
            // 
            // SumaButton
            // 
            this.SumaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SumaButton.Location = new System.Drawing.Point(39, 142);
            this.SumaButton.Name = "SumaButton";
            this.SumaButton.Size = new System.Drawing.Size(75, 65);
            this.SumaButton.TabIndex = 3;
            this.SumaButton.Text = "Suma";
            this.SumaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SumaButton.UseVisualStyleBackColor = true;
            this.SumaButton.Click += new System.EventHandler(this.SumaButton_Click);
            // 
            // RestaButton
            // 
            this.RestaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RestaButton.Location = new System.Drawing.Point(144, 142);
            this.RestaButton.Name = "RestaButton";
            this.RestaButton.Size = new System.Drawing.Size(75, 65);
            this.RestaButton.TabIndex = 4;
            this.RestaButton.Text = "Resta";
            this.RestaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RestaButton.UseVisualStyleBackColor = true;
            this.RestaButton.Click += new System.EventHandler(this.RestaButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionButton.Location = new System.Drawing.Point(144, 226);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(75, 64);
            this.DivisionButton.TabIndex = 6;
            this.DivisionButton.Text = "Dividir";
            this.DivisionButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // num1TxtBox
            // 
            this.num1TxtBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.num1TxtBox.Location = new System.Drawing.Point(117, 55);
            this.num1TxtBox.Name = "num1TxtBox";
            this.num1TxtBox.Size = new System.Drawing.Size(116, 23);
            this.num1TxtBox.TabIndex = 1;
            // 
            // num2TxtBox
            // 
            this.num2TxtBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.num2TxtBox.Location = new System.Drawing.Point(117, 97);
            this.num2TxtBox.Name = "num2TxtBox";
            this.num2TxtBox.Size = new System.Drawing.Size(116, 23);
            this.num2TxtBox.TabIndex = 2;
            // 
            // ProductoButton
            // 
            this.ProductoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductoButton.Location = new System.Drawing.Point(39, 226);
            this.ProductoButton.Name = "ProductoButton";
            this.ProductoButton.Size = new System.Drawing.Size(75, 64);
            this.ProductoButton.TabIndex = 5;
            this.ProductoButton.Text = "Multiplicar";
            this.ProductoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProductoButton.UseVisualStyleBackColor = true;
            this.ProductoButton.Click += new System.EventHandler(this.ProductoButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SalirButton.Location = new System.Drawing.Point(158, 323);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(75, 23);
            this.SalirButton.TabIndex = 8;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Location = new System.Drawing.Point(77, 323);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ErroresErrorProvider
            // 
            this.ErroresErrorProvider.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Calculadora de Operaciones Básicas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // opBasicasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 358);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num2TxtBox);
            this.Controls.Add(this.num1TxtBox);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.ProductoButton);
            this.Controls.Add(this.RestaButton);
            this.Controls.Add(this.SumaButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(279, 397);
            this.MinimumSize = new System.Drawing.Size(279, 397);
            this.Name = "opBasicasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones básicas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErroresErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button SumaButton;
        private Button RestaButton;
        private Button DivisionButton;
        private TextBox num1TxtBox;
        private TextBox num2TxtBox;
        private Button ProductoButton;
        private Button SalirButton;
        private Button ResetButton;
        private Label label3;
        private ErrorProvider ErroresErrorProvider;
    }
}