namespace VictoryDicesWF
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gameboardimg = new System.Windows.Forms.PictureBox();
            this.explbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.OutputBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameboardimg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Victory Dices Simulator";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 54);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 55);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Controls.Add(this.label2);
            this.OutputBox.Location = new System.Drawing.Point(195, 12);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(758, 260);
            this.OutputBox.TabIndex = 2;
            this.OutputBox.TabStop = false;
            this.OutputBox.Text = "Output";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(652, 213);
            this.label2.TabIndex = 0;
            // 
            // gameboardimg
            // 
            this.gameboardimg.Image = global::VictoryDicesWF.Properties.Resources.gameboard;
            this.gameboardimg.ImageLocation = "";
            this.gameboardimg.Location = new System.Drawing.Point(204, 294);
            this.gameboardimg.Name = "gameboardimg";
            this.gameboardimg.Size = new System.Drawing.Size(778, 621);
            this.gameboardimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gameboardimg.TabIndex = 3;
            this.gameboardimg.TabStop = false;
            this.gameboardimg.Click += new System.EventHandler(this.gameboardimg_Click);
            // 
            // explbtn
            // 
            this.explbtn.Location = new System.Drawing.Point(16, 124);
            this.explbtn.Name = "explbtn";
            this.explbtn.Size = new System.Drawing.Size(113, 66);
            this.explbtn.TabIndex = 4;
            this.explbtn.Text = "Explain";
            this.explbtn.UseVisualStyleBackColor = true;
            this.explbtn.Click += new System.EventHandler(this.explbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(19, 203);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(110, 68);
            this.clearbtn.TabIndex = 5;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(865, 791);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.explbtn);
            this.Controls.Add(this.gameboardimg);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Victory Dices Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.OutputBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameboardimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox OutputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox gameboardimg;
        private System.Windows.Forms.Button explbtn;
        private System.Windows.Forms.Button clearbtn;
    }
}

