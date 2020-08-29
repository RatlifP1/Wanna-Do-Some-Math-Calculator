using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3DMathApp_RatliffPaul07292020
{
    public partial class CloseingMessage : Form
    {
        public CloseingMessage()
        {
            InitializeComponent();
        }

        private void cexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
