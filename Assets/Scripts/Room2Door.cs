using TMPro;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Room2Door : MonoBehaviour
{

    //animaor for the door
    Animator animator;

    //switches for the door
    public Switch1 s1;
    public Switch2 s2;
    public Switch3 s3;

    //for testing
    public bool openDoor = false;

    //menuhints script and text to update menu
    public MenuHints menuHints;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI hintText;

    //toggle once for menu text update
    bool toggleOnce = true;

    // Awake is called before the first frame update
    void Start()
    {
        //get animator for door
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if all switches are on
        if ((s1.isSwitch1On && s2.isSwitch2On && s3.isSwitch3On) || openDoor) { 
            //open door
            animator.Play("Open");

            if (toggleOnce)
            {
                //update menu texts
                titleText.text = menuHints.roomNames[3];
                hintText.text = menuHints.roomHints[3];
                toggleOnce = false;
            }
        }
    }
}
