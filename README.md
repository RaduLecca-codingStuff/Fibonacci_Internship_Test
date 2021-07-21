# Fibonacci_Internship_Test

~Instructions
To go to the next number in the fibonacci sequnce, press the right arrow.
To go to a previous one , press the left one instead.

~Design choices
When I made the app, I focused of how much I could do in a short period of time, while also on keeping things cohesive.

For the design of the layout, I initially went for something very simple: a button and a counter. The most important decision at that point was the variabes used to store the numbers for the fibonacci sequence.I chose to use the "long" variable for the task since, while there were variables which could allocate more memory with no problem, I thought "long" was decently big and compatible with many more devices. It took me half an hour to finish it.The idea was a bit too plain,so I came up with two ideas to improve the functionality: the ability to save the last fibonacci number and come back to that number and the ability to navigate through the fibonacci sequence. I thought that both options were incompatible with one another, so I chose the latter because it took less time to implement. 

After that, I thought about how it should look like. The way the layout allowed the user to cycle between numbers reminded me a bit of how you could select numbers on a combination padlock, so I chose to make the transition between numbers look and sound like that. This was done by using IEnumerators to move the text to one side of the display, then make it appear on the other and center it. The reason why I chose IEnumerators was because of the WaitForSeconds function, which allowed me to re-create the way numbers on a padlock tended to click into place when you turn to the next number.

Since the fibonacci sequence is strongly correlated with the golden ratio and because I remembered that it was used in old art and architecture to make things visually appealing, I decided to make the layout look vintage and to have the interface be golden and somewhat luxurious. When I finished making the interface, I thought it looked a bit eery, since there wasn't anything else in the frame and because it looked a bit dark. So I went with it. I added more realistic sound effects for when interacting with the inputs and a creepy ambience noise. I also made some small visual changes to the app, such as changing the background from a pattern to a solid dark brown to both mach with the brown of the number display, but to also enhance a bit the eeriness of the atmosphere.

Lastly, after I did all the major features, I decided to addd a small easter egg. At random, there's a small chance that the app will play an echo-y knocking sound. This was done to enhance the creepy atmosphere of the app. Fear is mainly caused by the unknown, so having something minor that isn't in the player's control, while also hinting the possibility of danger, was what I thought was just what the app needed to have a fully establiched atmosphere and identity.
