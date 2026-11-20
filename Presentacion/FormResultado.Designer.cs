namespace Presentacion
{
    partial class FormResultado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbGanador = new System.Windows.Forms.Label();
            this.lbNombre1 = new System.Windows.Forms.Label();
            this.lbNombre2 = new System.Windows.Forms.Label();
            this.lbPuntaje2 = new System.Windows.Forms.Label();
            this.lbPuntaje1 = new System.Windows.Forms.Label();
            this.btnRevancha = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Partida Finalizada";
            // 
            // lbGanador
            // 
            this.lbGanador.AutoSize = true;
            this.lbGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGanador.ForeColor = System.Drawing.Color.Black;
            this.lbGanador.Location = new System.Drawing.Point(264, 78);
            this.lbGanador.Name = "lbGanador";
            this.lbGanador.Size = new System.Drawing.Size(59, 18);
            this.lbGanador.TabIndex = 1;
            this.lbGanador.Text = "Gano: ";
            // 
            // lbNombre1
            // 
            this.lbNombre1.AutoSize = true;
            this.lbNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre1.Location = new System.Drawing.Point(12, 118);
            this.lbNombre1.Name = "lbNombre1";
            this.lbNombre1.Size = new System.Drawing.Size(70, 18);
            this.lbNombre1.TabIndex = 3;
            this.lbNombre1.Text = "Jugador1";
            // 
            // lbNombre2
            // 
            this.lbNombre2.AutoSize = true;
            this.lbNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre2.Location = new System.Drawing.Point(12, 155);
            this.lbNombre2.Name = "lbNombre2";
            this.lbNombre2.Size = new System.Drawing.Size(70, 18);
            this.lbNombre2.TabIndex = 4;
            this.lbNombre2.Text = "Jugador2";
            // 
            // lbPuntaje2
            // 
            this.lbPuntaje2.AutoSize = true;
            this.lbPuntaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntaje2.Location = new System.Drawing.Point(535, 155);
            this.lbPuntaje2.Name = "lbPuntaje2";
            this.lbPuntaje2.Size = new System.Drawing.Size(67, 18);
            this.lbPuntaje2.TabIndex = 6;
            this.lbPuntaje2.Text = "0 Puntos";
            // 
            // lbPuntaje1
            // 
            this.lbPuntaje1.AutoSize = true;
            this.lbPuntaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntaje1.Location = new System.Drawing.Point(535, 118);
            this.lbPuntaje1.Name = "lbPuntaje1";
            this.lbPuntaje1.Size = new System.Drawing.Size(67, 18);
            this.lbPuntaje1.TabIndex = 5;
            this.lbPuntaje1.Text = "0 Puntos";
            // 
            // btnRevancha
            // 
            this.btnRevancha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevancha.Location = new System.Drawing.Point(131, 197);
            this.btnRevancha.Name = "btnRevancha";
            this.btnRevancha.Size = new System.Drawing.Size(131, 60);
            this.btnRevancha.TabIndex = 7;
            this.btnRevancha.Text = "Revancha";
            this.btnRevancha.UseVisualStyleBackColor = true;
            this.btnRevancha.Click += new System.EventHandler(this.btnRevancha_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(384, 197);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 60);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver al menu";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 300);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRevancha);
            this.Controls.Add(this.lbPuntaje2);
            this.Controls.Add(this.lbPuntaje1);
            this.Controls.Add(this.lbNombre2);
            this.Controls.Add(this.lbNombre1);
            this.Controls.Add(this.lbGanador);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generala - Resultado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbGanador;
        private System.Windows.Forms.Label lbNombre1;
        private System.Windows.Forms.Label lbNombre2;
        private System.Windows.Forms.Label lbPuntaje2;
        private System.Windows.Forms.Label lbPuntaje1;
        private System.Windows.Forms.Button btnRevancha;
        private System.Windows.Forms.Button btnVolver;
    }
}