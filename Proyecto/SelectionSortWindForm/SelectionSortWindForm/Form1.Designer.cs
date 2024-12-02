namespace SelectionSortWindForm
{
    partial class Form1
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
            label1 = new Label();
            txtDatos = new TextBox();
            btnOrdenar = new Button();
            lblResultado = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(266, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese numeros separado por ,";
            // 
            // txtDatos
            // 
            txtDatos.Location = new Point(21, 73);
            txtDatos.Name = "txtDatos";
            txtDatos.Size = new Size(403, 31);
            txtDatos.TabIndex = 1;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(312, 124);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(112, 34);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(21, 210);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 27);
            lblResultado.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(172, 370);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 447);
            Controls.Add(button1);
            Controls.Add(lblResultado);
            Controls.Add(btnOrdenar);
            Controls.Add(txtDatos);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDatos;
        private Button btnOrdenar;
        private Label lblResultado;
        private Button button1;
    }
}
