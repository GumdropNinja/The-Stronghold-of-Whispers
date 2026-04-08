using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    //menu variables
    public GameObject menu;
    public bool isMenuOpen = true;

    // Update is called once per frame
    void Update()
    {
        //get button press to open and close menu
        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
            isMenuOpen = !isMenuOpen;
        }

        //show and hide menu
        menu.SetActive(isMenuOpen);
    }
}
