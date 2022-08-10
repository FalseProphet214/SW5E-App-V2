
namespace SW5E_App.Player_Things.Character_Builder_Forms
{
    partial class Character_Builder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CharacterBuilderTabs = new System.Windows.Forms.TabControl();
            this.SpeciesTab = new System.Windows.Forms.TabPage();
            this.SpeciesSelectBtn = new System.Windows.Forms.Button();
            this.SpeciesRtf = new System.Windows.Forms.RichTextBox();
            this.SpeciesLbl = new System.Windows.Forms.Label();
            this.SpeciesList = new System.Windows.Forms.ListBox();
            this.ClassesTab = new System.Windows.Forms.TabPage();
            this.ClassRtf = new System.Windows.Forms.RichTextBox();
            this.ClassesList = new System.Windows.Forms.ListBox();
            this.AbilitysSkillsTab = new System.Windows.Forms.TabPage();
            this.BackgroundTab = new System.Windows.Forms.TabPage();
            this.EquipmentTab = new System.Windows.Forms.TabPage();
            this.SelectedSpeciesTxt = new System.Windows.Forms.Label();
            this.CharacterBuilderTabs.SuspendLayout();
            this.SpeciesTab.SuspendLayout();
            this.ClassesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // CharacterBuilderTabs
            // 
            this.CharacterBuilderTabs.Controls.Add(this.SpeciesTab);
            this.CharacterBuilderTabs.Controls.Add(this.ClassesTab);
            this.CharacterBuilderTabs.Controls.Add(this.AbilitysSkillsTab);
            this.CharacterBuilderTabs.Controls.Add(this.BackgroundTab);
            this.CharacterBuilderTabs.Controls.Add(this.EquipmentTab);
            this.CharacterBuilderTabs.Location = new System.Drawing.Point(12, 12);
            this.CharacterBuilderTabs.Name = "CharacterBuilderTabs";
            this.CharacterBuilderTabs.SelectedIndex = 0;
            this.CharacterBuilderTabs.Size = new System.Drawing.Size(1201, 914);
            this.CharacterBuilderTabs.TabIndex = 0;
            // 
            // SpeciesTab
            // 
            this.SpeciesTab.Controls.Add(this.SpeciesSelectBtn);
            this.SpeciesTab.Controls.Add(this.SpeciesRtf);
            this.SpeciesTab.Controls.Add(this.SpeciesLbl);
            this.SpeciesTab.Controls.Add(this.SpeciesList);
            this.SpeciesTab.Location = new System.Drawing.Point(4, 24);
            this.SpeciesTab.Name = "SpeciesTab";
            this.SpeciesTab.Padding = new System.Windows.Forms.Padding(3);
            this.SpeciesTab.Size = new System.Drawing.Size(1193, 886);
            this.SpeciesTab.TabIndex = 0;
            this.SpeciesTab.Text = "Species";
            this.SpeciesTab.UseVisualStyleBackColor = true;
            // 
            // SpeciesSelectBtn
            // 
            this.SpeciesSelectBtn.Location = new System.Drawing.Point(6, 811);
            this.SpeciesSelectBtn.Name = "SpeciesSelectBtn";
            this.SpeciesSelectBtn.Size = new System.Drawing.Size(165, 54);
            this.SpeciesSelectBtn.TabIndex = 3;
            this.SpeciesSelectBtn.Text = "Save and Continue";
            this.SpeciesSelectBtn.UseVisualStyleBackColor = true;
            this.SpeciesSelectBtn.Click += new System.EventHandler(this.SpeciesSelectBtn_Click);
            // 
            // SpeciesRtf
            // 
            this.SpeciesRtf.Location = new System.Drawing.Point(200, 36);
            this.SpeciesRtf.Name = "SpeciesRtf";
            this.SpeciesRtf.Size = new System.Drawing.Size(960, 844);
            this.SpeciesRtf.TabIndex = 2;
            this.SpeciesRtf.Text = "";
            // 
            // SpeciesLbl
            // 
            this.SpeciesLbl.AutoSize = true;
            this.SpeciesLbl.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SpeciesLbl.Location = new System.Drawing.Point(3, 6);
            this.SpeciesLbl.Name = "SpeciesLbl";
            this.SpeciesLbl.Size = new System.Drawing.Size(89, 27);
            this.SpeciesLbl.TabIndex = 1;
            this.SpeciesLbl.Text = "SPECIES";
            // 
            // SpeciesList
            // 
            this.SpeciesList.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.SpeciesList.FormattingEnabled = true;
            this.SpeciesList.ItemHeight = 15;
            this.SpeciesList.Location = new System.Drawing.Point(6, 36);
            this.SpeciesList.Name = "SpeciesList";
            this.SpeciesList.Size = new System.Drawing.Size(165, 769);
            this.SpeciesList.TabIndex = 0;
            this.SpeciesList.Click += new System.EventHandler(this.SpeciesSelect);
            this.SpeciesList.SelectedIndexChanged += new System.EventHandler(this.SpeciesSelect);
            // 
            // ClassesTab
            // 
            this.ClassesTab.Controls.Add(this.ClassRtf);
            this.ClassesTab.Controls.Add(this.ClassesList);
            this.ClassesTab.Location = new System.Drawing.Point(4, 24);
            this.ClassesTab.Name = "ClassesTab";
            this.ClassesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTab.Size = new System.Drawing.Size(1193, 886);
            this.ClassesTab.TabIndex = 1;
            this.ClassesTab.Text = "Classes";
            this.ClassesTab.UseVisualStyleBackColor = true;
            // 
            // ClassRtf
            // 
            this.ClassRtf.Location = new System.Drawing.Point(322, 6);
            this.ClassRtf.Name = "ClassRtf";
            this.ClassRtf.Size = new System.Drawing.Size(865, 874);
            this.ClassRtf.TabIndex = 1;
            this.ClassRtf.Text = "";
            // 
            // ClassesList
            // 
            this.ClassesList.Font = new System.Drawing.Font("Open Sans", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassesList.FormattingEnabled = true;
            this.ClassesList.ItemHeight = 55;
            this.ClassesList.Location = new System.Drawing.Point(6, 6);
            this.ClassesList.Name = "ClassesList";
            this.ClassesList.Size = new System.Drawing.Size(310, 774);
            this.ClassesList.TabIndex = 0;
            this.ClassesList.SelectedIndexChanged += new System.EventHandler(this.ClassSelect_Click);
            // 
            // AbilitysSkillsTab
            // 
            this.AbilitysSkillsTab.Location = new System.Drawing.Point(4, 24);
            this.AbilitysSkillsTab.Name = "AbilitysSkillsTab";
            this.AbilitysSkillsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AbilitysSkillsTab.Size = new System.Drawing.Size(1193, 886);
            this.AbilitysSkillsTab.TabIndex = 2;
            this.AbilitysSkillsTab.Text = "Ability Scores, Skills, Spells";
            this.AbilitysSkillsTab.UseVisualStyleBackColor = true;
            // 
            // BackgroundTab
            // 
            this.BackgroundTab.Location = new System.Drawing.Point(4, 24);
            this.BackgroundTab.Name = "BackgroundTab";
            this.BackgroundTab.Size = new System.Drawing.Size(1193, 886);
            this.BackgroundTab.TabIndex = 3;
            this.BackgroundTab.Text = "Backgrounds";
            this.BackgroundTab.UseVisualStyleBackColor = true;
            // 
            // EquipmentTab
            // 
            this.EquipmentTab.Location = new System.Drawing.Point(4, 24);
            this.EquipmentTab.Name = "EquipmentTab";
            this.EquipmentTab.Size = new System.Drawing.Size(1193, 886);
            this.EquipmentTab.TabIndex = 4;
            this.EquipmentTab.Text = "Equipment and Credits";
            this.EquipmentTab.UseVisualStyleBackColor = true;
            // 
            // SelectedSpeciesTxt
            // 
            this.SelectedSpeciesTxt.AutoSize = true;
            this.SelectedSpeciesTxt.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedSpeciesTxt.Location = new System.Drawing.Point(1219, 36);
            this.SelectedSpeciesTxt.Name = "SelectedSpeciesTxt";
            this.SelectedSpeciesTxt.Size = new System.Drawing.Size(100, 27);
            this.SelectedSpeciesTxt.TabIndex = 1;
            this.SelectedSpeciesTxt.Text = "SPECIES: ";
            // 
            // Character_Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 938);
            this.Controls.Add(this.SelectedSpeciesTxt);
            this.Controls.Add(this.CharacterBuilderTabs);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Character_Builder";
            this.Text = "Character_Builder";
            this.Load += new System.EventHandler(this.Character_Builder_Load);
            this.CharacterBuilderTabs.ResumeLayout(false);
            this.SpeciesTab.ResumeLayout(false);
            this.SpeciesTab.PerformLayout();
            this.ClassesTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl CharacterBuilderTabs;
        private System.Windows.Forms.TabPage SpeciesTab;
        private System.Windows.Forms.TabPage ClassesTab;
        private System.Windows.Forms.TabPage AbilitysSkillsTab;
        private System.Windows.Forms.ListBox SpeciesList;
        private System.Windows.Forms.TabPage BackgroundTab;
        private System.Windows.Forms.TabPage EquipmentTab;
        private System.Windows.Forms.Label SpeciesLbl;
        private System.Windows.Forms.RichTextBox SpeciesRtf;
        private System.Windows.Forms.Button SpeciesSelectBtn;
        private System.Windows.Forms.Label SelectedSpeciesTxt;
        private System.Windows.Forms.ListBox ClassesList;
        private System.Windows.Forms.RichTextBox ClassRtf;
    }
}