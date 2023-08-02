namespace formularios
{
    partial class frmmenu
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
            this.btnquadrado = new System.Windows.Forms.Button();
            this.btnretangulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnquadrado
            // 
            this.btnquadrado.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnquadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquadrado.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquadrado.ForeColor = System.Drawing.Color.White;
            this.btnquadrado.Location = new System.Drawing.Point(85, 93);
            this.btnquadrado.Name = "btnquadrado";
            this.btnquadrado.Size = new System.Drawing.Size(223, 49);
            this.btnquadrado.TabIndex = 0;
            this.btnquadrado.Text = "Quadrado";
            this.btnquadrado.UseVisualStyleBackColor = false;
            this.btnquadrado.Click += new System.EventHandler(this.btnquadrado_Click);
            // 
            // btnretangulo
            // 
            this.btnretangulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnretangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnretangulo.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretangulo.ForeColor = System.Drawing.Color.White;
            this.btnretangulo.Location = new System.Drawing.Point(85, 148);
            this.btnretangulo.Name = "btnretangulo";
            this.btnretangulo.Size = new System.Drawing.Size(223, 49);
            this.btnretangulo.TabIndex = 1;
            this.btnretangulo.Text = "Retângulo";
            this.btnretangulo.UseVisualStyleBackColor = false;
            this.btnretangulo.Click += new System.EventHandler(this.btnretangulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(63, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cálculo de Áreas";
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(159, 214);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 23);
            this.btnfechar.TabIndex = 3;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 249);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnretangulo);
            this.Controls.Add(this.btnquadrado);
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Áreas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnquadrado;
        private System.Windows.Forms.Button btnretangulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnfechar;
    }
}