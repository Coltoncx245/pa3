namespace pa3
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
            this.cb_players = new System.Windows.Forms.ComboBox();
            this.lbl_Players = new System.Windows.Forms.Label();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.lb_firstTeam = new System.Windows.Forms.ListBox();
            this.lb_secondTeam = new System.Windows.Forms.ListBox();
            this.btn_firstAdd = new System.Windows.Forms.Button();
            this.btn_secondAdd = new System.Windows.Forms.Button();
            this.btn_firstRmv = new System.Windows.Forms.Button();
            this.btn_secondRmv = new System.Windows.Forms.Button();
            this.lbl_firstTeam = new System.Windows.Forms.Label();
            this.lbl_secondTeam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_players
            // 
            this.cb_players.FormattingEnabled = true;
            this.cb_players.Location = new System.Drawing.Point(151, 74);
            this.cb_players.Name = "cb_players";
            this.cb_players.Size = new System.Drawing.Size(133, 21);
            this.cb_players.Sorted = true;
            this.cb_players.TabIndex = 0;
            this.cb_players.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_players_KeyPress);
            // 
            // lbl_Players
            // 
            this.lbl_Players.AutoSize = true;
            this.lbl_Players.Location = new System.Drawing.Point(197, 58);
            this.lbl_Players.Name = "lbl_Players";
            this.lbl_Players.Size = new System.Drawing.Size(41, 13);
            this.lbl_Players.TabIndex = 1;
            this.lbl_Players.Text = "Players";
            // 
            // btn_Restart
            // 
            this.btn_Restart.Location = new System.Drawing.Point(183, 127);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(75, 23);
            this.btn_Restart.TabIndex = 2;
            this.btn_Restart.Text = "Restart";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // lb_firstTeam
            // 
            this.lb_firstTeam.FormattingEnabled = true;
            this.lb_firstTeam.Location = new System.Drawing.Point(46, 214);
            this.lb_firstTeam.Name = "lb_firstTeam";
            this.lb_firstTeam.Size = new System.Drawing.Size(120, 95);
            this.lb_firstTeam.Sorted = true;
            this.lb_firstTeam.TabIndex = 3;
            // 
            // lb_secondTeam
            // 
            this.lb_secondTeam.FormattingEnabled = true;
            this.lb_secondTeam.Location = new System.Drawing.Point(261, 214);
            this.lb_secondTeam.Name = "lb_secondTeam";
            this.lb_secondTeam.Size = new System.Drawing.Size(120, 95);
            this.lb_secondTeam.Sorted = true;
            this.lb_secondTeam.TabIndex = 4;
            // 
            // btn_firstAdd
            // 
            this.btn_firstAdd.Location = new System.Drawing.Point(61, 316);
            this.btn_firstAdd.Name = "btn_firstAdd";
            this.btn_firstAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_firstAdd.TabIndex = 5;
            this.btn_firstAdd.Text = "Add";
            this.btn_firstAdd.UseVisualStyleBackColor = true;
            this.btn_firstAdd.Click += new System.EventHandler(this.btn_firstAdd_Click);
            // 
            // btn_secondAdd
            // 
            this.btn_secondAdd.Location = new System.Drawing.Point(282, 316);
            this.btn_secondAdd.Name = "btn_secondAdd";
            this.btn_secondAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_secondAdd.TabIndex = 6;
            this.btn_secondAdd.Text = "Add";
            this.btn_secondAdd.UseVisualStyleBackColor = true;
            this.btn_secondAdd.Click += new System.EventHandler(this.btn_secondAdd_Click);
            // 
            // btn_firstRmv
            // 
            this.btn_firstRmv.Location = new System.Drawing.Point(61, 345);
            this.btn_firstRmv.Name = "btn_firstRmv";
            this.btn_firstRmv.Size = new System.Drawing.Size(75, 23);
            this.btn_firstRmv.TabIndex = 7;
            this.btn_firstRmv.Text = "Remove";
            this.btn_firstRmv.UseVisualStyleBackColor = true;
            this.btn_firstRmv.Click += new System.EventHandler(this.btn_firstRmv_Click);
            // 
            // btn_secondRmv
            // 
            this.btn_secondRmv.Location = new System.Drawing.Point(282, 345);
            this.btn_secondRmv.Name = "btn_secondRmv";
            this.btn_secondRmv.Size = new System.Drawing.Size(75, 23);
            this.btn_secondRmv.TabIndex = 8;
            this.btn_secondRmv.Text = "Remove";
            this.btn_secondRmv.UseVisualStyleBackColor = true;
            this.btn_secondRmv.Click += new System.EventHandler(this.btn_secondRmv_Click);
            // 
            // lbl_firstTeam
            // 
            this.lbl_firstTeam.AutoSize = true;
            this.lbl_firstTeam.Location = new System.Drawing.Point(71, 195);
            this.lbl_firstTeam.Name = "lbl_firstTeam";
            this.lbl_firstTeam.Size = new System.Drawing.Size(56, 13);
            this.lbl_firstTeam.TabIndex = 9;
            this.lbl_firstTeam.Text = "First Team";
            // 
            // lbl_secondTeam
            // 
            this.lbl_secondTeam.AutoSize = true;
            this.lbl_secondTeam.Location = new System.Drawing.Point(283, 195);
            this.lbl_secondTeam.Name = "lbl_secondTeam";
            this.lbl_secondTeam.Size = new System.Drawing.Size(74, 13);
            this.lbl_secondTeam.TabIndex = 10;
            this.lbl_secondTeam.Text = "Second Team";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.lbl_secondTeam);
            this.Controls.Add(this.lbl_firstTeam);
            this.Controls.Add(this.btn_secondRmv);
            this.Controls.Add(this.btn_firstRmv);
            this.Controls.Add(this.btn_secondAdd);
            this.Controls.Add(this.btn_firstAdd);
            this.Controls.Add(this.lb_secondTeam);
            this.Controls.Add(this.lb_firstTeam);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.lbl_Players);
            this.Controls.Add(this.cb_players);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_players;
        private System.Windows.Forms.Label lbl_Players;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.ListBox lb_firstTeam;
        private System.Windows.Forms.ListBox lb_secondTeam;
        private System.Windows.Forms.Button btn_firstAdd;
        private System.Windows.Forms.Button btn_secondAdd;
        private System.Windows.Forms.Button btn_firstRmv;
        private System.Windows.Forms.Button btn_secondRmv;
        private System.Windows.Forms.Label lbl_firstTeam;
        private System.Windows.Forms.Label lbl_secondTeam;
    }
}

