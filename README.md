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
Character.cs - creates an object, assigns an xml document to it for character data, and manipulates the document.

GeneratedDragons.Proto-----

main->program-
            --> character <existing or new?>
                        -->new create new object, tie new storage document, generate based on ruleset
                                    -->accept user input to guide character generation
                -->leave character available for use in rest of program.


Generate Algorithm:

Create empty character object
Push object to StatGen
Gen Stats for Character object
pump out to Program.cs for output to cmd


Code Reuse Goals:
 - character should be able to generate any current PHB character regardless of race
 - new classes should be able to be added without much effort (XML implementation? generate new character based on metadata or database?)
 *- additional rulesets should be able to be used (ones that use a character-with-numbers-type system, such as pathfinder or others)