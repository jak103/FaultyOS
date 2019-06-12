namespace FaultyOS
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
            this.commandBox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.killRateBox = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.killRateBox)).BeginInit();
            this.SuspendLayout();
            // 
            // commandBox
            // 
            this.commandBox.Location = new System.Drawing.Point(101, 424);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(695, 26);
            this.commandBox.TabIndex = 0;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(721, 464);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 38);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 12);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(784, 371);
            this.outputBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Process:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kill Rate:";
            // 
            // killRateBox
            // 
            this.killRateBox.Location = new System.Drawing.Point(101, 471);
            this.killRateBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.killRateBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.killRateBox.Name = "killRateBox";
            this.killRateBox.Size = new System.Drawing.Size(75, 26);
            this.killRateBox.TabIndex = 5;
            this.killRateBox.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.killRateBox.ValueChanged += new System.EventHandler(this.killRateBox_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 390);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Enable Output";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 511);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.killRateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.commandBox);
            this.Name = "Form1";
            this.Text = "FaultyOS";
            ((System.ComponentModel.ISupportInitialize)(this.killRateBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commandBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown killRateBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

