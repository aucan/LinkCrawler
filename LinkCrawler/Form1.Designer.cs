namespace LinkCrawler
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
            this.btnGoogle = new System.Windows.Forms.Button();
            this.btnBing = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.listResults = new System.Windows.Forms.ListBox();
            this.btnYahoo = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.listLinks = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listLinksRoot = new System.Windows.Forms.ListBox();
            this.btnRecursive = new System.Windows.Forms.Button();
            this.nuRecCount = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nuRecCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoogle
            // 
            this.btnGoogle.Location = new System.Drawing.Point(139, 14);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(75, 23);
            this.btnGoogle.TabIndex = 0;
            this.btnGoogle.Text = "Google";
            this.btnGoogle.UseVisualStyleBackColor = true;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // btnBing
            // 
            this.btnBing.Location = new System.Drawing.Point(220, 14);
            this.btnBing.Name = "btnBing";
            this.btnBing.Size = new System.Drawing.Size(75, 23);
            this.btnBing.TabIndex = 2;
            this.btnBing.Text = "Bing";
            this.btnBing.UseVisualStyleBackColor = true;
            this.btnBing.Click += new System.EventHandler(this.btnBing_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(12, 16);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(121, 20);
            this.txtQuery.TabIndex = 3;
            this.txtQuery.Text = "web crawler";
            // 
            // listResults
            // 
            this.listResults.DisplayMember = "link";
            this.listResults.FormattingEnabled = true;
            this.listResults.Location = new System.Drawing.Point(12, 52);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(445, 485);
            this.listResults.TabIndex = 4;
            // 
            // btnYahoo
            // 
            this.btnYahoo.Location = new System.Drawing.Point(301, 14);
            this.btnYahoo.Name = "btnYahoo";
            this.btnYahoo.Size = new System.Drawing.Size(75, 23);
            this.btnYahoo.TabIndex = 5;
            this.btnYahoo.Text = "Yahoo";
            this.btnYahoo.UseVisualStyleBackColor = true;
            this.btnYahoo.Click += new System.EventHandler(this.btnYahoo_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(382, 14);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 6;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // listLinks
            // 
            this.listLinks.DisplayMember = "link";
            this.listLinks.FormattingEnabled = true;
            this.listLinks.Location = new System.Drawing.Point(506, 52);
            this.listLinks.Name = "listLinks";
            this.listLinks.Size = new System.Drawing.Size(421, 238);
            this.listLinks.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listLinksRoot
            // 
            this.listLinksRoot.DisplayMember = "root";
            this.listLinksRoot.FormattingEnabled = true;
            this.listLinksRoot.Location = new System.Drawing.Point(505, 296);
            this.listLinksRoot.Name = "listLinksRoot";
            this.listLinksRoot.Size = new System.Drawing.Size(421, 238);
            this.listLinksRoot.TabIndex = 10;
            // 
            // btnRecursive
            // 
            this.btnRecursive.Location = new System.Drawing.Point(462, 14);
            this.btnRecursive.Name = "btnRecursive";
            this.btnRecursive.Size = new System.Drawing.Size(75, 23);
            this.btnRecursive.TabIndex = 11;
            this.btnRecursive.Text = "Recursive";
            this.btnRecursive.UseVisualStyleBackColor = true;
            this.btnRecursive.Click += new System.EventHandler(this.btnRecursive_Click);
            // 
            // nuRecCount
            // 
            this.nuRecCount.Location = new System.Drawing.Point(543, 15);
            this.nuRecCount.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nuRecCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuRecCount.Name = "nuRecCount";
            this.nuRecCount.Size = new System.Drawing.Size(31, 20);
            this.nuRecCount.TabIndex = 13;
            this.nuRecCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 554);
            this.Controls.Add(this.nuRecCount);
            this.Controls.Add(this.btnRecursive);
            this.Controls.Add(this.listLinksRoot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listLinks);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnYahoo);
            this.Controls.Add(this.listResults);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.btnBing);
            this.Controls.Add(this.btnGoogle);
            this.Name = "Form1";
            this.Text = "Link Crawler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuRecCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.Button btnBing;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ListBox listResults;
        private System.Windows.Forms.Button btnYahoo;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ListBox listLinks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listLinksRoot;
        private System.Windows.Forms.Button btnRecursive;
        private System.Windows.Forms.NumericUpDown nuRecCount;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

