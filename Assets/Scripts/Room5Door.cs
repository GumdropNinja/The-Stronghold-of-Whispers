using TMPro;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Room5Door : MonoBehaviour
{
    //animator for door
    Animator animator;

    //pedestal scripts
    public PedestalTrigger1 p1;
    public PedestalTrigger2 p2;
    public PedestalTrigger3 p3;
    public PedestalTrigger4 p4;

    //menuhints script and text to update menu
    public MenuHints menuHints;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI hintText;

    //toggle once for menu text update
    bool toggleOnce = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get animator
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if all gems are placed
        if (p1.isGem1Placed && p2.isGem2Placed && p3.isGem3Placed && p4.isGem4Placed) {
            //open door
            animator.Play("Open");

            if (toggleOnce)
            {
                //update menu texts
                titleText.text = menuHints.roomNames[6];
                hintText.text = menuHints.roomHints[6];
                toggleOnce = false;
            }
        }
    }
}
