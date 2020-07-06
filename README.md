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

SCREENSHOTS:

![loginscreen](https://user-images.githubusercontent.com/47063149/85290241-f6fc9b00-b498-11ea-8500-da2502fa339b.jpg)


SHORT INSTRUCTION:
After importing "CoPoleci?" database to your server you have to put a file called "root_config.txt" in bin/Debug.
This file should contain five lines - in sequence: nickname, password, server address, database name and port.
For example:

root

mypassword

localhost

copoleci

3306

And that's all! If your server is on and correct file is in the correct place, everything should work. Have fun!
