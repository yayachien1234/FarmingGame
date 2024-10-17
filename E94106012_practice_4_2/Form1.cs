using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace E94106012_practice_4_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private int money = 100;
        private int seeds = 5;
        private int fertilizers = 5;
        private int fruits = 0;
        private string selected;
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // ��ʼ��Label�@ʾ��ʼ����
            Labelmoney.Text = $"���X: {money}Ԫ";
            own1.Text = $"�N��: {seeds}��";
            own2.Text = $"����: {fertilizers}��";
            own3.Text = $"����: {fruits}��";

            farm = new Button[12];
            for (int i = 0; i < 12; i++)
            {
                farm[i] = new Button();
                farm[i].ImageList = imageList1;
                farm[i].SetBounds(20 + 150 * (i % 3), 20 + 150 * (i / 3), 150, 150);
                farm[i].ImageIndex = 0;
                farm[i].Tag = i * 100;  // ��һ�����֞�index���ڶ������֞靲ˮ�����������֞�ʩ�ʣ�0��δ��ˮorʩ��
                farm[i].BackgroundImageLayout = ImageLayout.Stretch;
                farm[i].Click += new EventHandler(farm_Click);
                tabPage1.Controls.Add(farm[i]);
            }
        }
        private void farm_Click(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int index = (int)btn.Tag / 100;

            switch (selected)
            {
                case "wateringCan":
                    if (farm[index].ImageIndex == 1 || farm[index].ImageIndex == 2)
                    {
                        switch ((int)farm[index].Tag % 100)
                        {
                            case 00:
                                farm[index].Tag = index * 100 + 10;
                                break;

                            case 01:
                                farm[index].ImageIndex += 1;
                                farm[index].Tag = index * 100;
                                break;

                            default:
                                break;
                        }
                    }
                    break;

                case "seed":
                    if (farm[index].ImageIndex == 0 && seeds > 0)
                    {
                        seeds--;
                        farm[index].ImageIndex = 1;
                    }
                    else if (seeds == 0)
                    {
                        MessageBox.Show("�N��������", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "fertilizer":
                    if ((farm[index].ImageIndex == 1 || farm[index].ImageIndex == 2) && fertilizers > 0)
                    {
                        switch ((int)farm[index].Tag % 100)
                        {
                            case 00:
                                fertilizers--;
                                farm[index].Tag = index * 100 + 1;
                                break;

                            case 10:
                                fertilizers--;
                                farm[index].ImageIndex += 1;
                                farm[index].Tag = index * 100;
                                break;

                            default:
                                break;
                        }
                    }
                    else if (fertilizers == 0)
                    {
                        MessageBox.Show("����������", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "sickle":
                    if (farm[index].ImageIndex == 3)
                    {
                        fruits++;
                        farm[index].ImageIndex = 0;
                    }
                    break;

                default:
                    break;
            }
            Labelmoney.Text = $"���X: {money}Ԫ";
            own1.Text = $"�N��: {seeds}��";
            own2.Text = $"����: {fertilizers}��";
            own3.Text = $"����: {fruits}��";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selected = "wateringCan";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selected = "seed";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            selected = "fertilizer";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            selected = "sickle";
        }
        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Labelmoney_Click(object sender, EventArgs e)
        {

        }

        private void seed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fertilizer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fruit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void sellsold_Click(object sender, EventArgs e)
        {
            int buyCost = 10;
            int sellPrice = 40;

            // �u����
            if (fruit.Checked)
            {
                if (fruits > 0)
                {
                    money += sellPrice;
                    fruits--;
                }
            }

            // ُ�I�N��
            if (seed.Checked)
            {
                if (money >= buyCost)
                {
                    if (money> 0)
                    {
                    money -= buyCost;
                    seeds++;
                    }
                   
                }
            }

            // ُ�I����
            if (fertilizer.Checked)
            {
                if (money >= buyCost)
                {
                    if (money> 0)
                    {
                    money -= buyCost;
                    fertilizers++;
                    }

                }
            }

            // ���� Label �ă���
            Labelmoney.Text = $"���X: {money}Ԫ";
            own1.Text = $"�N��: {seeds}��";
            own2.Text = $"����: {fertilizers}��";
            own3.Text = $"����: {fruits}��";
        }

    }
}