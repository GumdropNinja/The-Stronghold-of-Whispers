using System.Collections.Generic;
using UnityEngine;

public class colourCodePuzzle : MonoBehaviour
{
    //puzzle list to check for colour code
    public List<int> puzzleArray = new List<int>();

    //buttons
    public toggleRedButton rButton;
    public toggleGreenButton gButton;
    public toggleBlueButton bButton;
    public toggleYellowButton yButton;

    //open door bool
    public bool openDoor31 = false;

    //reset puzzle bool
    public bool reset = false;

    // Update is called once per frame
    void Update() 
    {
        //if the puzzle has been filled
        if (puzzleArray.Count == 4 && puzzleArray != null) {

            //check if the puzzle is correct
            if (puzzleArray[0] == 1 && puzzleArray[1] == 2 && puzzleArray[2] == 3 && puzzleArray[3] == 4) {
                //open the door
                openDoor31 = true;
            } else { 
                //reset the puzzle
                openDoor31 = false;
                reset = true;
                puzzleArray.Clear();
            }
        }

        //check if all buttons are off and reset is on
        if (rButton.toggleOnce && gButton.toggleOnce && bButton.toggleOnce && yButton.toggleOnce && reset)
        {
            //turn off reset
            reset = false;
        }
    }
}
