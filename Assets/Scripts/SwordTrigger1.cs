using UnityEngine;

public class SwordTrigger1 : MonoBehaviour
{
    //bool for jail puzzle
    public bool SwordInPlace1 = false;

    //check for sword collision
    void OnTriggerEnter(Collider other)
    {
        //compare tag so any sword can be used
        if (other.gameObject.CompareTag("Sword"))
        {
            SwordInPlace1 = true;
        }
    }

    //check for sword exit collision
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Sword"))
        {
            SwordInPlace1 = false;
        }
    }
}
