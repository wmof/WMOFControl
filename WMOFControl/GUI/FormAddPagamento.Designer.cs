namespace WMOFControl.GUI
{
    partial class FormAddPagamento
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textVencimento = new System.Windows.Forms.MaskedTextBox();
            this.textRealizado = new System.Windows.Forms.MaskedTextBox();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.checkPago = new System.Windows.Forms.CheckBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo de Barras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vencimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Realizado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cliente";
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(106, 12);
            this.textDescricao.Multiline = true;
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(346, 38);
            this.textDescricao.TabIndex = 6;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(106, 82);
            this.textCodigo.Multiline = true;
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(346, 38);
            this.textCodigo.TabIndex = 8;
            // 
            // textVencimento
            // 
            this.textVencimento.Location = new System.Drawing.Point(106, 126);
            this.textVencimento.Mask = "00/00/0000";
            this.textVencimento.Name = "textVencimento";
            this.textVencimento.Size = new System.Drawing.Size(65, 20);
            this.textVencimento.TabIndex = 9;
            this.textVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // textRealizado
            // 
            this.textRealizado.Enabled = false;
            this.textRealizado.Location = new System.Drawing.Point(106, 152);
            this.textRealizado.Mask = "00/00/0000";
            this.textRealizado.Name = "textRealizado";
            this.textRealizado.Size = new System.Drawing.Size(65, 20);
            this.textRealizado.TabIndex = 10;
            this.textRealizado.ValidatingType = typeof(System.DateTime);
            // 
            // comboCliente
            // 
            this.comboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(106, 178);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(346, 21);
            this.comboCliente.TabIndex = 11;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(12, 208);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(377, 208);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 13;
            this.btClear.Text = "Limpar";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // checkPago
            // 
            this.checkPago.AutoSize = true;
            this.checkPago.Location = new System.Drawing.Point(177, 154);
            this.checkPago.Name = "checkPago";
            this.checkPago.Size = new System.Drawing.Size(51, 17);
            this.checkPago.TabIndex = 14;
            this.checkPago.Text = "Pago";
            this.checkPago.UseVisualStyleBackColor = true;
            this.checkPago.CheckedChanged += new System.EventHandler(this.checkPago_CheckedChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(106, 56);
            this.maskedTextBox1.Mask = "$ 00000.00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 15;
            // 
            // FormAddPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 237);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.checkPago);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.textRealizado);
            this.Controls.Add(this.textVencimento);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddPagamento";
            this.Text = "FormAddPagamento";
            this.Load += new System.EventHandler(this.FormAddPagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.MaskedTextBox textVencimento;
        private System.Windows.Forms.MaskedTextBox textRealizado;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.CheckBox checkPago;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}