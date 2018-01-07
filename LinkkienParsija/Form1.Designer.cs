namespace MoodleWebexLataaja
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_parsi = new System.Windows.Forms.Button();
            this.listBox_parsitutLinkit = new System.Windows.Forms.ListBox();
            this.richTextBox_console = new System.Windows.Forms.RichTextBox();
            this.label_lahdesivu = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox_lahde = new System.Windows.Forms.TextBox();
            this.button_poistaValittuJonosta = new System.Windows.Forms.Button();
            this.button_lataaKaikki = new System.Windows.Forms.Button();
            this.button_peruutaNykyinenLataus = new System.Windows.Forms.Button();
            this.listBox_latausjono = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_latauskansio = new System.Windows.Forms.TextBox();
            this.button_peruutaLataus = new System.Windows.Forms.Button();
            this.label_tiedosto = new System.Windows.Forms.Label();
            this.label_latausProsentti = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_poistettavaOsa = new System.Windows.Forms.Label();
            this.textBox_poistettavaOsa = new System.Windows.Forms.TextBox();
            this.button_lataaValitut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_parsi
            // 
            this.button_parsi.Location = new System.Drawing.Point(96, 110);
            this.button_parsi.Name = "button_parsi";
            this.button_parsi.Size = new System.Drawing.Size(106, 23);
            this.button_parsi.TabIndex = 0;
            this.button_parsi.Text = "Hae linkit";
            this.button_parsi.UseVisualStyleBackColor = true;
            this.button_parsi.Click += new System.EventHandler(this.button_parsi_Click);
            // 
            // listBox_parsitutLinkit
            // 
            this.listBox_parsitutLinkit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_parsitutLinkit.FormattingEnabled = true;
            this.listBox_parsitutLinkit.Location = new System.Drawing.Point(8, 139);
            this.listBox_parsitutLinkit.Name = "listBox_parsitutLinkit";
            this.listBox_parsitutLinkit.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_parsitutLinkit.Size = new System.Drawing.Size(541, 459);
            this.listBox_parsitutLinkit.TabIndex = 1;
            this.listBox_parsitutLinkit.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_parsitutLinkit_MouseDoubleClick);
            // 
            // richTextBox_console
            // 
            this.richTextBox_console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_console.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_console.Name = "richTextBox_console";
            this.richTextBox_console.Size = new System.Drawing.Size(995, 893);
            this.richTextBox_console.TabIndex = 2;
            this.richTextBox_console.Text = resources.GetString("richTextBox_console.Text");
            this.richTextBox_console.TextChanged += new System.EventHandler(this.richTextBox_console_TextChanged);
            // 
            // label_lahdesivu
            // 
            this.label_lahdesivu.AutoSize = true;
            this.label_lahdesivu.Location = new System.Drawing.Point(16, 27);
            this.label_lahdesivu.Name = "label_lahdesivu";
            this.label_lahdesivu.Size = new System.Drawing.Size(56, 13);
            this.label_lahdesivu.TabIndex = 4;
            this.label_lahdesivu.Text = "Lähdesivu";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_lataaValitut);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_lahde);
            this.splitContainer1.Panel1.Controls.Add(this.button_poistaValittuJonosta);
            this.splitContainer1.Panel1.Controls.Add(this.button_lataaKaikki);
            this.splitContainer1.Panel1.Controls.Add(this.button_peruutaNykyinenLataus);
            this.splitContainer1.Panel1.Controls.Add(this.listBox_latausjono);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_latauskansio);
            this.splitContainer1.Panel1.Controls.Add(this.button_peruutaLataus);
            this.splitContainer1.Panel1.Controls.Add(this.label_tiedosto);
            this.splitContainer1.Panel1.Controls.Add(this.button_parsi);
            this.splitContainer1.Panel1.Controls.Add(this.label_latausProsentti);
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.label_poistettavaOsa);
            this.splitContainer1.Panel1.Controls.Add(this.listBox_parsitutLinkit);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_poistettavaOsa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox_console);
            this.splitContainer1.Size = new System.Drawing.Size(1567, 897);
            this.splitContainer1.SplitterDistance = 564;
            this.splitContainer1.TabIndex = 5;
            // 
            // textBox_lahde
            // 
            this.textBox_lahde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_lahde.Location = new System.Drawing.Point(96, 22);
            this.textBox_lahde.Name = "textBox_lahde";
            this.textBox_lahde.Size = new System.Drawing.Size(453, 20);
            this.textBox_lahde.TabIndex = 17;
            // 
            // button_poistaValittuJonosta
            // 
            this.button_poistaValittuJonosta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_poistaValittuJonosta.Location = new System.Drawing.Point(421, 743);
            this.button_poistaValittuJonosta.Name = "button_poistaValittuJonosta";
            this.button_poistaValittuJonosta.Size = new System.Drawing.Size(133, 23);
            this.button_poistaValittuJonosta.TabIndex = 16;
            this.button_poistaValittuJonosta.Text = "Poista valittu jonosta";
            this.button_poistaValittuJonosta.UseVisualStyleBackColor = true;
            this.button_poistaValittuJonosta.Click += new System.EventHandler(this.button_poistaValittuJonosta_Click);
            // 
            // button_lataaKaikki
            // 
            this.button_lataaKaikki.Enabled = false;
            this.button_lataaKaikki.Location = new System.Drawing.Point(208, 110);
            this.button_lataaKaikki.Name = "button_lataaKaikki";
            this.button_lataaKaikki.Size = new System.Drawing.Size(106, 23);
            this.button_lataaKaikki.TabIndex = 15;
            this.button_lataaKaikki.Text = "Lataa kaikki";
            this.button_lataaKaikki.UseVisualStyleBackColor = true;
            this.button_lataaKaikki.Click += new System.EventHandler(this.button_lataaKaikki_Click);
            // 
            // button_peruutaNykyinenLataus
            // 
            this.button_peruutaNykyinenLataus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_peruutaNykyinenLataus.Location = new System.Drawing.Point(421, 682);
            this.button_peruutaNykyinenLataus.Name = "button_peruutaNykyinenLataus";
            this.button_peruutaNykyinenLataus.Size = new System.Drawing.Size(133, 23);
            this.button_peruutaNykyinenLataus.TabIndex = 14;
            this.button_peruutaNykyinenLataus.Text = "Peruuta nykyinen lataus";
            this.button_peruutaNykyinenLataus.UseVisualStyleBackColor = true;
            this.button_peruutaNykyinenLataus.Click += new System.EventHandler(this.button_peruutaNykyinenLataus_Click);
            // 
            // listBox_latausjono
            // 
            this.listBox_latausjono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_latausjono.FormattingEnabled = true;
            this.listBox_latausjono.Location = new System.Drawing.Point(8, 682);
            this.listBox_latausjono.Name = "listBox_latausjono";
            this.listBox_latausjono.Size = new System.Drawing.Size(407, 199);
            this.listBox_latausjono.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Latauskansio";
            // 
            // textBox_latauskansio
            // 
            this.textBox_latauskansio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_latauskansio.Location = new System.Drawing.Point(96, 76);
            this.textBox_latauskansio.Name = "textBox_latauskansio";
            this.textBox_latauskansio.Size = new System.Drawing.Size(453, 20);
            this.textBox_latauskansio.TabIndex = 11;
            this.textBox_latauskansio.TextChanged += new System.EventHandler(this.textBox_latauskansio_TextChanged);
            // 
            // button_peruutaLataus
            // 
            this.button_peruutaLataus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_peruutaLataus.Location = new System.Drawing.Point(421, 714);
            this.button_peruutaLataus.Name = "button_peruutaLataus";
            this.button_peruutaLataus.Size = new System.Drawing.Size(133, 23);
            this.button_peruutaLataus.TabIndex = 6;
            this.button_peruutaLataus.Text = "Peruuta kaikki lataukset";
            this.button_peruutaLataus.UseVisualStyleBackColor = true;
            this.button_peruutaLataus.Click += new System.EventHandler(this.button_peruutaLataus_Click);
            // 
            // label_tiedosto
            // 
            this.label_tiedosto.AutoSize = true;
            this.label_tiedosto.Location = new System.Drawing.Point(11, 610);
            this.label_tiedosto.Name = "label_tiedosto";
            this.label_tiedosto.Size = new System.Drawing.Size(48, 13);
            this.label_tiedosto.TabIndex = 10;
            this.label_tiedosto.Text = "Tiedosto";
            // 
            // label_latausProsentti
            // 
            this.label_latausProsentti.AutoSize = true;
            this.label_latausProsentti.Location = new System.Drawing.Point(11, 652);
            this.label_latausProsentti.Name = "label_latausProsentti";
            this.label_latausProsentti.Size = new System.Drawing.Size(50, 13);
            this.label_latausProsentti.TabIndex = 9;
            this.label_latausProsentti.Text = "Lataus %";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(8, 626);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(541, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // label_poistettavaOsa
            // 
            this.label_poistettavaOsa.AutoSize = true;
            this.label_poistettavaOsa.Location = new System.Drawing.Point(14, 53);
            this.label_poistettavaOsa.Name = "label_poistettavaOsa";
            this.label_poistettavaOsa.Size = new System.Drawing.Size(71, 13);
            this.label_poistettavaOsa.TabIndex = 7;
            this.label_poistettavaOsa.Text = "Poista linkistä";
            // 
            // textBox_poistettavaOsa
            // 
            this.textBox_poistettavaOsa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_poistettavaOsa.Location = new System.Drawing.Point(96, 50);
            this.textBox_poistettavaOsa.Name = "textBox_poistettavaOsa";
            this.textBox_poistettavaOsa.Size = new System.Drawing.Size(453, 20);
            this.textBox_poistettavaOsa.TabIndex = 6;
            this.textBox_poistettavaOsa.Text = "http://hamk.webex.com/webex/playback.php?FileName=";
            // 
            // button_lataaValitut
            // 
            this.button_lataaValitut.Enabled = false;
            this.button_lataaValitut.Location = new System.Drawing.Point(320, 110);
            this.button_lataaValitut.Name = "button_lataaValitut";
            this.button_lataaValitut.Size = new System.Drawing.Size(106, 23);
            this.button_lataaValitut.TabIndex = 18;
            this.button_lataaValitut.Text = "Lataa valitut";
            this.button_lataaValitut.UseVisualStyleBackColor = true;
            this.button_lataaValitut.Click += new System.EventHandler(this.button_lataaValitut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 897);
            this.Controls.Add(this.label_lahdesivu);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Lataa Webex-videot Moodlesta";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_parsi;
        private System.Windows.Forms.ListBox listBox_parsitutLinkit;
        private System.Windows.Forms.RichTextBox richTextBox_console;
        private System.Windows.Forms.Label label_lahdesivu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label_poistettavaOsa;
        private System.Windows.Forms.TextBox textBox_poistettavaOsa;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_latausProsentti;
        private System.Windows.Forms.Label label_tiedosto;
        private System.Windows.Forms.Button button_peruutaLataus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_latauskansio;
        private System.Windows.Forms.ListBox listBox_latausjono;
        private System.Windows.Forms.Button button_peruutaNykyinenLataus;
        private System.Windows.Forms.Button button_lataaKaikki;
        private System.Windows.Forms.Button button_poistaValittuJonosta;
        private System.Windows.Forms.TextBox textBox_lahde;
        private System.Windows.Forms.Button button_lataaValitut;
    }
}

