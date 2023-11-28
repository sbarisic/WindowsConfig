@echo off
echo Installing redistributables
REM Redistributables
winget install -e --id Microsoft.VCRedist.2008.x86
winget install -e --id Microsoft.VCRedist.2010.x64
winget install -e --id Microsoft.VCRedist.2012.x86
winget install -e --id Microsoft.VCRedist.2013.x86
winget install -e --id Microsoft.VCRedist.2013.x64
winget install -e --id Microsoft.VCRedist.2015+.x86

echo Installing explorer patcher
REM Explorer patcher
winget install -e --id valinet.ExplorerPatcher
taskkill /im explorer.exe /f
explorer.exe

echo Installing programs
REM Programs
winget install -e --id 7zip.7zip
winget install -e --id Notepad++.Notepad++
winget install -e --id Mozilla.Firefox
winget install -e --id Postman.Postman
winget install -e --id Spotify.Spotify
winget install -e --id VideoLAN.VLC
winget install -e --id Axosoft.GitKraken
winget install -e --id dotPDNLLC.paintdotnet
winget install -e --id Microsoft.VisualStudioCode
winget install -e --id PuTTY.PuTTY
winget install -e --id ShareX.ShareX
winget install -e --id Discord.Discord
winget install -e --id Logitech.GHUB
winget install -e --id BaldurKarlsson.RenderDoc

echo Copying local settings for programs
REM Settings
taskkill /im sharex.exe /f
robocopy "./Sharex" "%userprofile%/Documents/ShareX" /is /it
