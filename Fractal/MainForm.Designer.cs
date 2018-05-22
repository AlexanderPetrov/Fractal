namespace Fractal
{
    partial class MainForm
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
            this.btStartStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIteration = new System.Windows.Forms.Label();
            this.hSpeed = new System.Windows.Forms.HScrollBar();
            this.lbS = new System.Windows.Forms.Label();
            this.lSpeed = new System.Windows.Forms.Label();
            this.btClearPoints = new System.Windows.Forms.Button();
            this.btDrawNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStartStop
            // 
            this.btStartStop.Location = new System.Drawing.Point(17, 137);
            this.btStartStop.Name = "btStartStop";
            this.btStartStop.Size = new System.Drawing.Size(169, 28);
            this.btStartStop.TabIndex = 0;
            this.btStartStop.Text = "Start / Stop";
            this.btStartStop.UseVisualStyleBackColor = true;
            this.btStartStop.Click += new System.EventHandler(this.btStartStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iteration: ";
            // 
            // lbIteration
            // 
            this.lbIteration.AutoSize = true;
            this.lbIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIteration.Location = new System.Drawing.Point(110, 9);
            this.lbIteration.Name = "lbIteration";
            this.lbIteration.Size = new System.Drawing.Size(23, 25);
            this.lbIteration.TabIndex = 2;
            this.lbIteration.Text = "0";
            // 
            // hSpeed
            // 
            this.hSpeed.Location = new System.Drawing.Point(17, 91);
            this.hSpeed.Name = "hSpeed";
            this.hSpeed.Size = new System.Drawing.Size(169, 24);
            this.hSpeed.SmallChange = 10;
            this.hSpeed.TabIndex = 3;
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Location = new System.Drawing.Point(14, 64);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(53, 17);
            this.lbS.TabIndex = 4;
            this.lbS.Text = "Speed:";
            // 
            // lSpeed
            // 
            this.lSpeed.AutoSize = true;
            this.lSpeed.Location = new System.Drawing.Point(73, 64);
            this.lSpeed.Name = "lSpeed";
            this.lSpeed.Size = new System.Drawing.Size(16, 17);
            this.lSpeed.TabIndex = 4;
            this.lSpeed.Text = "0";
            // 
            // btClearPoints
            // 
            this.btClearPoints.Location = new System.Drawing.Point(17, 199);
            this.btClearPoints.Name = "btClearPoints";
            this.btClearPoints.Size = new System.Drawing.Size(169, 26);
            this.btClearPoints.TabIndex = 5;
            this.btClearPoints.Text = "Clear";
            this.btClearPoints.UseVisualStyleBackColor = true;
            this.btClearPoints.Click += new System.EventHandler(this.btClearPoints_Click);
            // 
            // btDrawNew
            // 
            this.btDrawNew.Location = new System.Drawing.Point(17, 231);
            this.btDrawNew.Name = "btDrawNew";
            this.btDrawNew.Size = new System.Drawing.Size(169, 29);
            this.btDrawNew.TabIndex = 6;
            this.btDrawNew.Text = "New";
            this.btDrawNew.UseVisualStyleBackColor = true;
            this.btDrawNew.Click += new System.EventHandler(this.btDrawNew_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 597);
            this.Controls.Add(this.btDrawNew);
            this.Controls.Add(this.btClearPoints);
            this.Controls.Add(this.lSpeed);
            this.Controls.Add(this.lbS);
            this.Controls.Add(this.hSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbIteration);
            this.Controls.Add(this.btStartStop);
            this.Name = "MainForm";
            this.Text = "Fractal";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.HScrollBar hSpeed;
        private System.Windows.Forms.Label lbIteration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStartStop;
        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.Label lSpeed;
        private System.Windows.Forms.Button btClearPoints;
        private System.Windows.Forms.Button btDrawNew;
    }
}

