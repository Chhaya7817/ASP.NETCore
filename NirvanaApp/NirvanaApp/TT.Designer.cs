namespace NirvanaApp
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
            this.textSymbol = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textQty = new System.Windows.Forms.TextBox();
            this.sideBox = new System.Windows.Forms.ComboBox();
            this.accountBox = new System.Windows.Forms.ComboBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.btnDoneAway = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Symbol";
            // 
            // textSymbol
            // 
            this.textSymbol.Location = new System.Drawing.Point(12, 38);
            this.textSymbol.Name = "textSymbol";
            this.textSymbol.Size = new System.Drawing.Size(129, 23);
            this.textSymbol.TabIndex = 1;
            this.textSymbol.Text = "Enter Symbol";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(147, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 92);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Side";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price";
            // 
            // textQty
            // 
            this.textQty.Location = new System.Drawing.Point(396, 38);
            this.textQty.Name = "textQty";
            this.textQty.Size = new System.Drawing.Size(89, 23);
            this.textQty.TabIndex = 7;
            this.textQty.Text = "0";
            this.textQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sideBox
            // 
            this.sideBox.FormattingEnabled = true;
            this.sideBox.Items.AddRange(new object[] {
            "Buy",
            "Sell",
            "Sell Short",
            "Buy to Close"});
            this.sideBox.Location = new System.Drawing.Point(164, 38);
            this.sideBox.Name = "sideBox";
            this.sideBox.Size = new System.Drawing.Size(99, 23);
            this.sideBox.TabIndex = 8;
            // 
            // accountBox
            // 
            this.accountBox.FormattingEnabled = true;
            this.accountBox.Items.AddRange(new object[] {
            "Unallocated",
            "Account1",
            "Account2",
            "Account3",
            "Account4"});
            this.accountBox.Location = new System.Drawing.Point(269, 38);
            this.accountBox.Name = "accountBox";
            this.accountBox.Size = new System.Drawing.Size(121, 23);
            this.accountBox.TabIndex = 9;
            this.accountBox.Text = "Select Account";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(503, 38);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(80, 23);
            this.textPrice.TabIndex = 10;
            this.textPrice.Text = "0.00";
            this.textPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDoneAway
            // 
            this.btnDoneAway.Location = new System.Drawing.Point(503, 70);
            this.btnDoneAway.Name = "btnDoneAway";
            this.btnDoneAway.Size = new System.Drawing.Size(80, 23);
            this.btnDoneAway.TabIndex = 12;
            this.btnDoneAway.Text = "Done Away";
            this.btnDoneAway.UseVisualStyleBackColor = true;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(396, 70);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(89, 23);
            this.btnCreateOrder.TabIndex = 13;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            // 
            // TT
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 94);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnDoneAway);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.accountBox);
            this.Controls.Add(this.sideBox);
            this.Controls.Add(this.textQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textSymbol);
            this.Controls.Add(this.label1);
            this.Name = "TT";
            this.Text = "Trading Ticket";
            this.Load += new System.EventHandler(this.TT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textSymbol;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textQty;
        private ComboBox sideBox;
        private ComboBox accountBox;
        private TextBox textPrice;
        private Button btnDoneAway;
        private Button btnCreateOrder;
    }
}