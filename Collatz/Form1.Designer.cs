namespace Collatz
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
            this.StartingNumberInputBox = new System.Windows.Forms.TextBox();
            this.ResultsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RangeNumberTestRadio = new System.Windows.Forms.RadioButton();
            this.SingleNumberTestRadio = new System.Windows.Forms.RadioButton();
            this.EndingNumberInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TestIncrementRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartingNumberInputBox
            // 
            this.StartingNumberInputBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.StartingNumberInputBox.Location = new System.Drawing.Point(125, 87);
            this.StartingNumberInputBox.Name = "StartingNumberInputBox";
            this.StartingNumberInputBox.Size = new System.Drawing.Size(332, 20);
            this.StartingNumberInputBox.TabIndex = 0;
            // 
            // ResultsList
            // 
            this.ResultsList.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultsList.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ResultsList.FormattingEnabled = true;
            this.ResultsList.HorizontalScrollbar = true;
            this.ResultsList.ItemHeight = 18;
            this.ResultsList.Location = new System.Drawing.Point(30, 174);
            this.ResultsList.Name = "ResultsList";
            this.ResultsList.Size = new System.Drawing.Size(618, 360);
            this.ResultsList.TabIndex = 1;
            this.ResultsList.SelectedIndexChanged += new System.EventHandler(this.ResultsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Starting Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(30, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(426, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TestIncrementRadio);
            this.groupBox1.Controls.Add(this.RangeNumberTestRadio);
            this.groupBox1.Controls.Add(this.SingleNumberTestRadio);
            this.groupBox1.Location = new System.Drawing.Point(487, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 111);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run Modes";
            // 
            // RangeNumberTestRadio
            // 
            this.RangeNumberTestRadio.Location = new System.Drawing.Point(6, 47);
            this.RangeNumberTestRadio.Name = "RangeNumberTestRadio";
            this.RangeNumberTestRadio.Size = new System.Drawing.Size(149, 32);
            this.RangeNumberTestRadio.TabIndex = 4;
            this.RangeNumberTestRadio.Text = "Test a Range of Numbers";
            this.RangeNumberTestRadio.UseVisualStyleBackColor = true;
            this.RangeNumberTestRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SingleNumberTestRadio
            // 
            this.SingleNumberTestRadio.Checked = true;
            this.SingleNumberTestRadio.Location = new System.Drawing.Point(6, 19);
            this.SingleNumberTestRadio.Name = "SingleNumberTestRadio";
            this.SingleNumberTestRadio.Size = new System.Drawing.Size(140, 29);
            this.SingleNumberTestRadio.TabIndex = 3;
            this.SingleNumberTestRadio.TabStop = true;
            this.SingleNumberTestRadio.Text = "Test a Single Number\r\n";
            this.SingleNumberTestRadio.UseVisualStyleBackColor = true;
            // 
            // EndingNumberInput
            // 
            this.EndingNumberInput.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.EndingNumberInput.Location = new System.Drawing.Point(125, 123);
            this.EndingNumberInput.Name = "EndingNumberInput";
            this.EndingNumberInput.Size = new System.Drawing.Size(331, 20);
            this.EndingNumberInput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(29, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ending Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TestIncrementRadio
            // 
            this.TestIncrementRadio.Location = new System.Drawing.Point(12, 79);
            this.TestIncrementRadio.Name = "TestIncrementRadio";
            this.TestIncrementRadio.Size = new System.Drawing.Size(149, 26);
            this.TestIncrementRadio.TabIndex = 5;
            this.TestIncrementRadio.TabStop = true;
            this.TestIncrementRadio.Text = "Test Incrementing\r\n";
            this.TestIncrementRadio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 565);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndingNumberInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartingNumberInputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultsList);
            this.Name = "Form1";
            this.Text = "Collatz";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RadioButton TestIncrementRadio;

        private System.Windows.Forms.RadioButton RangeNumberTestRadio;

        private System.Windows.Forms.TextBox EndingNumberInput;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TreeView treeView1;

        private System.Windows.Forms.RadioButton radioButton2;

        private System.Windows.Forms.RadioButton SingleNumberTestRadio;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox StartingNumberInputBox;
        public System.Windows.Forms.ListBox ResultsList;

        #endregion
    }
}