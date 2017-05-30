using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1RitchiePerera
{
    public partial class Form1 : Form
    {

        int counter = 0;

        public Form1()
        {
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            counter = 0;



            play.Enabled = false;

            close.TabIndex = 0;


           
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void england_CheckedChanged(object sender, EventArgs e)
        {

            if (sender is RadioButton)
            {
                groupA.Image = Properties.Resources.eng;
                groupA.SizeMode = PictureBoxSizeMode.Zoom;
                teamA.Text = england.Text;



                if (counter.Equals(0) || counter.Equals(1))
                {
                    counter++;
         //           counterval.Text = Convert.ToString(counter);
                }
                if (counter.Equals(2))
                {
                    play.Enabled = true;
                }


         //       counterval.Text = Convert.ToString(counter);
            }
            teamAscore.Text = null;
            teamBscore.Text = null;
            finResult.Text = null;


            //    counterval.Text = Convert.ToString(counter);

        }
        private void india_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                groupA.Image = Properties.Resources.ind;
                groupA.SizeMode = PictureBoxSizeMode.Zoom;
                teamA.Text = india.Text;
                if (counter.Equals(0) || counter.Equals(1))
                {
                    counter++;
            //        counterval.Text = Convert.ToString(counter);
                }
                if (counter.Equals(2))
                {
                    play.Enabled = true;
                }
          //      counterval.Text = Convert.ToString(counter);
            }
            teamAscore.Text = null;
            teamBscore.Text = null;
            finResult.Text = null;


            //   counterval.Text = Convert.ToString(counter);
        }

        private void newZealand_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                groupA.Image = Properties.Resources._new;
                teamA.Text = newZealand.Text;

                if (counter.Equals(0) || counter.Equals(1))
                {
                    counter++;
                    //counterval.Text = Convert.ToString(counter);
                }
                if (counter.Equals(2))
                {
                    play.Enabled = true;

                }
              //  counterval.Text = Convert.ToString(counter);
            }

            teamAscore.Text = null;
            teamBscore.Text = null;
            finResult.Text = null;


            //   counterval.Text = Convert.ToString(counter);


        }

        private void southAfrica_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                groupA.Image = Properties.Resources.soa;
                teamA.Text = southAfrica.Text;

                if (counter.Equals(0) || counter.Equals(1))
                {
                    counter++;
           //         counterval.Text = Convert.ToString(counter);
                }
                if (counter.Equals(2))
                {
                    play.Enabled = true;
                }


          //      counterval.Text = Convert.ToString(counter);
            }
            teamAscore.Text = null;
            teamBscore.Text = null;
            finResult.Text = null;


            //     counterval.Text = Convert.ToString(counter);

        }

        private void westIndies_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                groupA.Image = Properties.Resources.wes;
                teamA.Text = westIndies.Text;


                if (counter.Equals(0) || counter.Equals(1))
                {
                    counter++;
          //          counterval.Text = Convert.ToString(counter);
                }

                if (counter.Equals(2))
                {
                    play.Enabled = true;
                }

         //       counterval.Text = Convert.ToString(counter);
            }
            teamAscore.Text = null;
            teamBscore.Text = null;
            finResult.Text = null;


            //     counterval.Text = Convert.ToString(counter);
        }

        private void srilanka_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                groupB.Image = Properties.Resources.sri;
                teamB.Text = srilanka.Text;

                if (counter.Equals(0) || counter.Equals(1))
                {
                    counter++;
             //       counterval.Text = Convert.ToString(counter);
                }

                if (counter.Equals(2))
                {
                    play.Enabled = true;
                }

           //     counterval.Text = Convert.ToString(counter);
            }
            teamAscore.Text = null;
            teamBscore.Text = null;
            finResult.Text = null;


            //       counterval.Text = Convert.ToString(counter);
        }

        private void pakistan_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                groupB.Image = Properties.Resources.pak;
                teamB.Text = pakistan.Text;



                if (counter.Equals(0) || counter.Equals(1))
                {
                    counter++;
           //         counterval.Text = Convert.ToString(counter);
                }
                if (counter.Equals(2))
                {
                    play.Enabled = true;
                }

     //           counterval.Text = Convert.ToString(counter);
            }
            teamAscore.Text = null;
            teamBscore.Text = null;
            finResult.Text = null;


            //      counterval.Text = Convert.ToString(counter);

        }

        private void australia_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                groupB.Image = Properties.Resources.aus;
                teamB.Text = australia.Text;


                if (counter.Equals(0) || counter.Equals(1))
                {
                    counter++;
       //             counterval.Text = Convert.ToString(counter);
                }
                if (counter.Equals(2))
                {
                    play.Enabled = true;
                }
      //          counterval.Text = Convert.ToString(counter);
            }
            teamAscore.Text = null;
            teamBscore.Text = null;
            finResult.Text = null;


            //        counterval.Text = Convert.ToString(counter);
        }

        private void bangladesh_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                groupB.Image = Properties.Resources.ban;
                teamB.Text = bangladesh.Text;


                if (counter.Equals(0) || counter.Equals(1))
                {
                    counter++;
       //             counterval.Text = Convert.ToString(counter);
                }
                if (counter.Equals(2))
                {
                    play.Enabled = true;
                }


        //        counterval.Text = Convert.ToString(counter);
            }
            teamAscore.Text = null;
            teamBscore.Text = null;
            finResult.Text = null;


            //        counterval.Text = Convert.ToString(counter);

        }

        private void zimbabwe_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                groupB.Image = Properties.Resources.zim;
                teamB.Text = zimbabwe.Text;

                if (counter.Equals(0) || counter.Equals(1))
                {
                    counter++;
    //                counterval.Text = Convert.ToString(counter);
                }
                if (counter.Equals(2))
                {
                    play.Enabled = true;
                }

     //           counterval.Text = Convert.ToString(counter);
            }
            teamAscore.Text = null;
            teamBscore.Text = null;
            finResult.Text = null;


            //        counterval.Text = Convert.ToString(counter);
        }

        private void reset_Click(object sender, EventArgs e)
        {
          
                england.Checked = false;
                india.Checked = false;
                newZealand.Checked = false;
                southAfrica.Checked = false;
                westIndies.Checked = false;


                srilanka.Checked = false;
                australia.Checked = false;
                bangladesh.Checked = false;
                pakistan.Checked = false;
                zimbabwe.Checked = false;

                teamAscore.Text = null;
                teamBscore.Text = null;
                finResult.Text = null;
                close.TabIndex = 0;
                counter = 0;
                //         counterval.Text = Convert.ToString(counter);
                play.Enabled = false;

            groupA.Image = null;
            groupB.Image = null;
            teamA.Text = null;
            teamB.Text = null;
            
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (counter.Equals(2))
            {
                play.Enabled = true;


                Random rnd = new Random();
                int runsA = rnd.Next(100, 340);

                int runsB = rnd.Next(100, 340);

                teamAscore.Text = Convert.ToString(runsA);
                teamBscore.Text = Convert.ToString(runsB);

                String result = "";
                String tie = "tie";
                if (runsA > runsB)
                {
                    result = teamA.Text + " won";
                   
                    finResult.Text = result;
                }
                else if (runsB > runsA)
                {
                    result = teamB.Text + " won";
                    
                    finResult.Text = result;
                }

                else
                    
                    finResult.Text = tie;
            }
                }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupA_Click(object sender, EventArgs e)
        {

        }
    }
    }


