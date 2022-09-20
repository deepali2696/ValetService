namespace ValetService
{
    partial class Frm_CarInOut
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
            this.ComboSearch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCarIn = new System.Windows.Forms.Button();
            this.buttonCarOut = new System.Windows.Forms.Button();
            this.listViewCarInOut = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temporary Check In/Out";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search By";
            // 
            // ComboSearch
            // 
            this.ComboSearch.FormattingEnabled = true;
            this.ComboSearch.Items.AddRange(new object[] {
            "Slip Id",
            "Room No"});
            this.ComboSearch.Location = new System.Drawing.Point(126, 58);
            this.ComboSearch.Name = "ComboSearch";
            this.ComboSearch.Size = new System.Drawing.Size(121, 24);
            this.ComboSearch.TabIndex = 2;
            this.ComboSearch.SelectedIndexChanged += new System.EventHandler(this.ComboSearch_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Details";
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Location = new System.Drawing.Point(126, 102);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.Size = new System.Drawing.Size(121, 22);
            this.textBoxDetails.TabIndex = 4;
            this.textBoxDetails.TextChanged += new System.EventHandler(this.textBoxDetails_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(40, 145);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(80, 34);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(150, 145);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 34);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonCarIn
            // 
            this.buttonCarIn.Location = new System.Drawing.Point(335, 94);
            this.buttonCarIn.Name = "buttonCarIn";
            this.buttonCarIn.Size = new System.Drawing.Size(97, 38);
            this.buttonCarIn.TabIndex = 7;
            this.buttonCarIn.Text = "Car In";
            this.buttonCarIn.UseVisualStyleBackColor = true;
            this.buttonCarIn.Click += new System.EventHandler(this.buttonCarIn_Click);
            // 
            // buttonCarOut
            // 
            this.buttonCarOut.Location = new System.Drawing.Point(335, 42);
            this.buttonCarOut.Name = "buttonCarOut";
            this.buttonCarOut.Size = new System.Drawing.Size(96, 40);
            this.buttonCarOut.TabIndex = 8;
            this.buttonCarOut.Text = "Car Out";
            this.buttonCarOut.UseVisualStyleBackColor = true;
            this.buttonCarOut.Click += new System.EventHandler(this.buttonCarOut_Click);
            // 
            // listViewCarInOut
            // 
            this.listViewCarInOut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader9,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader10,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewCarInOut.FullRowSelect = true;
            this.listViewCarInOut.HideSelection = false;
            this.listViewCarInOut.Location = new System.Drawing.Point(26, 210);
            this.listViewCarInOut.Name = "listViewCarInOut";
            this.listViewCarInOut.Size = new System.Drawing.Size(733, 228);
            this.listViewCarInOut.TabIndex = 9;
            this.listViewCarInOut.UseCompatibleStateImageBehavior = false;
            this.listViewCarInOut.View = System.Windows.Forms.View.Details;
            this.listViewCarInOut.SelectedIndexChanged += new System.EventHandler(this.listViewCarInOut_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CheckIn Id";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Room No";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Car Model";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Parking Lot";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CheckOut Date";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Car In";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Car Out";
            this.columnHeader8.Width = 70;
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(663, 21);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(96, 35);
            this.buttonHome.TabIndex = 10;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(335, 145);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(98, 40);
            this.buttonList.TabIndex = 11;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 1;
            this.columnHeader9.Text = "Slip Id";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Parking Spot";
            // 
            // CarInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.listViewCarInOut);
            this.Controls.Add(this.buttonCarOut);
            this.Controls.Add(this.buttonCarIn);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CarInOut";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCarIn;
        private System.Windows.Forms.Button buttonCarOut;
        private System.Windows.Forms.ListView listViewCarInOut;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}

