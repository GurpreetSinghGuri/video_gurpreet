namespace video_gurpreet
{
    partial class customer
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
            this.phone_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.lname_label = new System.Windows.Forms.Label();
            this.fname_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.phone_text = new System.Windows.Forms.TextBox();
            this.address_text = new System.Windows.Forms.TextBox();
            this.lname_text = new System.Windows.Forms.TextBox();
            this.fname_text = new System.Windows.Forms.TextBox();
            this.addcustomer_button = new System.Windows.Forms.Button();
            this.customer_Grid = new System.Windows.Forms.DataGridView();
            this.Srno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customer_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(318, 211);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(49, 17);
            this.phone_label.TabIndex = 100;
            this.phone_label.Text = "Phone";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(316, 181);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(60, 17);
            this.address_label.TabIndex = 99;
            this.address_label.Text = "Address";
            // 
            // lname_label
            // 
            this.lname_label.AutoSize = true;
            this.lname_label.Location = new System.Drawing.Point(304, 139);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(76, 17);
            this.lname_label.TabIndex = 98;
            this.lname_label.Text = "Last Name";
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Location = new System.Drawing.Point(300, 100);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(76, 17);
            this.fname_label.TabIndex = 97;
            this.fname_label.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 96;
            this.label2.Text = "Custid";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 41);
            this.button1.TabIndex = 95;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 41);
            this.button2.TabIndex = 94;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(386, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 93;
            // 
            // phone_text
            // 
            this.phone_text.Location = new System.Drawing.Point(386, 211);
            this.phone_text.Name = "phone_text";
            this.phone_text.Size = new System.Drawing.Size(73, 22);
            this.phone_text.TabIndex = 92;
            // 
            // address_text
            // 
            this.address_text.Location = new System.Drawing.Point(386, 176);
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(100, 22);
            this.address_text.TabIndex = 91;
            // 
            // lname_text
            // 
            this.lname_text.Location = new System.Drawing.Point(386, 134);
            this.lname_text.Name = "lname_text";
            this.lname_text.Size = new System.Drawing.Size(100, 22);
            this.lname_text.TabIndex = 90;
            // 
            // fname_text
            // 
            this.fname_text.Location = new System.Drawing.Point(386, 95);
            this.fname_text.Name = "fname_text";
            this.fname_text.Size = new System.Drawing.Size(88, 22);
            this.fname_text.TabIndex = 89;
            // 
            // addcustomer_button
            // 
            this.addcustomer_button.Location = new System.Drawing.Point(312, 268);
            this.addcustomer_button.Name = "addcustomer_button";
            this.addcustomer_button.Size = new System.Drawing.Size(118, 41);
            this.addcustomer_button.TabIndex = 88;
            this.addcustomer_button.Text = "Add Customer";
            this.addcustomer_button.UseVisualStyleBackColor = true;
            this.addcustomer_button.Click += new System.EventHandler(this.addcustomer_button_Click);
            // 
            // customer_Grid
            // 
            this.customer_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Srno});
            this.customer_Grid.Location = new System.Drawing.Point(0, 0);
            this.customer_Grid.Name = "customer_Grid";
            this.customer_Grid.RowTemplate.Height = 24;
            this.customer_Grid.Size = new System.Drawing.Size(298, 381);
            this.customer_Grid.TabIndex = 101;
            this.customer_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_Grid_CellContentClick);
            // 
            // Srno
            // 
            this.Srno.DataPropertyName = "CustID";
            this.Srno.HeaderText = "Srno";
            this.Srno.Name = "Srno";
            this.Srno.ReadOnly = true;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 393);
            this.Controls.Add(this.customer_Grid);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.lname_label);
            this.Controls.Add(this.fname_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.phone_text);
            this.Controls.Add(this.address_text);
            this.Controls.Add(this.lname_text);
            this.Controls.Add(this.fname_text);
            this.Controls.Add(this.addcustomer_button);
            this.Name = "customer";
            this.Text = "customer";
            this.Load += new System.EventHandler(this.customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customer_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label lname_label;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox phone_text;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.TextBox lname_text;
        private System.Windows.Forms.TextBox fname_text;
        private System.Windows.Forms.Button addcustomer_button;
        private System.Windows.Forms.DataGridView customer_Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Srno;
    }
}