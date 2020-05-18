using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StructureOfMolecules
{
    public partial class Form2 : Form
    {
        public string nameText;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void TextOnForm2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            nameText = TextOnForm2.Text;
            TextOnForm2.Clear();
            Close();
        }
    }
}
