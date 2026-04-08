using UnityEngine;

public class Drink3Pos : MonoBehaviour
{
    //bool for if a drink is here
    public bool isDrinkHere3 = false;

    //check for drink collision
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drink"))
        {
            isDrinkHere3 = true;
        }
    }

    //check for drink exit
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Drink"))
        {
            isDrinkHere3 = false;
        }
    }
}
