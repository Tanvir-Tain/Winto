namespace generalformUI
{
    partial class pdfreader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pdfreader));
            this.openfilebutton = new System.Windows.Forms.Button();
            this.readbutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Resumebuton = new System.Windows.Forms.Button();
            this.Stopbutton = new System.Windows.Forms.Button();
            this.pausebutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rtfData = new System.Windows.Forms.RichTextBox();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // openfilebutton
            // 
            this.openfilebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openfilebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(166)))));
            this.openfilebutton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.openfilebutton.FlatAppearance.BorderSize = 2;
            this.openfilebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openfilebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openfilebutton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.openfilebutton.Location = new System.Drawing.Point(1213, 3);
            this.openfilebutton.Name = "openfilebutton";
            this.openfilebutton.Size = new System.Drawing.Size(114, 34);
            this.openfilebutton.TabIndex = 3;
            this.openfilebutton.Text = "PDF ";
            this.openfilebutton.UseVisualStyleBackColor = false;
            this.openfilebutton.Click += new System.EventHandler(this.openfilebutton_Click);
            // 
            // readbutton
            // 
            this.readbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.readbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(97)))), ((int)(((byte)(126)))));
            this.readbutton.FlatAppearance.BorderSize = 0;
            this.readbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.readbutton.ForeColor = System.Drawing.Color.Transparent;
            this.readbutton.Location = new System.Drawing.Point(15, 24);
            this.readbutton.Name = "readbutton";
            this.readbutton.Size = new System.Drawing.Size(95, 35);
            this.readbutton.TabIndex = 2;
            this.readbutton.Text = "Read";
            this.readbutton.UseVisualStyleBackColor = false;
            this.readbutton.Click += new System.EventHandler(this.readbutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(143)))), ((int)(((byte)(150)))));
            this.trackBar1.Location = new System.Drawing.Point(419, 23);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(172, 45);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Resumebuton
            // 
            this.Resumebuton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Resumebuton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(105)))), ((int)(((byte)(129)))));
            this.Resumebuton.FlatAppearance.BorderSize = 0;
            this.Resumebuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resumebuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Resumebuton.ForeColor = System.Drawing.Color.Transparent;
            this.Resumebuton.Location = new System.Drawing.Point(116, 24);
            this.Resumebuton.Name = "Resumebuton";
            this.Resumebuton.Size = new System.Drawing.Size(95, 35);
            this.Resumebuton.TabIndex = 6;
            this.Resumebuton.Text = "Resume";
            this.Resumebuton.UseVisualStyleBackColor = false;
            this.Resumebuton.Click += new System.EventHandler(this.Resumebuton_Click);
            // 
            // Stopbutton
            // 
            this.Stopbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Stopbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(137)))));
            this.Stopbutton.FlatAppearance.BorderSize = 0;
            this.Stopbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stopbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Stopbutton.ForeColor = System.Drawing.Color.Transparent;
            this.Stopbutton.Location = new System.Drawing.Point(318, 24);
            this.Stopbutton.Name = "Stopbutton";
            this.Stopbutton.Size = new System.Drawing.Size(95, 35);
            this.Stopbutton.TabIndex = 7;
            this.Stopbutton.Text = "Stop";
            this.Stopbutton.UseVisualStyleBackColor = false;
            this.Stopbutton.Click += new System.EventHandler(this.Stopbutton_Click);
            // 
            // pausebutton
            // 
            this.pausebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pausebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(117)))), ((int)(((byte)(136)))));
            this.pausebutton.FlatAppearance.BorderSize = 0;
            this.pausebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pausebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.pausebutton.ForeColor = System.Drawing.Color.Transparent;
            this.pausebutton.Location = new System.Drawing.Point(217, 24);
            this.pausebutton.Name = "pausebutton";
            this.pausebutton.Size = new System.Drawing.Size(95, 35);
            this.pausebutton.TabIndex = 5;
            this.pausebutton.Text = "Pause";
            this.pausebutton.UseVisualStyleBackColor = false;
            this.pausebutton.Click += new System.EventHandler(this.pausebutton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.trackBar1);
            this.bunifuGradientPanel1.Controls.Add(this.button2);
            this.bunifuGradientPanel1.Controls.Add(this.readbutton);
            this.bunifuGradientPanel1.Controls.Add(this.pausebutton);
            this.bunifuGradientPanel1.Controls.Add(this.Resumebuton);
            this.bunifuGradientPanel1.Controls.Add(this.Stopbutton);
            this.bunifuGradientPanel1.Controls.Add(this.button1);
            this.bunifuGradientPanel1.Controls.Add(this.openfilebutton);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.IndianRed;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Coral;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Aqua;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 647);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1330, 80);
            this.bunifuGradientPanel1.TabIndex = 15;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(97)))), ((int)(((byte)(126)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(15, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(166)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(166)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(166)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(1093, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "txt / Word";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtfData
            // 
            this.rtfData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtfData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfData.Location = new System.Drawing.Point(0, 0);
            this.rtfData.Name = "rtfData";
            this.rtfData.Size = new System.Drawing.Size(1330, 647);
            this.rtfData.TabIndex = 16;
            this.rtfData.Text = "";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(1330, 647);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // pdfreader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 727);
            this.Controls.Add(this.rtfData);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "pdfreader";
            this.Text = "File Read ";
            this.Load += new System.EventHandler(this.pdfreader_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button openfilebutton;
        private System.Windows.Forms.Button readbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Resumebuton;
        private System.Windows.Forms.Button Stopbutton;
        private System.Windows.Forms.Button pausebutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtfData;
        private System.Windows.Forms.Button button2;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}