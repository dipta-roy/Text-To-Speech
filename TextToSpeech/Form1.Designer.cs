namespace TextToSpeech
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Resume = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.delay_Cbx = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.output_Cbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.voice_Cbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(543, 389);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(555, 89);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(85, 29);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Play";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(555, 179);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(85, 29);
            this.btn_Stop.TabIndex = 3;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // btn_Resume
            // 
            this.btn_Resume.Location = new System.Drawing.Point(555, 149);
            this.btn_Resume.Name = "btn_Resume";
            this.btn_Resume.Size = new System.Drawing.Size(85, 29);
            this.btn_Resume.TabIndex = 4;
            this.btn_Resume.Text = "Resume";
            this.btn_Resume.UseVisualStyleBackColor = true;
            this.btn_Resume.Click += new System.EventHandler(this.Btn_Resume_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Location = new System.Drawing.Point(555, 119);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(85, 29);
            this.btn_Pause.TabIndex = 5;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.Btn_Pause_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Delay in seconds";
            // 
            // delay_Cbx
            // 
            this.delay_Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delay_Cbx.FormattingEnabled = true;
            this.delay_Cbx.Items.AddRange(new object[] {
            "0",
            "3",
            "5",
            "10",
            "12",
            "15",
            "20",
            "30"});
            this.delay_Cbx.Location = new System.Drawing.Point(556, 67);
            this.delay_Cbx.Name = "delay_Cbx";
            this.delay_Cbx.Size = new System.Drawing.Size(82, 21);
            this.delay_Cbx.TabIndex = 8;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(555, 277);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(85, 29);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save Audio";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.Btn_SaveAsMP3_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(555, 358);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(85, 29);
            this.btn_Close.TabIndex = 10;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Developed By ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dipta Roy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(237, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Text To Audio";
            // 
            // output_Cbx
            // 
            this.output_Cbx.AllowDrop = true;
            this.output_Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.output_Cbx.FormattingEnabled = true;
            this.output_Cbx.Items.AddRange(new object[] {
            "MP3",
            "WAV"});
            this.output_Cbx.Location = new System.Drawing.Point(556, 255);
            this.output_Cbx.Name = "output_Cbx";
            this.output_Cbx.Size = new System.Drawing.Size(83, 21);
            this.output_Cbx.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Output Format";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(555, 306);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(85, 29);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "Clear Content";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // voice_Cbx
            // 
            this.voice_Cbx.AllowDrop = true;
            this.voice_Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.voice_Cbx.FormattingEnabled = true;
            this.voice_Cbx.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.voice_Cbx.Location = new System.Drawing.Point(556, 29);
            this.voice_Cbx.Name = "voice_Cbx";
            this.voice_Cbx.Size = new System.Drawing.Size(82, 21);
            this.voice_Cbx.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(648, 423);
            this.Controls.Add(this.voice_Cbx);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.output_Cbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.delay_Cbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Resume);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text To Speech";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Resume;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox delay_Cbx;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox output_Cbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ComboBox voice_Cbx;
    }
}

