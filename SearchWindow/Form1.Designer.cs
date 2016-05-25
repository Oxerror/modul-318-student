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
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.Depart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Arrive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(249, 30);
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
            this.CMBSearch1.TextChanged += new System.EventHandler(this.Helper);
            // 
            // CMBSearch2
            // 
            this.CMBSearch2.FormattingEnabled = true;
            this.CMBSearch2.Location = new System.Drawing.Point(79, 59);
            this.CMBSearch2.Name = "CMBSearch2";
            this.CMBSearch2.Size = new System.Drawing.Size(155, 21);
            this.CMBSearch2.TabIndex = 1;
            this.CMBSearch2.TextChanged += new System.EventHandler(this.Helper);
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
            this.Depart,
            this.Arrive,
            this.Duration});
            this.listResult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listResult.Location = new System.Drawing.Point(12, 163);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(334, 97);
            this.listResult.TabIndex = 9;
            this.listResult.UseCompatibleStateImageBehavior = false;
            this.listResult.View = System.Windows.Forms.View.Details;
            // 
            // Duration
            // 
            this.Duration.Text = "Duration";
            this.Duration.Width = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "From:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(58, 128);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(35, 13);
            this.lblFrom.TabIndex = 11;
            this.lblFrom.Text = "label5";
            this.lblFrom.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "To:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(58, 147);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(35, 13);
            this.lblTo.TabIndex = 13;
            this.lblTo.Text = "label7";
            this.lblTo.Visible = false;
            // 
            // Depart
            // 
            this.Depart.Text = "Depart";
            this.Depart.Width = 100;
            // 
            // Arrive
            // 
            this.Arrive.Text = "Arrive";
            this.Arrive.Width = 100;
            // 
            // Number
            // 
            this.Number.Text = "";
            this.Number.Width = 30;
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(249, 59);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(97, 23);
            this.cmdClear.TabIndex = 3;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 273);
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
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ColumnHeader Depart;
        private System.Windows.Forms.ColumnHeader Arrive;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.Button cmdClear;
    }
}

