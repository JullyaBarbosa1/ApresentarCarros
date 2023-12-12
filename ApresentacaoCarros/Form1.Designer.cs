namespace ApresentacaoCarros
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbDados = new System.Windows.Forms.GroupBox();
            this.TbPortas = new System.Windows.Forms.Label();
            this.PortasTB = new System.Windows.Forms.TextBox();
            this.TbModelo = new System.Windows.Forms.Label();
            this.TbAno = new System.Windows.Forms.Label();
            this.TbMarca = new System.Windows.Forms.Label();
            this.labelSaudacao = new System.Windows.Forms.Label();
            this.DiaSemana = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AnoTB = new System.Windows.Forms.TextBox();
            this.ModeloTB = new System.Windows.Forms.TextBox();
            this.MarcaTB = new System.Windows.Forms.TextBox();
            this.tbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carros Antigos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbDados
            // 
            this.tbDados.BackColor = System.Drawing.Color.Transparent;
            this.tbDados.Controls.Add(this.MarcaTB);
            this.tbDados.Controls.Add(this.ModeloTB);
            this.tbDados.Controls.Add(this.AnoTB);
            this.tbDados.Controls.Add(this.TbPortas);
            this.tbDados.Controls.Add(this.PortasTB);
            this.tbDados.Controls.Add(this.TbModelo);
            this.tbDados.Controls.Add(this.TbAno);
            this.tbDados.Controls.Add(this.TbMarca);
            this.tbDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbDados.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDados.Location = new System.Drawing.Point(440, 77);
            this.tbDados.Name = "tbDados";
            this.tbDados.Size = new System.Drawing.Size(348, 341);
            this.tbDados.TabIndex = 2;
            this.tbDados.TabStop = false;
            this.tbDados.Text = "Dados";
            this.tbDados.Enter += new System.EventHandler(this.Dados_Enter);
            // 
            // TbPortas
            // 
            this.TbPortas.AutoSize = true;
            this.TbPortas.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPortas.ForeColor = System.Drawing.Color.White;
            this.TbPortas.Location = new System.Drawing.Point(1, 250);
            this.TbPortas.Name = "TbPortas";
            this.TbPortas.Size = new System.Drawing.Size(76, 23);
            this.TbPortas.TabIndex = 6;
            this.TbPortas.Text = "Portas:";
            // 
            // PortasTB
            // 
            this.PortasTB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortasTB.Location = new System.Drawing.Point(37, 276);
            this.PortasTB.Multiline = true;
            this.PortasTB.Name = "PortasTB";
            this.PortasTB.Size = new System.Drawing.Size(281, 46);
            this.PortasTB.TabIndex = 5;
            // 
            // TbModelo
            // 
            this.TbModelo.AutoSize = true;
            this.TbModelo.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbModelo.ForeColor = System.Drawing.Color.White;
            this.TbModelo.Location = new System.Drawing.Point(2, 99);
            this.TbModelo.Name = "TbModelo";
            this.TbModelo.Size = new System.Drawing.Size(90, 23);
            this.TbModelo.TabIndex = 2;
            this.TbModelo.Text = "Modelo:";
            // 
            // TbAno
            // 
            this.TbAno.AutoSize = true;
            this.TbAno.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAno.ForeColor = System.Drawing.Color.White;
            this.TbAno.Location = new System.Drawing.Point(1, 174);
            this.TbAno.Name = "TbAno";
            this.TbAno.Size = new System.Drawing.Size(57, 23);
            this.TbAno.TabIndex = 1;
            this.TbAno.Text = "Ano:";
            // 
            // TbMarca
            // 
            this.TbMarca.AutoSize = true;
            this.TbMarca.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMarca.ForeColor = System.Drawing.Color.White;
            this.TbMarca.Location = new System.Drawing.Point(1, 23);
            this.TbMarca.Name = "TbMarca";
            this.TbMarca.Size = new System.Drawing.Size(75, 23);
            this.TbMarca.TabIndex = 0;
            this.TbMarca.Text = "Marca:";
            // 
            // labelSaudacao
            // 
            this.labelSaudacao.AutoSize = true;
            this.labelSaudacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaudacao.Location = new System.Drawing.Point(15, 54);
            this.labelSaudacao.Name = "labelSaudacao";
            this.labelSaudacao.Size = new System.Drawing.Size(104, 20);
            this.labelSaudacao.TabIndex = 3;
            this.labelSaudacao.Text = "lbSaudacao";
            // 
            // DiaSemana
            // 
            this.DiaSemana.AutoSize = true;
            this.DiaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaSemana.Location = new System.Drawing.Point(15, 90);
            this.DiaSemana.Name = "DiaSemana";
            this.DiaSemana.Size = new System.Drawing.Size(102, 20);
            this.DiaSemana.TabIndex = 4;
            this.DiaSemana.Text = "DiaSemana";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(174, 90);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(62, 20);
            this.lbData.TabIndex = 5;
            this.lbData.Text = "lbData";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(279, 90);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(62, 20);
            this.lbHora.TabIndex = 6;
            this.lbHora.Text = "lbHora";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBar1.Location = new System.Drawing.Point(12, 424);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(770, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AnoTB
            // 
            this.AnoTB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnoTB.Location = new System.Drawing.Point(37, 201);
            this.AnoTB.Multiline = true;
            this.AnoTB.Name = "AnoTB";
            this.AnoTB.Size = new System.Drawing.Size(281, 46);
            this.AnoTB.TabIndex = 7;
            this.AnoTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ModeloTB
            // 
            this.ModeloTB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeloTB.Location = new System.Drawing.Point(37, 125);
            this.ModeloTB.Multiline = true;
            this.ModeloTB.Name = "ModeloTB";
            this.ModeloTB.Size = new System.Drawing.Size(281, 46);
            this.ModeloTB.TabIndex = 8;
            // 
            // MarcaTB
            // 
            this.MarcaTB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaTB.Location = new System.Drawing.Point(37, 50);
            this.MarcaTB.Multiline = true;
            this.MarcaTB.Name = "MarcaTB";
            this.MarcaTB.Size = new System.Drawing.Size(281, 46);
            this.MarcaTB.TabIndex = 9;
            this.MarcaTB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.DiaSemana);
            this.Controls.Add(this.labelSaudacao);
            this.Controls.Add(this.tbDados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbDados.ResumeLayout(false);
            this.tbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox tbDados;
        private System.Windows.Forms.Label TbPortas;
        private System.Windows.Forms.TextBox PortasTB;
        private System.Windows.Forms.Label TbModelo;
        private System.Windows.Forms.Label TbAno;
        private System.Windows.Forms.Label TbMarca;
        private System.Windows.Forms.Label labelSaudacao;
        private System.Windows.Forms.Label DiaSemana;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox AnoTB;
        private System.Windows.Forms.TextBox MarcaTB;
        private System.Windows.Forms.TextBox ModeloTB;
    }
}

