using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Speech.Synthesis.TtsEngine;
using System.IO;
using AIMLbot;



namespace generalformUI
{
    public partial class chatting : Form
    {
        SpeechSynthesizer sps = new SpeechSynthesizer();
        public chatting()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bot AI = new Bot();
            AI.loadSettings(); //It will Load Settings from its Config Folder with this code
            AI.loadAIMLFromFiles(); //With this Code It Will Load AIML Files from its AIML Folder
            AI.isAcceptingUserInput = false; //With this Code it will Disable UserInput For Now
            User myuser = new User("Tain", AI); //With This Code We Will Add The User Through AI/Bot
            AI.isAcceptingUserInput = true; //Now The User Input is Enabled Again with this Code
            Request r = new Request(inputtextbox.Text, myuser, AI); //With This Code it will Request The Response From AIML Folders
            Result res = AI.Chat(r); //With This Code It Will Get Result
            outputtxtbox.Text = res.Output; //With this Code It Will Write the Result of Textbox1 Response to Textbox2 text
                                            //Now Coding Is Finished!
                                            //Now Add/Copy & Paste AIML Folder & Config Folder to the Project Directory
                                            //Now Test the Bot
            if (outputtxtbox.Text != "")
            {
                sps.Dispose();

                sps = new SpeechSynthesizer();

                sps.SpeakAsync(outputtxtbox.Text);

                inputtextbox.Text = "";
            }
            else
                MessageBox.Show(" Write Some thing intext box");


        }

        private void speechbutton_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine s = new SpeechRecognitionEngine();
            Grammar words = new DictationGrammar();

            s.LoadGrammar(words);

            try
            {
                s.SetInputToDefaultAudioDevice();

                RecognitionResult result = s.Recognize();
                inputtextbox.Text = result.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                s.UnloadAllGrammars();

            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chatting_Load(object sender, EventArgs e)
        {
            inputtextbox.Focus();
           // inputtextbox.Text = "Write Your Message";
        }

        private void inputtextbox_Enter(object sender, EventArgs e)
        {
            if (inputtextbox.Text == "Write Your Message")
            {
                inputtextbox.Text = "";
                inputtextbox.ForeColor = Color.White;
            }
        }

        private void inputtextbox_Leave(object sender, EventArgs e)
        {
            if (inputtextbox.Text == "")
            {
                inputtextbox.Text = "Write Your Message";
                inputtextbox.ForeColor = Color.White;
            }
        }

        private void outputtxtbox_Enter(object sender, EventArgs e)
        {
            if ( outputtxtbox.Text == "Hi ... I am Winto . What is Your Name ?")
            {
                outputtxtbox.Text = "";
                outputtxtbox.ForeColor = Color.White;
            }

        }

        private void outputtxtbox_Leave(object sender, EventArgs e)
        {
            if (outputtxtbox.Text == "")
            {
                outputtxtbox.Text = "Hi ... I am Winto . What is Your Name ?";
                outputtxtbox.ForeColor = Color.Silver;
            }
        }
    }
}
