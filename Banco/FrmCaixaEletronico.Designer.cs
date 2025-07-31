namespace Banco
{
    partial class FrmCaixaEletronico
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
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaque = new System.Windows.Forms.Label();
            this.numericValorSaque = new System.Windows.Forms.NumericUpDown();
            this.btnSacar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericValorSaque)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaldo
            // 
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(492, 38);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(100, 23);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(585, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 41);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSaque
            // 
            this.lblSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaque.Location = new System.Drawing.Point(29, 126);
            this.lblSaque.Name = "lblSaque";
            this.lblSaque.Size = new System.Drawing.Size(132, 23);
            this.lblSaque.TabIndex = 2;
            this.lblSaque.Text = "Valor de Saque:";
            // 
            // numericValorSaque
            // 
            this.numericValorSaque.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericValorSaque.Location = new System.Drawing.Point(196, 128);
            this.numericValorSaque.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numericValorSaque.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.numericValorSaque.Name = "numericValorSaque";
            this.numericValorSaque.Size = new System.Drawing.Size(120, 20);
            this.numericValorSaque.TabIndex = 3;
            this.numericValorSaque.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(657, 382);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(121, 56);
            this.btnSacar.TabIndex = 4;
            this.btnSacar.Text = "&Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // FrmCaixaEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.numericValorSaque);
            this.Controls.Add(this.lblSaque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSaldo);
            this.Name = "FrmCaixaEletronico";
            this.Text = "Caixa Eletrônico";
            ((System.ComponentModel.ISupportInitialize)(this.numericValorSaque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaque;
        private System.Windows.Forms.NumericUpDown numericValorSaque;
        private System.Windows.Forms.Button btnSacar;
    }
}

