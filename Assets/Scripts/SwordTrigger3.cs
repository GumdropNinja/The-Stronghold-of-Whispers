using UnityEngine;

public class SwordTrigger3 : MonoBehaviour
{
    //bool for jail puzzle
    public bool SwordInPlace3 = false;

    //check for sword collision
    void OnTriggerEnter(Collider other)
    {
        //compare tag so any sword can be used
        if (other.gameObject.CompareTag("Sword"))
        {
            SwordInPlace3 = true;
        }
    }

    //check for sword exit collision
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Sword"))
        {
            SwordInPlace3 = false;
        }
    }
}
