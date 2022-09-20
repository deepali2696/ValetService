namespace ValetService
{
    partial class Frm_Parking
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
            this.label2_ParkingLot = new System.Windows.Forms.Label();
            this.label3_ParkingSpot = new System.Windows.Forms.Label();
            this.comboBox1_ParkingLot = new System.Windows.Forms.ComboBox();
            this.textBox1_ParkingSpot = new System.Windows.Forms.TextBox();
            this.radioButton1_ParkingLot = new System.Windows.Forms.RadioButton();
            this.radioButton2_ParkingSpot = new System.Windows.Forms.RadioButton();
            this.button1_Add = new System.Windows.Forms.Button();
            this.button2_Deactivate = new System.Windows.Forms.Button();
            this.button3_Remove = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parking Spot Access";
            // 
            // label2_ParkingLot
            // 
            this.label2_ParkingLot.AutoSize = true;
            this.label2_ParkingLot.Location = new System.Drawing.Point(384, 133);
            this.label2_ParkingLot.Name = "label2_ParkingLot";
            this.label2_ParkingLot.Size = new System.Drawing.Size(74, 16);
            this.label2_ParkingLot.TabIndex = 1;
            this.label2_ParkingLot.Text = "Parking Lot";
            // 
            // label3_ParkingSpot
            // 
            this.label3_ParkingSpot.AutoSize = true;
            this.label3_ParkingSpot.Location = new System.Drawing.Point(384, 185);
            this.label3_ParkingSpot.Name = "label3_ParkingSpot";
            this.label3_ParkingSpot.Size = new System.Drawing.Size(84, 16);
            this.label3_ParkingSpot.TabIndex = 2;
            this.label3_ParkingSpot.Text = "Parking Spot";
            // 
            // comboBox1_ParkingLot
            // 
            this.comboBox1_ParkingLot.FormattingEnabled = true;
            this.comboBox1_ParkingLot.Location = new System.Drawing.Point(492, 130);
            this.comboBox1_ParkingLot.Name = "comboBox1_ParkingLot";
            this.comboBox1_ParkingLot.Size = new System.Drawing.Size(121, 24);
            this.comboBox1_ParkingLot.TabIndex = 3;
            this.comboBox1_ParkingLot.SelectedIndexChanged += new System.EventHandler(this.comboBox1_ParkingLot_SelectedIndexChanged);
            // 
            // textBox1_ParkingSpot
            // 
            this.textBox1_ParkingSpot.Location = new System.Drawing.Point(492, 185);
            this.textBox1_ParkingSpot.Name = "textBox1_ParkingSpot";
            this.textBox1_ParkingSpot.Size = new System.Drawing.Size(121, 22);
            this.textBox1_ParkingSpot.TabIndex = 4;
            // 
            // radioButton1_ParkingLot
            // 
            this.radioButton1_ParkingLot.AutoSize = true;
            this.radioButton1_ParkingLot.Location = new System.Drawing.Point(378, 251);
            this.radioButton1_ParkingLot.Name = "radioButton1_ParkingLot";
            this.radioButton1_ParkingLot.Size = new System.Drawing.Size(95, 20);
            this.radioButton1_ParkingLot.TabIndex = 5;
            this.radioButton1_ParkingLot.TabStop = true;
            this.radioButton1_ParkingLot.Text = "Parking Lot";
            this.radioButton1_ParkingLot.UseVisualStyleBackColor = true;
            this.radioButton1_ParkingLot.CheckedChanged += new System.EventHandler(this.radioButton1_ParkingLot_CheckedChanged);
            // 
            // radioButton2_ParkingSpot
            // 
            this.radioButton2_ParkingSpot.AutoSize = true;
            this.radioButton2_ParkingSpot.Location = new System.Drawing.Point(552, 251);
            this.radioButton2_ParkingSpot.Name = "radioButton2_ParkingSpot";
            this.radioButton2_ParkingSpot.Size = new System.Drawing.Size(105, 20);
            this.radioButton2_ParkingSpot.TabIndex = 6;
            this.radioButton2_ParkingSpot.TabStop = true;
            this.radioButton2_ParkingSpot.Text = "Parking Spot";
            this.radioButton2_ParkingSpot.UseVisualStyleBackColor = true;
            this.radioButton2_ParkingSpot.CheckedChanged += new System.EventHandler(this.radioButton2_ParkingSpot_CheckedChanged);
            // 
            // button1_Add
            // 
            this.button1_Add.Location = new System.Drawing.Point(290, 313);
            this.button1_Add.Name = "button1_Add";
            this.button1_Add.Size = new System.Drawing.Size(120, 43);
            this.button1_Add.TabIndex = 7;
            this.button1_Add.Text = "Add";
            this.button1_Add.UseVisualStyleBackColor = true;
            this.button1_Add.Click += new System.EventHandler(this.button1_Add_Click);
            // 
            // button2_Deactivate
            // 
            this.button2_Deactivate.Location = new System.Drawing.Point(467, 313);
            this.button2_Deactivate.Name = "button2_Deactivate";
            this.button2_Deactivate.Size = new System.Drawing.Size(120, 43);
            this.button2_Deactivate.TabIndex = 8;
            this.button2_Deactivate.Text = "Deactivate";
            this.button2_Deactivate.UseVisualStyleBackColor = true;
            this.button2_Deactivate.Click += new System.EventHandler(this.button2_Deactivate_Click);
            // 
            // button3_Remove
            // 
            this.button3_Remove.Location = new System.Drawing.Point(642, 313);
            this.button3_Remove.Name = "button3_Remove";
            this.button3_Remove.Size = new System.Drawing.Size(120, 43);
            this.button3_Remove.TabIndex = 9;
            this.button3_Remove.Text = "Remove";
            this.button3_Remove.UseVisualStyleBackColor = true;
            this.button3_Remove.Click += new System.EventHandler(this.button3_Remove_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, 402);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1043, 279);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Parking Lot";
            this.columnHeader1.Width = 310;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Parking Spot";
            this.columnHeader2.Width = 310;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 310;
            // 
            // Frm_Parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 679);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3_Remove);
            this.Controls.Add(this.button2_Deactivate);
            this.Controls.Add(this.button1_Add);
            this.Controls.Add(this.radioButton2_ParkingSpot);
            this.Controls.Add(this.radioButton1_ParkingLot);
            this.Controls.Add(this.textBox1_ParkingSpot);
            this.Controls.Add(this.comboBox1_ParkingLot);
            this.Controls.Add(this.label3_ParkingSpot);
            this.Controls.Add(this.label2_ParkingLot);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Parking";
            this.Text = "Frm_Parking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2_ParkingLot;
        private System.Windows.Forms.Label label3_ParkingSpot;
        private System.Windows.Forms.ComboBox comboBox1_ParkingLot;
        private System.Windows.Forms.TextBox textBox1_ParkingSpot;
        private System.Windows.Forms.RadioButton radioButton1_ParkingLot;
        private System.Windows.Forms.RadioButton radioButton2_ParkingSpot;
        private System.Windows.Forms.Button button1_Add;
        private System.Windows.Forms.Button button2_Deactivate;
        private System.Windows.Forms.Button button3_Remove;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}