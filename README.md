# CoPoleci
C#/WPF project that uses MySql DataBase. 

"CoPoleci?" is a desktop application and it is all about movies. 
It has its own database containing information about films, actors, directors and film companies. 
The application allows you to browse and search among its resources. It provides the possibility to display rankings and
it has a registration and logging mechanism. Logged in users have the possibility to mark already watched movies and add a short commentary.
"CoPoleci?" also has a built-in a movie recommendation system based on artificial intelligence mechanisms. 
The user at the entrance indicates how much he or she cares about the specific parameters of the film 
and the system in response to his or her choices shows him or her a list of several suggestions, 
but excluding films that the user has already seen. 

## SCREENSHOTS:

![loginscreen](https://user-images.githubusercontent.com/47063149/85290241-f6fc9b00-b498-11ea-8500-da2502fa339b.jpg)


## SHORT INSTRUCTION:
After you clone the project first thing you need to do is to edit a file called "root_config.txt" which is in bin/Debug.
This file contains five lines - in sequence: nickname, password, server address, database name and port.
By default you can see there is a root's account with no password and localhost server on port 3306.

Second thing is to turn on the server and create+import database - to make it faster you can simply double-click 
DataInserter.bat file and enter your root's password twice.

And this is it. Everything should work now. Have fun!
