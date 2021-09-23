
namespace ActFinal1
{
    partial class mod5
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
            this.txt_leer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Regresar = new System.Windows.Forms.Button();
            this.salidalbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_leer
            // 
            this.txt_leer.Location = new System.Drawing.Point(176, 210);
            this.txt_leer.Name = "txt_leer";
            this.txt_leer.Size = new System.Drawing.Size(415, 23);
            this.txt_leer.TabIndex = 0;
            this.txt_leer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detector de Pangrama";
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(629, 355);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(75, 23);
            this.Regresar.TabIndex = 2;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // salidalbl
            // 
            this.salidalbl.AutoSize = true;
            this.salidalbl.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.salidalbl.Location = new System.Drawing.Point(359, 318);
            this.salidalbl.Name = "salidalbl";
            this.salidalbl.Size = new System.Drawing.Size(0, 20);
            this.salidalbl.TabIndex = 3;
            // 
            // mod5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salidalbl);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_leer);
            this.Name = "mod5";
            this.Text = "mod5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_leer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Label salidalbl;
    }
}