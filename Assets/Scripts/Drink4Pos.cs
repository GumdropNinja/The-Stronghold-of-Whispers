using UnityEngine;

public class Drink4Pos : MonoBehaviour
{
    //bool for if a drink is here
    public bool isDrinkHere4 = false;


    //check for drink collision
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drink"))
        {
            isDrinkHere4 = true;
        }
    }

    //check for drink exit
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Drink"))
        {
            isDrinkHere4 = false;
        }
    }
}
