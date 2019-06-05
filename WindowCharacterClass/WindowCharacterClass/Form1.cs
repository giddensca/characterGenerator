using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace WindowCharacterClass
{
    /* Programmer: Chancynn Giddens
     * Date: 10-26-2018 v2
     * Purpose: Incorporate Character Class file into windows programming This is version 2.0 of the program
     * Date: 11-27-18 v3
     */
    public partial class frmNameAttributes : Form
    {

        //Global Varaible 
        Character charClass = new Character();
        AboutForm openingScreen = new AboutForm();
        SoundPlayer laugh = new SoundPlayer(WindowCharacterClass.Properties.Resources.Evil_Laugh_Cackle_SoundBible_com_957382653);

        Character[] Players = new Character[5];
        int buttonIndex = 0;

        public frmNameAttributes()
        {
            InitializeComponent();
        }

        private void Intelligence()
        {
            //Algorithm to Calculate a player's perception
            //Use if statement to make sure the number can be calculated
            if (txtHealth.Text != string.Empty && txtStrength.Text != string.Empty)
            {
                //Declaring variables to help gather data from a string and convert it to a usable integer
                int health = 0;
                int strength = 0;
                double eq1 = 0;
                double eq2 = 0;
                health = Convert.ToInt32(txtHealth.Text);
                strength = Convert.ToInt32(txtStrength.Text);

                //Equation for final calculation
                eq1 = (((health * (1 / 4.0)) + 5));
                eq2 = (strength * (1/50.0));
                txtIntel.Text = (eq1 / eq2).ToString("n0");
            }
        }
        private void Wisdom()
        {
            //Calculate Wisdom
            if (txtEndurance.Text != string.Empty && txtLuck.Text != string.Empty)
            {
                int endurance = 0;
                int luck = 0;
                double eq1 = 0;
                double eq2 = 0;
                endurance = Convert.ToInt32(txtEndurance.Text);
                luck = Convert.ToInt32(txtLuck.Text);

                //Equation for final calculation
                eq1 = (((endurance * (1 / 4.0)) + 5));
                eq2 = (luck * (1 / 50.0));
                txtWisdom.Text = (eq1 / eq2).ToString("n0");
            }
        }
        private void WillPower()
        {
            //Calculate WillPower
            if (txtAwareness.Text != string.Empty && txtCharisma.Text != string.Empty)
            {
                int awareness = 0;
                int charisma = 0;
                double eq1 = 0;
                double eq2 = 0;
                awareness = Convert.ToInt32(txtAwareness.Text);
                charisma = Convert.ToInt32(txtCharisma.Text);

                //Equation for final calculation
                eq1 = (((awareness * (1 / 4.0)) + 5));
                eq2 = (charisma * (1 / 50.0));
                txtWillPower.Text = (eq1 / eq2).ToString("n0");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                Players[i] = new Character();
            }
            displayCharacter(Players[0]);
        }
        private void displayCharacter(Character data2show)
        {
            txtFirstName.Text = data2show.firstName;
            txtLastName.Text = data2show.lastName;
            comboBox1.SelectedItem = data2show.Race;
            comboBox2.SelectedItem = data2show.Gender;
            txtHealth.Text = data2show.health.ToString("n0");
            txtStrength.Text = data2show.strength.ToString("n0");
            txtEndurance.Text = data2show.endurance.ToString("n0");
            txtLuck.Text = data2show.luck.ToString("n0");
            txtCharisma.Text = data2show.charisma.ToString("n0");
            txtAwareness.Text = data2show.awareness.ToString("n0");
            txtIntel.Text = data2show.intelligence.ToString("n0");
            txtWisdom.Text = data2show.wisdom.ToString("n0");
            txtWillPower.Text = data2show.willpower.ToString("n0");
           if (data2show.helmet == "Daedric")
            {
                rdbtnDaedric.Checked = true;
            }
           else if (data2show.helmet == "Dwarven")
            {
                rdbtnDwarven.Checked = true;
            }
            else if (data2show.helmet == "Elvish")
            {
                rdbtnElvish.Checked = true;
            }

            if (data2show.chestPlate == "Daedric")
            {
                rdbtnDChest.Checked = true;
            }
            else if (data2show.chestPlate == "Dwarven")
            {
                rdbtnDwChest.Checked = true;
            }
            else if (data2show.chestPlate == "Elvish")
            {
                rdbtnEChest.Checked = true;
            }

            if (data2show.leggings == "Daedric")
            {
                rdbtnDLeg.Checked = true;
            }
            else if (data2show.leggings == "Dwarven")
            {
                rdbtnDwLeg.Checked = true;
            }
            else if (data2show.leggings == "Elvish")
            {
                rdbtnELeg.Checked = true;
            }
        }

        //Collect data from user on Simple First Last Race
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

            Players[buttonIndex].firstName = txtFirstName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

            Players[buttonIndex].lastName = txtLastName.Text;
        }

        private void txtRace_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFullName_Click(object sender, EventArgs e)
        {
            //Irrelevant code from previous version
            //MessageBox.Show(charClass.fullName());
        }

        //Check for valid attribute inputs as well as collecting data
        private void txtHealth_TextChanged(object sender, EventArgs e)
        {
            int numericalValue;
            //Checks to see whether or not their should be valid or invalid data

            if (int.TryParse(txtHealth.Text, out numericalValue))
            {

                charClass.health = numericalValue;
                Intelligence();
                Players[buttonIndex].health = int.Parse(txtHealth.Text);
            }
            else
            {
                if (txtHealth.Text == string.Empty)
                {
                    txtHealth.BackColor = Color.White;
                }
            }
            
        }

        private void txtStrength_TextChanged(object sender, EventArgs e)
        {
            int numericalValue;

            //Checks to see whether or not their should be valid or invalid data
            if (int.TryParse(txtStrength.Text, out numericalValue))
            {
                
                charClass.strength = numericalValue;
                Intelligence();
                Players[buttonIndex].strength = int.Parse(txtStrength.Text);
            }
            else
            {
                if (txtStrength.Text == string.Empty)
                {
                    txtStrength.BackColor = Color.White;
                }
            }
            
        }

        private void txtEndurance_TextChanged(object sender, EventArgs e)
        {
            int numericalValue;
            //Checks to see whether or not their should be valid or invalid data
            if (int.TryParse(txtEndurance.Text, out numericalValue))
            {
                charClass.endurance = numericalValue;
                Wisdom();
                Players[buttonIndex].endurance = int.Parse(txtEndurance.Text);
            }
            else
            {
                if (txtEndurance.Text == string.Empty)
                {
                    txtEndurance.BackColor = Color.White;
                }
            }
        }


        private void txtLuck_TextChanged(object sender, EventArgs e)
        {
            int numericalValue;
            //Checks to see whether or not their should be valid or invalid data
            if (int.TryParse(txtLuck.Text, out numericalValue))
            {
                charClass.luck = numericalValue;
                Wisdom();
                Players[buttonIndex].luck = int.Parse(txtLuck.Text);
            }
            else
            {
                if (txtLuck.Text == string.Empty)
                {
                    txtLuck.BackColor = Color.White;
                }
            }
        }

        private void txtAwareness_TextChanged(object sender, EventArgs e)
        {
            int numericalValue;
            //Checks to see whether or not their should be valid or invalid data
            if (int.TryParse(txtAwareness.Text, out numericalValue))
            {
                charClass.awareness = numericalValue;
                WillPower();
                Players[buttonIndex].awareness = int.Parse(txtAwareness.Text);
            }
            else
            {
                if (txtAwareness.Text == string.Empty)
                {
                    txtAwareness.BackColor = Color.White;
                }
            }
        }

        private void txtCharisma_TextChanged(object sender, EventArgs e)
        {
            int numericalValue;
            //Checks to see whether or not their should be valid or invalid data
            if (int.TryParse(txtCharisma.Text, out numericalValue))
            {
                charClass.charisma = numericalValue;
                WillPower();
                Players[buttonIndex].charisma = int.Parse(txtCharisma.Text);
            }
            else
            {
                if (txtCharisma.Text == string.Empty)
                {
                    txtCharisma.BackColor = Color.White;
                }
            }
        }
        private void btnAttributes_Click(object sender, EventArgs e)
        {
            //Displays the second form

        }


        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //Decides what character photo is loaded
        //    //Reason for order combo2 then combo1. Forces the user to go in particular order so the correct image can be loaded
        //    //Here index 0,0 means the choices were selected as human and male
        //    if (comboBox2.SelectedIndex == 0 && comboBox1.SelectedIndex == 0)
        //    {
        //        picCharacter.Image = WindowCharacterClass.Properties.Resources.male_blank;
        //        Players[buttonIndex].Race = comboBox1.SelectedItem.ToString();
        //        Players[buttonIndex].Gender = comboBox2.SelectedItem.ToString();

        //    }
        //    //Index 0,1 shows elvish male
        //    else if (comboBox2.SelectedIndex == 0 && comboBox1.SelectedIndex == 1)
        //    {
        //        picCharacter.Image = WindowCharacterClass.Properties.Resources.elf_blank;
        //        Players[buttonIndex].Race = comboBox1.SelectedItem.ToString();
        //        Players[buttonIndex].Gender = comboBox2.SelectedItem.ToString();
        //    }
        //    //Index 1,0 says human female
        //    else if (comboBox2.SelectedIndex == 1 && comboBox1.SelectedIndex == 0)
        //    {
        //        picCharacter.Image = WindowCharacterClass.Properties.Resources.female_blank;
        //        Players[buttonIndex].Race = comboBox1.SelectedItem.ToString();
        //        Players[buttonIndex].Gender = comboBox2.SelectedItem.ToString();
        //    }
        //    //Index 1,1 elvish female
        //    else if (comboBox2.SelectedIndex == 1 && comboBox1.SelectedIndex == 1)
        //    {
        //        picCharacter.Image = WindowCharacterClass.Properties.Resources.elf_female_blank;
        //        Players[buttonIndex].Race = comboBox1.SelectedItem.ToString();
        //        Players[buttonIndex].Gender = comboBox2.SelectedItem.ToString();
        //    }
        //}

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Decides what character photo is loaded
            //Reason for order combo2 then combo1. Forces the user to go in particular order so the correct image can be loaded
            //Here index 0,0 means the choices were selected as human and male
            if (comboBox2.SelectedIndex == 0 && comboBox1.SelectedIndex == 0)
            {
                picCharacter.Image = WindowCharacterClass.Properties.Resources.male_blank;
                Players[buttonIndex].Race = comboBox1.SelectedItem.ToString();
                Players[buttonIndex].Gender = comboBox2.SelectedItem.ToString();

            }
            //Index 0,1 shows elvish male
            else if (comboBox2.SelectedIndex == 0 && comboBox1.SelectedIndex == 1)
            {
                picCharacter.Image = WindowCharacterClass.Properties.Resources.elf_blank;
                Players[buttonIndex].Race = comboBox1.SelectedItem.ToString();
                Players[buttonIndex].Gender = comboBox2.SelectedItem.ToString();
            }
            //Index 1,0 says human female
            else if (comboBox2.SelectedIndex == 1 && comboBox1.SelectedIndex == 0)
            {
                picCharacter.Image = WindowCharacterClass.Properties.Resources.female_blank;
                Players[buttonIndex].Race = comboBox1.SelectedItem.ToString();
                Players[buttonIndex].Gender = comboBox2.SelectedItem.ToString();
            }
            //Index 1,1 elvish female
            else if (comboBox2.SelectedIndex == 1 && comboBox1.SelectedIndex == 1)
            {
                picCharacter.Image = WindowCharacterClass.Properties.Resources.elf_female_blank;
                Players[buttonIndex].Race = comboBox1.SelectedItem.ToString();
                Players[buttonIndex].Gender = comboBox2.SelectedItem.ToString();
            }
        }

        private void rdbtnDaedric_CheckedChanged(object sender, EventArgs e)
        {
            Players[buttonIndex].helmet = "Daedric";
        }

        private void txtPerception_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbtnDLeg_CheckedChanged(object sender, EventArgs e)
        {
            Players[buttonIndex].leggings = "Daedric";
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            buttonIndex++;
            displayCharacter(Players[buttonIndex]);
            btnBack.Enabled = true;
            if (buttonIndex == 4) btnForward.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            buttonIndex--;
            displayCharacter(Players[buttonIndex]);
            btnForward.Enabled = true;
            if (buttonIndex == 0) btnBack.Enabled = false;
        }

        private void txtIntel_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnDChest_CheckedChanged(object sender, EventArgs e)
        {
            Players[buttonIndex].chestPlate = "Daedric";
        }

        private void rdbtnElvish_CheckedChanged(object sender, EventArgs e)
        {
            Players[buttonIndex].helmet = "Elvish";
        }

        private void rdbtnEChest_CheckedChanged(object sender, EventArgs e)
        {
            Players[buttonIndex].chestPlate = "Elvish";
        }

        private void rdbtnELeg_CheckedChanged(object sender, EventArgs e)
        {
            Players[buttonIndex].leggings = "Elvish";
        }

        private void rdbtnDwarven_CheckedChanged(object sender, EventArgs e)
        {
            Players[buttonIndex].helmet = "Dwarven";
        }

        private void rdbtnDwChest_CheckedChanged(object sender, EventArgs e)
        {
            Players[buttonIndex].chestPlate = "Dwarven";
        }

        private void rdbtnDwLeg_CheckedChanged(object sender, EventArgs e)
        {
            Players[buttonIndex].leggings = "Dwarven";
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Task.Delay(150);
            openingScreen.Show();
            laugh.PlaySync();
        }
    }
}
