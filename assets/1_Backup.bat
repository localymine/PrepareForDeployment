@echo off
set production_root=C:\GTL\WEB_APP\GMAWEB
set cur_date=20170228
set cur_time=1600
set backup_folder=Backup_Folder
set backup_root=F:\%backup_folder%\%cur_date%\%cur_time%\bk\GMAWEB
set deploy_root=F:\%backup_folder%\%cur_date%\%cur_time%\deploy\GMAWEB

:Syntax
echo .------------------------------------
echo Backup Sourcecode From The Production
echo Base on The Files List in Release Note
echo .------------------------------------
echo
:End

:: go to F
F:

if not exist F:\%backup_folder% md F:\%backup_folder%
if not exist F:\%backup_folder%\%cur_date% md F:\%backup_folder%\%cur_date% 
if not exist F:\%backup_folder%\%cur_date%\%cur_time% md F:\%backup_folder%\%cur_date%\%cur_time%
if not exist F:\%backup_folder%\%cur_date%\%cur_time%\bk md F:\%backup_folder%\%cur_date%\%cur_time%\bk
if not exist %backup_root% md %backup_root%
if not exist %backup_root%\Areas md %backup_root%\Areas
if not exist %backup_root%\Areas\GMA.Customer md %backup_root%\Areas\GMA.Customer
if not exist %backup_root%\Areas\GMA.Customer\Views md %backup_root%\Areas\GMA.Customer\Views
if not exist %backup_root%\Areas\GMA.Customer\Views\Template md %backup_root%\Areas\GMA.Customer\Views\Template
if not exist %backup_root%\Areas\GMA.Customer\bin md %backup_root%\Areas\GMA.Customer\bin
if not exist %backup_root%\Content md %backup_root%\Content
if not exist %backup_root%\Content\Images md %backup_root%\Content\Images
if not exist %backup_root%\Scripts md %backup_root%\Scripts
if not exist %backup_root%\bin md %backup_root%\bin

copy %production_root%\Areas\GMA.Customer\Views\Template\EditCard.cshtml %backup_root%\Areas\GMA.Customer\Views\Template\EditCard.cshtml
copy %production_root%\Areas\GMA.Customer\Views\Template\ZoomAndCropImage.cshtml %backup_root%\Areas\GMA.Customer\Views\Template\ZoomAndCropImage.cshtml
copy %production_root%\Areas\GMA.Customer\bin\GMA.Customer.dll %backup_root%\Areas\GMA.Customer\bin\GMA.Customer.dll
copy %production_root%\Content\jquery-ui-1.7.2.custom.css %backup_root%\Content\jquery-ui-1.7.2.custom.css
copy %production_root%\Content\jquery.cropzoom.css %backup_root%\Content\jquery.cropzoom.css
copy %production_root%\Content\Images\ui-bg_gloss-wave_45_817865_500x100.png %backup_root%\Content\Images\ui-bg_gloss-wave_45_817865_500x100.png
copy %production_root%\Content\Images\ui-bg_gloss-wave_70_ffdd57_500x100.png %backup_root%\Content\Images\ui-bg_gloss-wave_70_ffdd57_500x100.png
copy %production_root%\Content\Images\ui-bg_gloss-wave_60_fece2f_500x100.png %backup_root%\Content\Images\ui-bg_gloss-wave_60_fece2f_500x100.png
copy %production_root%\Content\Images\ui-bg_inset-soft_30_ffffff_1x100.png %backup_root%\Content\Images\ui-bg_inset-soft_30_ffffff_1x100.png
copy %production_root%\Content\Images\ui-icons_d19405_256x240.png %backup_root%\Content\Images\ui-icons_d19405_256x240.png
copy %production_root%\Scripts\jquery-1.6.2.min.js %backup_root%\Scripts\jquery-1.6.2.min.js
copy %production_root%\Scripts\jquery-ui-1.8.14.custom.min.js %backup_root%\Scripts\jquery-ui-1.8.14.custom.min.js
copy %production_root%\Scripts\jquery.cropzoom.js %backup_root%\Scripts\jquery.cropzoom.js
copy %production_root%\bin\GMA.Customer.dll %backup_root%\bin\GMA.Customer.dll

pause