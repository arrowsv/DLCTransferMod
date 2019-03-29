using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLCTransferMod
{
    public partial class progress : Form
    {
        public progress()
        {
            InitializeComponent();


        }

        public void ChangeLabel(string s)
        {
            statusText.Text = s;
        }

        public void ChangeProgress(int s)
        {
            installProgress.Value = s;
        }
    }
}
