using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Speech;

namespace generalformUI
{
    public partial class Speeking : Form
    {


        SpeechSynthesizer sps = new SpeechSynthesizer();
        
        public Speeking()
        {
            InitializeComponent();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            for (panel1.Height = 0; panel1.Height <= 10; panel1.Height += 1)
            {
                
                panel1.Height += 1;
                panel1.Height -= 1;
                
            }
           

            for (bunifuGradientPanel1.Height = 0; bunifuGradientPanel1.Height <= 15; bunifuGradientPanel1.Height += 1)
            {
                
                bunifuGradientPanel1.Height +=1;
                bunifuGradientPanel1.Height -=1;
                

            }

            //val += 1;



            //if (bunifuCircleProgressbar1.Value == 100)
            //{
            //    increase 
            //    /give msg 

            // stop timer


            //}
        }
        
           
       

        private void iconButton1_Click(object sender, EventArgs e)
        {
            pausebutton.Enabled = true;
            Resumebuton.Enabled = true;


           
            if (textBox1.Text != "")
            {
                timer1.Start();
                sps.Dispose();
                sps = new SpeechSynthesizer();
                sps.SpeakAsync(textBox1.Text);
                sps.Volume = trackBar1.Value;
            }
            else
                MessageBox.Show("Write Something in text box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

           
        }

        private void pausebutton_Click(object sender, EventArgs e)
        {
            if (sps != null)
            {
                if (sps.State == SynthesizerState.Speaking)
                {

                    sps.Pause();
                }
                timer1.Stop();
            }
        }

        private void Resumebuton_Click(object sender, EventArgs e)
        {
            if (sps != null)
            {
                if (sps.State == SynthesizerState.Paused)
                {
                    timer1.Start();

                    sps.Resume();
                }

            }
        }

        private void Stopbutton_Click(object sender, EventArgs e)
        {
            if (sps != null)
            {
                sps.Dispose();
                timer1.Stop();
            }
            Resumebuton.Enabled = false;
            pausebutton.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                timer1.Start();
                sps.Dispose();
                sps = new SpeechSynthesizer();
                sps.SpeakAsync(textBox1.Text);
                sps.Volume = trackBar1.Value;
            }
            else
                MessageBox.Show("Write Something in text box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
