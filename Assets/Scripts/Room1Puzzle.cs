using UnityEngine;


public class Room1Puzzle : MonoBehaviour
{
    //bool for door
    public bool open12Door = false;

    //Book keys
    bool bookKey1 = false;
    bool bookKey2 = false;
    bool bookKey3 = false;
    bool bookKey4 = false;
    bool bookKey5 = false;
    bool bookKey6 = false;

    // Update is called once per frame
    void Update()
    {
        //if books are placed on the bookshelf
        if (bookKey1 && bookKey2 && bookKey3 && bookKey4 && bookKey5 && bookKey6)
        {
            open12Door = true;
        }
    }

    //check for book collisions
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "1-Book1")
        {
            bookKey1 = true;
        }
        if (other.gameObject.name == "1-Book2")
        {
            bookKey2 = true;
        }
        if (other.gameObject.name == "1-Book3")
        {
            bookKey3 = true;
        }
        if (other.gameObject.name == "1-Book4")
        {
            bookKey4 = true;
        }
        if (other.gameObject.name == "1-Book5")
        {
            bookKey5 = true;
        }
        if (other.gameObject.name == "1-Book6")
        {
            bookKey6 = true;
        }
    }
}
