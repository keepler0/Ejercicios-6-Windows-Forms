namespace Ejercicio4
{
    partial class convTempFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(convTempFRM));
            this.convertirButton = new System.Windows.Forms.Button();
            this.reiniciarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.reaumurTextBox = new System.Windows.Forms.TextBox();
            this.fahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.celsiusTextBox = new System.Windows.Forms.TextBox();
            this.salirButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // convertirButton
            // 
            this.convertirButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.convertirButton.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.convertirButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.convertirButton.Image = ((System.Drawing.Image)(resources.GetObject("convertirButton.Image")));
            this.convertirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.convertirButton.Location = new System.Drawing.Point(12, 154);
            this.convertirButton.Name = "convertirButton";
            this.convertirButton.Size = new System.Drawing.Size(296, 67);
            this.convertirButton.TabIndex = 0;
            this.convertirButton.Text = "Convertir";
            this.convertirButton.UseVisualStyleBackColor = false;
            this.convertirButton.Click += new System.EventHandler(this.convertirButton_Click);
            // 
            // reiniciarButton
            // 
            this.reiniciarButton.Location = new System.Drawing.Point(168, 249);
            this.reiniciarButton.Name = "reiniciarButton";
            this.reiniciarButton.Size = new System.Drawing.Size(75, 23);
            this.reiniciarButton.TabIndex = 1;
            this.reiniciarButton.Text = "Reiniciar";
            this.reiniciarButton.UseVisualStyleBackColor = true;
            this.reiniciarButton.Click += new System.EventHandler(this.reiniciarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // reaumurTextBox
            // 
            this.reaumurTextBox.Enabled = false;
            this.reaumurTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reaumurTextBox.Location = new System.Drawing.Point(187, 79);
            this.reaumurTextBox.Name = "reaumurTextBox";
            this.reaumurTextBox.ReadOnly = true;
            this.reaumurTextBox.Size = new System.Drawing.Size(121, 27);
            this.reaumurTextBox.TabIndex = 2;
            // 
            // fahrenheitTextBox
            // 
            this.fahrenheitTextBox.Enabled = false;
            this.fahrenheitTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fahrenheitTextBox.Location = new System.Drawing.Point(187, 121);
            this.fahrenheitTextBox.Name = "fahrenheitTextBox";
            this.fahrenheitTextBox.ReadOnly = true;
            this.fahrenheitTextBox.Size = new System.Drawing.Size(121, 27);
            this.fahrenheitTextBox.TabIndex = 2;
            // 
            // celsiusTextBox
            // 
            this.celsiusTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.celsiusTextBox.Location = new System.Drawing.Point(12, 79);
            this.celsiusTextBox.Multiline = true;
            this.celsiusTextBox.Name = "celsiusTextBox";
            this.celsiusTextBox.Size = new System.Drawing.Size(169, 69);
            this.celsiusTextBox.TabIndex = 2;
            // 
            // salirButton
            // 
            this.salirButton.Location = new System.Drawing.Point(249, 249);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(75, 23);
            this.salirButton.TabIndex = 1;
            this.salirButton.Text = "Salir";
            this.salirButton.UseVisualStyleBackColor = true;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conversor C°/Reaumur/F°";
            // 
            // convTempFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 284);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.celsiusTextBox);
            this.Controls.Add(this.fahrenheitTextBox);
            this.Controls.Add(this.reaumurTextBox);
            this.Controls.Add(this.salirButton);
            this.Controls.Add(this.reiniciarButton);
            this.Controls.Add(this.convertirButton);
            this.MaximumSize = new System.Drawing.Size(352, 323);
            this.MinimumSize = new System.Drawing.Size(352, 323);
            this.Name = "convTempFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Conversor Celsius Reaumur Fahrenheit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.convTempFRM_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button convertirButton;
        private Button reiniciarButton;
        private ErrorProvider errorProvider1;
        private TextBox celsiusTextBox;
        private TextBox fahrenheitTextBox;
        private TextBox reaumurTextBox;
        private Button salirButton;
        private Label label1;
    }
}