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
using System.Threading;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;



namespace generalformUI
{
    public partial class pdfreader : Form
    {
        String readThis;
        SpeechSynthesizer sps = new SpeechSynthesizer();
        public pdfreader()
        {
            InitializeComponent();
        }

        private void pdfreader_Load(object sender, EventArgs e)
        {
            readbutton.Enabled = false;
            pausebutton.Enabled = false;
            Resumebuton.Enabled = false;
            Stopbutton.Enabled = false;
            trackBar1.Enabled = false;
        }
        public void readpdf()
        {
            pausebutton.Enabled = true;
            Resumebuton.Enabled = true;
            trackBar1.Enabled = true;
            Stopbutton.Enabled = true;
            readbutton.BringToFront();
            button2.SendToBack();


            sps.Dispose();

            sps = new SpeechSynthesizer();

            sps.SpeakAsync(readThis);



            sps.Volume = trackBar1.Value;
        }
        private void openfilebutton_Click(object sender, EventArgs e)
        {


            rtfData.SendToBack();
            axAcroPDF1.BringToFront();

            button1.Enabled = false;
            openfilebutton.Enabled = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                readbutton.Enabled = true;
                readbutton.BringToFront();
                pausebutton.Enabled = false;
                Resumebuton.Enabled = false;
                Stopbutton.Enabled = false;
                trackBar1.Enabled = false;
                button2.Enabled = false;
                button2.SendToBack();
                String location = openFileDialog1.FileName;
                axAcroPDF1.src = location;
                PdfReader reader = new PdfReader(location);
                for (int page = 1; page < reader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy item = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
                    string currentpage = PdfTextExtractor.GetTextFromPage(reader, page, item);
                    readThis += currentpage;
                }

            }

       


        }



            private void readbutton_Click(object sender, EventArgs e)
            {

            readpdf();
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

            private void timer1_Tick(object sender, EventArgs e)
            {
              
            }



            private void button1_Click(object sender, EventArgs e)
            {
                rtfData.BringToFront();
                axAcroPDF1.SendToBack();
           
            pausebutton.Enabled = false;
            readbutton.Enabled = false;
            Resumebuton.Enabled = false;
            Stopbutton.Enabled = false;
            trackBar1.Enabled = false;

                button1.Enabled = false;
                openfilebutton.Enabled = false;

                using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "Word 97-2003|*.doc|Word Document|*.docx|Text Document|*.txt" })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    object readOnly = false;
                        object visible = true;
                        object save = false;
                        object filename = ofd.FileName;
                        object newTemplate = false;
                        object docType = 0;
                        object missing = Type.Missing;
                        Microsoft.Office.Interop.Word.Document document;
                        Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application() { Visible = false };
                        document = application.Documents.Open(ref filename, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref visible, ref missing, ref missing, ref missing, ref missing);
                        document.ActiveWindow.Selection.WholeStory();
                        document.ActiveWindow.Selection.Copy();
                        IDataObject dataObject = Clipboard.GetDataObject();
                        rtfData.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
                        application.Quit(ref missing, ref missing, ref missing);
                    }
                }
            }

        public void read ()
        {
            readbutton.SendToBack();
            button2.BringToFront();
            rtfData.BringToFront();
            axAcroPDF1.SendToBack();
            button2.Enabled = true;
            pausebutton.Enabled = true;

            Resumebuton.Enabled = true;
            Stopbutton.Enabled = true;
            trackBar1.Enabled = true;
            if (rtfData.Text != "")
            {
                timer1.Start();
                sps.Dispose();
                sps = new SpeechSynthesizer();
                sps.SpeakAsync(rtfData.Text);
                sps.Volume = trackBar1.Value;
            }
            else
                MessageBox.Show("Write Something in text box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

            private void button2_Click(object sender, EventArgs e)
            {
            read();
            }

            private void axAcroPDF1_OnError(object sender, EventArgs e)
            {

            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

        private void pdfreader_Load_1(object sender, EventArgs e)
        {
            pausebutton.Enabled = false;
            readbutton.Enabled = false;
            Resumebuton.Enabled = false;
            Stopbutton.Enabled = false;
            button2.Enabled = false;
            trackBar1.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
          if (  rtfData.Text != "")
            {

                read();
            }
          else 
            readpdf();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
