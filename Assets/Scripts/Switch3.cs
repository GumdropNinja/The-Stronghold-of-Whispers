using UnityEngine;

public class Switch3 : MonoBehaviour
{
    //bool for switch
    public bool isSwitch3On = false;

    //gameobject for button
    public GameObject button3;

    void Update()
    {
        //if switch is on
        if (isSwitch3On) { 
            //remove button
            Destroy(button3);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            //turn on switch
            isSwitch3On = true;
        }
    }
}
