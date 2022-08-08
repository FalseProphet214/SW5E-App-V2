
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SpeciesTab = new System.Windows.Forms.TabPage();
            this.ClassesTab = new System.Windows.Forms.TabPage();
            this.AbilitysSkillsTab = new System.Windows.Forms.TabPage();
            this.BackgroundTab = new System.Windows.Forms.TabPage();
            this.EquipmentTab = new System.Windows.Forms.TabPage();
            this.SpeciesList = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.SpeciesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SpeciesTab);
            this.tabControl1.Controls.Add(this.ClassesTab);
            this.tabControl1.Controls.Add(this.AbilitysSkillsTab);
            this.tabControl1.Controls.Add(this.BackgroundTab);
            this.tabControl1.Controls.Add(this.EquipmentTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1201, 914);
            this.tabControl1.TabIndex = 0;
            // 
            // SpeciesTab
            // 
            this.SpeciesTab.Controls.Add(this.SpeciesList);
            this.SpeciesTab.Location = new System.Drawing.Point(4, 24);
            this.SpeciesTab.Name = "SpeciesTab";
            this.SpeciesTab.Padding = new System.Windows.Forms.Padding(3);
            this.SpeciesTab.Size = new System.Drawing.Size(1193, 886);
            this.SpeciesTab.TabIndex = 0;
            this.SpeciesTab.Text = "Species";
            this.SpeciesTab.UseVisualStyleBackColor = true;
            // 
            // ClassesTab
            // 
            this.ClassesTab.Location = new System.Drawing.Point(4, 24);
            this.ClassesTab.Name = "ClassesTab";
            this.ClassesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTab.Size = new System.Drawing.Size(1193, 886);
            this.ClassesTab.TabIndex = 1;
            this.ClassesTab.Text = "Classes";
            this.ClassesTab.UseVisualStyleBackColor = true;
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
            // SpeciesList
            // 
            this.SpeciesList.FormattingEnabled = true;
            this.SpeciesList.ItemHeight = 15;
            this.SpeciesList.Location = new System.Drawing.Point(6, 6);
            this.SpeciesList.Name = "SpeciesList";
            this.SpeciesList.Size = new System.Drawing.Size(165, 799);
            this.SpeciesList.TabIndex = 0;
            // 
            // Character_Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 938);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Character_Builder";
            this.Text = "Character_Builder";
            this.tabControl1.ResumeLayout(false);
            this.SpeciesTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SpeciesTab;
        private System.Windows.Forms.TabPage ClassesTab;
        private System.Windows.Forms.TabPage AbilitysSkillsTab;
        private System.Windows.Forms.ListBox SpeciesList;
        private System.Windows.Forms.TabPage BackgroundTab;
        private System.Windows.Forms.TabPage EquipmentTab;
    }
}