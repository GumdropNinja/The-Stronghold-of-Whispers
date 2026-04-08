using UnityEngine;

public class Drink5Pos : MonoBehaviour
{
    //bool for if a drink is here
    public bool isDrinkHere5 = false;

    //check for drink collision
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drink"))
        {
            isDrinkHere5 = true;
        }
    }

    //check for drink exit
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Drink"))
        {
            isDrinkHere5 = false;
        }
    }
}
