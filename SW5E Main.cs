using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SW5E_App.Player_Things.Character_Builder_Forms;

namespace SW5E_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaunchCharacterBuilder(object sender, EventArgs e)
        {
            var newCharacterForm = new Character_Builder();
            newCharacterForm.ShowDialog();
        }
    }
}
