Overview:
This program was designed to simplify creating and managing an Organization per the downtime rules in the Pathfinder roleplaying game.
As the alternative involved spreadsheets that became rather cumbersome, and Augmentations were difficult to add, this was made mostly to help my group out and I thought I might as well share it.

Code Info:
The basic code shouldn't be too difficult to understand.  The program displays the SummaryDisplay form and instantiates an Organization object.
That object contains any of the relevent data the user can control, and is exported to an XML object to make it easily readable, hence most everything being public instead of private.

The Summary Display is able to show any of the other Display forms that should be instantiated.
The OrgDisplay shows minor information that is unique to the Organization, such as the name, location, and manager.
The ManagerDisplay is called from OrgDisplay, and allows information on the manager to be set.

The ObjectDisplay is a base for the RoomDisplay and TeamDisplay forms.  They edit the organizations lists of Rooms and Teams.
While teams do not currently have existing Augmentations, they may in the future so preperations were made in case they are later added.
The Rooms (and Teams) lists are made up of OrgRoom (and OrgTeam) objects.
These are both instances of the OrgObject object, which contains anything that all components must contain, mostly method calls, calculations, and some information.
The OrgObjects are build off of BaseObjects.
These contain data pulled from the included SQLite database that is populated with, as of the time of August 2015, has any open game content listed from the SRD for Managers, Rooms, and Teams.
The Org objects essentially wrap around the BaseObjects to differentiate core statistics and use controlled information on the room.
Inheritance was used because there would otherwise be a rather large amount of code duplication, but I tried to keep it as simple as possible.

The GUI folder contains any user interfaces.
The Models containts any models used to store information that is read from the database or the users saved XML file, or that will be written back out.
Andything in the Models folder beginning with Base is read from the database and is not user modifyable.
Anything beggining with Org is user controlled and written to the XML file.
XML files were used because this needs to be tossed around between members in a game.
This is not a web based program as I do not have a place to host it, but converting it would be rather simple, as the majority of the work is handled by the Models.

The Data folder containts the classes to interact with the SQL Database and the XML files.  Externalized enough so that they can be changed later if needed.

As for the individual objects in the base project folder
The App.config contains the default file path, nothing else at the moment
The Data.cs is currently static as this is a single user application and it was easier than passing anything around the program.
It holds the organization instance, and the instanced lists of anything read from the database.

Downtime.db is a simple SQLite database I created and populated with information from the Pathfinder SRDs Downtime rules, which are open rules and can be redistributed freely.
If you would like to modify this simply grab an SQLite manegment program and make whatever chnages you would like
Everything but resources should be easily changable without real source modifications.  Resource refactoring is in the todo list.

The majority of things are Int64 just because thats what the database is using, not that I ever expect anything to reach integer limits.