
namespace ActFinal1
{
    partial class mod1
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
            this.verificar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.medio = new System.Windows.Forms.Label();
            this.rNumero2 = new System.Windows.Forms.Label();
            this.rNumero1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // verificar
            // 
            this.verificar.Location = new System.Drawing.Point(353, 242);
            this.verificar.Name = "verificar";
            this.verificar.Size = new System.Drawing.Size(75, 23);
            this.verificar.TabIndex = 0;
            this.verificar.Text = "Verificar";
            this.verificar.UseVisualStyleBackColor = true;
            this.verificar.Click += new System.EventHandler(this.verificar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(658, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(230, 158);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(100, 23);
            this.numero1.TabIndex = 2;
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(456, 158);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(100, 23);
            this.numero2.TabIndex = 3;
            // 
            // medio
            // 
            this.medio.AutoSize = true;
            this.medio.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.medio.Location = new System.Drawing.Point(381, 158);
            this.medio.Name = "medio";
            this.medio.Size = new System.Drawing.Size(0, 44);
            this.medio.TabIndex = 4;
            // 
            // rNumero2
            // 
            this.rNumero2.AutoSize = true;
            this.rNumero2.Location = new System.Drawing.Point(486, 198);
            this.rNumero2.Name = "rNumero2";
            this.rNumero2.Size = new System.Drawing.Size(0, 15);
            this.rNumero2.TabIndex = 5;
            // 
            // rNumero1
            // 
            this.rNumero1.AutoSize = true;
            this.rNumero1.Location = new System.Drawing.Point(260, 198);
            this.rNumero1.Name = "rNumero1";
            this.rNumero1.Size = new System.Drawing.Size(0, 15);
            this.rNumero1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(135, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Compare dos numero y mire cual es menor!";
            // 
            // mod1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rNumero1);
            this.Controls.Add(this.rNumero2);
            this.Controls.Add(this.medio);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.verificar);
            this.Name = "mod1";
            this.Text = "mod1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verificar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.Label medio;
        private System.Windows.Forms.Label rNumero2;
        private System.Windows.Forms.Label rNumero1;
        private System.Windows.Forms.Label label1;
    }
}