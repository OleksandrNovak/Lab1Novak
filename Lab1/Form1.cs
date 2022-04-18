using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private char charToFind = 'с';
        private int maxCount = 2;
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void clearButton_Click(object sender, EventArgs e)
        {
            arrayListBox.Items.Clear();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            arrayListBox.Items.Add(itemTextBox.Text);
        }

        /// <summary>
        /// Search array items which are less than at least 2 previous array elements.
        /// </summary>
        /// <param name="string">Input string array.</param>
        /// <returns>The list of sought numbers.</returns>
        private void runButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arrayListBox.Items.Count; i++)
            {
                int count = 0;
                
                if (arrayListBox.Items[i].ToString().ToLower().Contains(charToFind))
                {
                    foreach (char c in arrayListBox.Items[i].ToString().ToLower())
                    {
                        if (c == charToFind) count++;
                    }
                    if (count < maxCount) {
                        var resultStr = string.Join("\n", arrayListBox.Items[i]);
                        MessageBox.Show(resultStr);
                    }
                }

            }

        }

    }
}