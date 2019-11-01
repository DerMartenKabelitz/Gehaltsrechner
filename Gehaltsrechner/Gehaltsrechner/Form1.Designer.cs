namespace Gehaltsrechner
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
            this.textBox_Anzeige = new System.Windows.Forms.TextBox();
            this.dtmPickerStartDtm = new System.Windows.Forms.DateTimePicker();
            this.dtmPickerEndDtm = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aktStundenlohn = new System.Windows.Forms.Button();
            this.btn_startTimer = new System.Windows.Forms.Button();
            this.btn_stopTimer = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer_laufendeZeit = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Tagesabschluss = new System.Windows.Forms.Button();
            this.txtBoxTimerZeit = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtBoxStundenlohn = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_SnickersCounter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Anzeige
            // 
            this.textBox_Anzeige.Location = new System.Drawing.Point(268, 120);
            this.textBox_Anzeige.Name = "textBox_Anzeige";
            this.textBox_Anzeige.Size = new System.Drawing.Size(166, 22);
            this.textBox_Anzeige.TabIndex = 0;
            this.textBox_Anzeige.TextChanged += new System.EventHandler(this.TextBox_Anzeige_TextChanged);
            // 
            // dtmPickerStartDtm
            // 
            this.dtmPickerStartDtm.Location = new System.Drawing.Point(353, 326);
            this.dtmPickerStartDtm.Name = "dtmPickerStartDtm";
            this.dtmPickerStartDtm.Size = new System.Drawing.Size(242, 22);
            this.dtmPickerStartDtm.TabIndex = 1;
            // 
            // dtmPickerEndDtm
            // 
            this.dtmPickerEndDtm.Location = new System.Drawing.Point(353, 355);
            this.dtmPickerEndDtm.Name = "dtmPickerEndDtm";
            this.dtmPickerEndDtm.Size = new System.Drawing.Size(242, 22);
            this.dtmPickerEndDtm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ZeitraumAuswaehlen";
            // 
            // btn_aktStundenlohn
            // 
            this.btn_aktStundenlohn.Location = new System.Drawing.Point(632, 329);
            this.btn_aktStundenlohn.Name = "btn_aktStundenlohn";
            this.btn_aktStundenlohn.Size = new System.Drawing.Size(106, 48);
            this.btn_aktStundenlohn.TabIndex = 4;
            this.btn_aktStundenlohn.Text = "Aktualisiere Stundenlohn";
            this.btn_aktStundenlohn.UseVisualStyleBackColor = true;
            this.btn_aktStundenlohn.Click += new System.EventHandler(this.Btn_aktStundenlohn_Click);
            // 
            // btn_startTimer
            // 
            this.btn_startTimer.Location = new System.Drawing.Point(191, 325);
            this.btn_startTimer.Name = "btn_startTimer";
            this.btn_startTimer.Size = new System.Drawing.Size(130, 23);
            this.btn_startTimer.TabIndex = 5;
            this.btn_startTimer.Text = "Starten";
            this.btn_startTimer.UseVisualStyleBackColor = true;
            this.btn_startTimer.Click += new System.EventHandler(this.Btn_startTimer_Click);
            // 
            // btn_stopTimer
            // 
            this.btn_stopTimer.Location = new System.Drawing.Point(191, 351);
            this.btn_stopTimer.Name = "btn_stopTimer";
            this.btn_stopTimer.Size = new System.Drawing.Size(130, 23);
            this.btn_stopTimer.TabIndex = 6;
            this.btn_stopTimer.Text = "Stoppen";
            this.btn_stopTimer.UseVisualStyleBackColor = true;
            this.btn_stopTimer.Click += new System.EventHandler(this.btn_stopTimer_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 53);
            this.button4.TabIndex = 7;
            this.button4.Text = "Zurueck zur Gesamtanzeige";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // timer_laufendeZeit
            // 
            this.timer_laufendeZeit.Interval = 1000;
            this.timer_laufendeZeit.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gesamtanzeige";
            // 
            // btn_Tagesabschluss
            // 
            this.btn_Tagesabschluss.Location = new System.Drawing.Point(12, 383);
            this.btn_Tagesabschluss.Name = "btn_Tagesabschluss";
            this.btn_Tagesabschluss.Size = new System.Drawing.Size(146, 35);
            this.btn_Tagesabschluss.TabIndex = 9;
            this.btn_Tagesabschluss.Text = "TagesAbschluss";
            this.btn_Tagesabschluss.UseVisualStyleBackColor = true;
            this.btn_Tagesabschluss.Click += new System.EventHandler(this.btn_Tagesabschluss_Click);
            // 
            // txtBoxTimerZeit
            // 
            this.txtBoxTimerZeit.Location = new System.Drawing.Point(191, 389);
            this.txtBoxTimerZeit.Name = "txtBoxTimerZeit";
            this.txtBoxTimerZeit.Size = new System.Drawing.Size(130, 22);
            this.txtBoxTimerZeit.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(384, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Zeitraum Auswerten";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtBoxStundenlohn
            // 
            this.txtBoxStundenlohn.Location = new System.Drawing.Point(632, 388);
            this.txtBoxStundenlohn.Name = "txtBoxStundenlohn";
            this.txtBoxStundenlohn.Size = new System.Drawing.Size(106, 22);
            this.txtBoxStundenlohn.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(155, 168);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(409, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btn_SnickersCounter
            // 
            this.btn_SnickersCounter.BackColor = System.Drawing.Color.Lime;
            this.btn_SnickersCounter.Location = new System.Drawing.Point(409, 209);
            this.btn_SnickersCounter.Name = "btn_SnickersCounter";
            this.btn_SnickersCounter.Size = new System.Drawing.Size(137, 74);
            this.btn_SnickersCounter.TabIndex = 15;
            this.btn_SnickersCounter.Text = "button1";
            this.btn_SnickersCounter.UseVisualStyleBackColor = false;
            this.btn_SnickersCounter.TextChanged += new System.EventHandler(this.btn_SnickersCounter_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "€";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_SnickersCounter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtBoxStundenlohn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtBoxTimerZeit);
            this.Controls.Add(this.btn_Tagesabschluss);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_stopTimer);
            this.Controls.Add(this.btn_startTimer);
            this.Controls.Add(this.btn_aktStundenlohn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtmPickerEndDtm);
            this.Controls.Add(this.dtmPickerStartDtm);
            this.Controls.Add(this.textBox_Anzeige);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Anzeige;
        private System.Windows.Forms.DateTimePicker dtmPickerStartDtm;
        private System.Windows.Forms.DateTimePicker dtmPickerEndDtm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aktStundenlohn;
        private System.Windows.Forms.Button btn_startTimer;
        private System.Windows.Forms.Button btn_stopTimer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer_laufendeZeit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Tagesabschluss;
        private System.Windows.Forms.TextBox txtBoxTimerZeit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtBoxStundenlohn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_SnickersCounter;
        private System.Windows.Forms.Label label3;
    }
}

