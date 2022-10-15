namespace Sistema_de_Controle_de
{
    partial class fmmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmmenu));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.buttonclose = new System.Windows.Forms.Button();
            this.panelfixo = new System.Windows.Forms.Panel();
            this.panelcentral = new System.Windows.Forms.Panel();
            this.panellateral = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.panelselecao = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelfixo.SuspendLayout();
            this.panellateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pesquisa-de-lupa (1).png");
            this.imageList1.Images.SetKeyName(1, "conecte-se.png");
            this.imageList1.Images.SetKeyName(2, "estoque-pronto.png");
            this.imageList1.Images.SetKeyName(3, "producao.png");
            this.imageList1.Images.SetKeyName(4, "relatorio-de-lucro.png");
            this.imageList1.Images.SetKeyName(5, "botao-de-inicio.png");
            this.imageList1.Images.SetKeyName(6, "fechar.png");
            this.imageList1.Images.SetKeyName(7, "119-1198492_green-logout-icon-logout-icon-png-red.png");
            this.imageList1.Images.SetKeyName(8, "excluir.png");
            this.imageList1.Images.SetKeyName(9, "logout.png");
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ImageKey = "logout.png";
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(1414, -10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 68);
            this.button7.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button7, "Fazer Logout");
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.BackColor = System.Drawing.Color.Transparent;
            this.buttonclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonclose.FlatAppearance.BorderSize = 0;
            this.buttonclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclose.ImageKey = "excluir.png";
            this.buttonclose.ImageList = this.imageList1;
            this.buttonclose.Location = new System.Drawing.Point(1466, -7);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(92, 64);
            this.buttonclose.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonclose, "Fechar");
            this.buttonclose.UseVisualStyleBackColor = false;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // panelfixo
            // 
            this.panelfixo.BackColor = System.Drawing.Color.Transparent;
            this.panelfixo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelfixo.Controls.Add(this.button7);
            this.panelfixo.Controls.Add(this.buttonclose);
            this.panelfixo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelfixo.Location = new System.Drawing.Point(0, 0);
            this.panelfixo.Name = "panelfixo";
            this.panelfixo.Size = new System.Drawing.Size(1550, 50);
            this.panelfixo.TabIndex = 0;
            this.panelfixo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelfixo_Paint);
            // 
            // panelcentral
            // 
            this.panelcentral.BackgroundImage = global::Sistema_de_Controle_de.Properties.Resources.Web_Designer_com_Desenho_em_Códigos_Amarelo_Minimalista_Logo__2_1;
            this.panelcentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcentral.Location = new System.Drawing.Point(286, 50);
            this.panelcentral.Name = "panelcentral";
            this.panelcentral.Size = new System.Drawing.Size(1264, 830);
            this.panelcentral.TabIndex = 2;
            this.panelcentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcentral_Paint_1);
            // 
            // panellateral
            // 
            this.panellateral.BackColor = System.Drawing.Color.White;
            this.panellateral.BackgroundImage = global::Sistema_de_Controle_de.Properties.Resources.download;
            this.panellateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panellateral.Controls.Add(this.label1);
            this.panellateral.Controls.Add(this.button6);
            this.panellateral.Controls.Add(this.panelselecao);
            this.panellateral.Controls.Add(this.button5);
            this.panellateral.Controls.Add(this.button4);
            this.panellateral.Controls.Add(this.button3);
            this.panellateral.Controls.Add(this.button2);
            this.panellateral.Controls.Add(this.button1);
            this.panellateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panellateral.Location = new System.Drawing.Point(0, 50);
            this.panellateral.Name = "panellateral";
            this.panellateral.Size = new System.Drawing.Size(286, 830);
            this.panellateral.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(147, 785);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "© nomus, 2022";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.ImageKey = "botao-de-inicio.png";
            this.button6.ImageList = this.imageList1;
            this.button6.Location = new System.Drawing.Point(69, 66);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(191, 65);
            this.button6.TabIndex = 5;
            this.button6.Text = "INICIO";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panelselecao
            // 
            this.panelselecao.BackColor = System.Drawing.Color.Transparent;
            this.panelselecao.BackgroundImage = global::Sistema_de_Controle_de.Properties.Resources.icons8_dedos_de_espuma_48;
            this.panelselecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelselecao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panelselecao.Location = new System.Drawing.Point(12, 66);
            this.panelselecao.Name = "panelselecao";
            this.panelselecao.Size = new System.Drawing.Size(41, 45);
            this.panelselecao.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.ImageKey = "relatorio-de-lucro.png";
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(69, 684);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 65);
            this.button5.TabIndex = 4;
            this.button5.Text = "RELATÓRIO";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.ImageKey = "producao.png";
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(69, 573);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = " PRODUÇÃO";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageKey = "estoque-pronto.png";
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(69, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "CONTROLE DE ESTOQUE";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "pesquisa-de-lupa (1).png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(69, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "CONSULTAS";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageKey = "conecte-se.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(69, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "CADASTROS";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 880);
            this.Controls.Add(this.panelcentral);
            this.Controls.Add(this.panellateral);
            this.Controls.Add(this.panelfixo);
            this.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "fmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelfixo.ResumeLayout(false);
            this.panellateral.ResumeLayout(false);
            this.panellateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelfixo;
        private System.Windows.Forms.Panel panellateral;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Panel panelcentral;
        private System.Windows.Forms.Panel panelselecao;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

