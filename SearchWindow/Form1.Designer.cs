namespace SearchWindow
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
            this.cmdSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CMBSearch1 = new System.Windows.Forms.ComboBox();
            this.CMBSearch2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listResult = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Depart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FromPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.To = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Arrive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdstationboard = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rbDepart = new System.Windows.Forms.RadioButton();
            this.rbArrival = new System.Windows.Forms.RadioButton();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdMap1 = new System.Windows.Forms.Button();
            this.cmdMap2 = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(275, 91);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(97, 23);
            this.cmdSearch.TabIndex = 2;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Depart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arrival";
            // 
            // CMBSearch1
            // 
            this.CMBSearch1.FormattingEnabled = true;
            this.CMBSearch1.Location = new System.Drawing.Point(78, 30);
            this.CMBSearch1.Name = "CMBSearch1";
            this.CMBSearch1.Size = new System.Drawing.Size(156, 21);
            this.CMBSearch1.TabIndex = 0;
            this.CMBSearch1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Helper);
            // 
            // CMBSearch2
            // 
            this.CMBSearch2.FormattingEnabled = true;
            this.CMBSearch2.Location = new System.Drawing.Point(79, 59);
            this.CMBSearch2.Name = "CMBSearch2";
            this.CMBSearch2.Size = new System.Drawing.Size(155, 21);
            this.CMBSearch2.TabIndex = 1;
            this.CMBSearch2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Helper);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Station";
            // 
            // listResult
            // 
            this.listResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.From,
            this.Depart,
            this.FromPlatform,
            this.To,
            this.Arrive,
            this.ToPlatform,
            this.Duration});
            this.listResult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listResult.Location = new System.Drawing.Point(12, 144);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(570, 97);
            this.listResult.TabIndex = 9;
            this.listResult.UseCompatibleStateImageBehavior = false;
            this.listResult.View = System.Windows.Forms.View.Details;
            // 
            // Number
            // 
            this.Number.Text = "";
            this.Number.Width = 30;
            // 
            // From
            // 
            this.From.Text = "From";
            this.From.Width = 100;
            // 
            // Depart
            // 
            this.Depart.Text = "Depart";
            this.Depart.Width = 70;
            // 
            // FromPlatform
            // 
            this.FromPlatform.Text = "Platform";
            // 
            // To
            // 
            this.To.Text = "To";
            this.To.Width = 100;
            // 
            // Arrive
            // 
            this.Arrive.Text = "Arrive";
            this.Arrive.Width = 70;
            // 
            // ToPlatform
            // 
            this.ToPlatform.Text = "Platform";
            // 
            // Duration
            // 
            this.Duration.Text = "Duration";
            this.Duration.Width = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "From:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "To:";
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(480, 91);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(97, 23);
            this.cmdClear.TabIndex = 8;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdstationboard
            // 
            this.cmdstationboard.Location = new System.Drawing.Point(378, 91);
            this.cmdstationboard.Name = "cmdstationboard";
            this.cmdstationboard.Size = new System.Drawing.Size(96, 23);
            this.cmdstationboard.TabIndex = 3;
            this.cmdstationboard.Text = "Stationboard";
            this.cmdstationboard.UseVisualStyleBackColor = true;
            this.cmdstationboard.Click += new System.EventHandler(this.cmdstatonboard_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(488, 50);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(87, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // rbDepart
            // 
            this.rbDepart.AutoSize = true;
            this.rbDepart.Checked = true;
            this.rbDepart.Location = new System.Drawing.Point(294, 37);
            this.rbDepart.Name = "rbDepart";
            this.rbDepart.Size = new System.Drawing.Size(57, 17);
            this.rbDepart.TabIndex = 4;
            this.rbDepart.TabStop = true;
            this.rbDepart.Text = "Depart";
            this.rbDepart.UseVisualStyleBackColor = true;
            // 
            // rbArrival
            // 
            this.rbArrival.AutoSize = true;
            this.rbArrival.Location = new System.Drawing.Point(294, 64);
            this.rbArrival.Name = "rbArrival";
            this.rbArrival.Size = new System.Drawing.Size(54, 17);
            this.rbArrival.TabIndex = 5;
            this.rbArrival.Text = "Arrival";
            this.rbArrival.UseVisualStyleBackColor = true;
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = "HH:mm";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(412, 50);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(52, 20);
            this.TimePicker.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "at";
            // 
            // cmdMap1
            // 
            this.cmdMap1.Location = new System.Drawing.Point(240, 30);
            this.cmdMap1.Name = "cmdMap1";
            this.cmdMap1.Size = new System.Drawing.Size(40, 23);
            this.cmdMap1.TabIndex = 24;
            this.cmdMap1.Text = "Map";
            this.cmdMap1.UseVisualStyleBackColor = true;
            this.cmdMap1.Click += new System.EventHandler(this.cmdMap_Click);
            // 
            // cmdMap2
            // 
            this.cmdMap2.Location = new System.Drawing.Point(240, 60);
            this.cmdMap2.Name = "cmdMap2";
            this.cmdMap2.Size = new System.Drawing.Size(40, 23);
            this.cmdMap2.TabIndex = 25;
            this.cmdMap2.Text = "Map";
            this.cmdMap2.UseVisualStyleBackColor = true;
            this.cmdMap2.Click += new System.EventHandler(this.cmdMap_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(58, 121);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(35, 13);
            this.lblTo.TabIndex = 13;
            this.lblTo.Text = "label7";
            this.lblTo.Visible = false;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(58, 102);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(35, 13);
            this.lblFrom.TabIndex = 11;
            this.lblFrom.Text = "label5";
            this.lblFrom.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Time:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(211, 121);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 13);
            this.lblDate.TabIndex = 29;
            this.lblDate.Text = "label10";
            this.lblDate.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(211, 102);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 28;
            this.lblTime.Text = "label9";
            this.lblTime.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Find me on the Map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdMap2);
            this.Controls.Add(this.cmdMap1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.rbArrival);
            this.Controls.Add(this.rbDepart);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cmdstationboard);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CMBSearch2);
            this.Controls.Add(this.CMBSearch1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSearch);
            this.Name = "Form1";
            this.Text = "Search Connections";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CMBSearch1;
        private System.Windows.Forms.ComboBox CMBSearch2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listResult;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader Depart;
        private System.Windows.Forms.ColumnHeader Arrive;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdstationboard;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader To;
        private System.Windows.Forms.ColumnHeader FromPlatform;
        private System.Windows.Forms.ColumnHeader ToPlatform;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RadioButton rbDepart;
        private System.Windows.Forms.RadioButton rbArrival;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdMap1;
        private System.Windows.Forms.Button cmdMap2;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button button1;
    }
}

