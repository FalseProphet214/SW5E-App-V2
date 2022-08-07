
namespace SW5E_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SW5ETitle = new System.Windows.Forms.Label();
            this.WelcomeText = new System.Windows.Forms.TextBox();
            this.RulebooksTitle = new System.Windows.Forms.Label();
            this.SourceBooksText = new System.Windows.Forms.TextBox();
            this.SWPHB = new System.Windows.Forms.Button();
            this.SWSV = new System.Windows.Forms.Button();
            this.SWSotG = new System.Windows.Forms.Button();
            this.SWWH = new System.Windows.Forms.Button();
            this.PlayerTitle = new System.Windows.Forms.Label();
            this.CreateCharacterBtn = new System.Windows.Forms.Button();
            this.SelectCharacterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GMScreenBtn = new System.Windows.Forms.Button();
            this.LootBtn = new System.Windows.Forms.Button();
            this.NPCBtn = new System.Windows.Forms.Button();
            this.HeroVillainBtn = new System.Windows.Forms.Button();
            this.QuestBtn = new System.Windows.Forms.Button();
            this.AssetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SW5ETitle
            // 
            this.SW5ETitle.AutoSize = true;
            this.SW5ETitle.Font = new System.Drawing.Font("Arial", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SW5ETitle.Location = new System.Drawing.Point(13, 13);
            this.SW5ETitle.Name = "SW5ETitle";
            this.SW5ETitle.Size = new System.Drawing.Size(218, 32);
            this.SW5ETitle.TabIndex = 0;
            this.SW5ETitle.Text = "STAR WARS 5E";
            // 
            // WelcomeText
            // 
            this.WelcomeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeText.Location = new System.Drawing.Point(12, 48);
            this.WelcomeText.Multiline = true;
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.ReadOnly = true;
            this.WelcomeText.Size = new System.Drawing.Size(219, 164);
            this.WelcomeText.TabIndex = 1;
            this.WelcomeText.Text = resources.GetString("WelcomeText.Text");
            this.WelcomeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RulebooksTitle
            // 
            this.RulebooksTitle.AutoSize = true;
            this.RulebooksTitle.Font = new System.Drawing.Font("Arial", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulebooksTitle.Location = new System.Drawing.Point(401, 19);
            this.RulebooksTitle.Name = "RulebooksTitle";
            this.RulebooksTitle.Size = new System.Drawing.Size(182, 24);
            this.RulebooksTitle.TabIndex = 2;
            this.RulebooksTitle.Text = "THE RULEBOOKS";
            // 
            // SourceBooksText
            // 
            this.SourceBooksText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SourceBooksText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceBooksText.Location = new System.Drawing.Point(301, 48);
            this.SourceBooksText.Multiline = true;
            this.SourceBooksText.Name = "SourceBooksText";
            this.SourceBooksText.ReadOnly = true;
            this.SourceBooksText.Size = new System.Drawing.Size(386, 51);
            this.SourceBooksText.TabIndex = 3;
            this.SourceBooksText.Text = "Star Wars 5e is currently comprised of four books—The Player\'s Handbook, Scum and" +
    " Villainy, Starships of the Galaxy, and Wretched Hives—with two more books plann" +
    "ed.";
            this.SourceBooksText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SWPHB
            // 
            this.SWPHB.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWPHB.Location = new System.Drawing.Point(301, 105);
            this.SWPHB.Name = "SWPHB";
            this.SWPHB.Size = new System.Drawing.Size(138, 52);
            this.SWPHB.TabIndex = 4;
            this.SWPHB.Text = "PLAYER\'S HANDBOOK";
            this.SWPHB.UseVisualStyleBackColor = true;
            // 
            // SWSV
            // 
            this.SWSV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.SWSV.Location = new System.Drawing.Point(549, 105);
            this.SWSV.Name = "SWSV";
            this.SWSV.Size = new System.Drawing.Size(138, 52);
            this.SWSV.TabIndex = 5;
            this.SWSV.Text = "SCUM AND VILLAINY";
            this.SWSV.UseVisualStyleBackColor = true;
            // 
            // SWSotG
            // 
            this.SWSotG.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.SWSotG.Location = new System.Drawing.Point(301, 163);
            this.SWSotG.Name = "SWSotG";
            this.SWSotG.Size = new System.Drawing.Size(138, 52);
            this.SWSotG.TabIndex = 6;
            this.SWSotG.Text = "STARSHIPS OF THE GALAXY";
            this.SWSotG.UseVisualStyleBackColor = true;
            // 
            // SWWH
            // 
            this.SWWH.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.SWWH.Location = new System.Drawing.Point(549, 163);
            this.SWWH.Name = "SWWH";
            this.SWWH.Size = new System.Drawing.Size(138, 52);
            this.SWWH.TabIndex = 7;
            this.SWWH.Text = "WRETCHED HIVES";
            this.SWWH.UseVisualStyleBackColor = true;
            // 
            // PlayerTitle
            // 
            this.PlayerTitle.AutoSize = true;
            this.PlayerTitle.Font = new System.Drawing.Font("Arial", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.PlayerTitle.Location = new System.Drawing.Point(54, 262);
            this.PlayerTitle.Name = "PlayerTitle";
            this.PlayerTitle.Size = new System.Drawing.Size(140, 24);
            this.PlayerTitle.TabIndex = 8;
            this.PlayerTitle.Text = "Player Things";
            // 
            // CreateCharacterBtn
            // 
            this.CreateCharacterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCharacterBtn.Location = new System.Drawing.Point(58, 302);
            this.CreateCharacterBtn.Name = "CreateCharacterBtn";
            this.CreateCharacterBtn.Size = new System.Drawing.Size(130, 46);
            this.CreateCharacterBtn.TabIndex = 9;
            this.CreateCharacterBtn.Text = "CREATE A CHARACTER";
            this.CreateCharacterBtn.UseVisualStyleBackColor = true;
            this.CreateCharacterBtn.Click += new System.EventHandler(this.LaunchCharacterBuilder);
            // 
            // SelectCharacterBtn
            // 
            this.SelectCharacterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCharacterBtn.Location = new System.Drawing.Point(58, 354);
            this.SelectCharacterBtn.Name = "SelectCharacterBtn";
            this.SelectCharacterBtn.Size = new System.Drawing.Size(130, 46);
            this.SelectCharacterBtn.TabIndex = 10;
            this.SelectCharacterBtn.Text = "OPEN SAVED CHARACTER";
            this.SelectCharacterBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(297, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Game Master Things";
            // 
            // GMScreenBtn
            // 
            this.GMScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GMScreenBtn.Location = new System.Drawing.Point(301, 302);
            this.GMScreenBtn.Name = "GMScreenBtn";
            this.GMScreenBtn.Size = new System.Drawing.Size(130, 46);
            this.GMScreenBtn.TabIndex = 12;
            this.GMScreenBtn.Text = "GM SCREEN";
            this.GMScreenBtn.UseVisualStyleBackColor = true;
            // 
            // LootBtn
            // 
            this.LootBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LootBtn.Location = new System.Drawing.Point(437, 302);
            this.LootBtn.Name = "LootBtn";
            this.LootBtn.Size = new System.Drawing.Size(130, 46);
            this.LootBtn.TabIndex = 13;
            this.LootBtn.Text = "LOOT";
            this.LootBtn.UseVisualStyleBackColor = true;
            // 
            // NPCBtn
            // 
            this.NPCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPCBtn.Location = new System.Drawing.Point(301, 354);
            this.NPCBtn.Name = "NPCBtn";
            this.NPCBtn.Size = new System.Drawing.Size(130, 46);
            this.NPCBtn.TabIndex = 14;
            this.NPCBtn.Text = "NPCs";
            this.NPCBtn.UseVisualStyleBackColor = true;
            // 
            // HeroVillainBtn
            // 
            this.HeroVillainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroVillainBtn.Location = new System.Drawing.Point(437, 354);
            this.HeroVillainBtn.Name = "HeroVillainBtn";
            this.HeroVillainBtn.Size = new System.Drawing.Size(130, 46);
            this.HeroVillainBtn.TabIndex = 15;
            this.HeroVillainBtn.Text = "HEROS AND VILLAINS";
            this.HeroVillainBtn.UseVisualStyleBackColor = true;
            // 
            // QuestBtn
            // 
            this.QuestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestBtn.Location = new System.Drawing.Point(573, 302);
            this.QuestBtn.Name = "QuestBtn";
            this.QuestBtn.Size = new System.Drawing.Size(130, 46);
            this.QuestBtn.TabIndex = 16;
            this.QuestBtn.Text = "QUESTS";
            this.QuestBtn.UseVisualStyleBackColor = true;
            // 
            // AssetBtn
            // 
            this.AssetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssetBtn.Location = new System.Drawing.Point(573, 354);
            this.AssetBtn.Name = "AssetBtn";
            this.AssetBtn.Size = new System.Drawing.Size(130, 46);
            this.AssetBtn.TabIndex = 17;
            this.AssetBtn.Text = "ASSETS";
            this.AssetBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AssetBtn);
            this.Controls.Add(this.QuestBtn);
            this.Controls.Add(this.HeroVillainBtn);
            this.Controls.Add(this.NPCBtn);
            this.Controls.Add(this.LootBtn);
            this.Controls.Add(this.GMScreenBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectCharacterBtn);
            this.Controls.Add(this.CreateCharacterBtn);
            this.Controls.Add(this.PlayerTitle);
            this.Controls.Add(this.SWWH);
            this.Controls.Add(this.SWSotG);
            this.Controls.Add(this.SWSV);
            this.Controls.Add(this.SWPHB);
            this.Controls.Add(this.SourceBooksText);
            this.Controls.Add(this.RulebooksTitle);
            this.Controls.Add(this.WelcomeText);
            this.Controls.Add(this.SW5ETitle);
            this.Name = "Form1";
            this.Text = "Star Wars 5E";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SW5ETitle;
        private System.Windows.Forms.TextBox WelcomeText;
        private System.Windows.Forms.Label RulebooksTitle;
        private System.Windows.Forms.TextBox SourceBooksText;
        private System.Windows.Forms.Button SWPHB;
        private System.Windows.Forms.Button SWSV;
        private System.Windows.Forms.Button SWSotG;
        private System.Windows.Forms.Button SWWH;
        private System.Windows.Forms.Label PlayerTitle;
        private System.Windows.Forms.Button CreateCharacterBtn;
        private System.Windows.Forms.Button SelectCharacterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GMScreenBtn;
        private System.Windows.Forms.Button LootBtn;
        private System.Windows.Forms.Button NPCBtn;
        private System.Windows.Forms.Button HeroVillainBtn;
        private System.Windows.Forms.Button QuestBtn;
        private System.Windows.Forms.Button AssetBtn;
    }
}

