# AlsoEnergyCodeChallenge
Code challenge.


•	Concept or element that was unfamiliar or unexpected
o	I have not created a web api app in quite a while, but it was easy to figure out.
•	Constructive review or recommended improvement
o	The code is structured in a way that is really hard to read and there is no documentation to help out devs maintaining the code base, I would restructure the code to meet some level of coding standards, for instance using resharper.  In some cases I would also use more descriptive variable names.
o	The biggest issue I saw was the need to place code in shared assemblies to reduce duplicate code; for example ‘PermissionSet’ and ‘User’ are duplicated due to their reliance on the ‘BlobIO’ class.
•	Opportunity or future enhancement
o	I would consider using the newest version of .Net which provides some new language enhancements.
o	I would also define the PermissionSet and User with interfaces to make sharing code easier.

