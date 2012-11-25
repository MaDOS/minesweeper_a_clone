using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace minesweeper_a_clone_client
{
    public partial class msgame : Microsoft.Xna.Framework.Game
    {
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnHighscores;
        private System.Windows.Forms.Button btnQuit;

        public void InitializeComponent()
        {
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnHighscores = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();

            #region properties
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
           
            #endregion

            Control.FromHandle(Window.Handle).Controls.Add(btnPlay);
            Control.FromHandle(Window.Handle).Controls.Add(btnOptions);
            Control.FromHandle(Window.Handle).Controls.Add(btnHighscores);
            Control.FromHandle(Window.Handle).Controls.Add(btnQuit);
        }

        public void refreshWinForms()
        {
            this.btnPlay.Refresh();
            this.btnOptions.Refresh();
            this.btnHighscores.Refresh();
            this.btnQuit.Refresh();
        }
    }
}
