namespace NirvanaAppilcation
{
    partial class TT
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inputSym = new System.Windows.Forms.TextBox();
            this.inputQty = new System.Windows.Forms.TextBox();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.inputSide = new System.Windows.Forms.ComboBox();
            this.inputAcc = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Symbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(681, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(512, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(360, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Account";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(194, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Side";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(182, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // inputSym
            // 
            this.inputSym.ForeColor = System.Drawing.Color.Black;
            this.inputSym.Location = new System.Drawing.Point(3, 58);
            this.inputSym.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputSym.Name = "inputSym";
            this.inputSym.Size = new System.Drawing.Size(168, 26);
            this.inputSym.TabIndex = 6;
            this.inputSym.Text = "Enter Symbol";
            this.inputSym.Click += new System.EventHandler(this.inputSym_Click);
            this.inputSym.Leave += new System.EventHandler(this.inputSym_Leave);
            // 
            // inputQty
            // 
            this.inputQty.Location = new System.Drawing.Point(516, 60);
            this.inputQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputQty.Name = "inputQty";
            this.inputQty.Size = new System.Drawing.Size(134, 26);
            this.inputQty.TabIndex = 7;
            this.inputQty.Text = "0";
            this.inputQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputQty.Click += new System.EventHandler(this.inputQty_Click);
            this.inputQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputQty_KeyPress);
            this.inputQty.Leave += new System.EventHandler(this.inputQty_Leave);
            // 
            // inputPrice
            // 
            this.inputPrice.Location = new System.Drawing.Point(662, 60);
            this.inputPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(134, 26);
            this.inputPrice.TabIndex = 8;
            this.inputPrice.Text = "0.0";
            this.inputPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputPrice.Click += new System.EventHandler(this.inputPrice_Click);
            this.inputPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputPrice_KeyPress);
            this.inputPrice.Leave += new System.EventHandler(this.inputPrice_Leave);
            // 
            // inputSide
            // 
            this.inputSide.FormattingEnabled = true;
            this.inputSide.Items.AddRange(new object[] {
            "Buy",
            "Sell",
            "Sell Short",
            "Buy to Close"});
            this.inputSide.Location = new System.Drawing.Point(194, 58);
            this.inputSide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputSide.Name = "inputSide";
            this.inputSide.Size = new System.Drawing.Size(152, 28);
            this.inputSide.TabIndex = 9;
            this.inputSide.Text = "Select Side";
            this.inputSide.Click += new System.EventHandler(this.inputSide_Click);
            this.inputSide.Leave += new System.EventHandler(this.inputSide_Leave);
            // 
            // inputAcc
            // 
            this.inputAcc.FormattingEnabled = true;
            this.inputAcc.Items.AddRange(new object[] {
            "Unallocated",
            "Account1",
            "Account2",
            "Account3",
            "Account4"});
            this.inputAcc.Location = new System.Drawing.Point(357, 58);
            this.inputAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputAcc.Name = "inputAcc";
            this.inputAcc.Size = new System.Drawing.Size(150, 28);
            this.inputAcc.TabIndex = 10;
            this.inputAcc.Text = "Select Account";
            this.inputAcc.Click += new System.EventHandler(this.inputAcc_Click);
            this.inputAcc.Leave += new System.EventHandler(this.inputAcc_Leave);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(516, 125);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(112, 35);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create Order";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(662, 125);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(112, 35);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Done Away";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // TT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(812, 188);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.inputAcc);
            this.Controls.Add(this.inputSide);
            this.Controls.Add(this.inputPrice);
            this.Controls.Add(this.inputQty);
            this.Controls.Add(this.inputSym);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TT";
            this.Text = "TT";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox inputSym;
        private System.Windows.Forms.TextBox inputQty;
        private System.Windows.Forms.TextBox inputPrice;
        private System.Windows.Forms.ComboBox inputSide;
        private System.Windows.Forms.ComboBox inputAcc;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDone;
    }
}