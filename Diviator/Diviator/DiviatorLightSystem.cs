using System;

using System.Windows.Forms;

namespace Diviator
{
    public partial class DiviatorLightSystem : Form
    {
        public bool circuit1 = false;
        public bool circuit2 = false;
        public void LigtOn()
        {
            if (circuit1 == true)
            {
                label1.Text = "turned on light is from closed Circuit 1";
            }
            else if (circuit2 == true)
            {
                label1.Text = "turned on light is from closed Circuit 2";
            }
            else
            {
                label1.Text = "It is Dark";
            }
        }
        private void OpenCircuit()
        {
            circuit2 = false;
            circuit1 = false;

        }

        public DiviatorLightSystem()
        {
            InitializeComponent();
            label1.Text = "";

        }

        private void diviator_ValueChanged(object sender, EventArgs e)
        {
            if (diviator.Value == diviator2.Value && (diviator.Value==1&&diviator2.Value==1) )
            {
                circuit1 = true;
                circuit2 = false;
                LigtOn();
            }
            else if (diviator.Value == diviator2.Value && (diviator.Value == 0 && diviator2.Value == 0))
            {
                circuit2 = true;
                circuit1 = false;
                LigtOn();
            }

            else
            {
                OpenCircuit();
                LigtOn();
            }
         }

        private void diviator2_ValueChanged(object sender, EventArgs e)
        {
            if (diviator.Value == diviator2.Value && (diviator.Value == 1 && diviator2.Value == 1))
            {
                circuit1 = true;
                circuit2 = false;
                LigtOn();
            } 
            else if (diviator.Value == diviator2.Value && (diviator.Value == 0 && diviator2.Value == 0))
            {
                circuit2 = true;
                circuit1 = false;
                LigtOn();
            }
            else
            {
                OpenCircuit();
                LigtOn();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LigtOn();
        }
    }
}