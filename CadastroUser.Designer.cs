﻿
namespace ProjPTCC
{
    partial class CadastroUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bntCadastrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSenhaCad = new System.Windows.Forms.TextBox();
            this.txtLoginCad = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // bntCadastrar
            // 
            this.bntCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.bntCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCadastrar.Location = new System.Drawing.Point(470, 458);
            this.bntCadastrar.Name = "bntCadastrar";
            this.bntCadastrar.Size = new System.Drawing.Size(116, 32);
            this.bntCadastrar.TabIndex = 5;
            this.bntCadastrar.Text = "Cadastro";
            this.bntCadastrar.UseVisualStyleBackColor = false;
            this.bntCadastrar.Click += new System.EventHandler(this.bntCadastrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(418, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // txtSenhaCad
            // 
            this.txtSenhaCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtSenhaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCad.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSenhaCad.Location = new System.Drawing.Point(405, 416);
            this.txtSenhaCad.Name = "txtSenhaCad";
            this.txtSenhaCad.Size = new System.Drawing.Size(234, 26);
            this.txtSenhaCad.TabIndex = 7;
            this.txtSenhaCad.Text = "Insira a Senha";
            this.txtSenhaCad.Enter += new System.EventHandler(this.txtSenhaCad_Enter);
            this.txtSenhaCad.Leave += new System.EventHandler(this.txtSenhaCad_Leave);
            // 
            // txtLoginCad
            // 
            this.txtLoginCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoginCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtLoginCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginCad.ForeColor = System.Drawing.Color.DarkGray;
            this.txtLoginCad.Location = new System.Drawing.Point(405, 374);
            this.txtLoginCad.Name = "txtLoginCad";
            this.txtLoginCad.Size = new System.Drawing.Size(234, 26);
            this.txtLoginCad.TabIndex = 8;
            this.txtLoginCad.Text = "Insira o E-mail";
            this.txtLoginCad.Enter += new System.EventHandler(this.txtLoginCad_Enter);
            this.txtLoginCad.Leave += new System.EventHandler(this.txtLoginCad_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNome.Location = new System.Drawing.Point(405, 333);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(234, 26);
            this.txtNome.TabIndex = 9;
            this.txtNome.Text = "Insira o Nome Completo";
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // CadastroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 536);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtLoginCad);
            this.Controls.Add(this.txtSenhaCad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bntCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroUser";
            this.Load += new System.EventHandler(this.CadastroUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bntCadastrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSenhaCad;
        private System.Windows.Forms.TextBox txtLoginCad;
        private System.Windows.Forms.TextBox txtNome;
    }
}