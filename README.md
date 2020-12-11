# _Tutoring_

#### _An MTG Card Searcher, Dec 11, 2020_

#### By _**Ben White**_

## Description

_Tutoring is an application that will allow a user to search for any Magic: The Gathering card_

[Capstone Proposal](https://docs.google.com/document/d/1NCYp7lvUeb6GWjMHd2G7k3887MbcMsXX3iFoPBk0oBI/edit)

## Setup/Installation Requirements

Software Requirements:

1. This program utilizes .NET version 2.2, and requires this framework to be pre-installed:
    * Please go to https://dotnet.microsoft.com/download/dotnet-core/2.2 and install the SDK version 2.2 or
      greater patch version, but do not upgrade to a higher minor version number.

2. Clone this repository onto your computer: https://github.com/...

3. In your preferred terminal window, navigate into Tutoring.Solution/Tutoring using
    cd (i.e. cd desktop/Tutoring.Solution/Tutoring) and open the project with your preferred code editor.
4. Run the following terminal command: $ dotnet restore

5. To initiate this terminal program, run the command: $ dotnet run

6. To run the test suite included with this project, within the terminal navigate into Tutoring.Tests and run the following commands:
  * $ dotnet restore
  * $ dotnet test

[ScryFall API](https://scryfall.com/docs/api):

Endpoint: https://api.scryfall.com

## Specs

User Stories:

As a user, I want to search for cards by name in order to find my favorite cards

As a user, I want to search for cards by color in order to find cards I can use

As a user, I want to search for cards by mana cost in order to find high and low cost cards easier

As a user, I want to search for cards by card type in order to find thematically similar cards

## Known Bugs

_TBD_

## Support and contact details

_Ben White: bwhite2140@outlook.com_

## Technologies Used

* C#/.NET
* Scryfall API

### License

*MIT License*

Copyright (c) 2020 **_Ben White_**