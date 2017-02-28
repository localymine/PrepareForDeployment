@echo off
set production_root=C:\GTL\WEB_APP\GMAWEB
set cur_date=20170228
set cur_time=xxxx
set backup_folder=Backup_Folder
set backup_root=F:\%backup_folder%\%cur_date%\%cur_time%\bk\GMAWEB

:Syntax
echo .------------------------------------
echo Delete The Files From The Production
echo Restore The Backup Files
echo .------------------------------------
echo
:End

del %production_root%\Areas\GMA.Customer\Views\Template\EditCard.cshtml
del %production_root%\Areas\GMA.Customer\Views\Template\ZoomAndCropImage.cshtml
del %production_root%\Areas\GMA.Customer\bin\GMA.Customer.dll
del %production_root%\Content\jquery-ui-1.7.2.custom.css
del %production_root%\Content\jquery.cropzoom.css
del %production_root%\Content\Images\ui-bg_gloss-wave_45_817865_500x100.png
del %production_root%\Content\Images\ui-bg_gloss-wave_70_ffdd57_500x100.png
del %production_root%\Content\Images\ui-bg_gloss-wave_60_fece2f_500x100.png
del %production_root%\Content\Images\ui-bg_inset-soft_30_ffffff_1x100.png
del %production_root%\Content\Images\ui-icons_d19405_256x240.png
del %production_root%\Scripts\jquery-1.6.2.min.js
del %production_root%\Scripts\jquery-ui-1.8.14.custom.min.js
del %production_root%\Scripts\jquery.cropzoom.js
del %production_root%\bin\GMA.Customer.dll


copy %backup_root%\Areas\GMA.Customer\Views\Template\EditCard.cshtml %production_root%\Areas\GMA.Customer\Views\Template\EditCard.cshtml
copy %backup_root%\Areas\GMA.Customer\Views\Template\ZoomAndCropImage.cshtml %production_root%\Areas\GMA.Customer\Views\Template\ZoomAndCropImage.cshtml
copy %backup_root%\Areas\GMA.Customer\bin\GMA.Customer.dll %production_root%\Areas\GMA.Customer\bin\GMA.Customer.dll
copy %backup_root%\Content\jquery-ui-1.7.2.custom.css %production_root%\Content\jquery-ui-1.7.2.custom.css
copy %backup_root%\Content\jquery.cropzoom.css %production_root%\Content\jquery.cropzoom.css
copy %backup_root%\Content\Images\ui-bg_gloss-wave_45_817865_500x100.png %production_root%\Content\Images\ui-bg_gloss-wave_45_817865_500x100.png
copy %backup_root%\Content\Images\ui-bg_gloss-wave_70_ffdd57_500x100.png %production_root%\Content\Images\ui-bg_gloss-wave_70_ffdd57_500x100.png
copy %backup_root%\Content\Images\ui-bg_gloss-wave_60_fece2f_500x100.png %production_root%\Content\Images\ui-bg_gloss-wave_60_fece2f_500x100.png
copy %backup_root%\Content\Images\ui-bg_inset-soft_30_ffffff_1x100.png %production_root%\Content\Images\ui-bg_inset-soft_30_ffffff_1x100.png
copy %backup_root%\Content\Images\ui-icons_d19405_256x240.png %production_root%\Content\Images\ui-icons_d19405_256x240.png
copy %backup_root%\Scripts\jquery-1.6.2.min.js %production_root%\Scripts\jquery-1.6.2.min.js
copy %backup_root%\Scripts\jquery-ui-1.8.14.custom.min.js %production_root%\Scripts\jquery-ui-1.8.14.custom.min.js
copy %backup_root%\Scripts\jquery.cropzoom.js %production_root%\Scripts\jquery.cropzoom.js
copy %backup_root%\bin\GMA.Customer.dll %production_root%\bin\GMA.Customer.dll

pause