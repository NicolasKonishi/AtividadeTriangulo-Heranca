namespace Triangulo
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
            lblLado1 = new Label();
            lblLado2 = new Label();
            lblLado3 = new Label();
            txblado1 = new TextBox();
            txbLado2 = new TextBox();
            txbLado3 = new TextBox();
            btnVeriicar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblLado1
            // 
            lblLado1.AutoSize = true;
            lblLado1.Font = new Font("Segoe UI", 14.25F);
            lblLado1.ForeColor = Color.Black;
            lblLado1.Location = new Point(88, 17);
            lblLado1.Name = "lblLado1";
            lblLado1.Size = new Size(68, 25);
            lblLado1.TabIndex = 0;
            lblLado1.Text = "Lado 1";
            // 
            // lblLado2
            // 
            lblLado2.AutoSize = true;
            lblLado2.Font = new Font("Segoe UI", 14.25F);
            lblLado2.ForeColor = Color.Black;
            lblLado2.Location = new Point(88, 91);
            lblLado2.Name = "lblLado2";
            lblLado2.Size = new Size(68, 25);
            lblLado2.TabIndex = 1;
            lblLado2.Text = "Lado 2";
            lblLado2.Click += lblLado2_Click;
            // 
            // lblLado3
            // 
            lblLado3.AutoSize = true;
            lblLado3.Font = new Font("Segoe UI", 14.25F);
            lblLado3.ForeColor = Color.Black;
            lblLado3.Location = new Point(88, 165);
            lblLado3.Name = "lblLado3";
            lblLado3.Size = new Size(68, 25);
            lblLado3.TabIndex = 2;
            lblLado3.Text = "Lado 3";
            // 
            // txblado1
            // 
            txblado1.Font = new Font("Segoe UI", 14.25F);
            txblado1.Location = new Point(88, 50);
            txblado1.Margin = new Padding(3, 2, 3, 2);
            txblado1.Name = "txblado1";
            txblado1.Size = new Size(68, 33);
            txblado1.TabIndex = 3;
            // 
            // txbLado2
            // 
            txbLado2.Font = new Font("Segoe UI", 14.25F);
            txbLado2.Location = new Point(88, 124);
            txbLado2.Margin = new Padding(3, 2, 3, 2);
            txbLado2.Name = "txbLado2";
            txbLado2.Size = new Size(68, 33);
            txbLado2.TabIndex = 4;
            // 
            // txbLado3
            // 
            txbLado3.Font = new Font("Segoe UI", 14.25F);
            txbLado3.Location = new Point(88, 198);
            txbLado3.Margin = new Padding(3, 2, 3, 2);
            txbLado3.Name = "txbLado3";
            txbLado3.Size = new Size(68, 33);
            txbLado3.TabIndex = 5;
            // 
            // btnVeriicar
            // 
            btnVeriicar.BackColor = Color.White;
            btnVeriicar.Cursor = Cursors.Hand;
            btnVeriicar.FlatStyle = FlatStyle.Flat;
            btnVeriicar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVeriicar.Location = new Point(67, 238);
            btnVeriicar.Margin = new Padding(3, 2, 3, 2);
            btnVeriicar.Name = "btnVeriicar";
            btnVeriicar.Size = new Size(110, 37);
            btnVeriicar.TabIndex = 6;
            btnVeriicar.Text = "Verificar";
            btnVeriicar.UseVisualStyleBackColor = false;
            btnVeriicar.Click += btnVeriicar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.Black;
            lblResultado.Location = new Point(75, 298);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(94, 25);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado";
            lblResultado.Click += lblResultado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(244, 358);
            Controls.Add(lblResultado);
            Controls.Add(btnVeriicar);
            Controls.Add(txbLado3);
            Controls.Add(txbLado2);
            Controls.Add(txblado1);
            Controls.Add(lblLado3);
            Controls.Add(lblLado2);
            Controls.Add(lblLado1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLado1;
        private Label lblLado2;
        private Label lblLado3;
        private TextBox txblado1;
        private TextBox txbLado2;
        private TextBox txbLado3;
        private Button btnVeriicar;
        private Label lblResultado;
    }
}
