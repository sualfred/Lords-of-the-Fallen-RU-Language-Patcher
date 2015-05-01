namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioCN = new System.Windows.Forms.RadioButton();
            this.radioKR = new System.Windows.Forms.RadioButton();
            this.radioJP = new System.Windows.Forms.RadioButton();
            this.radioBR = new System.Windows.Forms.RadioButton();
            this.radioPT = new System.Windows.Forms.RadioButton();
            this.radioPL = new System.Windows.Forms.RadioButton();
            this.radioCZ = new System.Windows.Forms.RadioButton();
            this.radioES = new System.Windows.Forms.RadioButton();
            this.radioIT = new System.Windows.Forms.RadioButton();
            this.radioFR = new System.Windows.Forms.RadioButton();
            this.radioEN = new System.Windows.Forms.RadioButton();
            this.radioGER = new System.Windows.Forms.RadioButton();
            this.radioRU = new System.Windows.Forms.RadioButton();
            this.patchButton = new System.Windows.Forms.Button();
            this.voiceFR = new System.Windows.Forms.RadioButton();
            this.voiceGER = new System.Windows.Forms.RadioButton();
            this.voiceEN = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioCN
            // 
            this.radioCN.AutoSize = true;
            this.radioCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioCN.Location = new System.Drawing.Point(10, 159);
            this.radioCN.Name = "radioCN";
            this.radioCN.Size = new System.Drawing.Size(135, 18);
            this.radioCN.TabIndex = 12;
            this.radioCN.TabStop = true;
            this.radioCN.Text = "Chinese (experimental)";
            this.radioCN.UseVisualStyleBackColor = true;
            this.radioCN.CheckedChanged += new System.EventHandler(this.radioCN_CheckedChanged_1);
            // 
            // radioKR
            // 
            this.radioKR.AutoSize = true;
            this.radioKR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioKR.Location = new System.Drawing.Point(10, 136);
            this.radioKR.Name = "radioKR";
            this.radioKR.Size = new System.Drawing.Size(59, 18);
            this.radioKR.TabIndex = 11;
            this.radioKR.TabStop = true;
            this.radioKR.Text = "Korean";
            this.radioKR.UseVisualStyleBackColor = true;
            this.radioKR.CheckedChanged += new System.EventHandler(this.radioKR_CheckedChanged_1);
            // 
            // radioJP
            // 
            this.radioJP.AutoSize = true;
            this.radioJP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioJP.Location = new System.Drawing.Point(89, 113);
            this.radioJP.Name = "radioJP";
            this.radioJP.Size = new System.Drawing.Size(71, 18);
            this.radioJP.TabIndex = 10;
            this.radioJP.TabStop = true;
            this.radioJP.Text = "Japanese";
            this.radioJP.UseVisualStyleBackColor = true;
            this.radioJP.CheckedChanged += new System.EventHandler(this.radioJP_CheckedChanged_1);
            // 
            // radioBR
            // 
            this.radioBR.AutoSize = true;
            this.radioBR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBR.Location = new System.Drawing.Point(89, 136);
            this.radioBR.Name = "radioBR";
            this.radioBR.Size = new System.Drawing.Size(110, 18);
            this.radioBR.TabIndex = 9;
            this.radioBR.TabStop = true;
            this.radioBR.Text = "Portuguese-Brazil";
            this.radioBR.UseVisualStyleBackColor = true;
            this.radioBR.CheckedChanged += new System.EventHandler(this.radioBR_CheckedChanged_1);
            // 
            // radioPT
            // 
            this.radioPT.AutoSize = true;
            this.radioPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioPT.Location = new System.Drawing.Point(89, 90);
            this.radioPT.Name = "radioPT";
            this.radioPT.Size = new System.Drawing.Size(79, 18);
            this.radioPT.TabIndex = 8;
            this.radioPT.TabStop = true;
            this.radioPT.Text = "Portuguese";
            this.radioPT.UseVisualStyleBackColor = true;
            this.radioPT.CheckedChanged += new System.EventHandler(this.radioPT_CheckedChanged);
            // 
            // radioPL
            // 
            this.radioPL.AutoSize = true;
            this.radioPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioPL.Location = new System.Drawing.Point(89, 67);
            this.radioPL.Name = "radioPL";
            this.radioPL.Size = new System.Drawing.Size(52, 18);
            this.radioPL.TabIndex = 7;
            this.radioPL.TabStop = true;
            this.radioPL.Text = "Polish";
            this.radioPL.UseVisualStyleBackColor = true;
            this.radioPL.CheckedChanged += new System.EventHandler(this.radioPL_CheckedChanged_1);
            // 
            // radioCZ
            // 
            this.radioCZ.AutoSize = true;
            this.radioCZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioCZ.Location = new System.Drawing.Point(10, 90);
            this.radioCZ.Name = "radioCZ";
            this.radioCZ.Size = new System.Drawing.Size(55, 18);
            this.radioCZ.TabIndex = 6;
            this.radioCZ.TabStop = true;
            this.radioCZ.Text = "Czech";
            this.radioCZ.UseVisualStyleBackColor = true;
            this.radioCZ.CheckedChanged += new System.EventHandler(this.radioCZ_CheckedChanged_1);
            // 
            // radioES
            // 
            this.radioES.AutoSize = true;
            this.radioES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioES.Location = new System.Drawing.Point(9, 67);
            this.radioES.Name = "radioES";
            this.radioES.Size = new System.Drawing.Size(63, 18);
            this.radioES.TabIndex = 5;
            this.radioES.TabStop = true;
            this.radioES.Text = "Spanish";
            this.radioES.UseVisualStyleBackColor = true;
            this.radioES.CheckedChanged += new System.EventHandler(this.radioES_CheckedChanged_1);
            // 
            // radioIT
            // 
            this.radioIT.AutoSize = true;
            this.radioIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioIT.Location = new System.Drawing.Point(89, 44);
            this.radioIT.Name = "radioIT";
            this.radioIT.Size = new System.Drawing.Size(51, 18);
            this.radioIT.TabIndex = 4;
            this.radioIT.TabStop = true;
            this.radioIT.Text = "Italian";
            this.radioIT.UseVisualStyleBackColor = true;
            this.radioIT.CheckedChanged += new System.EventHandler(this.radioIT_CheckedChanged_1);
            // 
            // radioFR
            // 
            this.radioFR.AutoSize = true;
            this.radioFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioFR.Location = new System.Drawing.Point(9, 44);
            this.radioFR.Name = "radioFR";
            this.radioFR.Size = new System.Drawing.Size(58, 18);
            this.radioFR.TabIndex = 3;
            this.radioFR.TabStop = true;
            this.radioFR.Text = "French";
            this.radioFR.UseVisualStyleBackColor = true;
            this.radioFR.CheckedChanged += new System.EventHandler(this.radioFR_CheckedChanged);
            // 
            // radioEN
            // 
            this.radioEN.AutoSize = true;
            this.radioEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioEN.Location = new System.Drawing.Point(9, 21);
            this.radioEN.Name = "radioEN";
            this.radioEN.Size = new System.Drawing.Size(58, 18);
            this.radioEN.TabIndex = 2;
            this.radioEN.TabStop = true;
            this.radioEN.Text = "English";
            this.radioEN.UseVisualStyleBackColor = true;
            this.radioEN.CheckedChanged += new System.EventHandler(this.radioEN_CheckedChanged_1);
            // 
            // radioGER
            // 
            this.radioGER.AutoSize = true;
            this.radioGER.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioGER.FlatAppearance.BorderSize = 0;
            this.radioGER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioGER.Location = new System.Drawing.Point(89, 21);
            this.radioGER.Name = "radioGER";
            this.radioGER.Size = new System.Drawing.Size(62, 18);
            this.radioGER.TabIndex = 1;
            this.radioGER.TabStop = true;
            this.radioGER.Text = "German";
            this.radioGER.UseVisualStyleBackColor = true;
            this.radioGER.CheckedChanged += new System.EventHandler(this.radioGER_CheckedChanged);
            // 
            // radioRU
            // 
            this.radioRU.AutoSize = true;
            this.radioRU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioRU.Location = new System.Drawing.Point(10, 113);
            this.radioRU.Name = "radioRU";
            this.radioRU.Size = new System.Drawing.Size(63, 18);
            this.radioRU.TabIndex = 0;
            this.radioRU.TabStop = true;
            this.radioRU.Text = "Russian";
            this.radioRU.UseVisualStyleBackColor = true;
            this.radioRU.CheckedChanged += new System.EventHandler(this.radioRU_CheckedChanged);
            // 
            // patchButton
            // 
            this.patchButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.patchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patchButton.FlatAppearance.BorderSize = 0;
            this.patchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patchButton.Location = new System.Drawing.Point(-1, 354);
            this.patchButton.Name = "patchButton";
            this.patchButton.Padding = new System.Windows.Forms.Padding(2);
            this.patchButton.Size = new System.Drawing.Size(353, 51);
            this.patchButton.TabIndex = 2;
            this.patchButton.Text = "Apply Patch";
            this.patchButton.UseVisualStyleBackColor = false;
            this.patchButton.Click += new System.EventHandler(this.patchButton_Click);
            // 
            // voiceFR
            // 
            this.voiceFR.AutoSize = true;
            this.voiceFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voiceFR.Location = new System.Drawing.Point(8, 68);
            this.voiceFR.Name = "voiceFR";
            this.voiceFR.Size = new System.Drawing.Size(58, 18);
            this.voiceFR.TabIndex = 2;
            this.voiceFR.TabStop = true;
            this.voiceFR.Text = "French";
            this.voiceFR.UseVisualStyleBackColor = true;
            this.voiceFR.CheckedChanged += new System.EventHandler(this.voiceFR_CheckedChanged);
            // 
            // voiceGER
            // 
            this.voiceGER.AutoSize = true;
            this.voiceGER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voiceGER.Location = new System.Drawing.Point(8, 45);
            this.voiceGER.Name = "voiceGER";
            this.voiceGER.Size = new System.Drawing.Size(62, 18);
            this.voiceGER.TabIndex = 1;
            this.voiceGER.TabStop = true;
            this.voiceGER.Text = "German";
            this.voiceGER.UseVisualStyleBackColor = true;
            this.voiceGER.CheckedChanged += new System.EventHandler(this.voiceGER_CheckedChanged);
            // 
            // voiceEN
            // 
            this.voiceEN.AutoSize = true;
            this.voiceEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voiceEN.Location = new System.Drawing.Point(8, 22);
            this.voiceEN.Name = "voiceEN";
            this.voiceEN.Size = new System.Drawing.Size(58, 18);
            this.voiceEN.TabIndex = 0;
            this.voiceEN.TabStop = true;
            this.voiceEN.Text = "English";
            this.voiceEN.UseVisualStyleBackColor = true;
            this.voiceEN.CheckedChanged += new System.EventHandler(this.voiceEN_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtConsole.Location = new System.Drawing.Point(0, 406);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(350, 144);
            this.txtConsole.TabIndex = 4;
            this.txtConsole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-1, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(364, 78);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 174);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WndProc);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(306, -1);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(48, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "QUIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioCN);
            this.panel1.Controls.Add(this.radioGER);
            this.panel1.Controls.Add(this.radioKR);
            this.panel1.Controls.Add(this.radioRU);
            this.panel1.Controls.Add(this.radioJP);
            this.panel1.Controls.Add(this.radioEN);
            this.panel1.Controls.Add(this.radioBR);
            this.panel1.Controls.Add(this.radioFR);
            this.panel1.Controls.Add(this.radioPT);
            this.panel1.Controls.Add(this.radioIT);
            this.panel1.Controls.Add(this.radioPL);
            this.panel1.Controls.Add(this.radioES);
            this.panel1.Controls.Add(this.radioCZ);
            this.panel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(-3, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 182);
            this.panel1.TabIndex = 8;
            this.panel1.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Text Language";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Voice Over Language";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.voiceFR);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.voiceGER);
            this.panel2.Controls.Add(this.voiceEN);
            this.panel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(205, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 182);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(145, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "v3.4";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Cursor = System.Windows.Forms.Cursors.Help;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(252, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "HELP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(351, 624);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.patchButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language Patcher 3.3 - by Sualfred(DerFred)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioGER;
        private System.Windows.Forms.RadioButton radioRU;
        private System.Windows.Forms.Button patchButton;
        private System.Windows.Forms.RadioButton voiceGER;
        private System.Windows.Forms.RadioButton voiceEN;
        private System.Windows.Forms.RadioButton radioCN;
        private System.Windows.Forms.RadioButton radioKR;
        private System.Windows.Forms.RadioButton radioJP;
        private System.Windows.Forms.RadioButton radioBR;
        private System.Windows.Forms.RadioButton radioPT;
        private System.Windows.Forms.RadioButton radioPL;
        private System.Windows.Forms.RadioButton radioCZ;
        private System.Windows.Forms.RadioButton radioES;
        private System.Windows.Forms.RadioButton radioIT;
        private System.Windows.Forms.RadioButton radioFR;
        private System.Windows.Forms.RadioButton radioEN;
        private System.Windows.Forms.RadioButton voiceFR;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

