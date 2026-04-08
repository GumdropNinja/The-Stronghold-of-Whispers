using UnityEngine;

public class MenuHints : MonoBehaviour
{
    public string[] roomNames = {
        "Room 1: The Jail", 
        "Room 1: The Bookshelf", 
        "Room 2: The Walls", 
        "Room 3: The Drinks", 
        "Room 4: The Colours", 
        "Room 5: The Gems",
        "Congratulations!"
    };

    public string[] roomHints =  {
        "There seems to be some items that are missing in an object beside the jail door. Maybe you can pick up those objects and return them to their places.",
        "The bookshelf beside the door looks a little empty. If you think you have found all of the missing objects, maybe there is one in another room.",
        "Look at the walls more closely. There may be some details in the wall that look weird. Maybe you can do something with them.",
        "Some of the seats have something in them. All of the objects seem to be looking at some place in the corner. Is there something there that they could want?",
        "If you brute force the puzzle, that could work. There are only 24 different combinations. To solve the puzzle, maybe there are some objects with that colour within the basement section at the top of the staircase.",
        "The podiums look a little empty with a shadow showing the appropiate object. You may need to go back through the stronghold to gather some objects to put them in their slots.",
        "You did it! Thank you for playing The Stronghold of Whispers. I hope you enjoyed it from me, the developer."
    };
}
