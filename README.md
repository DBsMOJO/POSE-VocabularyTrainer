# POSE-VocabularyTrainer

It is an educational game to be developed for two people.

- Player A (the expert) is asked to say an English word and then the German one
Enter translation.
- After that, the contents of the console should be deleted - use the method for this
Clear() of class Console.
- Now it's player B's (the student's) turn: the program asks him to
to enter a German translation of the English word. If the entered
Translation does not match the specified translation, a
An error message will be issued and the translation will be asked again.

Hints:

- Count the number of times the student attempts to provide the correct translation.
- Attention: There are a maximum of 10 failed attempts available!
- At the end of the program, print a comment depending on the number of attempts, e.g.:

| Number of attempts   | Comment    |
|--------------- | --------------- |
| 1   | Ausgezeichnet, sofort gewußt!   |
| 2 or 3   | Gut gemacht, nur <n> Versuche!   |
| 4 or 5   | Ein bisschen üben, das wird schon.   |
| >5   | Üben, üben, üben!   |
| 10 | Das war wohl nichts!! |

