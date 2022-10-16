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
    public partial class B2 : Form
    {
        public B2()
        {
            InitializeComponent();
            lblSum.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Bạn có muốn thoát?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rsl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                lbOutput.Items.Add(txtInput.Text);
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(ctr, "Vui lòng chỉ nhập số!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            lblSum.ResetText();
            var tmpList = new List<int>();
            lbOutput.Items.OfType<string>().ToList().ForEach(x => tmpList.Add(int.Parse(x)));
            lblSum.Text += "Tổng các phần tử trong list: " + tmpList.Sum();
        }

        private void btnDeleteHeadNTail_Click(object sender, EventArgs e)
        {
            if (lbOutput.Items.Count > 2)
            {
                lbOutput.Items.RemoveAt(0);
                lbOutput.Items.RemoveAt(lbOutput.Items.Count - 1);
            }            
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            lbOutput.ClearSelected();
            if (lbOutput.SelectedIndex != -1)
            {
                //lbOutput.Items.RemoveAt(lbOutput.SelectedIndex);
                var tmpList = lbOutput.SelectedItems.OfType<string>().ToList();
                tmpList.ForEach(x => {
                    lbOutput.Items.Remove(x);
                });
            }
        }

        private void btnIncreaseAll2Unit_Click(object sender, EventArgs e)
        {
            List<string> tmp = new List<string>();
            lbOutput.Items.OfType<string>().ToList().ForEach(x => {
                tmp.Add((int.Parse(x) + 2).ToString());
            });
            lbOutput.Items.Clear();
            tmp.ForEach(x => lbOutput.Items.Add(x));
        }

        private void btnPowSelf_Click(object sender, EventArgs e)
        {
            List<string> tmp = new List<string>();
            lbOutput.Items.OfType<string>().ToList().ForEach(x => {
                tmp.Add((Math.Pow(int.Parse(x), 2)).ToString());
            });
            lbOutput.Items.Clear();
            tmp.ForEach(x => lbOutput.Items.Add(x));
        }

        private void btnPickEvens_Click(object sender, EventArgs e)
        {
            lbOutput.ClearSelected();
            int pos = 0;
            var tmpList = lbOutput.Items.OfType<string>().ToList();
            tmpList.ForEach(x => {
                if (int.Parse(x) % 2 == 0)
                {
                    lbOutput.SelectedIndex = pos;
                }
                pos++;
            });
        }

        private void btnPickOdds_Click(object sender, EventArgs e)
        {
            lbOutput.ClearSelected();
            int pos = 0;
            var tmpList = lbOutput.Items.OfType<string>().ToList();
            tmpList.ForEach(x => {
                if (int.Parse(x) % 2 != 0)
                {
                    lbOutput.SelectedIndex = pos;
                }
                pos++;
            });
        }
    }
}
