namespace minesweeper_a_clone_client
{
    partial class mainFrm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnHighscores = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.chkBxDlHighscores = new System.Windows.Forms.CheckBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.cmbBoxTheme = new System.Windows.Forms.ComboBox();
            this.cmbBxDifficulty = new System.Windows.Forms.ComboBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnCreateDifficulty = new System.Windows.Forms.Button();
            this.pnlHighscores = new System.Windows.Forms.Panel();
            this.lblHighscores = new System.Windows.Forms.Label();
            this.lstHighscores = new System.Windows.Forms.ListBox();
            this.cmbBoxHighscores = new System.Windows.Forms.ComboBox();
            this.pnlOptions.SuspendLayout();
            this.pnlHighscores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPlay.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Quartz MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Maroon;
            this.btnPlay.Location = new System.Drawing.Point(41, 78);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(200, 40);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOptions.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Quartz MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.Color.Maroon;
            this.btnOptions.Location = new System.Drawing.Point(41, 124);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(200, 40);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnHighscores
            // 
            this.btnHighscores.BackColor = System.Drawing.Color.Transparent;
            this.btnHighscores.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHighscores.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnHighscores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHighscores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHighscores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighscores.Font = new System.Drawing.Font("Quartz MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighscores.ForeColor = System.Drawing.Color.Maroon;
            this.btnHighscores.Location = new System.Drawing.Point(41, 170);
            this.btnHighscores.Name = "btnHighscores";
            this.btnHighscores.Size = new System.Drawing.Size(200, 40);
            this.btnHighscores.TabIndex = 2;
            this.btnHighscores.Text = "Highscores";
            this.btnHighscores.UseVisualStyleBackColor = false;
            this.btnHighscores.Click += new System.EventHandler(this.btnHighscores_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Quartz MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.Maroon;
            this.btnQuit.Location = new System.Drawing.Point(41, 409);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(200, 40);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // chkBxDlHighscores
            // 
            this.chkBxDlHighscores.AutoSize = true;
            this.chkBxDlHighscores.BackColor = System.Drawing.Color.Transparent;
            this.chkBxDlHighscores.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkBxDlHighscores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkBxDlHighscores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkBxDlHighscores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBxDlHighscores.Font = new System.Drawing.Font("Quartz MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxDlHighscores.ForeColor = System.Drawing.Color.Maroon;
            this.chkBxDlHighscores.Location = new System.Drawing.Point(7, 163);
            this.chkBxDlHighscores.Name = "chkBxDlHighscores";
            this.chkBxDlHighscores.Size = new System.Drawing.Size(244, 27);
            this.chkBxDlHighscores.TabIndex = 9;
            this.chkBxDlHighscores.Text = "Download Highscores";
            this.chkBxDlHighscores.UseVisualStyleBackColor = false;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTheme.Font = new System.Drawing.Font("Quartz MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.ForeColor = System.Drawing.Color.Maroon;
            this.lblTheme.Location = new System.Drawing.Point(3, 78);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(76, 23);
            this.lblTheme.TabIndex = 8;
            this.lblTheme.Text = "Theme";
            // 
            // cmbBoxTheme
            // 
            this.cmbBoxTheme.BackColor = System.Drawing.Color.Black;
            this.cmbBoxTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxTheme.ForeColor = System.Drawing.Color.Maroon;
            this.cmbBoxTheme.FormattingEnabled = true;
            this.cmbBoxTheme.Items.AddRange(new object[] {
            "default",
            "space",
            "flowers",
            "cookies",
            "windows orig",
            "ponys"});
            this.cmbBoxTheme.Location = new System.Drawing.Point(122, 80);
            this.cmbBoxTheme.Name = "cmbBoxTheme";
            this.cmbBoxTheme.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxTheme.TabIndex = 7;
            // 
            // cmbBxDifficulty
            // 
            this.cmbBxDifficulty.BackColor = System.Drawing.Color.Black;
            this.cmbBxDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBxDifficulty.ForeColor = System.Drawing.Color.Maroon;
            this.cmbBxDifficulty.FormattingEnabled = true;
            this.cmbBxDifficulty.Items.AddRange(new object[] {
            "hard",
            "medium",
            "easy",
            "- unofficial -",
            "1337",
            "amazing",
            "supaeasy"});
            this.cmbBxDifficulty.Location = new System.Drawing.Point(122, 21);
            this.cmbBxDifficulty.Name = "cmbBxDifficulty";
            this.cmbBxDifficulty.Size = new System.Drawing.Size(121, 21);
            this.cmbBxDifficulty.TabIndex = 6;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDifficulty.Font = new System.Drawing.Font("Quartz MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.ForeColor = System.Drawing.Color.Maroon;
            this.lblDifficulty.Location = new System.Drawing.Point(3, 17);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(113, 23);
            this.lblDifficulty.TabIndex = 5;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.btnCreateDifficulty);
            this.pnlOptions.Controls.Add(this.lblDifficulty);
            this.pnlOptions.Controls.Add(this.chkBxDlHighscores);
            this.pnlOptions.Controls.Add(this.cmbBxDifficulty);
            this.pnlOptions.Controls.Add(this.lblTheme);
            this.pnlOptions.Controls.Add(this.cmbBoxTheme);
            this.pnlOptions.Location = new System.Drawing.Point(41, 466);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(176, 139);
            this.pnlOptions.TabIndex = 10;
            // 
            // btnCreateDifficulty
            // 
            this.btnCreateDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateDifficulty.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCreateDifficulty.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCreateDifficulty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCreateDifficulty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCreateDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateDifficulty.Font = new System.Drawing.Font("Quartz MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDifficulty.ForeColor = System.Drawing.Color.Maroon;
            this.btnCreateDifficulty.Location = new System.Drawing.Point(266, 9);
            this.btnCreateDifficulty.Name = "btnCreateDifficulty";
            this.btnCreateDifficulty.Size = new System.Drawing.Size(200, 40);
            this.btnCreateDifficulty.TabIndex = 11;
            this.btnCreateDifficulty.Text = "create own";
            this.btnCreateDifficulty.UseVisualStyleBackColor = false;
            this.btnCreateDifficulty.Click += new System.EventHandler(this.btnCreateDifficulty_Click);
            // 
            // pnlHighscores
            // 
            this.pnlHighscores.Controls.Add(this.cmbBoxHighscores);
            this.pnlHighscores.Controls.Add(this.lstHighscores);
            this.pnlHighscores.Controls.Add(this.lblHighscores);
            this.pnlHighscores.Location = new System.Drawing.Point(302, 484);
            this.pnlHighscores.Name = "pnlHighscores";
            this.pnlHighscores.Size = new System.Drawing.Size(267, 142);
            this.pnlHighscores.TabIndex = 12;
            // 
            // lblHighscores
            // 
            this.lblHighscores.AutoSize = true;
            this.lblHighscores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHighscores.Font = new System.Drawing.Font("Quartz MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscores.ForeColor = System.Drawing.Color.Maroon;
            this.lblHighscores.Location = new System.Drawing.Point(16, 18);
            this.lblHighscores.Name = "lblHighscores";
            this.lblHighscores.Size = new System.Drawing.Size(121, 23);
            this.lblHighscores.TabIndex = 12;
            this.lblHighscores.Text = "Highscores";
            // 
            // lstHighscores
            // 
            this.lstHighscores.BackColor = System.Drawing.Color.Black;
            this.lstHighscores.Font = new System.Drawing.Font("Quartz MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHighscores.ForeColor = System.Drawing.Color.Maroon;
            this.lstHighscores.FormattingEnabled = true;
            this.lstHighscores.ItemHeight = 23;
            this.lstHighscores.Items.AddRange(new object[] {
            "#1 player1 - 13:37",
            "#2 player2 - 42:42",
            "#3 player3 - 55:55",
            ".",
            ".",
            "."});
            this.lstHighscores.Location = new System.Drawing.Point(83, 55);
            this.lstHighscores.Name = "lstHighscores";
            this.lstHighscores.Size = new System.Drawing.Size(295, 349);
            this.lstHighscores.TabIndex = 13;
            // 
            // cmbBoxHighscores
            // 
            this.cmbBoxHighscores.BackColor = System.Drawing.Color.Black;
            this.cmbBoxHighscores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxHighscores.ForeColor = System.Drawing.Color.Maroon;
            this.cmbBoxHighscores.FormattingEnabled = true;
            this.cmbBoxHighscores.Items.AddRange(new object[] {
            "hard",
            "meduim",
            "easy"});
            this.cmbBoxHighscores.Location = new System.Drawing.Point(339, 24);
            this.cmbBoxHighscores.Name = "cmbBoxHighscores";
            this.cmbBoxHighscores.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxHighscores.TabIndex = 12;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(792, 570);
            this.Controls.Add(this.pnlHighscores);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnHighscores);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnPlay);
            this.Name = "mainFrm";
            this.Text = "minesweeper a clone";
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.pnlHighscores.ResumeLayout(false);
            this.pnlHighscores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnHighscores;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.CheckBox chkBxDlHighscores;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.ComboBox cmbBoxTheme;
        private System.Windows.Forms.ComboBox cmbBxDifficulty;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnCreateDifficulty;
        private System.Windows.Forms.Panel pnlHighscores;
        private System.Windows.Forms.ComboBox cmbBoxHighscores;
        private System.Windows.Forms.ListBox lstHighscores;
        private System.Windows.Forms.Label lblHighscores;
    }
}

