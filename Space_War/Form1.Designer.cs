﻿namespace Space_War
{
    partial class Wind
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MouveMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.MouveEnemisTimer = new System.Windows.Forms.Timer(this.components);
            this.enemiesMun = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MouveMunitionTimer
            // 
            this.MouveMunitionTimer.Enabled = true;
            this.MouveMunitionTimer.Tick += new System.EventHandler(this.MouveMunitionTimer_Tick);
            // 
            // MouveEnemisTimer
            // 
            this.MouveEnemisTimer.Enabled = true;
            this.MouveEnemisTimer.Tick += new System.EventHandler(this.MouveEnemisTimer_Tick);
            // 
            // enemiesMun
            // 
            this.enemiesMun.Enabled = true;
            this.enemiesMun.Interval = 20;
            this.enemiesMun.Tick += new System.EventHandler(this.enemiesMun_Tick);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(243, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Jouer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(243, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(281, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Space War";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // Wind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.HelpButton = true;
            this.Name = "Wind";
            this.Text = "jayson koyaweda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Wind_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Wind_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MouveMunitionTimer;
        private System.Windows.Forms.Timer MouveEnemisTimer;
        private System.Windows.Forms.Timer EnemiesMunition;
        private System.Windows.Forms.Timer enemiesMun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}

