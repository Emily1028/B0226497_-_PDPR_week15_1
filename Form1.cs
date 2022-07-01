using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week15_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string str = "";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                str += $"{checkedListBox1.CheckedItems[i]} ";
            }
            lblRESULT.Text += $"\n選取{comboBox1.Text}類別：{str}";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    List<string> romantic = new List<string>();
                    checkedListBox1.Items.Clear();
                    romantic.Add("樂來越愛你");
                    checkedListBox1.Items.Add(romantic[0]);
                    romantic.Add("手札情緣");
                    checkedListBox1.Items.Add(romantic[1]);
                    romantic.Add("婚姻故事");
                    checkedListBox1.Items.Add(romantic[2]);
                    romantic.Add("真愛挑日子");
                    checkedListBox1.Items.Add(romantic[3]);
                    romantic.Add("王牌冤家");
                    checkedListBox1.Items.Add(romantic[4]);
                    break;
                case 1:
                    List<string> suspense = new List<string>();
                    checkedListBox1.Items.Clear();
                    for (int i = 0; i < 5; i++)
                    {
                        suspense.Add("佈局");
                        suspense.Add("幻象");
                        suspense.Add("神秘沼澤");
                        suspense.Add("屍物招領");
                        suspense.Add("凌刑密密縫");
                        checkedListBox1.Items.Add(suspense[i]);
                    }
                    break;
                case 2:
                    List<string> animated = new List<string>();
                    checkedListBox1.Items.Clear();
                    for (int i = 0; i < 5; i++)
                    {
                        animated.Add("風起");
                        animated.Add("龍貓");
                        animated.Add("神隱少女");
                        animated.Add("龍與雀斑公主");
                        animated.Add("想哭的我戴上貓的面具");
                        checkedListBox1.Items.Add(animated[i]);
                    }
                    break;
            }
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
