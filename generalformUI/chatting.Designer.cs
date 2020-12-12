namespace generalformUI
{
    partial class chatting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chatting));
            this.outputtxtbox = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.button5 = new System.Windows.Forms.PictureBox();
            this.speechbutton = new System.Windows.Forms.PictureBox();
            this.inputtextbox = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speechbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // outputtxtbox
            // 
            this.outputtxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.outputtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputtxtbox.ForeColor = System.Drawing.SystemColors.Menu;
            this.outputtxtbox.Location = new System.Drawing.Point(0, 84);
            this.outputtxtbox.Multiline = true;
            this.outputtxtbox.Name = "outputtxtbox";
            this.outputtxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.outputtxtbox.Size = new System.Drawing.Size(702, 57);
            this.outputtxtbox.TabIndex = 2;
            this.outputtxtbox.Text = "Hi ... I am Winto . What is Your Name ?";
            this.outputtxtbox.Enter += new System.EventHandler(this.outputtxtbox_Enter);
            this.outputtxtbox.Leave += new System.EventHandler(this.outputtxtbox_Leave);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.button5);
            this.bunifuGradientPanel1.Controls.Add(this.speechbutton);
            this.bunifuGradientPanel1.Controls.Add(this.inputtextbox);
            this.bunifuGradientPanel1.Controls.Add(this.outputtxtbox);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Magenta;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.bunifuGradientPanel1.TabIndex = 12;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(744, 405);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 42);
            this.button5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button5.TabIndex = 16;
            this.button5.TabStop = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // speechbutton
            // 
            this.speechbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.speechbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.speechbutton.Image = ((System.Drawing.Image)(resources.GetObject("speechbutton.Image")));
            this.speechbutton.Location = new System.Drawing.Point(680, 405);
            this.speechbutton.Name = "speechbutton";
            this.speechbutton.Size = new System.Drawing.Size(58, 42);
            this.speechbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.speechbutton.TabIndex = 16;
            this.speechbutton.TabStop = false;
            this.speechbutton.Click += new System.EventHandler(this.speechbutton_Click);
            // 
            // inputtextbox
            // 
            this.inputtextbox.AcceptsReturn = true;
            this.inputtextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inputtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.inputtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputtextbox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.inputtextbox.Location = new System.Drawing.Point(200, 331);
            this.inputtextbox.Multiline = true;
            this.inputtextbox.Name = "inputtextbox";
            this.inputtextbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.inputtextbox.Size = new System.Drawing.Size(597, 57);
            this.inputtextbox.TabIndex = 1;
            this.inputtextbox.Text = "Write Your Message";
            this.inputtextbox.Enter += new System.EventHandler(this.inputtextbox_Enter);
            this.inputtextbox.Leave += new System.EventHandler(this.inputtextbox_Leave);
            // 
            // chatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "chatting";
            this.Text = "chatting";
            this.Load += new System.EventHandler(this.chatting_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speechbutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox outputtxtbox;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.TextBox inputtextbox;
        private System.Windows.Forms.PictureBox speechbutton;
        private System.Windows.Forms.PictureBox button5;
    }
}