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
using System.Diagnostics;
using System.Speech.Synthesis.TtsEngine;
using System.IO;
using AIMLbot;
using iTextSharp.text;
using System.Threading;
using Org.BouncyCastle.Crypto.Parameters;

namespace generalformUI
{
    public partial class voicecommand : Form
    {
        SpeechSynthesizer sps = new SpeechSynthesizer();

        Boolean winto = true;


        public Boolean search = false;

        Choices list = new Choices();


        public voicecommand()
        {
            InitializeComponent();

        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;

            Choices list = new Choices();


            SpeechRecognitionEngine rec = new SpeechRecognitionEngine();

            list.Add(new string[] { "Recording", "Cp","Hello","Hoichekaro", "School", "Rsc", "Software", "Math", "Operating", "Compiler","Sdp", "Bujcho","jimadam","bishumunshi" , "search for", "How are you", "winto", "what time is it", "what is the day", "sleep", "Open All", "open skype", "close skype", "Maximize", "Minimize", "search for", "cat", "dog", "Open Youtube", "pen", "BUBT", "Open BUBT website", "Open facebook", "covid 19", "corona virus", "book", "chair", "pen", "nokia phone", "corona update", "what is your name?", "wintr", "What is your age", "close chrome", "open chrome", "What is the current situation of Covid 19", "work perfectly,Thank you", "Shekh mujibor rahman", "tain", "kuyakata", "sajek","vehicles"});

            list.Add(File.ReadAllLines(@"D:\my project list\Ai\comd.txt"));
            Grammar gr = new Grammar(new GrammarBuilder(list));

            try
            {
                rec.RequestRecognizerUpdate();
                rec.LoadGrammar(gr);
                rec.SpeechRecognized += rec_SpeechRecognized;

                rec.SetInputToDefaultAudioDevice();

                rec.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch
            {
                return;
            }

           sps.SelectVoiceByHints(VoiceGender.Female);
        }



        public void clear()
        {
            // outputtxtbox.Text = " ";
            label5.Text = "";


        }

        public void say(String h)
        {
            sps.Speak(h);
            clear();
            // outputtxtbox.AppendText(h);
            label5.Text = h;
        }

        public void killprog2(String s)
        {
            System.Diagnostics.Process[] procs = null;
            try
            {
                procs = Process.GetProcessesByName(s);
                Process prog = procs[0];
                if (! prog.HasExited)
                {
                    prog.Kill();
                }
            }
          
           finally
            {
                if (procs != null)
                {
                   foreach(  Process p in procs)
                    {
                        p.Dispose();
                    }
                }
            }
        }

        public void killprog()
        {
            SendKeys.Send("%{F4}");
        }

        public void Maximized()
        {
            WindowState = FormWindowState.Maximized;
        }

        public void Minimized()
        {
            WindowState = FormWindowState.Minimized;
        }


        
      
        private void rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {


            String r = e.Result.Text;

            if (search)
            {
                Process.Start("https://www.google.com/#q=" + r);
                search = false;

            }
            if (r == "wintr" || r == "winto")
            {

                winto = true;
                label2.Text = "Mood : ON";
                say("yess Boss");
            }


            if (r == "sleep")
            {
                winto = false;
                label2.Text = "Mood : OFF";
            }




            if (winto == true && search == false)
            {
                if (r == "search for")
                {
                    search = true;
                }

                if (r == "Hello")
                {
                    say(" hi");

                }

                if (r == "what is your name?")
                {
                    say("My Name is wintr");
                }
                if (r == "Rsc")
                {
                    Process.Start("https://meet.google.com/hcj-nzfh-qzf");
                }
                if (r == "School")
                {
                    Process.Start("https://meet.google.com/hcj-nzfh-qzf");
                }
                if (r == "Software")
                {
                    Process.Start("https://meet.google.com/nks-dqzy-byk");
                }
                if (r == "Math")
                {
                    Process.Start("https://meet.google.com/enu-jxgn-epq");
                }
                if (r == "Operating")
                {
                    Process.Start("https://meet.google.com/twe-ahww-ewo");
                }
                if (r == "Cp")
                {
                    Process.Start("https://meet.google.com/ijk-wnxo-zoi");
                }
                if (r == "Compiler")
                {
                    Process.Start("https://meet.google.com/ijk-wnxo-zoi");
                }
                if (r == "Sdp")
                {
                    Process.Start("https://meet.google.com/jfy-tpgi-nen");
                }

                if (r == "How are you")
                {
                    say(" I am fine ");

                }

                if (r == "open skype")
                {
                    Process.Start(@"C:\Program Files (x86)\Microsoft\Skype for Desktop\Skype.exe");


                }
                if (r == "close skype")
                {
                    killprog();

                    //killprog2("Skype.bin");


                }

                if (r == "open chrome")
                {
                    Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
                }
                if (r == "Recording")
                {
                    Process.Start(@"F:\instalation\OBS\obs-studio\bin\64bit\obs64.exe");
                }

                if (r == "close chrome")
                {
                   // killprog();
                }

                if (r == "What is the current situation of Covid 19")
                {
                    say("Very dangerous.Stay Home , Stay save.");
                }

                if (r== "What is your age")
                {
                    say(" Infinity light year");
                }
                if (r == "Bujcho")
                {
                    say("jimadam");
                }
                if (r == "Hoichekaro")
                {
                    say("jimadam");
                }

                if (r == "You work perfectly,Thank you")
                {
                    say(" Hamm.... Welcome.Stay home Stay Safe.");
                }

                if (r == "Maximize")
                {
                    Maximized();

                }
                if (r == "Minimize")
                {
                    Minimized();

                }

                if (r == "what time is it")
                {
                    say(DateTime.Now.ToString("h:mm tt"));

                }
                if (r == "what is the day")
                {
                    say(DateTime.Now.ToString("M/d/yyyy"));

                }

                //if (r == " fb ")
                //{
                //    Process.Start(" http ");
                //    say(DateTime.Now.ToString(" M/d/yyyy","or" ," h:mm tt"));
                //}

                if (r == "Open Youtube")
                {
                    Process.Start("https://www.youtube.com/");
                    //Process.Start("https://www.facebook.com/");
                }
                if (r == "Open facebook")
                {
                    //Process.Start("https://www.bubt.edu.bd/");
                    Process.Start("https://www.facebook.com/");
                }
                if (r == "Open BUBT website")
                {
                    Process.Start("https://www.bubt.edu.bd/");
                }
                if (r == "corona update")
                {
                   Process.Start("https://www.worldometers.info/coronavirus/");
                }


            }
            // inputtextbox.Text = " ";
            label4.Text = "";
            //  inputtextbox.AppendText(r);
            label4.Text = r;
        }
 
        private void voicecommand_Load(object sender, EventArgs e)
        {
  

        }

        

        
    }
}
