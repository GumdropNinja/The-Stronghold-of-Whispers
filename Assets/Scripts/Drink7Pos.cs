using UnityEngine;

public class Drink7Pos : MonoBehaviour
{
    //bool for if a drink is here
    public bool isDrinkHere7 = false;

    //check for drink collision
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drink"))
        {
            isDrinkHere7 = true;
        }
    }

    //check for drink exit
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Drink"))
        {
            isDrinkHere7 = false;
        }
    }
}
