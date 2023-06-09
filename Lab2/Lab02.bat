set created=відкрито
set tmpFilesPath=%~2
set /a count=0
if not exist "%~1" (
	echo start log>"%~1"
	set created=створено
)
start w32tm /resync
set _time=%time:~0,-3%
echo %date% - %_time%>>"%~1"
echo Файл %~1 успішно %created%>>"%~1"
tasklist>>"%~1"
taskkill /im %~3
set _time=%time:~0,-3%
echo %date% - %_time%>>"%~1"

if "%ERRORLEVEL%" EQU "0" (
	echo Файл %~3 успішно завершено >>"%~1"
) else (
	echo Помилка. Файл %~3 не завершено>>"%~1"
)
setlocal ENABLEDELAYEDEXPANSION
for /r %~2 %%g in (*.tmp, temp*.*)do (
	set /a count=count+1
	del "%%g">>"%~1"
)
set _time=%time:~0,-3%
echo %date% - %_time%>>"%~1"
echo Кількість видалених файлів - "%count%">>"%~1"

set CUR_HH=%time:~0,2%
if %CUR_HH% lss 10 (set CUR_HH=0%time:~1,1%)
set CUR_NN=%time:~3,2%
set CUR_SS=%time:~6,2%
set SUBFILENAME=%CUR_HH%,%CUR_NN%,%CUR_SS%
"C:\Program Files\7-Zip\7z.exe" a -r "%DATE:~7,2%.%DATE:~4,2%.%DATE:~-4%_%SUBFILENAME%".7z "%~2\*"
set _time=%time:~0,-3%
echo %date% - %_time%>>"%~1"

if "%ERRORLEVEL%" EQU "0" (	
	echo Архівування файлів успішно завершено>>"%~1"
) else (
	echo Помилка. Архівування файлів не завершено>>"%~1"
)

move "%CD%\%DATE:~7,2%.%DATE:~4,2%.%DATE:~-4%_%SUBFILENAME%.7z" %~4

set _time=%time:~0,-3%
echo %date% - %_time%>>"%~1"

if "%ERRORLEVEL%" EQU "0" (	
	echo Переміщення архіву успішно завершено>>"%~1"
) else (
	echo Помилка. Переміщення архіву не завершено>>"%~1"
)
ForFiles /p "%~4" /s /d -1 /c "cmd /c echo @file">>"%~1"
::архів старший 1 дня

set _time=%time:~0,-3%
echo %date% - %_time%>>"%~1"

if "%ERRORLEVEL%" EQU "0" (
	echo Вчорашній архів існує>>"%~1"
) else (
	echo Помилка. Вчорашній архів відсутній>>%~1"
	echo %date% - %_time%>>"email.txt"
	echo Помилка. Вчорашній архів відсутній>>"email.txt"
)

set _time=%time:~0,-3%
echo %date% - %_time%>>"%~1"
ForFiles /p "%~4" /s /d -30 /c "cmd /c del @file"
if "%ERRORLEVEL%" EQU "0" (
	echo Всі архіви старші за 30 днів видалено>>"%~1"
) else (
	echo Помилка. Архівів старших за 30 днів не знайдено>>"%~1"
)

set _time=%time:~0,-3%
echo %date% - %_time%>>"%~1"
ping "google.com"
if "%ERRORLEVEL%" EQU "0" (
	echo Підключення до інтернету присутнє>>"%~1"
) else (
	echo Помилка. Підключення до інтернету відсутнє>>"%~1"
)
set _time=%time:~0,-3%
echo %date% - %_time%>>"%~1"
ipconfig | find /i "IPv4-адреса. . . . . . . . . . . . : %~5"
::порівняння ip адреси комп'ютера та того, що був у команді записаний
if %errorlevel% equ 0 (
  echo Адреса знайдена>>"%~1"
  shutdown /m \\%~5 /s
) else (
  echo Помилка. Адреса не знайдена>>"%~1"
)
arp -a>>"%~1"
find ipon.txt "%~5"
if "%ERRORLEVEL%" EQU "0" (
	set _time=%time:~0,-3%
	echo %date% - %_time%>>"%~1"
	echo Адреса присутня в ipon.txt>>"%~1"
	echo Адреса присутня в ipon.txt>>"email.txt"
)
set _time=%time:~0,-3%
echo %date% - %_time%>>"%~1"
if %~z1 GTR %~6 (
	echo Розмір "%~1" більше "%~6" >>"%~1"
	echo Розмір "%~1" більше "%~6" >>"email.txt"
)
set _time=%time:~0,-3%
echo %date% - %_time%>>"%~1"
wmic logicaldisk get size,freespace,caption |findstr.exe /r /c:".*">>"lab.log"
set CUR_HH=%time:~0,2%
if %CUR_HH% lss 10 (set CUR_HH=0%time:~1,1%)
set CUR_NN=%time:~3,2%
set CUR_SS=%time:~6,2%
set SUBFILENAME=%CUR_HH%,%CUR_NN%,%CUR_SS%
systeminfo > "systeminfo_%DATE:~7,2%.%DATE:~4,2%.%DATE:~-4%_%SUBFILENAME%.txt"
endlocal
echo =====================================>>"%~1"
