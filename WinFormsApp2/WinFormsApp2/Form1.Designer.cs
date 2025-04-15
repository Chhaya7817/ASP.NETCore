namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Programmer = new System.Windows.Forms.RadioButton();
            this.Engineer = new System.Windows.Forms.RadioButton();
            this.box = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hii Chhaya";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(313, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USER DETAILS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 31);
            this.textBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "market",
            "mathura",
            "gao"});
            this.listBox1.Location = new System.Drawing.Point(19, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 129);
            this.listBox1.TabIndex = 2;
            // 
            // Programmer
            // 
            this.Programmer.AutoSize = true;
            this.Programmer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Programmer.ForeColor = System.Drawing.Color.Coral;
            this.Programmer.Location = new System.Drawing.Point(376, 287);
            this.Programmer.Name = "Programmer";
            this.Programmer.Size = new System.Drawing.Size(137, 29);
            this.Programmer.TabIndex = 3;
            this.Programmer.TabStop = true;
            this.Programmer.Text = "Programmer";
            this.Programmer.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Programmer.UseVisualStyleBackColor = false;
            this.Programmer.UseWaitCursor = true;
            this.Programmer.CheckedChanged += new System.EventHandler(this.Programmer_CheckedChanged);
            // 
            // Engineer
            // 
            this.Engineer.AutoSize = true;
            this.Engineer.Location = new System.Drawing.Point(376, 336);
            this.Engineer.Name = "Engineer";
            this.Engineer.Size = new System.Drawing.Size(105, 29);
            this.Engineer.TabIndex = 4;
            this.Engineer.TabStop = true;
            this.Engineer.Text = "Engineer";
            this.Engineer.UseVisualStyleBackColor = true;
            // 
            // box
            // 
            this.box.AutoSize = true;
            this.box.Checked = true;
            this.box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.box.Location = new System.Drawing.Point(37, 288);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(59, 29);
            this.box.TabIndex = 5;
            this.box.Text = "Hii";
            this.box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.box.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(37, 336);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(121, 29);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.box);
            this.Controls.Add(this.Engineer);
            this.Controls.Add(this.Programmer);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private ListBox listBox1;
        private RadioButton Programmer;
        private RadioButton Engineer;
        private CheckBox box;
        private CheckBox checkBox2;
    }
}