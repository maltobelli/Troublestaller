# Troublestaller
The troublesome installer to use for logging diagnostic demo


# How to use
## Files
Create a folder called "files" and then create folders with the below names for where you want them to install to
 - AppData -> Install to %APPDATA%
 - UserProfile -> Installed to %USERPROFILE%
 - StartMenu -> Install to user start menu
 
## Prerequisites
Create a folder called "prerequisites" and copy the installer EXE's directly into the folder
These exe's will be called with a /S command line

## Switches
 - /u - Uninstall
 - /l <path> - Log out to a file specified
