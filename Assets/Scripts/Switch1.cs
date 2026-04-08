using UnityEngine;

public class Switch1 : MonoBehaviour
{
    //bool for switch
    public bool isSwitch1On = false;

    //gameobject for button
    public GameObject button1;

    void Update()
    {
        //if switch is on
        if (isSwitch1On) {
            //remove button
            Destroy(button1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand")) { 
            //turn on switch
            isSwitch1On = true;
        }
    }
}
