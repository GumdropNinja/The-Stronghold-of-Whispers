using UnityEngine;

public class Drink8Pos : MonoBehaviour
{
    //bool for if a drink is here
    public bool isDrinkHere8 = false;

    //check for drink collision
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drink"))
        {
            isDrinkHere8 = true;
        }
    }

    //check for drink exit
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Drink"))
        {
            isDrinkHere8 = false;
        }
    }
}
