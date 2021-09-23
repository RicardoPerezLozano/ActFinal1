
namespace ActFinal1
{
    partial class mod3
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
            this.oracion = new System.Windows.Forms.TextBox();
            this.verificar = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oracion
            // 
            this.oracion.Location = new System.Drawing.Point(198, 172);
            this.oracion.Name = "oracion";
            this.oracion.Size = new System.Drawing.Size(441, 23);
            this.oracion.TabIndex = 1;
            this.oracion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // verificar
            // 
            this.verificar.Location = new System.Drawing.Point(343, 255);
            this.verificar.Name = "verificar";
            this.verificar.Size = new System.Drawing.Size(103, 23);
            this.verificar.TabIndex = 2;
            this.verificar.Text = "Verificar";
            this.verificar.UseVisualStyleBackColor = true;
            this.verificar.Click += new System.EventHandler(this.verificar_Click);
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(354, 362);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(75, 23);
            this.Regresar.TabIndex = 3;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(312, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cuenta Letras";
            // 
            // mod3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.verificar);
            this.Controls.Add(this.oracion);
            this.Name = "mod3";
            this.Text = "mod3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox oracion;
        private System.Windows.Forms.Button verificar;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Label label1;
    }
}