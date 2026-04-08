using UnityEngine;

public class SwordTrigger2 : MonoBehaviour
{
    //bool for jail puzzle
    public bool SwordInPlace2 = false;

    //check for sword collision
    void OnTriggerEnter(Collider other)
    {
        //compare tag so any sword can be used
        if (other.gameObject.CompareTag("Sword"))
        {
            SwordInPlace2 = true;
        }
    }

    //check for sword exit collision
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Sword"))
        {
            SwordInPlace2 = false;
        }
    }
}
