
namespace ZekaWinForm
{
    partial class ParametriZaIgru
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbOpcije = new System.Windows.Forms.GroupBox();
            this.tbDimenzijeMatrice = new System.Windows.Forms.TextBox();
            this.tbVrijemeTrajanjaIgre = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.gbOpcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite dimenziju matrice:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vrijeme trajanje igre (s):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(90, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "RABIT GAME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbOpcije
            // 
            this.gbOpcije.Controls.Add(this.btnPlay);
            this.gbOpcije.Controls.Add(this.tbVrijemeTrajanjaIgre);
            this.gbOpcije.Controls.Add(this.tbDimenzijeMatrice);
            this.gbOpcije.Controls.Add(this.label1);
            this.gbOpcije.Controls.Add(this.label2);
            this.gbOpcije.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbOpcije.Location = new System.Drawing.Point(10, 62);
            this.gbOpcije.Name = "gbOpcije";
            this.gbOpcije.Size = new System.Drawing.Size(261, 122);
            this.gbOpcije.TabIndex = 3;
            this.gbOpcije.TabStop = false;
            this.gbOpcije.Text = "Game options:";
            // 
            // tbDimenzijeMatrice
            // 
            this.tbDimenzijeMatrice.Location = new System.Drawing.Point(189, 31);
            this.tbDimenzijeMatrice.Name = "tbDimenzijeMatrice";
            this.tbDimenzijeMatrice.Size = new System.Drawing.Size(46, 22);
            this.tbDimenzijeMatrice.TabIndex = 2;
            // 
            // tbVrijemeTrajanjaIgre
            // 
            this.tbVrijemeTrajanjaIgre.Location = new System.Drawing.Point(189, 57);
            this.tbVrijemeTrajanjaIgre.Name = "tbVrijemeTrajanjaIgre";
            this.tbVrijemeTrajanjaIgre.Size = new System.Drawing.Size(46, 22);
            this.tbVrijemeTrajanjaIgre.TabIndex = 3;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(82, 87);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(97, 29);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play Game";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // ParametriZaIgru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 196);
            this.Controls.Add(this.gbOpcije);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParametriZaIgru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParametriZaIgru";
            this.gbOpcije.ResumeLayout(false);
            this.gbOpcije.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbOpcije;
        private System.Windows.Forms.TextBox tbVrijemeTrajanjaIgre;
        private System.Windows.Forms.TextBox tbDimenzijeMatrice;
        private System.Windows.Forms.Button btnPlay;
    }
}