using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LinkCrawler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LinkCollector lc = new LinkCollector();

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            try
            {
                listResults.DataSource = lc.FindResultsGoogle(txtQuery.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        private void btnBing_Click(object sender, EventArgs e)
        {
            try
            {
                listResults.DataSource = lc.FindResultsBing(txtQuery.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        private void btnYahoo_Click(object sender, EventArgs e)
        {
            try
            {
                listResults.DataSource = lc.FindResultsYahoo(txtQuery.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                listResults.DataSource = lc.FindAllResults(txtQuery.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var linklist = lc.GetLinksFromAPage(((LinkCollector.Link)listResults.SelectedItem).link);
                listLinks.DataSource = linklist;
                listLinksRoot.DataSource = linklist.GroupBy(x => x.root).Select(y => y.First()).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listResults.DisplayMember = "link";
            listLinks.DisplayMember = "link";
            listLinksRoot.DisplayMember = "root";
        }

        private void btnRecursive_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var list = lc.GetRecursiveLinks(txtQuery.Text, (int)nuRecCount.Value);
                File.AppendAllLines(saveFileDialog1.FileName, list);
            }

        }
    }
}
