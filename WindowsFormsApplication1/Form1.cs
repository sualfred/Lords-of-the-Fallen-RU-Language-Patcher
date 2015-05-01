using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Runtime.InteropServices;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string textLang;
        string voiceLang;
        bool fredcheck;
        bool russiancheck;
        bool gamecompatible;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
       
        private static readonly string originalFile = @".\bin\LordsOfTheFallen.exe";
        private static readonly string backupFile = @".\bin\LordsOfTheFallen.sic";
        private static readonly string backupFileOld = @".\bin\LordsOfTheFallen.bak";
        private static readonly string voiceFile = @".\audio\speech-english.fsb";
        private static readonly string voiceFileGer = @".\audio\speech-german.fsb";
        private static readonly string voiceFileFr = @".\audio\speech-french.fsb";
        private static readonly string voicebackupFile = @".\audio\speech-english.bak";

        private static readonly byte[] PatchFind = { 0x72, 0x75, 0x73, 0x73, 0x69, 0x61, 0x6E, 0x00, 0x6B, 0x6F, 0x72, 0x65, 0x61, 0x6E, 0x00, 0x00 };      // "original russian values"
        private static readonly byte[] FredFind = { 0x66, 0x72, 0x65, 0x64 };      // "my patch checker"

        private static readonly byte[] PatchRu = { 0x72, 0x75, 0x73, 0x73, 0x69, 0x61, 0x6E, 0x00, 0x00, 0x00, 0x00, 0x66, 0x72, 0x65, 0x64, 0x00 };      // "russian"
        private static readonly byte[] PatchEn = { 0x65, 0x6E, 0x67, 0x6C, 0x69, 0x73, 0x68, 0x00, 0x00, 0x00, 0x00, 0x66, 0x72, 0x65, 0x64, 0x00 };   // "english"
        private static readonly byte[] PatchGer = { 0x67, 0x65, 0x72, 0x6D, 0x61, 0x6E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x66, 0x72, 0x65, 0x64, 0x00 };   // "german"
        private static readonly byte[] PatchFr = { 0x66, 0x72, 0x65, 0x6E, 0x63, 0x68, 0x00, 0x00, 0x00, 0x00, 0x00, 0x66, 0x72, 0x65, 0x64, 0x00 };   // "french"
        private static readonly byte[] PatchIt = { 0x69, 0x74, 0x61, 0x6C, 0x69, 0x61, 0x6E, 0x00, 0x00, 0x00, 0x00, 0x66, 0x72, 0x65, 0x64, 0x00 };   // "italian"
        private static readonly byte[] PatchSp = { 0x73, 0x70, 0x61, 0x6E, 0x69, 0x73, 0x68, 0x00, 0x00, 0x00, 0x00, 0x66, 0x72, 0x65, 0x64, 0x00 };   // "spanish"
        private static readonly byte[] PatchPl = { 0x70, 0x6F, 0x6C, 0x69, 0x73, 0x68, 0x00, 0x00, 0x00, 0x00, 0x00, 0x66, 0x72, 0x65, 0x64, 0x00 };   // "polish"
        private static readonly byte[] PatchCz = { 0x63, 0x7A, 0x65, 0x63, 0x68, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x66, 0x72, 0x65, 0x64, 0x00 };   // "czech"
        private static readonly byte[] PatchKr = { 0x6B, 0x6F, 0x72, 0x65, 0x61, 0x6E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x66, 0x72, 0x65, 0x64, 0x00 };   // "korean"
        private static readonly byte[] PatchCn = { 0x63, 0x68, 0x69, 0x6E, 0x65, 0x73, 0x65, 0x00, 0x00, 0x00, 0x00, 0x66, 0x72, 0x65, 0x64, 0x00 };   // "Chinese"
        private static readonly byte[] PatchJp = { 0x6A, 0x61, 0x70, 0x61, 0x6E, 0x65, 0x73, 0x65, 0x00, 0x00, 0x00, 0x66, 0x72, 0x65, 0x64, 0x00 };   // "japanese"
        private static readonly byte[] PatchPt = { 0x70, 0x6F, 0x72, 0x74, 0x75, 0x67, 0x75, 0x65, 0x73, 0x65, 0x00, 0x66, 0x72, 0x65, 0x64, 0x00 };   // "Portuguese"
        private static readonly byte[] PatchBr = { 0x62, 0x72, 0x61, 0x7A, 0x69, 0x6C, 0x69, 0x61, 0x6E, 0x00, 0x00, 0x66, 0x72, 0x65, 0x64, 0x00 };   // "Brazilian"

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        //check for the original sequenz

        private void WriteLang(string Line, string Line2)
        {
            // These examples assume a "C:\Users\Public\TestFolder" folder on your machine.
            // You can modify the path if necessary.

            // Example #1: Write an array of strings to a file.
            // Create a string array that consists of three lines.
            string[] lines = { Line, Line2 };
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.
            System.IO.File.WriteAllLines(@".\language.ini", lines);
        }

        private bool DetectPatch(byte[] sequence, int position)
        {
            if (position + PatchFind.Length > sequence.Length) return false;
            for (int p = 0; p < PatchFind.Length; p++)
            {
                if (PatchFind[p] != sequence[position + p]) return false;
            }
            return true;
        }

        private bool DetectFred(byte[] sequence, int position)
        {
            if (position + FredFind.Length > sequence.Length) return false;
            for (int p = 0; p < FredFind.Length; p++)
            {
                if (FredFind[p] != sequence[position + p]) return false;
            }
            return true;
        }

        private void CheckFile(string originalFile)
        {
            // Ensure target directory exists.
            byte[] fileContent = File.ReadAllBytes(originalFile);
            // Detect and patch file.
            for (int p = 0; p < fileContent.Length; p++)
            {
                if (!DetectFred(fileContent, p)) continue;
                fredcheck = true;
                gamecompatible = true;
                File.Delete(originalFile);
                File.Copy(backupFile, originalFile);
                File.Delete(backupFile);
            }
        }

        private void changeLanguageINI()
        {
            Console.WriteLine("Switching font assets...");
            if (textLang == "English")
            {
                WriteLang("game_language_text = english", "game_language_voice = english");
            }

            else if (textLang == "German")
            {
                WriteLang("game_language_text = german", "game_language_voice = english");
            }

            else if (textLang == "French")
            {
                WriteLang("game_language_text = french", "game_language_voice = english");
            }

            else if (textLang == "Italian")
            {
                WriteLang("game_language_text = italian", "game_language_voice = english");
            }

            else if (textLang == "Spanish")
            {
                WriteLang("game_language_text = spanish", "game_language_voice = english");
            }

            else if (textLang == "Russian")
            {
                WriteLang("game_language_text = russian", "game_language_voice = english");
            }

            else if (textLang == "Polish")
            {
                WriteLang("game_language_text = polish", "game_language_voice = english");
            }

            else if (textLang == "Czech")
            {
                WriteLang("game_language_text = czech", "game_language_voice = english");
            }

            else if (textLang == "Japanese")
            {
                WriteLang("game_language_text = japanese", "game_language_voice = english");
            }

            else if (textLang == "Chinese")
            {
                WriteLang("game_language_text = chinese", "game_language_voice = english");
            }

            else if (textLang == "Portuguese")
            {
                WriteLang("game_language_text = portuguese", "game_language_voice = english");
            }

            else if (textLang == "Korean")
            {
                WriteLang("game_language_text = korean", "game_language_voice = english");
            }

            else if (textLang == "Brazil")
            {
                WriteLang("game_language_text = brazilian", "game_language_voice = english");
            }
        }

        private void createBackups()
        {
            if (File.Exists(backupFileOld))
            {
            Console.WriteLine("Deleting obsolute existing backup...");
            File.Delete(backupFileOld);
            }
            if (!File.Exists(backupFile))
            {
            Console.WriteLine("Creating backup...");
            File.Copy(originalFile, backupFile);
            }
            else
            {
            Console.WriteLine("Creating backup...");
            File.Delete(backupFile);
            File.Copy(originalFile, backupFile);
            }

        }
        private void PatchFile(string originalFile, string patchedFile, string textLang)
        {
            //checkfile
            CheckFile(originalFile);
            // Ensure target directory exists.
            var targetDirectory = Path.GetDirectoryName(patchedFile);
            if (targetDirectory == null) return;
            Directory.CreateDirectory(targetDirectory);

            // Read file bytes.
            byte[] fileContent = File.ReadAllBytes(originalFile);
            // Detect and patch file.
            for (int p = 0; p < fileContent.Length; p++)
            {
                if (!DetectPatch(fileContent, p)) continue;

                for (int w = 0; w < PatchFind.Length; w++)
                {

                    if (textLang == "English") fileContent[p + w] = PatchEn[w];
                    else if (textLang == "German") fileContent[p + w] = PatchGer[w];
                    else if (textLang == "French") fileContent[p + w] = PatchFr[w];
                    else if (textLang == "Italian") fileContent[p + w] = PatchIt[w];
                    else if (textLang == "Spanish") fileContent[p + w] = PatchSp[w];
                    else if (textLang == "Russian") fileContent[p + w] = PatchRu[w];
                    else if (textLang == "Polish") fileContent[p + w] = PatchPl[w];
                    else if (textLang == "Czech") fileContent[p + w] = PatchCz[w];
                    else if (textLang == "Japanese") fileContent[p + w] = PatchJp[w];
                    else if (textLang == "Portuguese") fileContent[p + w] = PatchPt[w];
                    else if (textLang == "Korean") fileContent[p + w] = PatchKr[w];
                    else if (textLang == "Brazil") fileContent[p + w] = PatchBr[w];
                    else if (textLang == "Chinese") fileContent[p + w] = PatchCn[w];
                    russiancheck = true;
                    gamecompatible = true;
                }
            }


            // Save it to another location.
            if (fredcheck)
            {
                Console.WriteLine("Existing language patch detected...");
                Console.Write("\n");
                createBackups();
                Console.WriteLine("Applying new text language settings...");
                changeLanguageINI();
                File.WriteAllBytes(patchedFile, fileContent);
                fredcheck = false;
                
            }
            else if (russiancheck)
            {
                Console.WriteLine("Installed version compatible: Hell yeah, compatible!");
                Console.Write("\n");
                createBackups();
                Console.WriteLine("Applying text language patch...");
                changeLanguageINI();
                File.WriteAllBytes(patchedFile, fileContent);
                russiancheck = false;
            }
            else
            {
                Console.WriteLine("Installed version compatible: Meeeh, nope :( ");
            }
            


        }

        // text language
        private void radioRU_CheckedChanged(object sender, EventArgs e)
        {
            textLang = "Russian";
        }

        private void radioGER_CheckedChanged(object sender, EventArgs e)
        {
            textLang = "German";
        }

        private void radioFR_CheckedChanged(object sender, EventArgs e)
        {
            textLang = "French";
        }

        private void radioEN_CheckedChanged_1(object sender, EventArgs e)
        {
            textLang = "English";
        }

        private void radioES_CheckedChanged_1(object sender, EventArgs e)
        {
            textLang = "Spanish";
        }

        private void radioCZ_CheckedChanged_1(object sender, EventArgs e)
        {
            textLang = "Czech";
        }

        private void radioKR_CheckedChanged_1(object sender, EventArgs e)
        {
            textLang = "Korean";
        }

        private void radioCN_CheckedChanged_1(object sender, EventArgs e)
        {
            textLang = "Chinese";
            if (radioCN.Checked)
            {
                Console.WriteLine("\n### WARNING ####\nThis language is experimental. It seems that the chinese font assets are missing in the game and this could cause blank ____ text labels.\nWhile this patch was written, no official fix has been released yet.");
            }
            
        }

        private void radioIT_CheckedChanged_1(object sender, EventArgs e)
        {
            textLang = "Italian";
        }

        private void radioPL_CheckedChanged_1(object sender, EventArgs e)
        {
            textLang = "Polish";
        }

        private void radioPT_CheckedChanged(object sender, EventArgs e)
        {
            textLang = "Portuguese";
        }

        private void radioJP_CheckedChanged_1(object sender, EventArgs e)
        {
            textLang = "Japanese";
        }

        private void radioBR_CheckedChanged_1(object sender, EventArgs e)
        {
            textLang = "Brazil";
        }

        // voice language
        private void voiceEN_CheckedChanged(object sender, EventArgs e)
        {
            voiceLang = "English";
        }

        private void voiceGER_CheckedChanged(object sender, EventArgs e)
        {
            voiceLang = "German";
        }

        private void voiceFR_CheckedChanged(object sender, EventArgs e)
        {
            voiceLang = "French";
        }

        private void patchButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(originalFile) | !File.Exists(voiceFile) | !File.Exists(voiceFileGer) | !File.Exists(voiceFileFr))
            {
                Console.WriteLine("Game files not found - Place this patcher in the game directory!");
            }
            else if (String.IsNullOrEmpty(textLang) | String.IsNullOrEmpty(voiceLang))
            {
                Console.WriteLine("Please select your languages first!");
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                Console.Write("\n");
                Console.WriteLine("Patch process started");
                Console.WriteLine("Text language: " + textLang);                
                Console.WriteLine("Voice over language: " + voiceLang);

                Console.Write("\n");
                Console.WriteLine("Please wait, have to analyse your game binaries...");
                PatchFile(originalFile, originalFile, textLang);

                //apply voice
                if (gamecompatible)
                {
                    Console.Write("\n");
                    Console.WriteLine("Patching voice over language...");
                    if (voiceLang == "English")
                    {
                        if (File.Exists(voicebackupFile))
                        {
                            Console.WriteLine("Replacing files...");
                            File.Delete(voiceFile);
                            File.Copy(voicebackupFile, voiceFile);
                        }
                        else
                        {
                            Console.WriteLine("No backup found, creating backup...");
                            File.Copy(voiceFile, voicebackupFile);
                            Console.WriteLine("Replacing files...");
                            File.Delete(voiceFile);
                            File.Copy(voicebackupFile, voiceFile);
                        }
                    }

                    else if (voiceLang == "German")
                    {
                        if (File.Exists(voicebackupFile))
                        {
                            Console.WriteLine("Replacing files...");
                            File.Delete(voiceFile);
                            File.Copy(voiceFileGer, voiceFile);
                        }
                        else
                        {
                            Console.WriteLine("No backup found, creating backup...");
                            File.Copy(voiceFile, voicebackupFile);
                            Console.WriteLine("Replacing files...");
                            File.Delete(voiceFile);
                            File.Copy(voiceFileGer, voiceFile);
                        }

                    }

                    else if (voiceLang == "French")
                    {
                        if (File.Exists(voicebackupFile))
                        {
                            Console.WriteLine("Replacing files...");
                            File.Delete(voiceFile);
                            File.Copy(voiceFileFr, voiceFile);
                        }
                        else
                        {
                            Console.WriteLine("No backup found, creating backup...");
                            File.Copy(voiceFile, voicebackupFile);
                            Console.WriteLine("Replacing files...");
                            File.Delete(voiceFile);
                            File.Copy(voiceFileFr, voiceFile);
                        }

                    }
                } 
                
                Console.Write("\n");
                if (gamecompatible)
                {
                    Console.WriteLine("All done! And don't forget to hate region restrictions.");
                    Console.WriteLine("Special thanks to my friends of www.gamekeys4all.com for testing!");                                      
                }
                else
                {
                    Console.WriteLine("### ERROR ###");
                    Console.WriteLine("Sry dude, but your game binaries aren't compatible.");
                    Console.WriteLine("You know that this patcher is only working for the RU version?");  
                }
                Cursor.Current = Cursors.Default;

            }
        }

        // That's our custom TextWriter class
        TextWriter _writer = null;



        private void Form1_Load(object sender, EventArgs e)
        {
            // Instantiate the writer
            _writer = new TextBoxStreamWriter(txtConsole);
            // Redirect the out Console stream
            Console.SetOut(_writer);
            this.txtConsole.ReadOnly = true;
            if (!File.Exists(originalFile) | !File.Exists(voiceFile) | !File.Exists(voiceFileGer) | !File.Exists(voiceFileFr))
            {
                Console.WriteLine("Game files not found - Place this patcher in the game directory!");
            }
            else { 
            Console.WriteLine("Please choose the languages");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=C6TLQCMA6JPG4");
        }

        private void WndProc(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-----\nTrouble Shooting:\n-----\nThis patcher only works for the RUSSIAN version and has to be placed in your game installation folder.\n\nIf the ingame languages won't change or the patcher is creating errors:\n\nStep#1:\nGo to the subfolder /BIN/\nDelete lordsofthefallen.exe\nDelete (if files exist) lordsofthefallen.sic and lordsofthefallen.bac\nGo back and switch to the subfolder /audio/\nDelete speech-english.fsb\nDelete (if file exists) speech-english.bak\nLet Steam verify your local files (it will re-download some files)\nUse my patch again\nRun the game\n\nIf it still doesn't work:\nStep#2:\nGo to your installation folder\nDelete settings.ini\nDelete language.ini\nGo to C:/Users/%USER%/Documents/Lords of the Fallen/\nDelete settings.ini\nApply this patch again\nRun the game\n\n");
        }
    }
}
       
      

