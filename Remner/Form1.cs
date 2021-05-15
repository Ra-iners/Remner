using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remner
{
    public partial class Remner : Form
    {
        public Remner()
        {
            InitializeComponent();
        }
        int Pets = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Pets++;
            PetCounter.Text = $"Rai has been petted {Pets} times";
            switch(Pets)
            {
                case 621:
                    MessageBox.Show("OwO~");
                    break;
            }
        }

        private async void BlinkLights_Tick(object sender, EventArgs e)
        {
            PetPetButton.BackColor = Color.FromArgb(243, 121, 140);
            await Task.Delay(250);
            PetPetButton.BackColor = Color.FromArgb(203, 81, 100);
            await Task.Delay(250);

        }

        private async void BlinkExc_Tick(object sender, EventArgs e)
        {
            ExclamationMark.ForeColor = Color.Red;
            await Task.Delay(125);
            ExclamationMark.ForeColor = Color.Black;
            await Task.Delay(125);

        }
    }
}
