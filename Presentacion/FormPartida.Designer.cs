namespace Presentacion
{
    partial class FormPartida
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
            this.label2 = new System.Windows.Forms.Label();
            this.LbTurnero = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbContador = new System.Windows.Forms.Label();
            this.btnLanzarDados = new System.Windows.Forms.Button();
            this.dgvPuntajes = new System.Windows.Forms.DataGridView();
            this.btnAbandonar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDado3 = new System.Windows.Forms.Button();
            this.btnDado4 = new System.Windows.Forms.Button();
            this.btnDado2 = new System.Windows.Forms.Button();
            this.btnDado5 = new System.Windows.Forms.Button();
            this.btnDado1 = new System.Windows.Forms.Button();
            this.btnAnotar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntajes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "GENERALA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Partida en curso";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LbTurnero
            // 
            this.LbTurnero.AutoSize = true;
            this.LbTurnero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTurnero.Location = new System.Drawing.Point(358, 104);
            this.LbTurnero.Name = "LbTurnero";
            this.LbTurnero.Size = new System.Drawing.Size(120, 25);
            this.LbTurnero.TabIndex = 4;
            this.LbTurnero.Text = " Turno de:";
            this.LbTurnero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Selecciona los dados que quieras conservar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LbContador
            // 
            this.LbContador.AutoSize = true;
            this.LbContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbContador.Location = new System.Drawing.Point(360, 280);
            this.LbContador.Name = "LbContador";
            this.LbContador.Size = new System.Drawing.Size(117, 18);
            this.LbContador.TabIndex = 12;
            this.LbContador.Text = "Lanzamiento 0/3";
            this.LbContador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLanzarDados
            // 
            this.btnLanzarDados.Location = new System.Drawing.Point(17, 312);
            this.btnLanzarDados.Name = "btnLanzarDados";
            this.btnLanzarDados.Size = new System.Drawing.Size(807, 40);
            this.btnLanzarDados.TabIndex = 13;
            this.btnLanzarDados.Text = "Lanzar Dados";
            this.btnLanzarDados.UseVisualStyleBackColor = true;
            this.btnLanzarDados.Click += new System.EventHandler(this.btnLanzarDados_Click);
            // 
            // dgvPuntajes
            // 
            this.dgvPuntajes.AllowUserToAddRows = false;
            this.dgvPuntajes.AllowUserToDeleteRows = false;
            this.dgvPuntajes.AllowUserToResizeRows = false;
            this.dgvPuntajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuntajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntajes.Location = new System.Drawing.Point(35, 358);
            this.dgvPuntajes.MultiSelect = false;
            this.dgvPuntajes.Name = "dgvPuntajes";
            this.dgvPuntajes.ReadOnly = true;
            this.dgvPuntajes.RowHeadersVisible = false;
            this.dgvPuntajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuntajes.Size = new System.Drawing.Size(767, 308);
            this.dgvPuntajes.TabIndex = 14;
            // 
            // btnAbandonar
            // 
            this.btnAbandonar.BackColor = System.Drawing.Color.IndianRed;
            this.btnAbandonar.Location = new System.Drawing.Point(692, 672);
            this.btnAbandonar.Name = "btnAbandonar";
            this.btnAbandonar.Size = new System.Drawing.Size(110, 46);
            this.btnAbandonar.TabIndex = 15;
            this.btnAbandonar.Text = "Abandonar Partida";
            this.btnAbandonar.UseVisualStyleBackColor = false;
            this.btnAbandonar.Click += new System.EventHandler(this.btnAbandonar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDado3);
            this.panel1.Controls.Add(this.btnDado4);
            this.panel1.Controls.Add(this.btnDado2);
            this.panel1.Controls.Add(this.btnDado5);
            this.panel1.Controls.Add(this.btnDado1);
            this.panel1.Location = new System.Drawing.Point(12, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 100);
            this.panel1.TabIndex = 16;
            // 
            // btnDado3
            // 
            this.btnDado3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDado3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDado3.FlatAppearance.BorderSize = 2;
            this.btnDado3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDado3.Location = new System.Drawing.Point(361, 7);
            this.btnDado3.Name = "btnDado3";
            this.btnDado3.Size = new System.Drawing.Size(90, 90);
            this.btnDado3.TabIndex = 4;
            this.btnDado3.UseVisualStyleBackColor = true;
            this.btnDado3.Click += new System.EventHandler(this.btnDado3_Click);
            // 
            // btnDado4
            // 
            this.btnDado4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDado4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDado4.FlatAppearance.BorderSize = 2;
            this.btnDado4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDado4.Location = new System.Drawing.Point(457, 7);
            this.btnDado4.Name = "btnDado4";
            this.btnDado4.Size = new System.Drawing.Size(90, 90);
            this.btnDado4.TabIndex = 3;
            this.btnDado4.UseVisualStyleBackColor = true;
            this.btnDado4.Click += new System.EventHandler(this.btnDado4_Click);
            // 
            // btnDado2
            // 
            this.btnDado2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDado2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDado2.FlatAppearance.BorderSize = 2;
            this.btnDado2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDado2.Location = new System.Drawing.Point(265, 7);
            this.btnDado2.Name = "btnDado2";
            this.btnDado2.Size = new System.Drawing.Size(90, 90);
            this.btnDado2.TabIndex = 2;
            this.btnDado2.UseVisualStyleBackColor = true;
            this.btnDado2.Click += new System.EventHandler(this.btnDado2_Click);
            // 
            // btnDado5
            // 
            this.btnDado5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDado5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDado5.FlatAppearance.BorderSize = 2;
            this.btnDado5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDado5.Location = new System.Drawing.Point(553, 7);
            this.btnDado5.Name = "btnDado5";
            this.btnDado5.Size = new System.Drawing.Size(90, 90);
            this.btnDado5.TabIndex = 1;
            this.btnDado5.UseVisualStyleBackColor = true;
            this.btnDado5.Click += new System.EventHandler(this.btnDado5_Click);
            // 
            // btnDado1
            // 
            this.btnDado1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDado1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDado1.FlatAppearance.BorderSize = 2;
            this.btnDado1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDado1.Location = new System.Drawing.Point(169, 7);
            this.btnDado1.Name = "btnDado1";
            this.btnDado1.Size = new System.Drawing.Size(90, 90);
            this.btnDado1.TabIndex = 0;
            this.btnDado1.UseVisualStyleBackColor = true;
            this.btnDado1.Click += new System.EventHandler(this.btnDado1_Click);
            // 
            // btnAnotar
            // 
            this.btnAnotar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAnotar.Location = new System.Drawing.Point(35, 672);
            this.btnAnotar.Name = "btnAnotar";
            this.btnAnotar.Size = new System.Drawing.Size(104, 46);
            this.btnAnotar.TabIndex = 17;
            this.btnAnotar.Text = "Anotar Puntos";
            this.btnAnotar.UseVisualStyleBackColor = false;
            this.btnAnotar.Click += new System.EventHandler(this.btnAnotar_Click);
            // 
            // FormPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 727);
            this.Controls.Add(this.btnAnotar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAbandonar);
            this.Controls.Add(this.dgvPuntajes);
            this.Controls.Add(this.btnLanzarDados);
            this.Controls.Add(this.LbContador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbTurnero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generala - Partida";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntajes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbTurnero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbContador;
        private System.Windows.Forms.Button btnLanzarDados;
        private System.Windows.Forms.DataGridView dgvPuntajes;
        private System.Windows.Forms.Button btnAbandonar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDado1;
        private System.Windows.Forms.Button btnDado3;
        private System.Windows.Forms.Button btnDado4;
        private System.Windows.Forms.Button btnDado2;
        private System.Windows.Forms.Button btnDado5;
        private System.Windows.Forms.Button btnAnotar;
    }
}