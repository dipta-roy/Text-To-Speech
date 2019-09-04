using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Pipes;
using System.IO;
using NAudio.Lame;
using NAudio.Wave;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
               
        SpeechSynthesizer speechSynthesizerObj;
        private void Form1_Load(object sender, EventArgs e)
        {
        //Form Load Event
            speechSynthesizerObj = new SpeechSynthesizer();
            btn_Resume.Enabled = false;
            btn_Pause.Enabled = false;
            btn_Stop.Enabled = false;
            output_Cbx.Text = "MP3";
            delay_Cbx.Text = "0";
            voice_Cbx.Text = "Male";
        }
        private void Btn_Start_Click(object sender, EventArgs e)
        {
        //On Start Button Click
            try
            {
                int delay;
                if(delay_Cbx.Text == ""){
                    delay = 0;
                } else {
                    //setting up delay
                    delay = Convert.ToInt32(delay_Cbx.Text) * 1000;
                }
                System.Threading.Thread.Sleep(delay);
                speechSynthesizerObj.Dispose(); //clean cache
                if (richTextBox1.Text != "")
                {
                    speechSynthesizerObj = new SpeechSynthesizer();
                    //voice module male/female selection
                    if(voice_Cbx.Text == "Male")
                    {
                        speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Male);
                    } else if(voice_Cbx.Text == "Female")
                    {
                        speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Female);
                    } else
                    {
                        //error incase of invalid voice selection
                        throw new Exception("Invalid Voice Type");
                    }
                    //enabling pause,stop button. disabling start, delay, voice, save, output, clear, text box
                    btn_Pause.Enabled = true;
                    btn_Stop.Enabled = true;
                    btn_Start.Enabled = false;
                    delay_Cbx.Enabled = false;
                    voice_Cbx.Enabled = false;
                    btn_Save.Enabled = false;
                    output_Cbx.Enabled = false;
                    btn_Clear.Enabled = false;
                    richTextBox1.Enabled = false;
                    speechSynthesizerObj.SpeakAsync(richTextBox1.Text); //play text box audio
                    speechSynthesizerObj.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(SpeechComplete);
                   } else
                {   
                    //if text box is empty. throw error
                    throw new Exception("Container is Empty!");
                }
            } catch(Exception ex)
            {
                //catch unexpected exception
                MessageBox.Show(ex.Message);
            }
        }
        private void SpeechComplete(Object sender,EventArgs e)
        {
            btn_Stop.PerformClick();
        }
        private void Btn_Pause_Click(object sender, EventArgs e)
        {
        //On Pause Button Click
            try
            {
                if (speechSynthesizerObj != null)
                {
                    if (speechSynthesizerObj.State == SynthesizerState.Speaking)
                    {
                        speechSynthesizerObj.Pause();
                        // enabling and disabling buttons
                        btn_Resume.Enabled = true;
                        btn_Start.Enabled = false;
                        btn_Pause.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                //catch unexpected exception
                MessageBox.Show(ex.Message);
            }
        }
        private void Btn_Resume_Click(object sender, EventArgs e)
        {
            // On Resume button clicked
            try
            {
                if (speechSynthesizerObj != null)
                {
                    if (speechSynthesizerObj.State == SynthesizerState.Paused)
                    {
                        speechSynthesizerObj.Resume();
                        // enabling and disabling buttons
                        btn_Resume.Enabled = false;
                        btn_Start.Enabled = false;
                        btn_Pause.Enabled = true;
                        

                    }
                }
            }
            catch (Exception ex)
            {
                //catch unexpected exception
                MessageBox.Show(ex.Message);
            }
        }
        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            //On Stop Button Clicked
            try
            {
                if (speechSynthesizerObj != null)
                {
                    //Clean Cache
                    speechSynthesizerObj.Dispose();
                    // enabling and disabling buttons
                    btn_Start.Enabled = true;
                    btn_Resume.Enabled = false;
                    btn_Pause.Enabled = false;
                    btn_Stop.Enabled = false;
                    voice_Cbx.Enabled = true;
                    delay_Cbx.Enabled = true;
                    btn_Save.Enabled = true;
                    output_Cbx.Enabled = true;
                    btn_Clear.Enabled = true;
                    richTextBox1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                //catch unexpected exception
                MessageBox.Show(ex.Message);
            }
        }
        public static void ConvertWavStreamToMp3File(ref MemoryStream ms, string savetofilename)
        {
            //Convert audio stream to WAV file
            ms.Seek(0, SeekOrigin.Begin);
            using (var retMs = new MemoryStream())
            using (var rdr = new WaveFileReader(ms))
            using (var wtr = new LameMP3FileWriter(savetofilename, rdr.WaveFormat, LAMEPreset.VBR_90))
            {
                rdr.CopyTo(wtr);
            }
        }
        private void Btn_SaveAsMP3_Click(object sender, EventArgs e)
        {
            //On Save as button clicked
            try
            {
                if (richTextBox1.Text == "")
                {
                    //throw exception if text box is empty
                    throw new Exception("Container is Empty!");
                }
                
                speechSynthesizerObj = new SpeechSynthesizer();
                String ofileName;
                SaveFileDialog save = new SaveFileDialog();
                //select voice module
                if (voice_Cbx.Text == "Male")
                {
                    speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Male);
                }
                else if (voice_Cbx.Text == "Female")
                {
                    speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Female);
                }
                else
                {
                    throw new Exception("Invalid Voice Type");
                }
                //Choose file type MP3/WAV
                if (output_Cbx.Text == "MP3")
                {
                    //for MP3 file
                    save.Filter = "MP3| *.mp3";
                    save.ShowDialog();
                    ofileName = save.FileName;
                    MemoryStream ms = new MemoryStream();
                    speechSynthesizerObj.SetOutputToWaveStream(ms);
                    speechSynthesizerObj.Speak(richTextBox1.Text);
                    ConvertWavStreamToMp3File(ref ms, ofileName);
                    MessageBox.Show("MP3 File Generated");
                } else if(output_Cbx.Text == "WAV")
                {
                //for WAV file
                    save.Filter = "Wave Files| *.wav";
                    save.ShowDialog();
                    ofileName = save.FileName;
                    //SpeechSynthesizer ss = new SpeechSynthesizer();
                    speechSynthesizerObj.SetOutputToWaveFile(ofileName);
                    speechSynthesizerObj.Speak(richTextBox1.Text);
                    speechSynthesizerObj.SetOutputToDefaultAudioDevice();
                    MessageBox.Show("WAV File Generated");
                }
                else
                {
                //Catch invalid file type exception 
                    throw new Exception("Invalid File Type");
                }
            }
            catch(Exception ex)
            {
                //Catch unexpected exception
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //clean cache
                speechSynthesizerObj.Dispose();
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            //On Close button clicked
            Application.Exit();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            //On Clear button clicked
            try
            {
                if (richTextBox1.Text != "")
                {
                    richTextBox1.Text = "";
                }
                else
                {
                    throw new Exception("Container is Empty!");
                }
            } catch(Exception ex)
            {
            //Catch unexpected exception
                MessageBox.Show(ex.Message);
            }
            finally
            {
            //Clean any cache object
                speechSynthesizerObj.Dispose();
            }
        }
    }
}
