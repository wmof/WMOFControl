namespace WMOFControl.GUI
{
    partial class FormCliente
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
            this.listViewCliente = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btPgDetalhes = new System.Windows.Forms.Button();
            this.btPgDelete = new System.Windows.Forms.Button();
            this.btPg = new System.Windows.Forms.Button();
            this.btPgCadastrar = new System.Windows.Forms.Button();
            this.listViewPagamentos = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btProd = new System.Windows.Forms.Button();
            this.btProdAlterar = new System.Windows.Forms.Button();
            this.btProdCadastrar = new System.Windows.Forms.Button();
            this.btProdDetalhes = new System.Windows.Forms.Button();
            this.btProdPronto = new System.Windows.Forms.Button();
            this.listViewProduto = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewDemandas = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAlterar = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewCliente
            // 
            this.listViewCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewCliente.FullRowSelect = true;
            this.listViewCliente.GridLines = true;
            this.listViewCliente.Location = new System.Drawing.Point(12, 12);
            this.listViewCliente.Name = "listViewCliente";
            this.listViewCliente.Size = new System.Drawing.Size(760, 638);
            this.listViewCliente.TabIndex = 0;
            this.listViewCliente.UseCompatibleStateImageBehavior = false;
            this.listViewCliente.View = System.Windows.Forms.View.Details;
            this.listViewCliente.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listViewCliente.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 175;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefone";
            this.columnHeader3.Width = 123;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E-mail";
            this.columnHeader4.Width = 224;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CPF/CNPJ";
            this.columnHeader5.Width = 173;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(12, 656);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Enabled = false;
            this.btDelete.Location = new System.Drawing.Point(174, 656);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Deletar";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btPgDetalhes);
            this.groupBox1.Controls.Add(this.btPgDelete);
            this.groupBox1.Controls.Add(this.btPg);
            this.groupBox1.Controls.Add(this.btPgCadastrar);
            this.groupBox1.Controls.Add(this.listViewPagamentos);
            this.groupBox1.Location = new System.Drawing.Point(778, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagamentos";
            // 
            // btPgDetalhes
            // 
            this.btPgDetalhes.Enabled = false;
            this.btPgDetalhes.Location = new System.Drawing.Point(479, 48);
            this.btPgDetalhes.Name = "btPgDetalhes";
            this.btPgDetalhes.Size = new System.Drawing.Size(75, 23);
            this.btPgDetalhes.TabIndex = 5;
            this.btPgDetalhes.Text = "+ Detalhes";
            this.btPgDetalhes.UseVisualStyleBackColor = true;
            this.btPgDetalhes.Click += new System.EventHandler(this.btPgDetalhes_Click);
            // 
            // btPgDelete
            // 
            this.btPgDelete.Enabled = false;
            this.btPgDelete.Location = new System.Drawing.Point(479, 181);
            this.btPgDelete.Name = "btPgDelete";
            this.btPgDelete.Size = new System.Drawing.Size(75, 23);
            this.btPgDelete.TabIndex = 3;
            this.btPgDelete.Text = "Deletar";
            this.btPgDelete.UseVisualStyleBackColor = true;
            this.btPgDelete.Click += new System.EventHandler(this.btPgDelete_Click);
            // 
            // btPg
            // 
            this.btPg.Enabled = false;
            this.btPg.Location = new System.Drawing.Point(479, 19);
            this.btPg.Name = "btPg";
            this.btPg.Size = new System.Drawing.Size(75, 23);
            this.btPg.TabIndex = 2;
            this.btPg.Text = "Pago";
            this.btPg.UseVisualStyleBackColor = true;
            this.btPg.Click += new System.EventHandler(this.btPg_Click);
            // 
            // btPgCadastrar
            // 
            this.btPgCadastrar.Location = new System.Drawing.Point(479, 151);
            this.btPgCadastrar.Name = "btPgCadastrar";
            this.btPgCadastrar.Size = new System.Drawing.Size(75, 24);
            this.btPgCadastrar.TabIndex = 1;
            this.btPgCadastrar.Text = "Cadastrar";
            this.btPgCadastrar.UseVisualStyleBackColor = true;
            this.btPgCadastrar.Click += new System.EventHandler(this.btPgCadastrar_Click);
            // 
            // listViewPagamentos
            // 
            this.listViewPagamentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewPagamentos.FullRowSelect = true;
            this.listViewPagamentos.GridLines = true;
            this.listViewPagamentos.Location = new System.Drawing.Point(6, 19);
            this.listViewPagamentos.Name = "listViewPagamentos";
            this.listViewPagamentos.Size = new System.Drawing.Size(467, 185);
            this.listViewPagamentos.TabIndex = 0;
            this.listViewPagamentos.UseCompatibleStateImageBehavior = false;
            this.listViewPagamentos.View = System.Windows.Forms.View.Details;
            this.listViewPagamentos.SelectedIndexChanged += new System.EventHandler(this.listViewPagamentos_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Data de Venc.";
            this.columnHeader7.Width = 91;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Data Realizado";
            this.columnHeader8.Width = 103;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Valor";
            this.columnHeader9.Width = 71;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Situação";
            this.columnHeader10.Width = 196;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btProd);
            this.groupBox2.Controls.Add(this.btProdAlterar);
            this.groupBox2.Controls.Add(this.btProdCadastrar);
            this.groupBox2.Controls.Add(this.btProdDetalhes);
            this.groupBox2.Controls.Add(this.btProdPronto);
            this.groupBox2.Controls.Add(this.listViewProduto);
            this.groupBox2.Location = new System.Drawing.Point(778, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 208);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // btProd
            // 
            this.btProd.Enabled = false;
            this.btProd.Location = new System.Drawing.Point(479, 179);
            this.btProd.Name = "btProd";
            this.btProd.Size = new System.Drawing.Size(75, 23);
            this.btProd.TabIndex = 5;
            this.btProd.Text = "Deletar";
            this.btProd.UseVisualStyleBackColor = true;
            // 
            // btProdAlterar
            // 
            this.btProdAlterar.Enabled = false;
            this.btProdAlterar.Location = new System.Drawing.Point(479, 150);
            this.btProdAlterar.Name = "btProdAlterar";
            this.btProdAlterar.Size = new System.Drawing.Size(75, 23);
            this.btProdAlterar.TabIndex = 4;
            this.btProdAlterar.Text = "Alterar";
            this.btProdAlterar.UseVisualStyleBackColor = true;
            // 
            // btProdCadastrar
            // 
            this.btProdCadastrar.Location = new System.Drawing.Point(479, 121);
            this.btProdCadastrar.Name = "btProdCadastrar";
            this.btProdCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btProdCadastrar.TabIndex = 3;
            this.btProdCadastrar.Text = "Cadastrar";
            this.btProdCadastrar.UseVisualStyleBackColor = true;
            // 
            // btProdDetalhes
            // 
            this.btProdDetalhes.Enabled = false;
            this.btProdDetalhes.Location = new System.Drawing.Point(479, 48);
            this.btProdDetalhes.Name = "btProdDetalhes";
            this.btProdDetalhes.Size = new System.Drawing.Size(75, 23);
            this.btProdDetalhes.TabIndex = 2;
            this.btProdDetalhes.Text = "+ Detalhes";
            this.btProdDetalhes.UseVisualStyleBackColor = true;
            // 
            // btProdPronto
            // 
            this.btProdPronto.Enabled = false;
            this.btProdPronto.Location = new System.Drawing.Point(479, 19);
            this.btProdPronto.Name = "btProdPronto";
            this.btProdPronto.Size = new System.Drawing.Size(75, 23);
            this.btProdPronto.TabIndex = 1;
            this.btProdPronto.Text = "Pronto";
            this.btProdPronto.UseVisualStyleBackColor = true;
            // 
            // listViewProduto
            // 
            this.listViewProduto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listViewProduto.FullRowSelect = true;
            this.listViewProduto.GridLines = true;
            this.listViewProduto.Location = new System.Drawing.Point(6, 19);
            this.listViewProduto.Name = "listViewProduto";
            this.listViewProduto.Size = new System.Drawing.Size(467, 183);
            this.listViewProduto.TabIndex = 0;
            this.listViewProduto.UseCompatibleStateImageBehavior = false;
            this.listViewProduto.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Titulo";
            this.columnHeader6.Width = 176;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Valor";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Data Solicitação";
            this.columnHeader12.Width = 96;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Situação";
            this.columnHeader13.Width = 131;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.listViewDemandas);
            this.groupBox3.Location = new System.Drawing.Point(778, 444);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 206);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Demandas";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(479, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Deletar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(479, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(479, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "+ Detalhes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listViewDemandas
            // 
            this.listViewDemandas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.listViewDemandas.FullRowSelect = true;
            this.listViewDemandas.GridLines = true;
            this.listViewDemandas.Location = new System.Drawing.Point(6, 19);
            this.listViewDemandas.Name = "listViewDemandas";
            this.listViewDemandas.Size = new System.Drawing.Size(467, 181);
            this.listViewDemandas.TabIndex = 0;
            this.listViewDemandas.UseCompatibleStateImageBehavior = false;
            this.listViewDemandas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Titulo";
            this.columnHeader14.Width = 243;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Data";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Hora";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Situação";
            this.columnHeader17.Width = 99;
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(93, 656);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 6;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(1263, 656);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Fechar";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(1182, 656);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 8;
            this.btClear.Text = "Limpar";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.listViewCliente);
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCliente;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btPgDelete;
        private System.Windows.Forms.Button btPg;
        private System.Windows.Forms.Button btPgCadastrar;
        private System.Windows.Forms.ListView listViewPagamentos;
        private System.Windows.Forms.Button btPgDetalhes;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView listViewProduto;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btProd;
        private System.Windows.Forms.Button btProdAlterar;
        private System.Windows.Forms.Button btProdCadastrar;
        private System.Windows.Forms.Button btProdDetalhes;
        private System.Windows.Forms.Button btProdPronto;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewDemandas;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btClear;
    }
}