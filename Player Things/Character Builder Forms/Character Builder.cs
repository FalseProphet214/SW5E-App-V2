using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW5E_App.Player_Things.Character_Builder_Forms
{
    public partial class Character_Builder : Form
    {
        #region VARIABLES

        #region ABILITY SCORES

        public int _str = 0;
        public int _dex = 0;
        public int _con = 0;
        public int _int = 0;
        public int _wis = 0;
        public int _cha = 0;

        public int increasePrimary = 0;
        public int increaseSecondary = 0;

        #endregion

        #region SELECTED OBJECTS

        public string _selectedSpecies;
        public string _selectedClass;
        public string _selectedBackground;

        #endregion

        #region FILE PATHS

        string _speciesDescriptionsPath = @"Objects\Species\Descriptions";
        string _speciesJsonPath = @"Objects\Species\JSON";
        string _classesDescriptionsPath = @"Objects\Classes\Descriptions";
        string _classesJsonPath = @"Objects\Classes\JSON";
        string _backgroundJsonPath = @"Objects\Backgrounds\JSON";

        #endregion

        #region TOOLS

        public int _skillsChecked;

        #endregion

        #endregion

        #region FORM INITIALIZATION

        public Character_Builder()
        {
            InitializeComponent();
        }

        #endregion
    }
}
