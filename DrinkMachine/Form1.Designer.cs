namespace DrinkMachine
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
            this.dgvDrinksTabels = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cocoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSugar = new System.Windows.Forms.ComboBox();
            this.cmbCoffe = new System.Windows.Forms.ComboBox();
            this.cmbCocoa = new System.Windows.Forms.ComboBox();
            this.cmbMilk = new System.Windows.Forms.ComboBox();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNewDrink = new System.Windows.Forms.Label();
            this.txtNewDrink = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdataDrink = new System.Windows.Forms.Button();
            this.btnDeleteDrink = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrinksTabels)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDrinksTabels
            // 
            this.dgvDrinksTabels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrinksTabels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.sugar,
            this.coffee,
            this.cocoa,
            this.milk,
            this.price});
            this.dgvDrinksTabels.Location = new System.Drawing.Point(63, 213);
            this.dgvDrinksTabels.Name = "dgvDrinksTabels";
            this.dgvDrinksTabels.Size = new System.Drawing.Size(555, 182);
            this.dgvDrinksTabels.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // sugar
            // 
            this.sugar.HeaderText = "sugar";
            this.sugar.Name = "sugar";
            // 
            // coffee
            // 
            this.coffee.HeaderText = "coffee";
            this.coffee.Name = "coffee";
            // 
            // cocoa
            // 
            this.cocoa.HeaderText = "cocoa";
            this.cocoa.Name = "cocoa";
            // 
            // milk
            // 
            this.milk.HeaderText = "milk";
            this.milk.Name = "milk";
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // cmbSugar
            // 
            this.cmbSugar.FormattingEnabled = true;
            this.cmbSugar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbSugar.Location = new System.Drawing.Point(539, 143);
            this.cmbSugar.Name = "cmbSugar";
            this.cmbSugar.Size = new System.Drawing.Size(52, 21);
            this.cmbSugar.TabIndex = 1;
            this.cmbSugar.Text = "0";
            // 
            // cmbCoffe
            // 
            this.cmbCoffe.FormattingEnabled = true;
            this.cmbCoffe.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbCoffe.Location = new System.Drawing.Point(448, 143);
            this.cmbCoffe.Name = "cmbCoffe";
            this.cmbCoffe.Size = new System.Drawing.Size(52, 21);
            this.cmbCoffe.TabIndex = 2;
            this.cmbCoffe.Text = "0";
            // 
            // cmbCocoa
            // 
            this.cmbCocoa.FormattingEnabled = true;
            this.cmbCocoa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbCocoa.Location = new System.Drawing.Point(355, 143);
            this.cmbCocoa.Name = "cmbCocoa";
            this.cmbCocoa.Size = new System.Drawing.Size(52, 21);
            this.cmbCocoa.TabIndex = 3;
            this.cmbCocoa.Text = "0";
            // 
            // cmbMilk
            // 
            this.cmbMilk.FormattingEnabled = true;
            this.cmbMilk.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbMilk.Location = new System.Drawing.Point(264, 143);
            this.cmbMilk.Name = "cmbMilk";
            this.cmbMilk.Size = new System.Drawing.Size(52, 21);
            this.cmbMilk.TabIndex = 4;
            this.cmbMilk.Text = "0";
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Location = new System.Drawing.Point(386, 36);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(100, 42);
            this.btnAddDrink.TabIndex = 6;
            this.btnAddDrink.Text = "הוספת סוג שתיה";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 92);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "שמירה";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNewDrink
            // 
            this.lblNewDrink.AutoSize = true;
            this.lblNewDrink.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewDrink.Location = new System.Drawing.Point(535, 23);
            this.lblNewDrink.Name = "lblNewDrink";
            this.lblNewDrink.Size = new System.Drawing.Size(97, 19);
            this.lblNewDrink.TabIndex = 8;
            this.lblNewDrink.Text = "סוג שתיה חדש";
            // 
            // txtNewDrink
            // 
            this.txtNewDrink.Location = new System.Drawing.Point(532, 58);
            this.txtNewDrink.Name = "txtNewDrink";
            this.txtNewDrink.Size = new System.Drawing.Size(100, 20);
            this.txtNewDrink.TabIndex = 9;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Lime;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(141, 138);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(23, 32);
            this.btnPlus.TabIndex = 10;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Red;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(112, 138);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(23, 32);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "סוכר";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "קפה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "קקאו";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "חלב";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "מחיר";
            // 
            // btnUpdataDrink
            // 
            this.btnUpdataDrink.Location = new System.Drawing.Point(258, 36);
            this.btnUpdataDrink.Name = "btnUpdataDrink";
            this.btnUpdataDrink.Size = new System.Drawing.Size(100, 42);
            this.btnUpdataDrink.TabIndex = 17;
            this.btnUpdataDrink.Text = "עדכון סוג שתיה";
            this.btnUpdataDrink.UseVisualStyleBackColor = true;
            this.btnUpdataDrink.Click += new System.EventHandler(this.btnUpdataDrink_Click);
            // 
            // btnDeleteDrink
            // 
            this.btnDeleteDrink.Location = new System.Drawing.Point(132, 36);
            this.btnDeleteDrink.Name = "btnDeleteDrink";
            this.btnDeleteDrink.Size = new System.Drawing.Size(96, 42);
            this.btnDeleteDrink.TabIndex = 18;
            this.btnDeleteDrink.Text = "מחיקת סוג שתיה";
            this.btnDeleteDrink.UseVisualStyleBackColor = true;
            this.btnDeleteDrink.Click += new System.EventHandler(this.btnDeleteDrink_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(179, 144);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(52, 20);
            this.txtPrice.TabIndex = 20;
            this.txtPrice.Text = "0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 171);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 417);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblNewDrink);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNewDrink);
            this.Controls.Add(this.btnDeleteDrink);
            this.Controls.Add(this.btnUpdataDrink);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddDrink);
            this.Controls.Add(this.cmbMilk);
            this.Controls.Add(this.cmbCocoa);
            this.Controls.Add(this.cmbCoffe);
            this.Controls.Add(this.cmbSugar);
            this.Controls.Add(this.dgvDrinksTabels);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrinksTabels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDrinksTabels;
        private System.Windows.Forms.ComboBox cmbSugar;
        private System.Windows.Forms.ComboBox cmbCoffe;
        private System.Windows.Forms.ComboBox cmbCocoa;
        private System.Windows.Forms.ComboBox cmbMilk;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNewDrink;
        private System.Windows.Forms.TextBox txtNewDrink;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdataDrink;
        private System.Windows.Forms.Button btnDeleteDrink;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cocoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn milk;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

