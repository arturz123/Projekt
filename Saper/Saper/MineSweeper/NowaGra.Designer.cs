namespace Saper
{
    partial class NowaGra
    {
        /// <summary>
        /// Wymagana zmienna projektu.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Czyści źródła które zostały użyte.
        /// </summary>
        /// <param name="disposing">Prawda jeżeli źródła powinny dysponować; jeśli nie, fałsz.</param>
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
        /// Wymagana metoda dla Designera wsparcia - nie modyfikować
        /// zawartości tej metody edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.rb_easy = new System.Windows.Forms.RadioButton();
            this.rb_medium = new System.Windows.Forms.RadioButton();
            this.rb_hard = new System.Windows.Forms.RadioButton();
            this.bttn_start = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Łatwy
            // 
            this.rb_easy.AutoSize = true;
            this.rb_easy.Location = new System.Drawing.Point(12, 13);
            this.rb_easy.Name = "rb_easy";
            this.rb_easy.Size = new System.Drawing.Size(54, 17);
            this.rb_easy.TabIndex = 0;
            this.rb_easy.TabStop = true;
            this.rb_easy.Text = "Łatwy";
            this.rb_easy.UseVisualStyleBackColor = true;
            // 
            // Średni
            // 
            this.rb_medium.AutoSize = true;
            this.rb_medium.Location = new System.Drawing.Point(12, 36);
            this.rb_medium.Name = "rb_medium";
            this.rb_medium.Size = new System.Drawing.Size(55, 17);
            this.rb_medium.TabIndex = 1;
            this.rb_medium.TabStop = true;
            this.rb_medium.Text = "Średni";
            this.rb_medium.UseVisualStyleBackColor = true;
            // 
            // Trudny
            // 
            this.rb_hard.AutoSize = true;
            this.rb_hard.Location = new System.Drawing.Point(12, 59);
            this.rb_hard.Name = "rb_hard";
            this.rb_hard.Size = new System.Drawing.Size(58, 17);
            this.rb_hard.TabIndex = 2;
            this.rb_hard.TabStop = true;
            this.rb_hard.Text = "Trudny";
            this.rb_hard.UseVisualStyleBackColor = true;
            this.rb_hard.CheckedChanged += new System.EventHandler(this.rb_hard_CheckedChanged);
            // 
            // Przycisk Start Gry
            // 
            this.bttn_start.Location = new System.Drawing.Point(93, 93);
            this.bttn_start.Name = "bttn_start";
            this.bttn_start.Size = new System.Drawing.Size(75, 23);
            this.bttn_start.TabIndex = 3;
            this.bttn_start.Text = "Start Gry";
            this.bttn_start.UseVisualStyleBackColor = true;
            this.bttn_start.Click += new System.EventHandler(this.bttn_start_Click);
            // 
            // Przycisk Anuluj
            // 
            this.btn_cancel.Location = new System.Drawing.Point(12, 93);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Anuluj";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // NowaGra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 126);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.bttn_start);
            this.Controls.Add(this.rb_hard);
            this.Controls.Add(this.rb_medium);
            this.Controls.Add(this.rb_easy);
            this.Name = "NowaGra";
            this.Text = "Nowa Gra";
            this.Load += new System.EventHandler(this.NewGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_easy;
        private System.Windows.Forms.RadioButton rb_medium;
        private System.Windows.Forms.RadioButton rb_hard;
        private System.Windows.Forms.Button bttn_start;
        private System.Windows.Forms.Button btn_cancel;
    }
}