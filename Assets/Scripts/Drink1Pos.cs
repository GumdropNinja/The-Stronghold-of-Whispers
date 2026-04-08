using UnityEngine;

public class Drink1Pos : MonoBehaviour
{
    //bool for if a drink is here
    public bool isDrinkHere1 = false;

    //check for drink collision
    private void OnTriggerEnter(Collider other)
    {
    if (other.CompareTag("Drink"))
        {
            isDrinkHere1 = true;
        }
    }
    
    //check for drink exit
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Drink"))
        {
            isDrinkHere1 = false;
        }
    }
}
