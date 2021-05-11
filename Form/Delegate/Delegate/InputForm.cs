using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public partial class InputForm : Form
    {
        Form ParrantForm;
        public InputForm(Form ParrantForm)
        {
            InitializeComponent();
            this.ParrantForm = ParrantForm;
        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void InputForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParrantForm.Close();
        }
    }
}
