namespace HorseRace
{
    partial class GameForm
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
            this.txtNumberOfHorses = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.pnlFinishLine = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtNumberOfHorses
            // 
            this.txtNumberOfHorses.Location = new System.Drawing.Point(12, 21);
            this.txtNumberOfHorses.Name = "txtNumberOfHorses";
            this.txtNumberOfHorses.Size = new System.Drawing.Size(251, 20);
            this.txtNumberOfHorses.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(281, 18);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(169, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate and Start";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(472, 18);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(169, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // pnlFinishLine
            // 
            this.pnlFinishLine.BackColor = System.Drawing.Color.Red;
            this.pnlFinishLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFinishLine.Location = new System.Drawing.Point(666, 21);
            this.pnlFinishLine.Name = "pnlFinishLine";
            this.pnlFinishLine.Size = new System.Drawing.Size(16, 377);
            this.pnlFinishLine.TabIndex = 3;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 422);
            this.Controls.Add(this.pnlFinishLine);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtNumberOfHorses);
            this.Name = "GameForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberOfHorses;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel pnlFinishLine;
    }
}

