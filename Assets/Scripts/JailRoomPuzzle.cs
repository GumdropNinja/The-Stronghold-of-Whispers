using TMPro;
using UnityEngine;

public class JailRoomPuzzle : MonoBehaviour
{
    //public bool for the door
    public bool open11Door = false;

    //public variables to access the other scripts
    public SwordTrigger1 sT1;
    public SwordTrigger2 sT2;
    public SwordTrigger3 sT3;

    // Update is called once per frame
    void Update()
    {
        //if all swords are in place
        if (sT1.SwordInPlace1 && sT2.SwordInPlace2 && sT3.SwordInPlace3) { 

            //open the door
            open11Door = true;
        }
    }
}
