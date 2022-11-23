namespace PiHoleKillswitch
{
    partial class form_PiHoleKillswitch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_PiHoleKillswitch));
            this.grpBox_Killswitch = new System.Windows.Forms.GroupBox();
            this.lbl_response = new System.Windows.Forms.Label();
            this.txtBox_response = new System.Windows.Forms.TextBox();
            this.txtBox_TimeToDeactivateInSeconds = new System.Windows.Forms.NumericUpDown();
            this.btn_run = new System.Windows.Forms.Button();
            this.lbl_TimeToDeactivateInSeconds = new System.Windows.Forms.Label();
            this.grpBox_Settings = new System.Windows.Forms.GroupBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_copyright = new System.Windows.Forms.Label();
            this.btn_saveSettings = new System.Windows.Forms.Button();
            this.txtBox_IPPiHole = new System.Windows.Forms.TextBox();
            this.lbl_IPPiHole = new System.Windows.Forms.Label();
            this.txtBox_Token = new System.Windows.Forms.TextBox();
            this.lbl_Token = new System.Windows.Forms.Label();
            this.chkBox_showSettings = new System.Windows.Forms.CheckBox();
            this.grpBox_Killswitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBox_TimeToDeactivateInSeconds)).BeginInit();
            this.grpBox_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_Killswitch
            // 
            this.grpBox_Killswitch.Controls.Add(this.lbl_response);
            this.grpBox_Killswitch.Controls.Add(this.txtBox_response);
            this.grpBox_Killswitch.Controls.Add(this.txtBox_TimeToDeactivateInSeconds);
            this.grpBox_Killswitch.Controls.Add(this.btn_run);
            this.grpBox_Killswitch.Controls.Add(this.lbl_TimeToDeactivateInSeconds);
            this.grpBox_Killswitch.Location = new System.Drawing.Point(13, 13);
            this.grpBox_Killswitch.Name = "grpBox_Killswitch";
            this.grpBox_Killswitch.Size = new System.Drawing.Size(282, 143);
            this.grpBox_Killswitch.TabIndex = 0;
            this.grpBox_Killswitch.TabStop = false;
            this.grpBox_Killswitch.Text = "Killswitch";
            // 
            // lbl_response
            // 
            this.lbl_response.AutoSize = true;
            this.lbl_response.Location = new System.Drawing.Point(3, 74);
            this.lbl_response.Name = "lbl_response";
            this.lbl_response.Size = new System.Drawing.Size(46, 13);
            this.lbl_response.TabIndex = 4;
            this.lbl_response.Text = "Antwort:";
            // 
            // txtBox_response
            // 
            this.txtBox_response.Location = new System.Drawing.Point(6, 89);
            this.txtBox_response.Multiline = true;
            this.txtBox_response.Name = "txtBox_response";
            this.txtBox_response.ReadOnly = true;
            this.txtBox_response.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBox_response.Size = new System.Drawing.Size(269, 48);
            this.txtBox_response.TabIndex = 3;
            this.txtBox_response.TabStop = false;
            // 
            // txtBox_TimeToDeactivateInSeconds
            // 
            this.txtBox_TimeToDeactivateInSeconds.Location = new System.Drawing.Point(195, 18);
            this.txtBox_TimeToDeactivateInSeconds.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.txtBox_TimeToDeactivateInSeconds.Name = "txtBox_TimeToDeactivateInSeconds";
            this.txtBox_TimeToDeactivateInSeconds.Size = new System.Drawing.Size(81, 20);
            this.txtBox_TimeToDeactivateInSeconds.TabIndex = 1;
            this.txtBox_TimeToDeactivateInSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(7, 44);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(269, 23);
            this.btn_run.TabIndex = 2;
            this.btn_run.TabStop = false;
            this.btn_run.Text = "Pi-hole deativieren";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // lbl_TimeToDeactivateInSeconds
            // 
            this.lbl_TimeToDeactivateInSeconds.AutoSize = true;
            this.lbl_TimeToDeactivateInSeconds.Location = new System.Drawing.Point(7, 20);
            this.lbl_TimeToDeactivateInSeconds.Name = "lbl_TimeToDeactivateInSeconds";
            this.lbl_TimeToDeactivateInSeconds.Size = new System.Drawing.Size(189, 13);
            this.lbl_TimeToDeactivateInSeconds.TabIndex = 0;
            this.lbl_TimeToDeactivateInSeconds.Text = "Dauer der Deaktivierung in Sekunden:";
            // 
            // grpBox_Settings
            // 
            this.grpBox_Settings.Controls.Add(this.lbl_info);
            this.grpBox_Settings.Controls.Add(this.lbl_copyright);
            this.grpBox_Settings.Controls.Add(this.btn_saveSettings);
            this.grpBox_Settings.Controls.Add(this.txtBox_IPPiHole);
            this.grpBox_Settings.Controls.Add(this.lbl_IPPiHole);
            this.grpBox_Settings.Controls.Add(this.txtBox_Token);
            this.grpBox_Settings.Controls.Add(this.lbl_Token);
            this.grpBox_Settings.Location = new System.Drawing.Point(12, 185);
            this.grpBox_Settings.Name = "grpBox_Settings";
            this.grpBox_Settings.Size = new System.Drawing.Size(282, 99);
            this.grpBox_Settings.TabIndex = 1;
            this.grpBox_Settings.TabStop = false;
            this.grpBox_Settings.Text = "Einstellungen";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(200, 66);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(28, 13);
            this.lbl_info.TabIndex = 6;
            this.lbl_info.Text = "Info:";
            // 
            // lbl_copyright
            // 
            this.lbl_copyright.AutoSize = true;
            this.lbl_copyright.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_copyright.Location = new System.Drawing.Point(201, 79);
            this.lbl_copyright.Name = "lbl_copyright";
            this.lbl_copyright.Size = new System.Drawing.Size(72, 12);
            this.lbl_copyright.TabIndex = 2;
            this.lbl_copyright.Text = "© Tim Sauter";
            // 
            // btn_saveSettings
            // 
            this.btn_saveSettings.Location = new System.Drawing.Point(7, 71);
            this.btn_saveSettings.Name = "btn_saveSettings";
            this.btn_saveSettings.Size = new System.Drawing.Size(187, 21);
            this.btn_saveSettings.TabIndex = 5;
            this.btn_saveSettings.TabStop = false;
            this.btn_saveSettings.Text = "Einstellungen speichern";
            this.btn_saveSettings.UseVisualStyleBackColor = true;
            this.btn_saveSettings.Click += new System.EventHandler(this.btn_saveSettings_Click);
            // 
            // txtBox_IPPiHole
            // 
            this.txtBox_IPPiHole.Location = new System.Drawing.Point(113, 45);
            this.txtBox_IPPiHole.Name = "txtBox_IPPiHole";
            this.txtBox_IPPiHole.Size = new System.Drawing.Size(114, 20);
            this.txtBox_IPPiHole.TabIndex = 3;
            // 
            // lbl_IPPiHole
            // 
            this.lbl_IPPiHole.Location = new System.Drawing.Point(4, 48);
            this.lbl_IPPiHole.Name = "lbl_IPPiHole";
            this.lbl_IPPiHole.Size = new System.Drawing.Size(108, 17);
            this.lbl_IPPiHole.TabIndex = 3;
            this.lbl_IPPiHole.Text = "IP(:Port) des Pi-hole:";
            // 
            // txtBox_Token
            // 
            this.txtBox_Token.Location = new System.Drawing.Point(113, 19);
            this.txtBox_Token.Name = "txtBox_Token";
            this.txtBox_Token.Size = new System.Drawing.Size(114, 20);
            this.txtBox_Token.TabIndex = 2;
            // 
            // lbl_Token
            // 
            this.lbl_Token.AutoSize = true;
            this.lbl_Token.Location = new System.Drawing.Point(4, 22);
            this.lbl_Token.Name = "lbl_Token";
            this.lbl_Token.Size = new System.Drawing.Size(76, 13);
            this.lbl_Token.TabIndex = 1;
            this.lbl_Token.Text = "Token für API:";
            // 
            // chkBox_showSettings
            // 
            this.chkBox_showSettings.AutoSize = true;
            this.chkBox_showSettings.Location = new System.Drawing.Point(13, 162);
            this.chkBox_showSettings.Name = "chkBox_showSettings";
            this.chkBox_showSettings.Size = new System.Drawing.Size(135, 17);
            this.chkBox_showSettings.TabIndex = 0;
            this.chkBox_showSettings.TabStop = false;
            this.chkBox_showSettings.Text = "Einstellungen anzeigen";
            this.chkBox_showSettings.UseVisualStyleBackColor = true;
            this.chkBox_showSettings.CheckedChanged += new System.EventHandler(this.chkBox_showSettings_CheckedChanged);
            // 
            // form_PiHoleKillswitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 296);
            this.Controls.Add(this.grpBox_Settings);
            this.Controls.Add(this.grpBox_Killswitch);
            this.Controls.Add(this.chkBox_showSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_PiHoleKillswitch";
            this.Text = "Pi-hole Killswitch";
            this.grpBox_Killswitch.ResumeLayout(false);
            this.grpBox_Killswitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBox_TimeToDeactivateInSeconds)).EndInit();
            this.grpBox_Settings.ResumeLayout(false);
            this.grpBox_Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_Killswitch;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Label lbl_TimeToDeactivateInSeconds;
        private System.Windows.Forms.GroupBox grpBox_Settings;
        private System.Windows.Forms.CheckBox chkBox_showSettings;
        private System.Windows.Forms.Button btn_saveSettings;
        private System.Windows.Forms.TextBox txtBox_IPPiHole;
        private System.Windows.Forms.Label lbl_IPPiHole;
        private System.Windows.Forms.TextBox txtBox_Token;
        private System.Windows.Forms.Label lbl_Token;
        private System.Windows.Forms.NumericUpDown txtBox_TimeToDeactivateInSeconds;
        private System.Windows.Forms.Label lbl_copyright;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label lbl_response;
        private System.Windows.Forms.TextBox txtBox_response;
    }
}

