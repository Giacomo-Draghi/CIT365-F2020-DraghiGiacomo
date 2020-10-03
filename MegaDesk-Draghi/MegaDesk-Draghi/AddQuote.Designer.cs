namespace MegaDesk_Draghi
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addDepth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addWidth = new System.Windows.Forms.TextBox();
            this.drawer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.shipping = new System.Windows.Forms.ComboBox();
            this.SubmitOrder = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.areaPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.drawerPrice = new System.Windows.Forms.Label();
            this.materialPrice = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.shippingPrice = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pleas enter your Name:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(142, 87);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(232, 20);
            this.name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width of Desk:";
            // 
            // addDepth
            // 
            this.addDepth.Location = new System.Drawing.Point(543, 87);
            this.addDepth.Name = "addDepth";
            this.addDepth.Size = new System.Drawing.Size(149, 20);
            this.addDepth.TabIndex = 3;
            this.addDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddDepth_KeyPress);
            this.addDepth.Validating += new System.ComponentModel.CancelEventHandler(this.addDepth_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(538, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Depth of Desk:";
            // 
            // addWidth
            // 
            this.addWidth.Location = new System.Drawing.Point(385, 87);
            this.addWidth.Name = "addWidth";
            this.addWidth.Size = new System.Drawing.Size(147, 20);
            this.addWidth.TabIndex = 2;
            this.addWidth.Validating += new System.ComponentModel.CancelEventHandler(this.addWidth_Validaing);
            // 
            // drawer
            // 
            this.drawer.FormattingEnabled = true;
            this.drawer.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawer.Location = new System.Drawing.Point(274, 162);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(121, 21);
            this.drawer.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Drawer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Material:";
            // 
            // material
            // 
            this.material.FormattingEnabled = true;
            this.material.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.material.Location = new System.Drawing.Point(274, 191);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(121, 21);
            this.material.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Shipping:";
            // 
            // shipping
            // 
            this.shipping.FormattingEnabled = true;
            this.shipping.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
            this.shipping.Location = new System.Drawing.Point(274, 221);
            this.shipping.Name = "shipping";
            this.shipping.Size = new System.Drawing.Size(121, 21);
            this.shipping.TabIndex = 6;
            // 
            // SubmitOrder
            // 
            this.SubmitOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitOrder.Location = new System.Drawing.Point(516, 308);
            this.SubmitOrder.Name = "SubmitOrder";
            this.SubmitOrder.Size = new System.Drawing.Size(176, 65);
            this.SubmitOrder.TabIndex = 8;
            this.SubmitOrder.Text = "Submit Order";
            this.SubmitOrder.UseVisualStyleBackColor = true;
            this.SubmitOrder.Click += new System.EventHandler(this.SubmitOrder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Area Cost: $";
            // 
            // areaPrice
            // 
            this.areaPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areaPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaPrice.Location = new System.Drawing.Point(274, 120);
            this.areaPrice.Name = "areaPrice";
            this.areaPrice.Size = new System.Drawing.Size(418, 30);
            this.areaPrice.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(402, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total:           $";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(401, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Cost:            $";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(401, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "X   $50.00   =";
            // 
            // drawerPrice
            // 
            this.drawerPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawerPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerPrice.Location = new System.Drawing.Point(547, 159);
            this.drawerPrice.Name = "drawerPrice";
            this.drawerPrice.Size = new System.Drawing.Size(145, 30);
            this.drawerPrice.TabIndex = 18;
            // 
            // materialPrice
            // 
            this.materialPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialPrice.Location = new System.Drawing.Point(547, 188);
            this.materialPrice.Name = "materialPrice";
            this.materialPrice.Size = new System.Drawing.Size(145, 30);
            this.materialPrice.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(401, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 25);
            this.label14.TabIndex = 20;
            this.label14.Text = "Cost:            $";
            // 
            // shippingPrice
            // 
            this.shippingPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shippingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingPrice.Location = new System.Drawing.Point(547, 216);
            this.shippingPrice.Name = "shippingPrice";
            this.shippingPrice.Size = new System.Drawing.Size(145, 30);
            this.shippingPrice.TabIndex = 21;
            // 
            // total
            // 
            this.total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(547, 245);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(145, 30);
            this.total.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(329, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get Quote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(142, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 65);
            this.button2.TabIndex = 9;
            this.button2.Text = "Back to Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(137, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Quote Day:";
            // 
            // Day
            // 
            this.Day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.Location = new System.Drawing.Point(251, 247);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(145, 30);
            this.Day.TabIndex = 26;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.ControlBox = false;
            this.Controls.Add(this.Day);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.shippingPrice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.materialPrice);
            this.Controls.Add(this.drawerPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.areaPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SubmitOrder);
            this.Controls.Add(this.shipping);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.material);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.drawer);
            this.Controls.Add(this.addWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addDepth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addDepth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addWidth;
        private System.Windows.Forms.ComboBox drawer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox material;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox shipping;
        private System.Windows.Forms.Button SubmitOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label areaPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label drawerPrice;
        private System.Windows.Forms.Label materialPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label shippingPrice;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Day;
    }
}