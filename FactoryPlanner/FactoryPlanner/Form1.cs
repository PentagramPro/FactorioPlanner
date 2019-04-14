using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLua;

namespace FactoryPlanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            string source = File.ReadAllText("C:\\Users\\maxon\\Downloads\\production plan.txt");

            FactoryPlan plan = new FactoryPlan(source);
            mTxtInfo.Text = plan.ToString();

            
            
            
        }
    }
}
