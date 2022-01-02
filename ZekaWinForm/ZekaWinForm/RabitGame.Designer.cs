
namespace ZekaWinForm
{
    partial class RabitGame
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
            this.components = new System.ComponentModel.Container();
            this.panGamePlay = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBrojKupusa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVrijemeIgranja = new System.Windows.Forms.Label();
            this.lblBrojSkokova = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RabitGameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panGamePlay
            // 
            this.panGamePlay.BackColor = System.Drawing.Color.Black;
            this.panGamePlay.Location = new System.Drawing.Point(37, 73);
            this.panGamePlay.Name = "panGamePlay";
            this.panGamePlay.Size = new System.Drawing.Size(257, 156);
            this.panGamePlay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Br.Kupusa: ";
            // 
            // lblBrojKupusa
            // 
            this.lblBrojKupusa.AutoSize = true;
            this.lblBrojKupusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojKupusa.Location = new System.Drawing.Point(68, 3);
            this.lblBrojKupusa.Name = "lblBrojKupusa";
            this.lblBrojKupusa.Size = new System.Drawing.Size(14, 13);
            this.lblBrojKupusa.TabIndex = 2;
            this.lblBrojKupusa.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(265, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vrijeme Igranja: ";
            // 
            // lblVrijemeIgranja
            // 
            this.lblVrijemeIgranja.AutoSize = true;
            this.lblVrijemeIgranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrijemeIgranja.Location = new System.Drawing.Point(355, 3);
            this.lblVrijemeIgranja.Name = "lblVrijemeIgranja";
            this.lblVrijemeIgranja.Size = new System.Drawing.Size(14, 13);
            this.lblVrijemeIgranja.TabIndex = 4;
            this.lblVrijemeIgranja.Text = "0";
            // 
            // lblBrojSkokova
            // 
            this.lblBrojSkokova.AutoSize = true;
            this.lblBrojSkokova.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojSkokova.Location = new System.Drawing.Point(207, 3);
            this.lblBrojSkokova.Name = "lblBrojSkokova";
            this.lblBrojSkokova.Size = new System.Drawing.Size(14, 13);
            this.lblBrojSkokova.TabIndex = 6;
            this.lblBrojSkokova.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(131, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Br.Skokova: ";
            // 
            // RabitGameTimer
            // 
            this.RabitGameTimer.Enabled = true;
            this.RabitGameTimer.Interval = 20;
            this.RabitGameTimer.Tick += new System.EventHandler(this.RabitGameTimer_Event);
            // 
            // RabitGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 397);
            this.Controls.Add(this.lblBrojSkokova);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblVrijemeIgranja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBrojKupusa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panGamePlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RabitGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RabitGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBrojKupusa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVrijemeIgranja;
        private System.Windows.Forms.Label lblBrojSkokova;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer RabitGameTimer;
        private System.Windows.Forms.Panel panGamePlay;
    }
}