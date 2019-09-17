using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandInterfaceSMC100;

namespace newport
{
    public partial class Form1 : Form
    {
        SMC100 SMC;
        double pos;
        string err;
        int adress;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SMC = new SMC100();
            string deviceNumber = SMC.GetDevices()[0];
            int ans = SMC.OpenInstrument(deviceNumber);
            DeviceBox.Text = deviceNumber;
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            
            adress = int.Parse(AdressBox.Text);
            double step = double.Parse(StepBox.Text);
            SMC.TP(adress, out pos, out err).ToString();
            int ans = SMC.PR_Set(adress, step, out err);
            PosBox.Text = pos.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            adress = int.Parse(AdressBox.Text);
            double step = double.Parse(StepBox.Text);
            SMC.TP(adress, out pos, out err).ToString();
            int ans = SMC.PR_Set(adress, -step, out err);
            PosBox.Text = pos.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SMC.CloseInstrument();
        }

    }
}
