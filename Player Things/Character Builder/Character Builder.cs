using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SW5E_App.Error_Forms;

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
        string _backgroundDescriptionPath = @"Objects\Backgrounds\Descriptions";
        string _backgroundJsonPath = @"Objects\Backgrounds\JSON";

        #endregion

        #region TOOLS

        public int _skillsChecked;

        #endregion

        #endregion

        #region FORM INITIALIZATION CODE

        public Character_Builder()
        {
            InitializeComponent();

            #region SPECIES TAB INITIALIZATION

            string[] speciesList = Directory.GetFiles(_speciesDescriptionsPath)
                .Select(Path.GetFileNameWithoutExtension)
                .ToArray();

            foreach (string species in speciesList)
            {
                string speciesName = species;
                SpeciesList.Items.Add(speciesName);
            }

            #endregion

            #region CLASSES TAB INITIALIZATION

            string[] classesList = Directory.GetFiles(_classesDescriptionsPath)
                .Select(Path.GetFileNameWithoutExtension)
                .ToArray();

            foreach (string classes in classesList)
            {
                string className = classes;
                ClassesList.Items.Add(className);
            }

            #endregion
        }

        #endregion

        #region SPECIES TAB CODE

        private void SpeciesSelect(object sender, EventArgs e)
        {
            string selectedSpecies = SpeciesList.SelectedItems[0].ToString();
            _selectedSpecies = selectedSpecies;

            SpeciesRtf.LoadFile($@"{_speciesDescriptionsPath}\{selectedSpecies}.rtf");
        }

        private void SpeciesSelectBtn_Click(object sender, EventArgs e)
        {
            if (_selectedSpecies == null)
            {
                var newErrorForm = new Character_Builder_Error("Species");
                newErrorForm.ShowDialog();
            }
            else
            {
                SelectedSpeciesTxt.Text = "SPECIES: " + _selectedSpecies;
                CharacterBuilderTabs.SelectTab(1);
            }
        }

        #endregion

        #region CLASSES TAB CODE

        private void ClassSelect(object sender, EventArgs e)
        {
            string selectedClass = ClassesList.SelectedItems[0].ToString();
            _selectedClass = selectedClass;

            ClassesRtf.LoadFile($@"{_classesDescriptionsPath}\{selectedClass}.rtf");
        }

        private void BackToSpeciesBtn_Click(object sender, EventArgs e)
        {
            CharacterBuilderTabs.SelectTab(0);
        }

        private void ClassSelectBtn_Click(object sender, EventArgs e)
        {
            if (_selectedClass == null)
            {
                var newErrorForm = new Character_Builder_Error("Class");
                newErrorForm.ShowDialog();
            }
            else
            {
                SelectedClassTxt.Text = "CLASS: " + _selectedClass;
                CharacterBuilderTabs.SelectTab(2);
            }
        }

        #endregion
    }
}
