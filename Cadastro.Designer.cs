
namespace ProjPTCC
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.txtValorProd = new System.Windows.Forms.TextBox();
            this.txtQtdProd = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnConsAt = new System.Windows.Forms.Button();
            this.listaProd = new System.Windows.Forms.ListView();
            this.btnPedidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1050, 575);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtNomeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProd.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNomeProd.Location = new System.Drawing.Point(274, 132);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(200, 26);
            this.txtNomeProd.TabIndex = 2;
            this.txtNomeProd.Text = "Nome do Produto";
            this.txtNomeProd.Enter += new System.EventHandler(this.txtNomeProd_Enter);
            this.txtNomeProd.Leave += new System.EventHandler(this.txtNomeProd_Leave);
            // 
            // txtValorProd
            // 
            this.txtValorProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtValorProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorProd.ForeColor = System.Drawing.Color.DarkGray;
            this.txtValorProd.Location = new System.Drawing.Point(699, 132);
            this.txtValorProd.Name = "txtValorProd";
            this.txtValorProd.Size = new System.Drawing.Size(86, 26);
            this.txtValorProd.TabIndex = 3;
            this.txtValorProd.Text = "Valor";
            this.txtValorProd.Enter += new System.EventHandler(this.txtValorProd_Enter);
            this.txtValorProd.Leave += new System.EventHandler(this.txtValorProd_Leave);
            // 
            // txtQtdProd
            // 
            this.txtQtdProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtdProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtQtdProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdProd.ForeColor = System.Drawing.Color.DarkGray;
            this.txtQtdProd.Location = new System.Drawing.Point(924, 132);
            this.txtQtdProd.Name = "txtQtdProd";
            this.txtQtdProd.Size = new System.Drawing.Size(98, 26);
            this.txtQtdProd.TabIndex = 4;
            this.txtQtdProd.Text = "Quantidade";
            this.txtQtdProd.Enter += new System.EventHandler(this.txtQtdProd_Enter);
            this.txtQtdProd.Leave += new System.EventHandler(this.txtQtdProd_Leave);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Location = new System.Drawing.Point(911, 490);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(111, 31);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.DarkGray;
            this.txtId.Location = new System.Drawing.Point(206, 132);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(62, 26);
            this.txtId.TabIndex = 8;
            this.txtId.Text = "ID";
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMarca.Location = new System.Drawing.Point(791, 132);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(127, 26);
            this.txtMarca.TabIndex = 9;
            this.txtMarca.Text = "Marca";
            this.txtMarca.Enter += new System.EventHandler(this.txtMarca_Enter);
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            // 
            // txtCor
            // 
            this.txtCor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCor.Location = new System.Drawing.Point(480, 132);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(83, 26);
            this.txtCor.TabIndex = 11;
            this.txtCor.Text = "Cor";
            this.txtCor.Enter += new System.EventHandler(this.txtCor_Enter);
            this.txtCor.Leave += new System.EventHandler(this.txtCor_Leave);
            // 
            // txtTamanho
            // 
            this.txtTamanho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTamanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamanho.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTamanho.Location = new System.Drawing.Point(569, 132);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(124, 26);
            this.txtTamanho.TabIndex = 12;
            this.txtTamanho.Text = "Tamanho";
            this.txtTamanho.Enter += new System.EventHandler(this.txtTamanho_Enter);
            this.txtTamanho.Leave += new System.EventHandler(this.txtTamanho_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btnPedidos);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnConsAt);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 538);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(169, 158);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEditar.Location = new System.Drawing.Point(12, 306);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(146, 68);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnConsAt
            // 
            this.btnConsAt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnConsAt.Location = new System.Drawing.Point(12, 232);
            this.btnConsAt.Name = "btnConsAt";
            this.btnConsAt.Size = new System.Drawing.Size(146, 68);
            this.btnConsAt.TabIndex = 9;
            this.btnConsAt.Text = "Consulta";
            this.btnConsAt.UseVisualStyleBackColor = true;
            this.btnConsAt.Click += new System.EventHandler(this.btnConsAt_Click);
            // 
            // listaProd
            // 
            this.listaProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaProd.HideSelection = false;
            this.listaProd.Location = new System.Drawing.Point(206, 164);
            this.listaProd.Name = "listaProd";
            this.listaProd.Size = new System.Drawing.Size(816, 320);
            this.listaProd.TabIndex = 18;
            this.listaProd.UseCompatibleStateImageBehavior = false;
            // 
            // btnPedidos
            // 
            this.btnPedidos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPedidos.Location = new System.Drawing.Point(12, 380);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(146, 68);
            this.btnPedidos.TabIndex = 16;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 536);
            this.Controls.Add(this.listaProd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtQtdProd);
            this.Controls.Add(this.txtValorProd);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.TextBox txtValorProd;
        private System.Windows.Forms.TextBox txtQtdProd;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnConsAt;
        private System.Windows.Forms.ListView listaProd;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnPedidos;
    }
}