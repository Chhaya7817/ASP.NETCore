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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Symbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(454, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(341, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(240, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Account";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(129, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Side";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(121, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // inputSym
            // 
            this.inputSym.Location = new System.Drawing.Point(2, 38);
            this.inputSym.Name = "inputSym";
            this.inputSym.Size = new System.Drawing.Size(113, 20);
            this.inputSym.TabIndex = 6;
            // 
            // inputQty
            // 
            this.inputQty.Location = new System.Drawing.Point(344, 39);
            this.inputQty.Name = "inputQty";
            this.inputQty.Size = new System.Drawing.Size(91, 20);
            this.inputQty.TabIndex = 7;
            this.inputQty.Text = "0";
            this.inputQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inputPrice
            // 
            this.inputPrice.Location = new System.Drawing.Point(441, 39);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(91, 20);
            this.inputPrice.TabIndex = 8;
            this.inputPrice.Text = "0.0";
            this.inputPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inputSide
            // 
            this.inputSide.FormattingEnabled = true;
            this.inputSide.Items.AddRange(new object[] {
            "Buy",
            "Sell",
            "Sell Short",
            "Buy to Close"});
            this.inputSide.Location = new System.Drawing.Point(129, 38);
            this.inputSide.Name = "inputSide";
            this.inputSide.Size = new System.Drawing.Size(103, 21);
            this.inputSide.TabIndex = 9;
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
            this.inputAcc.Location = new System.Drawing.Point(238, 38);
            this.inputAcc.Name = "inputAcc";
            this.inputAcc.Size = new System.Drawing.Size(101, 21);
            this.inputAcc.TabIndex = 10;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(344, 81);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create Order";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(441, 81);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Done Away";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // TT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(544, 119);
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