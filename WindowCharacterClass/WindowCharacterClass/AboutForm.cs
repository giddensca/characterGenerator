using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowCharacterClass
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            ExtraFormSettings();
            SetAndStartTimer();

        }
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        bool fadeIn = true;
        bool fadeOut = false;


        private void SetAndStartTimer()
        {
            t.Interval = 100;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        private void ExtraFormSettings()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Opacity = 0.5;
            this.BackgroundImage = WindowCharacterClass.Properties.Resources.GetPersonaPhoto_1___1_;
        }

        void t_Tick(object sender, EventArgs e)
        {
            // Fade in by increasing the opacity of the slash to 1.0
            if (fadeIn)
            {
                if (this.Opacity < 1.0)
                {
                    this.Opacity += 0.02;
                }
                else // After fade in complete, begin fade out
                {
                    fadeIn = false;
                    fadeOut = true;
                }
            }
            else
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.02;
                }
                else
                {
                    fadeOut = false;
                }
            }
            if (!(fadeIn || fadeOut))
            {
                t.Stop();
                this.Close();
            }
        }
    }

}
