/*
 * Lords of the Fallen RU language patcher
 * by Sualfred (DerFred)
 * Original HEX Patching method by Fernando Rocha (https://social.msdn.microsoft.com/profile/fernandorocha/)
 * 
 */

using System;
using System.IO;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Lords of the Fallen - RU - Language Changer")]
[assembly: AssemblyProduct("Lords of the Fallen - RU - Language Changer")]
[assembly: AssemblyCopyright("by sualfred(DerFred)")]
[assembly: AssemblyVersion("3.2")]
[assembly: AssemblyFileVersion("3.2")]

namespace LotF_patcher
{

	

    class Program
    {
      	  
	private static readonly string originalFile = @".\bin\LordsOfTheFallen.exe";
    private static readonly string backupFile = @".\bin\LordsOfTheFallen.sic";
	private static readonly string backupFileOld = @".\bin\LordsOfTheFallen.bak";
	private static readonly string voiceFile = @".\audio\speech-english.fsb";
	private static readonly string voiceGer = @".\audio\speech-german.fsb";
	private static readonly string voiceFr = @".\audio\speech-french.fsb";
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
	
	private static void WriteLang(string Line, string Line2)
		{
        // These examples assume a "C:\Users\Public\TestFolder" folder on your machine.
        // You can modify the path if necessary.

        // Example #1: Write an array of strings to a file.
        // Create a string array that consists of three lines.
        string[] lines = {Line, Line2};
        // WriteAllLines creates a file, writes a collection of strings to the file,
        // and then closes the file.
        System.IO.File.WriteAllLines(@".\language.ini", lines);
		}
	
	private static bool DetectPatch(byte[] sequence, int position)
        {
            if (position + PatchFind.Length > sequence.Length) return false;
            for (int p = 0; p < PatchFind.Length; p++)
            {
                if (PatchFind[p] != sequence[position + p]) return false;
            }
            return true;
        }
	
	private static bool DetectFred(byte[] sequence, int position)
        {
            if (position + FredFind.Length > sequence.Length) return false;
            for (int p = 0; p < FredFind.Length; p++)
            {
                if (FredFind[p] != sequence[position + p]) return false;
            }
            return true;
        }

	
	
	private static void CheckFile(string originalFile)
        {
            // Ensure target directory exists.
            byte[] fileContent = File.ReadAllBytes(originalFile);
            // Detect and patch file.
            for (int p = 0; p < fileContent.Length; p++)
            {
                if (!DetectFred(fileContent, p)) continue;          	 	
		
		Console.Write("\n");
		Console.WriteLine("STEAM update detected: nope...");
		File.Delete(originalFile);
		File.Copy(backupFile, originalFile);
		File.Delete(backupFile);
            }
        }
	
	private static void PatchFile(string originalFile, string patchedFile, string eingabe)
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
			
			if(eingabe == "1") fileContent[p + w] = PatchEn[w];
			else if(eingabe == "2") fileContent[p + w] = PatchGer[w];
			else if(eingabe == "3") fileContent[p + w] = PatchFr[w];
			else if(eingabe == "4") fileContent[p + w] = PatchIt[w];
			else if(eingabe == "5") fileContent[p + w] = PatchSp[w];
			else if(eingabe == "6") fileContent[p + w] = PatchRu[w];
			else if(eingabe == "7") fileContent[p + w] = PatchPl[w];
			else if(eingabe == "8") fileContent[p + w] = PatchCz[w];
			else if(eingabe == "9") fileContent[p + w] = PatchJp[w];
			else if(eingabe == "10") fileContent[p + w] = PatchPt[w];
			else if(eingabe == "11") fileContent[p + w] = PatchKr[w];
			else if(eingabe == "12") fileContent[p + w] = PatchBr[w];
			else if(eingabe == "13") fileContent[p + w] = PatchCn[w];
                }
		
