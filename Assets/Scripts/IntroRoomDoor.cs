using TMPro;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class IntroRoomDoor : MonoBehaviour
{
    //get reference to plate puzzle
    public IntroRoomPuzzle plate;

    //get door animator
    Animator animator;

    //menuhints script and text to update menu
    public MenuHints menuHints;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI hintText;

    //toggle once for menu text update
    bool toggleOnce = true;

    // Start is called before the first frame update
    void Start()
    {
        //get animator
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if keys are placed on the plate
        if (plate.open01Door) 
        {
            //trigger open animation
            animator.Play("Open");

            if (toggleOnce)
            {
                //update menu texts
                titleText.text = menuHints.roomNames[0];
                hintText.text = menuHints.roomHints[0];
                toggleOnce = false;
            }
        }
    }
}
