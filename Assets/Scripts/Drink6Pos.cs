using UnityEngine;

public class Drink6Pos : MonoBehaviour
{
    //bool for if a drink is here
    public bool isDrinkHere6 = false;

    //check for drink collision
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drink"))
        {
            isDrinkHere6 = true;
        }
    }

    //check for drink exit
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Drink"))
        {
            isDrinkHere6 = false;
        }
    }
}
