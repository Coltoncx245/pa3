using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pa3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string buffer;
                StreamReader inputFile = File.OpenText("Players.txt");

                while(!inputFile.EndOfStream)
                {
                    buffer = inputFile.ReadLine();
                    cb_players.Items.Add(buffer);
                }

                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void cb_players_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                cb_players.Text.Trim();
                cb_players.Items.Add(cb_players.Text);
                cb_players.Text = "";
            }
        }

        private void btn_firstAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Add to lb
                lb_firstTeam.Items.Add(cb_players.Items[cb_players.SelectedIndex]);
                // Remove from cb
                cb_players.Items.Remove(cb_players.Items[cb_players.SelectedIndex]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: No Item Selected");
            }

        }

        private void btn_secondAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Add to lb
                lb_secondTeam.Items.Add(cb_players.Items[cb_players.SelectedIndex]);
                // Remove from cb
                cb_players.Items.Remove(cb_players.Items[cb_players.SelectedIndex]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: No Item Selected");
            }

        }

        private void btn_firstRmv_Click(object sender, EventArgs e)
        {
            try
            {
                // Add to cb
                cb_players.Items.Add(lb_firstTeam.Items[lb_firstTeam.SelectedIndex]);
                // Remove from lb   
                lb_firstTeam.Items.Remove(lb_firstTeam.Items[lb_firstTeam.SelectedIndex]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: No Item Selected");
            }
            
            
        }

        private void btn_secondRmv_Click(object sender, EventArgs e)
        {
            try
            {
                // Add to cb
                cb_players.Items.Add(lb_secondTeam.Items[lb_secondTeam.SelectedIndex]);
                // Remove from lb
                lb_secondTeam.Items.Remove(lb_secondTeam.Items[lb_secondTeam.SelectedIndex]);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: No Item Selected");
            }


        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            for (; ; )
            {
                try
                {
                    cb_players.Items.Add(lb_firstTeam.Items[0]);
                    lb_firstTeam.Items.Remove(lb_firstTeam.Items[0]);
                }
                // Loop until it breaks something
                catch { break; }

                
            }

            for (; ; )
            {
                try
                {
                    cb_players.Items.Add(lb_secondTeam.Items[0]);
                    lb_secondTeam.Items.Remove(lb_secondTeam.Items[0]);
                }
                // Loop until it breaks something
                catch { break; }
                
            }



            

            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Call restart method to ensure all names are returned to cb_players before writing to file
            btn_Restart_Click(sender, e);

            try
            {
                string buffer;
                StreamWriter outputFile = File.CreateText("Players.txt");

               
                foreach(var item in cb_players.Items)
                {
                    buffer = item.ToString();
                    outputFile.WriteLine(buffer);
                }
               
                outputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
