using _2001202045_VuNgoDat_SM24_Buoi6.Core.B1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001202045_VuNgoDat_SM24_Buoi6
{
    public partial class B1 : Form
    {
        ZDictionary dic;
        public B1()
        {
            InitializeComponent();
            dic = new ZDictionary();
            rtxtVN.ReadOnly = true;
            rtxtEN.ReadOnly = true;
        }

        private void B1_Load(object sender, EventArgs e)
        {
            cbbEN.Items.Clear();
            dic.Load();
            var tmpList = dic.dics.ToList();
            tmpList.ForEach(x => {
                cbbEN.Items.Add(x.Value.Trim());
                cbbVN.Items.Add(x.Key.Trim());
            });
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Bạn có muốn thoát?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rsl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbbEN_TextChanged(object sender, EventArgs e)
        {

            rtxtVN.ResetText();
            var tmpList = dic.dics.ToList().Where(x => x.Value.Equals(cbbEN.Text)).ToList();
            if (!string.IsNullOrEmpty(cbbEN.Text) && tmpList.Count != 0)
            {
                tmpList.ForEach(x => rtxtVN.AppendText(x.Key + "\n"));                
            }
        }
        private void cbbVN_TextChanged(object sender, EventArgs e)
        {

            rtxtEN.ResetText();
            var tmpList = dic.dics.ToList().Where(x => x.Key.Equals(cbbVN.Text)).ToList();
            if (!string.IsNullOrEmpty(cbbVN.Text) && tmpList.Count != 0)
            {
                tmpList.ForEach(x => rtxtEN.AppendText(x.Value + "\n"));
            }
        }
    }
}
