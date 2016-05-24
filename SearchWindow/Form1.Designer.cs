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
            this.listResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CMBSearch1 = new System.Windows.Forms.ComboBox();
            this.CMBSearch2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(205, 12);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 0;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.Location = new System.Drawing.Point(16, 75);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(250, 186);
            this.listResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Depart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arrival";
            // 
            // CMBSearch1
            // 
            this.CMBSearch1.FormattingEnabled = true;
            this.CMBSearch1.Location = new System.Drawing.Point(78, 14);
            this.CMBSearch1.Name = "CMBSearch1";
            this.CMBSearch1.Size = new System.Drawing.Size(121, 21);
            this.CMBSearch1.TabIndex = 6;
            this.CMBSearch1.TextChanged += new System.EventHandler(this.Helper);
            // 
            // CMBSearch2
            // 
            this.CMBSearch2.FormattingEnabled = true;
            this.CMBSearch2.Location = new System.Drawing.Point(79, 43);
            this.CMBSearch2.Name = "CMBSearch2";
            this.CMBSearch2.Size = new System.Drawing.Size(121, 21);
            this.CMBSearch2.TabIndex = 7;
            this.CMBSearch2.TextChanged += new System.EventHandler(this.Helper);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.CMBSearch2);
            this.Controls.Add(this.CMBSearch1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.cmdSearch);
            this.Name = "Form1";
            this.Text = "Search Connections";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CMBSearch1;
        private System.Windows.Forms.ComboBox CMBSearch2;
    }
}

