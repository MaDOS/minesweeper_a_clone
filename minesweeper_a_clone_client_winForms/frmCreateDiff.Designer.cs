namespace minesweeper_a_clone_client
{
    partial class frmCreateDiff
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblMines = new System.Windows.Forms.Label();
            this.numUDHeight = new System.Windows.Forms.NumericUpDown();
            this.numUDWidth = new System.Windows.Forms.NumericUpDown();
            this.numUDMines = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUDHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMines)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCreate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Quartz MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Maroon;
            this.btnCreate.Location = new System.Drawing.Point(252, 337);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(200, 40);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "create";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDifficulty.Font = new System.Drawing.Font("Quartz MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.ForeColor = System.Drawing.Color.Maroon;
            this.lblDifficulty.Location = new System.Drawing.Point(12, 9);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(69, 23);
            this.lblDifficulty.TabIndex = 6;
            this.lblDifficulty.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Black;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Maroon;
            this.txtName.Location = new System.Drawing.Point(98, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 21);
            this.txtName.TabIndex = 7;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeight.Font = new System.Drawing.Font("Quartz MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.ForeColor = System.Drawing.Color.Maroon;
            this.lblHeight.Location = new System.Drawing.Point(12, 62);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(80, 23);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "height:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWidth.Font = new System.Drawing.Font("Quartz MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.ForeColor = System.Drawing.Color.Maroon;
            this.lblWidth.Location = new System.Drawing.Point(12, 115);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(76, 23);
            this.lblWidth.TabIndex = 9;
            this.lblWidth.Text = "width:";
            // 
            // lblMines
            // 
            this.lblMines.AutoSize = true;
            this.lblMines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMines.Font = new System.Drawing.Font("Quartz MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMines.ForeColor = System.Drawing.Color.Maroon;
            this.lblMines.Location = new System.Drawing.Point(12, 168);
            this.lblMines.Name = "lblMines";
            this.lblMines.Size = new System.Drawing.Size(74, 23);
            this.lblMines.TabIndex = 10;
            this.lblMines.Text = "mines:";
            // 
            // numUDHeight
            // 
            this.numUDHeight.BackColor = System.Drawing.Color.Black;
            this.numUDHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numUDHeight.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDHeight.ForeColor = System.Drawing.Color.Maroon;
            this.numUDHeight.Location = new System.Drawing.Point(98, 65);
            this.numUDHeight.Name = "numUDHeight";
            this.numUDHeight.Size = new System.Drawing.Size(120, 17);
            this.numUDHeight.TabIndex = 11;
            // 
            // numUDWidth
            // 
            this.numUDWidth.BackColor = System.Drawing.Color.Black;
            this.numUDWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numUDWidth.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDWidth.ForeColor = System.Drawing.Color.Maroon;
            this.numUDWidth.Location = new System.Drawing.Point(98, 118);
            this.numUDWidth.Name = "numUDWidth";
            this.numUDWidth.Size = new System.Drawing.Size(120, 17);
            this.numUDWidth.TabIndex = 12;
            // 
            // numUDMines
            // 
            this.numUDMines.BackColor = System.Drawing.Color.Black;
            this.numUDMines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numUDMines.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDMines.ForeColor = System.Drawing.Color.Maroon;
            this.numUDMines.Location = new System.Drawing.Point(98, 171);
            this.numUDMines.Name = "numUDMines";
            this.numUDMines.Size = new System.Drawing.Size(120, 17);
            this.numUDMines.TabIndex = 13;
            // 
            // frmCreateDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(464, 389);
            this.Controls.Add(this.numUDMines);
            this.Controls.Add(this.numUDWidth);
            this.Controls.Add(this.numUDHeight);
            this.Controls.Add(this.lblMines);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.btnCreate);
            this.Name = "frmCreateDiff";
            this.Text = "frmCreateDiff";
            ((System.ComponentModel.ISupportInitialize)(this.numUDHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblMines;
        private System.Windows.Forms.NumericUpDown numUDHeight;
        private System.Windows.Forms.NumericUpDown numUDWidth;
        private System.Windows.Forms.NumericUpDown numUDMines;
    }
}