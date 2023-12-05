namespace grafy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_wezel = new System.Windows.Forms.Button();
            this.btn_wezel2 = new System.Windows.Forms.Button();
            this.binaryTree_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_wezel
            // 
            this.btn_wezel.Location = new System.Drawing.Point(362, 228);
            this.btn_wezel.Name = "btn_wezel";
            this.btn_wezel.Size = new System.Drawing.Size(75, 23);
            this.btn_wezel.TabIndex = 0;
            this.btn_wezel.Text = "Acykliczne";
            this.btn_wezel.UseVisualStyleBackColor = true;
            this.btn_wezel.Click += new System.EventHandler(this.btn_wezel_Click);
            // 
            // btn_wezel2
            // 
            this.btn_wezel2.Location = new System.Drawing.Point(482, 228);
            this.btn_wezel2.Name = "btn_wezel2";
            this.btn_wezel2.Size = new System.Drawing.Size(75, 23);
            this.btn_wezel2.TabIndex = 1;
            this.btn_wezel2.Text = "Cykliczne";
            this.btn_wezel2.UseVisualStyleBackColor = true;
            this.btn_wezel2.Click += new System.EventHandler(this.btn_wezel2_Click);
            // 
            // binaryTree_btn
            // 
            this.binaryTree_btn.Location = new System.Drawing.Point(231, 227);
            this.binaryTree_btn.Name = "binaryTree_btn";
            this.binaryTree_btn.Size = new System.Drawing.Size(75, 23);
            this.binaryTree_btn.TabIndex = 2;
            this.binaryTree_btn.Text = "Binary Tree";
            this.binaryTree_btn.UseVisualStyleBackColor = true;
            this.binaryTree_btn.Click += new System.EventHandler(this.binaryTree_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.binaryTree_btn);
            this.Controls.Add(this.btn_wezel2);
            this.Controls.Add(this.btn_wezel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_wezel;
        private System.Windows.Forms.Button btn_wezel2;
        private System.Windows.Forms.Button binaryTree_btn;
        private System.Windows.Forms.Button button1;
    }
}

