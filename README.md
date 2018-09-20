"# GeneratedDragons" 
DND 5E Character Generator
Goes step by step to generate a character based on the 5E player's handbook (Published by WOTC)
Goals:
    -   creator that builds a stat sheet    (PROTO)
    -   creator that generates a random background (PROTO2)
    -   creator that generates a random look    (PROTO3)
    -   generates a fully featured character    (ALPHA)
    -   generates an image of said character based on description   (BETA)
    -   generates adventuring parties and quests (Expandablility into DDD.ZONE) (RELEASE)

(Different milestone versions denoted by LABEL. Current Version: pre-PROTO)


CHARACTER GENERATION
1. Choose a race
2. Choose a class
3. Determine ability scores
4. (**)Describe your character
5. (***)Choose Equipment
6. (*****)ComeTogether

**:PROTO2
***:ALPHA
*****:RELEASE

Language Choice: C# (Visual C# by Microsoft/Mono)
***GUI Program
CLI Program for stats



Proto Architecture:

Program.cs - handles user input and include main()
StatGen.cs - takes a character object and pumps stats into it, pushes out to program
Character.cs - class generates a character object with the values into it
XMLExport.cs - exports the character object's values into a formatted XML sheet.

Generate Algorithm:

Create empty character object
Push object to StatGen
Gen Stats for Character object
pump out to Program.cs for output to cmd