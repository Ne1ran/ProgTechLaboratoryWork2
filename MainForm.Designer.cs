namespace ProgrammingTechnologiesLaboratoryWork2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMinX = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.calculateButton = new System.Windows.Forms.Button();
            this.textBoxMinY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaxY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaxX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStepX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum X value";
            // 
            // textBoxMinX
            // 
            this.textBoxMinX.Location = new System.Drawing.Point(592, 25);
            this.textBoxMinX.Name = "textBoxMinX";
            this.textBoxMinX.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinX.TabIndex = 1;
            this.textBoxMinX.Text = "1";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 219);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1037, 23);
            this.progressBar.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(877, 646);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // textBoxMinY
            // 
            this.textBoxMinY.Location = new System.Drawing.Point(592, 64);
            this.textBoxMinY.Name = "textBoxMinY";
            this.textBoxMinY.ReadOnly = true;
            this.textBoxMinY.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinY.TabIndex = 5;
            this.textBoxMinY.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minimum Y value";
            // 
            // textBoxMaxY
            // 
            this.textBoxMaxY.Location = new System.Drawing.Point(755, 64);
            this.textBoxMaxY.Name = "textBoxMaxY";
            this.textBoxMaxY.ReadOnly = true;
            this.textBoxMaxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxY.TabIndex = 9;
            this.textBoxMaxY.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(740, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maximum Y value";
            // 
            // textBoxMaxX
            // 
            this.textBoxMaxX.Location = new System.Drawing.Point(755, 25);
            this.textBoxMaxX.Name = "textBoxMaxX";
            this.textBoxMaxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxX.TabIndex = 7;
            this.textBoxMaxX.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(740, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Maximum X value";
            // 
            // textBoxStepX
            // 
            this.textBoxStepX.Location = new System.Drawing.Point(952, 25);
            this.textBoxStepX.Name = "textBoxStepX";
            this.textBoxStepX.Size = new System.Drawing.Size(100, 20);
            this.textBoxStepX.TabIndex = 11;
            this.textBoxStepX.Text = "0,1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(942, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Step X";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(15, 646);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(53, 13);
            this.labelDuration.TabIndex = 12;
            this.labelDuration.Text = "Duration: ";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(977, 646);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.textBoxStepX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMaxY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMaxX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMinY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBoxMinX);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Function Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMinX;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox textBoxMinY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaxY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaxX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStepX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Button exitButton;
    }
} 