using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR_2
{
    public partial class InputForm : Form
    {
        public InputResult Result;

        private TypeElem _type;

        public InputForm(TypeElem type, InputResult parent)
        {
            InitializeComponent();

            Result = new InputResult(type);

            _type = type;
            if (_type != TypeElem.Init)
            {
                label2.Visible = false;
                numericUpDown1.Visible = false;
            }

            if (parent != null)
            {
                Result.Parent = parent.Type == TypeElem.Init 
                    ? parent.Parent
                    : parent;
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result.Name = textBox1.Text;
            Result.Type = _type;

            if (_type == TypeElem.Init)
            {
                Result.Probably = Convert.ToDouble(numericUpDown1.Value);
            }

            Close();
        }
    }
}
