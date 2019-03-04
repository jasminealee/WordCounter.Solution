# Word Counter

#### Week 6 Independent Project Word-Counter Program February 26, 2019

#### By Jasmine Lee

## Description
This program allows the user to input a phrase and choose a word within the phrase. The program will then respond with the number of times the word appears in the phrase.

## Specifications
| Behavior | Input | Output |
|:---:|:---:|:---:|
| The user enters a phrase. | "I'm looking for some pie." | The phrase is saved as a variable. |
| The user enters a word to search for. | "for" | The word is saved as a variable. |
| The program returns the frequency the word appears in the phrase (casing of characters is not important). | N/A | "for" appears 1 time. |
| The program disregards punctuation marks (periods, commas, exclamations, and question marks) as long they're used correctly. | "Pie, pie, pie!" | "pie" appears 3 times. |
| If punctuation marks are used within words in the phrase then they are not counted. | "P!ie, pi.e pi?e p,ie pie" | "pie" appears 1 time. |

## Setup/Installation Requirements
Important Notes: Mono, .Net Core 1.1.4 SDK, and .NET Core Runtime 1.1.2 must be downloaded and installed.

* Open GitHub and go to https://github.com/jasminealee/WordCounter.Solution click "clone or download"; copy the url provided.
* Go to Terminal and clone the folder by typing "git clone (repository url)" then enter.
* Open the folder in atom or your choice of text editor.
* To run in Terminal, navigate to the WordCounter directory then compile the Main.cs and RepeatCounter.cs files with command "mcs Main.cs Models/RepeatCounter.cs"
* Next use command "mono Main.exe" to execute the Main.exe file.
* To run the tests, navigate to the WordCounter.Tests directory then use command "dotnet test".


## Known Bugs
None

## Support and contact details
Contact: jasmine.al1722@gmail.com

## Technologies Used
* Terminal
* Atom
* C#
* .Net Core 2.0
* GitBash

### License
MIT

Copyright (c) 2019 Jasmine Lee
