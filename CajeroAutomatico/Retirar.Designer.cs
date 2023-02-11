
namespace CajeroAutomatico
{
    partial class Retirar
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
            this.btn_Retirar = new System.Windows.Forms.Button();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Saldo = new System.Windows.Forms.Label();
            this.lbl_TopeDiario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Retirar
            // 
            this.btn_Retirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btn_Retirar.FlatAppearance.BorderSize = 0;
            this.btn_Retirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Retirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Retirar.ForeColor = System.Drawing.Color.White;
            this.btn_Retirar.Location = new System.Drawing.Point(219, 380);
            this.btn_Retirar.Name = "btn_Retirar";
            this.btn_Retirar.Size = new System.Drawing.Size(99, 53);
            this.btn_Retirar.TabIndex = 7;
            this.btn_Retirar.Text = "Retirar";
            this.btn_Retirar.UseVisualStyleBackColor = false;
            this.btn_Retirar.Click += new System.EventHandler(this.btn_Retirar_Click);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txt_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.ForeColor = System.Drawing.Color.White;
            this.txt_Cantidad.Location = new System.Drawing.Point(216, 195);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(306, 26);
            this.txt_Cantidad.TabIndex = 9;
            this.txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cantidad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad:";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txt_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contraseña.ForeColor = System.Drawing.Color.White;
            this.txt_Contraseña.Location = new System.Drawing.Point(216, 265);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(306, 26);
            this.txt_Contraseña.TabIndex = 11;
            this.txt_Contraseña.UseSystemPasswordChar = true;
            this.txt_Contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Contraseña_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Confirmar contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(198, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Retirar Saldo";
            // 
            // lbl_Saldo
            // 
            this.lbl_Saldo.AutoSize = true;
            this.lbl_Saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saldo.ForeColor = System.Drawing.Color.White;
            this.lbl_Saldo.Location = new System.Drawing.Point(38, 75);
            this.lbl_Saldo.Name = "lbl_Saldo";
            this.lbl_Saldo.Size = new System.Drawing.Size(100, 20);
            this.lbl_Saldo.TabIndex = 13;
            this.lbl_Saldo.Text = "Su saldo es: ";
            // 
            // lbl_TopeDiario
            // 
            this.lbl_TopeDiario.AutoSize = true;
            this.lbl_TopeDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TopeDiario.ForeColor = System.Drawing.Color.White;
            this.lbl_TopeDiario.Location = new System.Drawing.Point(38, 116);
            this.lbl_TopeDiario.Name = "lbl_TopeDiario";
            this.lbl_TopeDiario.Size = new System.Drawing.Size(153, 20);
            this.lbl_TopeDiario.TabIndex = 14;
            this.lbl_TopeDiario.Text = "Tope diario de retiro:";
            // 
            // Retirar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(560, 475);
            this.Controls.Add(this.lbl_TopeDiario);
            this.Controls.Add(this.lbl_Saldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Retirar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Retirar";
            this.Text = "Retirar";
            this.Load += new System.EventHandler(this.Retirar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Retirar;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Saldo;
        private System.Windows.Forms.Label lbl_TopeDiario;
    }
}