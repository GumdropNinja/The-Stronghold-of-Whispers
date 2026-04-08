using UnityEngine;

public class Drink2Pos : MonoBehaviour
{
    //bool for if a drink is here
    public bool isDrinkHere2 = false;

    //check for drink collision
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drink"))
        {
            isDrinkHere2 = true;
        }
    }

    //check for drink exit
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Drink"))
        {
            isDrinkHere2 = false;
        }
    }
}
