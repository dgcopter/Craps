namespace Craps
{
    partial class Craps
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
            this.txtBank = new System.Windows.Forms.TextBox();
            this.lblDieOne = new System.Windows.Forms.Label();
            this.lblDieTwo = new System.Windows.Forms.Label();
            this.lblPhase = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnConfirmBet = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecentResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurrentBet = new System.Windows.Forms.TextBox();
            this.lblCurrentBet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Bank:";
            // 
            // txtBank
            // 
            this.txtBank.Enabled = false;
            this.txtBank.Location = new System.Drawing.Point(240, 177);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(100, 20);
            this.txtBank.TabIndex = 1;
            this.txtBank.Text = "5000";
            this.txtBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDieOne
            // 
            this.lblDieOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDieOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDieOne.Location = new System.Drawing.Point(120, 88);
            this.lblDieOne.Name = "lblDieOne";
            this.lblDieOne.Size = new System.Drawing.Size(67, 68);
            this.lblDieOne.TabIndex = 2;
            this.lblDieOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDieTwo
            // 
            this.lblDieTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDieTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDieTwo.Location = new System.Drawing.Point(273, 88);
            this.lblDieTwo.Name = "lblDieTwo";
            this.lblDieTwo.Size = new System.Drawing.Size(67, 68);
            this.lblDieTwo.TabIndex = 3;
            this.lblDieTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhase
            // 
            this.lblPhase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhase.Location = new System.Drawing.Point(120, 13);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(220, 23);
            this.lblPhase.TabIndex = 4;
            this.lblPhase.Text = "Come Out";
            this.lblPhase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bet:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(240, 209);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(100, 20);
            this.txtBet.TabIndex = 6;
            this.txtBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConfirmBet
            // 
            this.btnConfirmBet.Location = new System.Drawing.Point(354, 209);
            this.btnConfirmBet.Name = "btnConfirmBet";
            this.btnConfirmBet.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmBet.TabIndex = 7;
            this.btnConfirmBet.Text = "Confirm Bet";
            this.btnConfirmBet.UseVisualStyleBackColor = true;
            this.btnConfirmBet.Click += new System.EventHandler(this.btnConfirmBet_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(120, 298);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(222, 35);
            this.btnRoll.TabIndex = 8;
            this.btnRoll.Text = "ROLL DEM BONES!";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Most recent win/loss:";
            // 
            // txtRecentResult
            // 
            this.txtRecentResult.Enabled = false;
            this.txtRecentResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecentResult.ForeColor = System.Drawing.Color.Black;
            this.txtRecentResult.Location = new System.Drawing.Point(15, 262);
            this.txtRecentResult.Name = "txtRecentResult";
            this.txtRecentResult.Size = new System.Drawing.Size(100, 20);
            this.txtRecentResult.TabIndex = 10;
            this.txtRecentResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Point:";
            // 
            // lblPoint
            // 
            this.lblPoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.Location = new System.Drawing.Point(427, 38);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(64, 53);
            this.lblPoint.TabIndex = 12;
            this.lblPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Current Bet:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCurrentBet
            // 
            this.txtCurrentBet.Enabled = false;
            this.txtCurrentBet.Location = new System.Drawing.Point(371, 262);
            this.txtCurrentBet.Name = "txtCurrentBet";
            this.txtCurrentBet.Size = new System.Drawing.Size(104, 20);
            this.txtCurrentBet.TabIndex = 14;
            this.txtCurrentBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCurrentBet
            // 
            this.lblCurrentBet.Location = new System.Drawing.Point(441, 285);
            this.lblCurrentBet.Name = "lblCurrentBet";
            this.lblCurrentBet.Size = new System.Drawing.Size(10, 10);
            this.lblCurrentBet.TabIndex = 15;
            this.lblCurrentBet.Visible = false;
            // 
            // Craps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 345);
            this.Controls.Add(this.lblCurrentBet);
            this.Controls.Add(this.txtCurrentBet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRecentResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnConfirmBet);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPhase);
            this.Controls.Add(this.lblDieTwo);
            this.Controls.Add(this.lblDieOne);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.label1);
            this.Name = "Craps";
            this.Text = "Craps";
            this.Load += new System.EventHandler(this.Craps_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label lblDieOne;
        private System.Windows.Forms.Label lblDieTwo;
        private System.Windows.Forms.Label lblPhase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Button btnConfirmBet;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecentResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCurrentBet;
        private System.Windows.Forms.Label lblCurrentBet;
    }
}

