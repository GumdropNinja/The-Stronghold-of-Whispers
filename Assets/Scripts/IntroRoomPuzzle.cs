using System;
using TMPro;
using UnityEngine;

public class IntroRoomPuzzle : MonoBehaviour
{
    //keys for intro room
    bool key1 = false;
    bool key2 = false;
    bool key3 = false;
    bool key4 = false;

    //open door variable
    public bool open01Door = false;

    // Update is called once per frame
    void Update()
    {
        //if keys are placed on the plate
        if (key1 && key2 && key3 && key4) {
            open01Door = true;
        }
    }

    //check for key collisions and make sure they are on top of the plate
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "0-Key1" && other.transform.position.y > transform.position.y)
        {
            key1 = true;
        }
        if (other.gameObject.name == "0-Key2" && other.transform.position.y > transform.position.y)
        {
            key2 = true;
        }
        if (other.gameObject.name == "0-Key3" && other.transform.position.y > transform.position.y)
        {
            key3 = true;
        }
        if (other.gameObject.name == "0-Key4" && other.transform.position.y > transform.position.y)
        {
            key4 = true;
        }
    }
}
