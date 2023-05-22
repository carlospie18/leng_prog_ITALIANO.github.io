
namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Codigo = new System.Windows.Forms.Label();
            this.Rtxtb_Codigo = new System.Windows.Forms.RichTextBox();
            this.Rtxtb_Pantalla = new System.Windows.Forms.RichTextBox();
            this.lb_Pantalla = new System.Windows.Forms.Label();
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.btn_BorrarPantalla = new System.Windows.Forms.Button();
            this.btn_BorrarCod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Codigo
            // 
            this.lb_Codigo.AutoSize = true;
            this.lb_Codigo.Location = new System.Drawing.Point(12, 9);
            this.lb_Codigo.Name = "lb_Codigo";
            this.lb_Codigo.Size = new System.Drawing.Size(55, 20);
            this.lb_Codigo.TabIndex = 0;
            this.lb_Codigo.Text = "Codice";
            // 
            // Rtxtb_Codigo
            // 
            this.Rtxtb_Codigo.Location = new System.Drawing.Point(12, 32);
            this.Rtxtb_Codigo.Name = "Rtxtb_Codigo";
            this.Rtxtb_Codigo.Size = new System.Drawing.Size(976, 323);
            this.Rtxtb_Codigo.TabIndex = 1;
            this.Rtxtb_Codigo.Text = "";
            // 
            // Rtxtb_Pantalla
            // 
            this.Rtxtb_Pantalla.Location = new System.Drawing.Point(12, 399);
            this.Rtxtb_Pantalla.Name = "Rtxtb_Pantalla";
            this.Rtxtb_Pantalla.Size = new System.Drawing.Size(976, 358);
            this.Rtxtb_Pantalla.TabIndex = 2;
            this.Rtxtb_Pantalla.Text = "";
            // 
            // lb_Pantalla
            // 
            this.lb_Pantalla.AutoSize = true;
            this.lb_Pantalla.Location = new System.Drawing.Point(12, 376);
            this.lb_Pantalla.Name = "lb_Pantalla";
            this.lb_Pantalla.Size = new System.Drawing.Size(67, 20);
            this.lb_Pantalla.TabIndex = 3;
            this.lb_Pantalla.Text = "Schermo";
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.Location = new System.Drawing.Point(994, 32);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(94, 29);
            this.btn_Cargar.TabIndex = 4;
            this.btn_Cargar.Text = "Carica";
            this.btn_Cargar.UseVisualStyleBackColor = true;
            this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
            // 
            // btn_BorrarPantalla
            // 
            this.btn_BorrarPantalla.Location = new System.Drawing.Point(995, 399);
            this.btn_BorrarPantalla.Name = "btn_BorrarPantalla";
            this.btn_BorrarPantalla.Size = new System.Drawing.Size(94, 29);
            this.btn_BorrarPantalla.TabIndex = 5;
            this.btn_BorrarPantalla.Text = "eliminare";
            this.btn_BorrarPantalla.UseVisualStyleBackColor = true;
            this.btn_BorrarPantalla.Click += new System.EventHandler(this.btn_BorrarPantalla_Click);
            // 
            // btn_BorrarCod
            // 
            this.btn_BorrarCod.Location = new System.Drawing.Point(995, 79);
            this.btn_BorrarCod.Name = "btn_BorrarCod";
            this.btn_BorrarCod.Size = new System.Drawing.Size(128, 29);
            this.btn_BorrarCod.TabIndex = 6;
            this.btn_BorrarCod.Text = "codice chiaro";
            this.btn_BorrarCod.UseVisualStyleBackColor = true;
            this.btn_BorrarCod.Click += new System.EventHandler(this.btn_BorrarCod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 769);
            this.Controls.Add(this.btn_BorrarCod);
            this.Controls.Add(this.btn_BorrarPantalla);
            this.Controls.Add(this.btn_Cargar);
            this.Controls.Add(this.lb_Pantalla);
            this.Controls.Add(this.Rtxtb_Pantalla);
            this.Controls.Add(this.Rtxtb_Codigo);
            this.Controls.Add(this.lb_Codigo);
            this.Name = "Form1";
            this.Text = "Itacod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Codigo;
        private System.Windows.Forms.RichTextBox Rtxtb_Codigo;
        private System.Windows.Forms.RichTextBox Rtxtb_Pantalla;
        private System.Windows.Forms.Label lb_Pantalla;
        private System.Windows.Forms.Button btn_Cargar;
        private System.Windows.Forms.Button btn_BorrarPantalla;
        private System.Windows.Forms.Button btn_BorrarCod;
    }
}

