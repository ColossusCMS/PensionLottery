using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PensionLottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += TabPage1_Load;
            this.Text = Application.ProductName + " v " + Application.ProductVersion;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("누른 키 : {0}", e.KeyData);
            if (e.KeyData == Keys.D1)
                tabControl1.SelectTab(0);
            else if (e.KeyData == Keys.D2)
                tabControl1.SelectTab(1);
            else if (e.KeyData == Keys.Escape)
                this.Close();
        }

        private void TabPage1_Load(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.TopLevel = false;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(f3);
            tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
            f3.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f3.Show();

            Form2 f2 = new Form2(f3);
            f2.TopLevel = false;
            tabControl1.TabPages[tabControl1.TabPages.Count - 2].Controls.Add(f2);
            tabControl1.SelectedIndex = tabControl1.TabPages.Count - 2;
            f2.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f2.Show();
        }
    }
}
