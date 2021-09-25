namespace Cálculo_de_Piso
{
    partial class Form1
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
            this.txt_Comp_Cômodo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Larg_Cômodo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Comp_Piso = new System.Windows.Forms.ComboBox();
            this.cmb_Larg_Piso = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Calc_Qtd_Pisos = new System.Windows.Forms.Button();
            this.txt_Qtd_Pisos = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculador de qtd de pisos";
            // 
            // txt_Comp_Cômodo
            // 
            this.txt_Comp_Cômodo.Location = new System.Drawing.Point(34, 103);
            this.txt_Comp_Cômodo.Name = "txt_Comp_Cômodo";
            this.txt_Comp_Cômodo.Size = new System.Drawing.Size(204, 20);
            this.txt_Comp_Cômodo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o comprimento do cômodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Digite o largura do cômodo";
            // 
            // txt_Larg_Cômodo
            // 
            this.txt_Larg_Cômodo.Location = new System.Drawing.Point(34, 163);
            this.txt_Larg_Cômodo.Name = "txt_Larg_Cômodo";
            this.txt_Larg_Cômodo.Size = new System.Drawing.Size(204, 20);
            this.txt_Larg_Cômodo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Qtd. de pisos";
            // 
            // cmb_Comp_Piso
            // 
            this.cmb_Comp_Piso.FormattingEnabled = true;
            this.cmb_Comp_Piso.Items.AddRange(new object[] {
            "30",
            "60 "});
            this.cmb_Comp_Piso.Location = new System.Drawing.Point(34, 219);
            this.cmb_Comp_Piso.Name = "cmb_Comp_Piso";
            this.cmb_Comp_Piso.Size = new System.Drawing.Size(204, 21);
            this.cmb_Comp_Piso.TabIndex = 8;
            // 
            // cmb_Larg_Piso
            // 
            this.cmb_Larg_Piso.FormattingEnabled = true;
            this.cmb_Larg_Piso.Items.AddRange(new object[] {
            "30",
            "60"});
            this.cmb_Larg_Piso.Location = new System.Drawing.Point(34, 282);
            this.cmb_Larg_Piso.Name = "cmb_Larg_Piso";
            this.cmb_Larg_Piso.Size = new System.Drawing.Size(204, 21);
            this.cmb_Larg_Piso.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Selecione o comprimento dos pisos (cm)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Selecionea largura dos pisos (cm)";
            // 
            // btn_Calc_Qtd_Pisos
            // 
            this.btn_Calc_Qtd_Pisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calc_Qtd_Pisos.Location = new System.Drawing.Point(32, 321);
            this.btn_Calc_Qtd_Pisos.Name = "btn_Calc_Qtd_Pisos";
            this.btn_Calc_Qtd_Pisos.Size = new System.Drawing.Size(107, 47);
            this.btn_Calc_Qtd_Pisos.TabIndex = 12;
            this.btn_Calc_Qtd_Pisos.Text = "Calcular qtd. de pisos";
            this.btn_Calc_Qtd_Pisos.UseVisualStyleBackColor = true;
            this.btn_Calc_Qtd_Pisos.Click += new System.EventHandler(this.btn_Calc_Qtd_Pisos_Click_1);
            // 
            // txt_Qtd_Pisos
            // 
            this.txt_Qtd_Pisos.BackColor = System.Drawing.SystemColors.InfoText;
            this.txt_Qtd_Pisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Qtd_Pisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Qtd_Pisos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Qtd_Pisos.Location = new System.Drawing.Point(314, 105);
            this.txt_Qtd_Pisos.Name = "txt_Qtd_Pisos";
            this.txt_Qtd_Pisos.Size = new System.Drawing.Size(117, 24);
            this.txt_Qtd_Pisos.TabIndex = 13;
            this.txt_Qtd_Pisos.Text = "0";
            this.txt_Qtd_Pisos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Location = new System.Drawing.Point(145, 321);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(107, 47);
            this.btn_Limpar.TabIndex = 14;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 390);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.txt_Qtd_Pisos);
            this.Controls.Add(this.btn_Calc_Qtd_Pisos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Larg_Piso);
            this.Controls.Add(this.cmb_Comp_Piso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Larg_Cômodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Comp_Cômodo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Comp_Cômodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Larg_Cômodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Comp_Piso;
        private System.Windows.Forms.ComboBox cmb_Larg_Piso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Calc_Qtd_Pisos;
        private System.Windows.Forms.TextBox txt_Qtd_Pisos;
        private System.Windows.Forms.Button btn_Limpar;
    }
}

