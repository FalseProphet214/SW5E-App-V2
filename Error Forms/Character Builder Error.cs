using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW5E_App.Error_Forms
{
    public partial class Character_Builder_Error : Form
    {
        public Character_Builder_Error(string missingObject)
        {
            InitializeComponent();

            ErrorMsg.Text = "Missing " + missingObject + "\n" + "Please select " + missingObject + " and then continue through the form";
        }
    }
}
