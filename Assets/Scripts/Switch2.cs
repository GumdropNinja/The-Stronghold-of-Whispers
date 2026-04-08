using UnityEngine;

public class Switch2 : MonoBehaviour
{
    public bool isSwitch2On = false;

    //gameobject for button
    public GameObject button2;

    void Update()
    {
        //if switch is on
        if (isSwitch2On) {
            //remove button
            Destroy(button2);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            //turn on switch
            isSwitch2On = true;
        }
    }
}
