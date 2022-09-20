namespace ValetService
{
    partial class Frm_CheckInOut
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
            this.gbFields = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.cbParkingSpot = new System.Windows.Forms.ComboBox();
            this.cbParkingLot = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCarPlateNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCarModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRoomNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCheckInId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFields
            // 
            this.gbFields.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbFields.Controls.Add(this.btnReset);
            this.gbFields.Controls.Add(this.btnEdit);
            this.gbFields.Controls.Add(this.btnCheckOut);
            this.gbFields.Controls.Add(this.btnCheckIn);
            this.gbFields.Controls.Add(this.rbManual);
            this.gbFields.Controls.Add(this.rbAuto);
            this.gbFields.Controls.Add(this.rbNo);
            this.gbFields.Controls.Add(this.rbYes);
            this.gbFields.Controls.Add(this.cbParkingSpot);
            this.gbFields.Controls.Add(this.cbParkingLot);
            this.gbFields.Controls.Add(this.label8);
            this.gbFields.Controls.Add(this.label7);
            this.gbFields.Controls.Add(this.label6);
            this.gbFields.Controls.Add(this.tbCarPlateNo);
            this.gbFields.Controls.Add(this.label5);
            this.gbFields.Controls.Add(this.tbCarModel);
            this.gbFields.Controls.Add(this.label4);
            this.gbFields.Controls.Add(this.label3);
            this.gbFields.Controls.Add(this.tbRoomNo);
            this.gbFields.Controls.Add(this.label2);
            this.gbFields.Controls.Add(this.tbCheckInId);
            this.gbFields.Controls.Add(this.label1);
            this.gbFields.Location = new System.Drawing.Point(12, 12);
            this.gbFields.Name = "gbFields";
            this.gbFields.Size = new System.Drawing.Size(1072, 296);
            this.gbFields.TabIndex = 0;
            this.gbFields.TabStop = false;
            this.gbFields.Text = "Check In / Out";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(780, 207);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(222, 35);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(780, 148);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(222, 35);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(780, 94);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(222, 35);
            this.btnCheckOut.TabIndex = 20;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(780, 40);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(222, 35);
            this.btnCheckIn.TabIndex = 19;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(599, 92);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(72, 20);
            this.rbManual.TabIndex = 18;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(515, 94);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(55, 20);
            this.rbAuto.TabIndex = 17;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Auto";
            this.rbAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAuto.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(254, 87);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(46, 20);
            this.rbNo.TabIndex = 16;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(170, 89);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(52, 20);
            this.rbYes.TabIndex = 15;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // cbParkingSpot
            // 
            this.cbParkingSpot.FormattingEnabled = true;
            this.cbParkingSpot.Location = new System.Drawing.Point(515, 189);
            this.cbParkingSpot.Name = "cbParkingSpot";
            this.cbParkingSpot.Size = new System.Drawing.Size(136, 24);
            this.cbParkingSpot.TabIndex = 14;
            // 
            // cbParkingLot
            // 
            this.cbParkingLot.FormattingEnabled = true;
            this.cbParkingLot.Location = new System.Drawing.Point(515, 136);
            this.cbParkingLot.Name = "cbParkingLot";
            this.cbParkingLot.Size = new System.Drawing.Size(136, 24);
            this.cbParkingLot.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Parking Spot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Parking Lot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Transmission\r\nType";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCarPlateNo
            // 
            this.tbCarPlateNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCarPlateNo.Location = new System.Drawing.Point(515, 41);
            this.tbCarPlateNo.Name = "tbCarPlateNo";
            this.tbCarPlateNo.Size = new System.Drawing.Size(136, 22);
            this.tbCarPlateNo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Car Plate No.";
            // 
            // tbCarModel
            // 
            this.tbCarModel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCarModel.Location = new System.Drawing.Point(170, 192);
            this.tbCarModel.Name = "tbCarModel";
            this.tbCarModel.Size = new System.Drawing.Size(136, 22);
            this.tbCarModel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Car Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Self Park";
            // 
            // tbRoomNo
            // 
            this.tbRoomNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbRoomNo.Location = new System.Drawing.Point(170, 133);
            this.tbRoomNo.Name = "tbRoomNo";
            this.tbRoomNo.Size = new System.Drawing.Size(136, 22);
            this.tbRoomNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room No.";
            // 
            // tbCheckInId
            // 
            this.tbCheckInId.BackColor = System.Drawing.SystemColors.Info;
            this.tbCheckInId.Location = new System.Drawing.Point(170, 44);
            this.tbCheckInId.Name = "tbCheckInId";
            this.tbCheckInId.Size = new System.Drawing.Size(136, 22);
            this.tbCheckInId.TabIndex = 1;
            this.tbCheckInId.TextChanged += new System.EventHandler(this.tbCheckInId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check-In Id";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 314);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1072, 284);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Check-In Id";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Self Park";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Room No.";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Car Model";
            this.columnHeader4.Width = 102;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Car Plate No.";
            this.columnHeader5.Width = 123;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Transmission Type";
            this.columnHeader6.Width = 152;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Parking Lot";
            this.columnHeader7.Width = 98;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Parking Spot";
            this.columnHeader8.Width = 143;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Check-In";
            this.columnHeader9.Width = 94;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Check-Out";
            this.columnHeader10.Width = 111;
            // 
            // Frm_CheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1096, 610);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gbFields);
            this.MaximizeBox = false;
            this.Name = "Frm_CheckInOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Best Western Plus Valet Service";
            this.gbFields.ResumeLayout(false);
            this.gbFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFields;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCarPlateNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCarModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRoomNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCheckInId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.ComboBox cbParkingSpot;
        private System.Windows.Forms.ComboBox cbParkingLot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}

