using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace minesweeper_a_clone_client
{
    public partial class mainFrm : Form
    {
        view activeView;

        enum view
        {
            none,
            options,
            highscores
        }

        public mainFrm()
        {
            InitializeComponent();
            this.pnlOptions.Hide();
            this.pnlHighscores.Hide();
            this.cmbBoxHighscores.SelectedIndex = 0;
            this.cmbBoxTheme.SelectedIndex = 0;
            this.cmbBxDifficulty.SelectedIndex = 0;
            this.chkBxDlHighscores.Checked = true;
            activeView = view.none;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            if(activeView == view.highscores)
            {
                pnlHighscores.Hide();
            }
            this.pnlOptions.Location = new Point(299, 69);
            this.pnlOptions.Size = new Size(481, 446);
            this.pnlOptions.Show();
            this.activeView = view.options;
        }

        private void btnHighscores_Click(object sender, EventArgs e)
        {
            if (activeView == view.options)
            {
                pnlOptions.Hide();
            }
            this.pnlHighscores.Location = new Point(299, 69);
            this.pnlHighscores.Size = new Size(481, 446);
            this.pnlHighscores.Show();
            this.activeView = view.highscores;
        }

        private void btnCreateDifficulty_Click(object sender, EventArgs e)
        {
            frmCreateDiff _frmCreateDiff = new frmCreateDiff();
            _frmCreateDiff.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            using (msgame game = new msgame())
            {
                game.Run();
            }
        }
    }
}
