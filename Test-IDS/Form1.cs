using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_IDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnS_Click(object sender, EventArgs e)
        {
            int x = Datashow.Rows.Add();
            //colocamos info
            Datashow.Rows[x].Cells[0].Value = txtID.Text;
            Datashow.Rows[x].Cells[1].Value = txt_lnac.Text;
            Datashow.Rows[x].Cells[2].Value = txt_fnac.Text;
            Datashow.Rows[x].Cells[3].Value = txt_nac.Text;
            Datashow.Rows[x].Cells[4].Value = lst_sx.Text;
            Datashow.Rows[x].Cells[5].Value = lst_s.Text;
            Datashow.Rows[x].Cells[6].Value = lst_ec.Text;
            Datashow.Rows[x].Cells[7].Value = txt_ocu.Text;
            Datashow.Rows[x].Cells[8].Value = txt_fde.Text;
        }
    }
}