		if (File.Exists(backupFileOld)) 
		{
		Console.Write("\n");
		Console.WriteLine("Deleting obsolute existing backup...");
		Console.Write("\n");
		File.Delete(backupFileOld);
		}
		if (!File.Exists(backupFile)) 
		{
		Console.Write("\n");
		Console.WriteLine("Creating backup...");
		Console.Write("\n");
		File.Copy(originalFile, backupFile);		
		}
		else
		{
		Console.Write("\n");
		Console.WriteLine("Fresh install or STEAM update detected: Yup...");
		Console.Write("\n");
		Console.WriteLine("Creating backup...");
		Console.Write("\n");
		File.Delete(backupFile);
		File.Copy(originalFile, backupFile);
		}
		
		
			
            }

	
	// Save it to another location.
	Console.WriteLine("Applying language patch...");
	Console.Write("\n");
	File.WriteAllBytes(patchedFile, fileContent);
	
        }

        static void Main(string[] args)
        {
	Console.WindowWidth = (Console.LargestWindowWidth * 37 / 100);
	Console.WindowHeight = (Console.LargestWindowHeight * 7 / 10);		
	
Console.Write("\n");
Console.Write(@"	     .__                       .___                   _____         "); Console.Write("\n");
Console.Write(@"	     |  |    ____  _______   __| _/  ______   ____  _/ ____\        "); Console.Write("\n");
Console.Write(@"	     |  |   /  _ \ \_  __ \ / __ |  /  ___/  /  _ \ \   __\         "); Console.Write("\n");
Console.Write(@"	     |  |__(  <_> ) |  | \// /_/ |  \___ \  (  <_> ) |  |           "); Console.Write("\n");
Console.Write(@"	     |____/ \____/  |__|   \____ | /____  >  \____/  |__|           "); Console.Write("\n");
Console.Write(@"	                                \/      \/                          "); Console.Write("\n");
Console.Write(@"	  __   .__                _____         .__   .__                   "); Console.Write("\n");
Console.Write(@"	_/  |_ |  |__    ____   _/ ____\_____   |  |  |  |    ____    ____  "); Console.Write("\n");
Console.Write(@"	\   __\|  |  \ _/ __ \  \   __\ \__  \  |  |  |  |  _/ __ \  /    \ "); Console.Write("\n");
Console.Write(@"	 |  |  |   Y  \\  ___/   |  |    / __ \_|  |__|  |__\  ___/ |   |  \"); Console.Write("\n");
Console.Write(@"	 |__|  |___|  / \___  >  |__|   (____  /|____/|____/ \___  >|___|  /"); Console.Write("\n");
Console.Write(@"	            \/      \/               \/                  \/      \/ "); Console.Write("\n");
Console.Write("\n");
Console.Write("    	       (RU) Language Changer v3.2 - by Sualfred(DerFred)");
Console.Write("\n");
Console.Write("                                         ---\n");
Console.Write("          THX at www.gamekeys4all.com for verify and testing this patch\n");
Console.Write("\n");
Console.Write("\n");
			
		// hier wars menu
			
				
			// Menu

			Console.Write("-----------------------\n");
			Console.Write("Text Language Selector\n");
			Console.Write("-----------------------\n");
			Console.Write("1 - Apply English\n");
			Console.Write("2 - Apply German\n");
			Console.Write("3 - Apply French\n");
			Console.Write("4 - Apply Italian\n");
			Console.Write("5 - Apply Spanish\n");
			Console.Write("6 - Apply Russian\n");
			Console.Write("7 - Apply Polish\n");
			Console.Write("8 - Apply Czech\n");
			Console.Write("9 - Apply Japanese\n");
			Console.Write("10 - Apply Portuguese\n");
			Console.Write("11 - Apply Korean\n");
			Console.Write("12 - Apply Portuguese - Brazil\n");
			Console.Write("13 - Apply Chinese (experimental - maybe fonts won't work)\n");
			Console.Write("-----------------------\n");
			Console.Write("\n");

			// Schleife 	

			do {
			Console.Write("Please choose: ");
			string eingabe = Console.ReadLine();
			
			if(eingabe == "1") 
				{
				Console.Write("\n");
				Console.WriteLine("Patching voice over language (EN)...");
				PatchFile(originalFile, originalFile, eingabe);
				WriteLang("game_language_text = english", "game_language_voice = english");
				break;
				}
			
				else if(eingabe == "2") 
					{
					Console.Write("\n");
					Console.WriteLine("Patching text language (GER)...");
					PatchFile(originalFile, originalFile, eingabe);
					WriteLang("game_language_text = german", "game_language_voice = english");
					break;
					}
				
				else if(eingabe == "3") 
					{
					Console.Write("\n");
					Console.WriteLine("Patching text language (FR)...");
					PatchFile(originalFile, originalFile, eingabe);
					break;
					}
				
				else if(eingabe == "4") 
					{
					Console.Write("\n");
					Console.WriteLine("Patching text language (IT)...");
					PatchFile(originalFile, originalFile, eingabe);
					WriteLang("game_language_text = italian", "game_language_voice = english");
					break;
					}
				
				else if(eingabe == "5") 
					{
					Console.Write("\n");
					Console.WriteLine("Patching text language (SP)...");
					PatchFile(originalFile, originalFile, eingabe);
					WriteLang("game_language_text = spanish", "game_language_voice = english");
					break;
					}
				
				else if(eingabe == "6") 
					{
					Console.Write("\n");
					Console.WriteLine("Patching text language (RU)...");
					PatchFile(originalFile, originalFile, eingabe);
					WriteLang("game_language_text = russian", "game_language_voice = english");
					break;
					}
					
				else if(eingabe == "7") 
					{
					Console.Write("\n");
					Console.WriteLine("Patching text language (PL)...");
					PatchFile(originalFile, originalFile, eingabe);
					WriteLang("game_language_text = polish", "game_language_voice = english");
					break;
					}
				
				else if(eingabe == "8") 
					{
					Console.Write("\n");
					Console.WriteLine("Patching text language (CZ)...");
					PatchFile(originalFile, originalFile, eingabe);
					WriteLang("game_language_text = czech", "game_language_voice = english");
					break;
					}
					
				else if(eingabe == "9") 
					{
					Console.Write("\n");
					Console.WriteLine("Patching text language (JP)...");
					PatchFile(originalFile, originalFile, eingabe);
					WriteLang("game_language_text = japanese", "game_language_voice = english");
					break;
					}
					
				else if(eingabe == "13") 
					{
					Console.Write("\n");
					Console.WriteLine("Patching text language (CN)...");
					PatchFile(originalFile, originalFile, eingabe);
					WriteLang("game_language_text = chinese", "game_language_voice = english");
					break;
					}
					
				else if(eingabe == "10") 
					{
					Console.Write("\n");
					Console.WriteLine("Patching text language (PT)...");
					PatchFile(originalFile, originalFile, eingabe);
					WriteLang("game_language_text = portuguese", "game_language_voice = english");
					break;
					}
					
				else if(eingabe == "11") 
					{
					Console.Write("\n");
					Console.WriteLine("Patching text language (KR)...");
					PatchFile(originalFile, originalFile, eingabe);
					WriteLang("game_language_text = korean", "game_language_voice = english");
					break;
					}
					
				else if(eingabe == "12") 
					{
					Console.Write("\n");
					Console.WriteLine("Patching text language (PT-BR)...");
					PatchFile(originalFile, originalFile, eingabe);
					WriteLang("game_language_text = brazilian", "game_language_voice = english");
					break;
					}
				
				else {
					// Fehleingabe! 
					Console.Write("\n");
					Console.Write("Wrong input - please choose again\n");
					Console.Write("\n");
					}
					
			} while(true);
			
			
			// Voice questions

			Console.Write("\n");
			Console.Write("-----------------------\n");
			Console.Write("Which voice over language do you want?\n");
			Console.Write("-----------------------\n");
			Console.Write("1 - English\n");
			Console.Write("2 - German\n");
			Console.Write("3 - French\n");
			Console.Write("-----------------------\n");
			Console.Write("\n");

			// Schleife 	

			do {
			Console.Write("Please choose: ");
			string voicepatch = Console.ReadLine();
			
			if(voicepatch == "1") 
				{
				Console.WriteLine();
				Console.WriteLine("Changing Lords of the Fallen voice over...");
				Console.WriteLine();

				Console.WriteLine("Backing up original files...");
				Console.WriteLine();
				if (File.Exists(voicebackupFile))
					{
					Console.WriteLine("Applying EN voice over...");
					File.Delete(voiceFile);
					File.Copy(voicebackupFile, voiceFile);
					}
				else
					{
					Console.WriteLine("Creating backup...");
					Console.WriteLine();
					File.Copy(voiceFile, voicebackupFile);
					Console.WriteLine("Applying EN voice over...");
					File.Delete(voiceFile);
					File.Copy(voicebackupFile, voiceFile);
					}		
				break;
				}
				
			else if(voicepatch == "2") 
					{
					Console.WriteLine();
					Console.WriteLine("Changing Lords of the Fallen voice over...");
					Console.WriteLine();

					Console.WriteLine("Backing up original files...");
					Console.WriteLine();
					if (File.Exists(voicebackupFile))
						{
						Console.WriteLine("Applying GER voice over...");
						File.Delete(voiceFile);
						File.Copy(voiceGer, voiceFile);
						}
					else
						{
						Console.WriteLine("Creating backup...");
						Console.WriteLine();
						File.Copy(voiceFile, voicebackupFile);
						Console.WriteLine("Applying GER voice over...");
						File.Delete(voiceFile);
						File.Copy(voiceGer, voiceFile);
						}		
					break;
					}
					
					else if(voicepatch == "3") 
					{
					Console.WriteLine();
					Console.WriteLine("Changing Lords of the Fallen voice over...");
					Console.WriteLine();

					Console.WriteLine("Backing up original files...");
					Console.WriteLine();
					if (File.Exists(voicebackupFile))
						{
						Console.WriteLine("Applying FR voice over...");
						File.Delete(voiceFile);
						File.Copy(voiceFr, voiceFile);
						}
					else
						{
						Console.WriteLine("Creating backup...");
						Console.WriteLine();
						File.Copy(voiceFile, voicebackupFile);
						Console.WriteLine("Applying FR voice over...");
						File.Delete(voiceFile);
						File.Copy(voiceFr, voiceFile);
						}		
					break;
					}					
			else {
				// Fehleingabe! 
				Console.Write("\n");
				Console.Write("Wrong input - please choose again\n");
				Console.Write("\n");
				}
			} while(true);
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("---\n");
			Console.WriteLine("All done! And don't forget to hate region restrictions.");
			Console.Write("Please smash your head against your keyboard to exit.");
			Console.Write("\n");
			Console.Read(); 
			
           // Thread.Sleep(10000);
        }
    }
}