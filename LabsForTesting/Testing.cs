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
                MessageBoxButtons btns = MessageBoxButtons.OK;
                MessageBoxDefaultButton defBtn = MessageBoxDefaultButton.Button1;
                string info = "Вы ввели невалидное значение!";
                MessageBoxIcon icon = MessageBoxIcon.Error;

                MessageBox.Show(info, "ERROR", btns, icon, defBtn);
            }
            else
            {
                if (numbers.Count == 10)
                {
                    MessageBoxButtons btns = MessageBoxButtons.OK;
                    MessageBoxDefaultButton defBtn = MessageBoxDefaultButton.Button1;
                    string info = "Слишком много значений в массиве для оперирования данными!";
                    MessageBoxIcon icon = MessageBoxIcon.Error;

                    MessageBox.Show(info, "ERROR", btns, icon, defBtn);
                }
                else
                {
                    numbers.Add(num);
                    listView.Items.Add(num.ToString());
                }
            }
        }
    }
}
