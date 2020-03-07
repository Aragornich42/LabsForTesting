using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabsForTesting
{
    public partial class Testing : Form
    {
        private List<int> numbers = new List<int>();

        public Testing()
        {
            InitializeComponent();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            var elem = inputField.Text;
            int num;

            if (!int.TryParse(elem, out num))
            {
                CreateMessageBox("Вы ввели невалидное значение!");
            }
            else
            {
                if (numbers.Count == 10)
                {
                    CreateMessageBox("Слишком много значений в массиве для оперирования данными!");
                }
                else
                {
                    numbers.Add(num);
                    listView.Items.Add(num.ToString());
                }
            }

            inputField.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!maxRadioButton.Checked && !minRadioButton.Checked)
            {
                CreateMessageBox("Вы не выбрали, какой именно элемент хотите найти из введенных!");
            }
            else
            {
                if (listView.Items.Count == 0)
                {
                    CreateMessageBox("Вы не добавили ни один элемент!");
                }
                else
                {
                    var flag = maxRadioButton.Checked ?
                        WhatFind.Max :
                        WhatFind.Min;
                    var count = Common.CountLessThen5BinaryUnits(numbers, out var findedNums);
                    var maxOrMin = Common.GetMaxOrMin(findedNums, flag);

                    elemCountField.Enabled = true;
                    elemCountField.Text = count.ToString();

                    maxOrMinField.Enabled = true;
                    if (flag == WhatFind.Min)
                        maxOrMinLbl.Text = "Минимальный:";
                    if (maxOrMin != int.MaxValue)
                        maxOrMinField.Text = maxOrMin.ToString();
                    else
                        maxOrMinField.Text = "none";

                    restart.Enabled = true;
                }
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            listView.Clear();
            elemCountField.Enabled = false;
            elemCountField.Clear();
            maxOrMinField.Enabled = false;
            maxOrMinField.Clear();
            maxOrMinLbl.Text = "Максимальный:";
            numbers.Clear();
            restart.Enabled = false;
        }

        //КОММОНЫ

        private void CreateMessageBox(string text)
        {
            MessageBoxButtons btns = MessageBoxButtons.OK;
            MessageBoxDefaultButton defBtn = MessageBoxDefaultButton.Button1;
            string info = text;
            MessageBoxIcon icon = MessageBoxIcon.Error;

            MessageBox.Show(info, "ERROR", btns, icon, defBtn);
        }
    }
}
