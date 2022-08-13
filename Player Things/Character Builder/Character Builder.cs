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

        // These are used store base ability scores during the character creation progress
        public int _strScore = 0;
        public int _dexScore = 0;
        public int _conScore = 0;
        public int _intScore = 0;
        public int _wisScore = 0;
        public int _chaScore = 0;

        // These are used to store any ability score increases from selected races/backgrounds
        public int _strIncrease = 0;
        public int _dexIncrease = 0;
        public int _conIncrease = 0;
        public int _intIncrease = 0;
        public int _wisIncrease = 0;
        public int _chaIncrease = 0;

        // These will be used to store the finalized ability scores for the character sheet form (not implemented yet)
        public int _strength = 0;
        public int _dexterity = 0;
        public int _constitution = 0;
        public int _intelligence = 0;
        public int _wisdom = 0;
        public int _charisma = 0;

        #endregion

        #region SELECTED OBJECTS

        // These are used to store the selected objects during the character creation process
        public string _selectedSpecies;
        public string _selectedClass;
        public string _selectedBackground;

        #endregion

        #region FILE PATHS

        // where the needed file paths are stored
        string _speciesDescriptionsPath = @"Objects\Species\Descriptions";
        string _speciesJsonPath = @"Objects\Species\JSON";
        string _classesDescriptionsPath = @"Objects\Classes\Descriptions";
        string _classesJsonPath = @"Objects\Classes\JSON";
        string _backgroundDescriptionPath = @"Objects\Backgrounds\Descriptions";
        string _backgroundJsonPath = @"Objects\Backgrounds\JSON";

        #endregion

        #region TOOLS

        // Where the variables that are used for different actions later in the form code base
        public int _skillsChecked = 0;

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

        // This will set the selected speacies to the index currently highlighted in the SpeciesList
        private void SpeciesSelect(object sender, EventArgs e)
        {
            string selectedSpecies = SpeciesList.SelectedItems[0].ToString();
            _selectedSpecies = selectedSpecies;

            SpeciesRtf.LoadFile($@"{_speciesDescriptionsPath}\{selectedSpecies}.rtf");
        }

        // This will set the selected species so we can save the character information in the future.
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

        // This will set the selected class from the ClassList and save that information
        // It will change the saved information whenever the ClassList index is changed
        private void ClassSelect(object sender, EventArgs e)
        {
            string selectedClass = ClassesList.SelectedItems[0].ToString();
            _selectedClass = selectedClass;

            ClassesRtf.LoadFile($@"{_classesDescriptionsPath}\{selectedClass}.rtf");
        }

        // Simply used to move back to the Species Tab in the event information needs to change
        private void BackToSpeciesBtn_Click(object sender, EventArgs e)
        {
            CharacterBuilderTabs.SelectTab(0);
        }

        // This will set the selected class so we can save the character information in the future.
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
