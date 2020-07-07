@echo off
echo TWORZENIE BAZY
mysql -uroot -p -e "create database copoleci;"
echo IMPORTOWANIE BAZY Z PLIKU
mysql -uroot -p copoleci < %cd%\CoPoleci_Database.sql
cd bin\Debug
call CoPoleci.exe