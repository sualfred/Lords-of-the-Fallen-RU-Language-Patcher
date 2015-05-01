	     .__                       .___                   _____         
	     |  |    ____  _______   __| _/  ______   ____  _/ ____\        
	     |  |   /  _ \ \_  __ \ / __ |  /  ___/  /  _ \ \   __\         
	     |  |__(  <_> ) |  | \// /_/ |  \___ \  (  <_> ) |  |           
	     |____/ \____/  |__|   \____ | /____  >  \____/  |__|           
	                                \/      \/                          
	  __   .__                _____         .__   .__                   
	_/  |_ |  |__    ____   _/ ____\_____   |  |  |  |    ____    ____  
	\   __\|  |  \ _/ __ \  \   __\ \__  \  |  |  |  |  _/ __ \  /    \ 
	 |  |  |   Y  \\  ___/   |  |    / __ \_|  |__|  |__\  ___/ |   |  \
	 |__|  |___|  / \___  >  |__|   (____  /|____/|____/ \___  >|___|  /
	            \/      \/               \/                  \/      \/ 

    	       (RU) Language Changer v3.4 - by Sualfred(DerFred)
			   
			   
##############################################################################
What does this patch?
##############################################################################
This patcher is written for Lords of the Fallen (RU).
It allows you to change the text and the voice-over language.

##############################################################################
How-To:
##############################################################################
- Place the file in your installation folder
- Run the patch
- Follow the instructions
- If STEAM released a patch and your game is Russian again, run the patch again

##############################################################################
Supported Languages
##############################################################################
Text: EN,RU,BR,PT,JP,KR,IT,FR,FR,CZ,PL,SP, CN
Voice-Over: EN, DE, FR

##############################################################################
Change Log v3.4
##############################################################################
- Added "Help" button with the trouble shooting hitngs
- Added security checks to prevent using this patcher on non-RU versions, 
because they aren't compatible
- Improved Steam update patch detection
- Code cleanup
- Small other things

##############################################################################
Change Log v3.3
##############################################################################
- Added GUI
- Added some more file checks to prevent errors and a broken installation
- Fixed small issues

##############################################################################
Known Issues:
##############################################################################
- Chinese language has a missing font. It seems that is a bug in Lords of the 
Fallen. Should be fixed with the upcoming patches by STEAM.
- This patcher COULD cause troubles with versions < 3.1. If this happen to 
you, follow the trouble shooting guide below.
##############################################################################
			   
##############################################################################
Trouble Shooting
##############################################################################
If the patch is creating errors or the language won't change:
Step#1:
- Go to the subfolder "/bin"
- Delete lordsofthefallen.exe
- Delete (if files exist) lordsofthefallen.sic and lordsofthefallen.bac
- Go back and switch to the subfolder "/audio"
- Delete speech-english.fsb
- Delete (if file exists) speech-english.bak
- Let Steam verify your local files (it will re-download some files)
- Use my patch again (Version 3.2 !!!)
- Test

If it still doesn't work:
Step#2 :
- Go to your installation folder
- Delete settings.ini
- Delete language.ini
- Go to C:\Users\%USER%\Documents\Lords of the Fallen
- Delete settings.ini
- Run the game
