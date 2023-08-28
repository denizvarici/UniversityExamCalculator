namespace Calculator.UI
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
            this.gbxFinalCalculator = new System.Windows.Forms.GroupBox();
            this.lblGecmePuani = new System.Windows.Forms.Label();
            this.tbxGecmePuani = new System.Windows.Forms.TextBox();
            this.tbxVizePuani = new System.Windows.Forms.TextBox();
            this.lblVizePuani = new System.Windows.Forms.Label();
            this.tbxVizeOrani = new System.Windows.Forms.TextBox();
            this.lblVizeOrani = new System.Windows.Forms.Label();
            this.btnCalculateFKA = new System.Windows.Forms.Button();
            this.lblAlmanizGerekenFinalNotu = new System.Windows.Forms.Label();
            this.tbxAlmanizGerekenFinalPuani = new System.Windows.Forms.TextBox();
            this.gbxFinalCalculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFinalCalculator
            // 
            this.gbxFinalCalculator.Controls.Add(this.tbxAlmanizGerekenFinalPuani);
            this.gbxFinalCalculator.Controls.Add(this.lblAlmanizGerekenFinalNotu);
            this.gbxFinalCalculator.Controls.Add(this.btnCalculateFKA);
            this.gbxFinalCalculator.Controls.Add(this.tbxVizeOrani);
            this.gbxFinalCalculator.Controls.Add(this.lblVizeOrani);
            this.gbxFinalCalculator.Controls.Add(this.tbxVizePuani);
            this.gbxFinalCalculator.Controls.Add(this.lblVizePuani);
            this.gbxFinalCalculator.Controls.Add(this.tbxGecmePuani);
            this.gbxFinalCalculator.Controls.Add(this.lblGecmePuani);
            this.gbxFinalCalculator.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxFinalCalculator.Location = new System.Drawing.Point(12, 12);
            this.gbxFinalCalculator.Name = "gbxFinalCalculator";
            this.gbxFinalCalculator.Size = new System.Drawing.Size(769, 370);
            this.gbxFinalCalculator.TabIndex = 0;
            this.gbxFinalCalculator.TabStop = false;
            this.gbxFinalCalculator.Text = "Finalden kaç almalıyım ?";
            // 
            // lblGecmePuani
            // 
            this.lblGecmePuani.AutoSize = true;
            this.lblGecmePuani.Location = new System.Drawing.Point(6, 49);
            this.lblGecmePuani.Name = "lblGecmePuani";
            this.lblGecmePuani.Size = new System.Drawing.Size(156, 27);
            this.lblGecmePuani.TabIndex = 0;
            this.lblGecmePuani.Text = "Geçme puanı:";
            // 
            // tbxGecmePuani
            // 
            this.tbxGecmePuani.Location = new System.Drawing.Point(159, 46);
            this.tbxGecmePuani.Name = "tbxGecmePuani";
            this.tbxGecmePuani.Size = new System.Drawing.Size(60, 31);
            this.tbxGecmePuani.TabIndex = 1;
            this.tbxGecmePuani.Text = "60";
            // 
            // tbxVizePuani
            // 
            this.tbxVizePuani.Location = new System.Drawing.Point(159, 101);
            this.tbxVizePuani.Name = "tbxVizePuani";
            this.tbxVizePuani.Size = new System.Drawing.Size(60, 31);
            this.tbxVizePuani.TabIndex = 3;
            // 
            // lblVizePuani
            // 
            this.lblVizePuani.AutoSize = true;
            this.lblVizePuani.Location = new System.Drawing.Point(6, 104);
            this.lblVizePuani.Name = "lblVizePuani";
            this.lblVizePuani.Size = new System.Drawing.Size(156, 27);
            this.lblVizePuani.TabIndex = 2;
            this.lblVizePuani.Text = "Vize Puanı :";
            // 
            // tbxVizeOrani
            // 
            this.tbxVizeOrani.Location = new System.Drawing.Point(159, 158);
            this.tbxVizeOrani.Name = "tbxVizeOrani";
            this.tbxVizeOrani.Size = new System.Drawing.Size(60, 31);
            this.tbxVizeOrani.TabIndex = 5;
            // 
            // lblVizeOrani
            // 
            this.lblVizeOrani.AutoSize = true;
            this.lblVizeOrani.Location = new System.Drawing.Point(6, 161);
            this.lblVizeOrani.Name = "lblVizeOrani";
            this.lblVizeOrani.Size = new System.Drawing.Size(168, 27);
            this.lblVizeOrani.TabIndex = 4;
            this.lblVizeOrani.Text = "Vize Oranı : ";
            // 
            // btnCalculateFKA
            // 
            this.btnCalculateFKA.Location = new System.Drawing.Point(115, 220);
            this.btnCalculateFKA.Name = "btnCalculateFKA";
            this.btnCalculateFKA.Size = new System.Drawing.Size(104, 47);
            this.btnCalculateFKA.TabIndex = 6;
            this.btnCalculateFKA.Text = "Hesapla";
            this.btnCalculateFKA.UseVisualStyleBackColor = true;
            this.btnCalculateFKA.Click += new System.EventHandler(this.btnCalculateFKA_Click);
            // 
            // lblAlmanizGerekenFinalNotu
            // 
            this.lblAlmanizGerekenFinalNotu.AutoSize = true;
            this.lblAlmanizGerekenFinalNotu.Location = new System.Drawing.Point(246, 230);
            this.lblAlmanizGerekenFinalNotu.Name = "lblAlmanizGerekenFinalNotu";
            this.lblAlmanizGerekenFinalNotu.Size = new System.Drawing.Size(360, 27);
            this.lblAlmanizGerekenFinalNotu.TabIndex = 7;
            this.lblAlmanizGerekenFinalNotu.Text = "Almanız Gereken Final Puanı :";
            // 
            // tbxAlmanizGerekenFinalPuani
            // 
            this.tbxAlmanizGerekenFinalPuani.Location = new System.Drawing.Point(612, 227);
            this.tbxAlmanizGerekenFinalPuani.Name = "tbxAlmanizGerekenFinalPuani";
            this.tbxAlmanizGerekenFinalPuani.Size = new System.Drawing.Size(151, 31);
            this.tbxAlmanizGerekenFinalPuani.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 394);
            this.Controls.Add(this.gbxFinalCalculator);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vize Final Hesaplayıcı";
            this.gbxFinalCalculator.ResumeLayout(false);
            this.gbxFinalCalculator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFinalCalculator;
        private System.Windows.Forms.TextBox tbxGecmePuani;
        private System.Windows.Forms.Label lblGecmePuani;
        private System.Windows.Forms.TextBox tbxVizeOrani;
        private System.Windows.Forms.Label lblVizeOrani;
        private System.Windows.Forms.TextBox tbxVizePuani;
        private System.Windows.Forms.Label lblVizePuani;
        private System.Windows.Forms.TextBox tbxAlmanizGerekenFinalPuani;
        private System.Windows.Forms.Label lblAlmanizGerekenFinalNotu;
        private System.Windows.Forms.Button btnCalculateFKA;
    }
}

