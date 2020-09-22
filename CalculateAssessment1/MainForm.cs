using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateAssessment1
{
    public partial class MainForm : Form
    {
        TemplateAssessment1.LogicClass Logic = new LogicClass();
        public MainForm()
        {
            InitializeComponent();
        }

        private void GunShootButton_Click(object sender, EventArgs e)
        {
             
            // i am playing a audio file
            SoundPlayer sound = new SoundPlayer(CalculateAssessment1.Properties.Resources.GunSound);
            sound.Play();
            Logic.GunShootButton();

        }

        private void ShootAwayButton_Click(object sender, EventArgs e)
        {
            Logic.ShootAwayButton();

        }
    }

    internal class LogicClass : TemplateAssessment1.LogicClass
    {
    }
}
