using TMPro;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class JailRoomDoor : MonoBehaviour
{
    //get reference to weapon rack puzzle
    public JailRoomPuzzle weaponRack;

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
        //if swords are placed on the weapon rack
        if (weaponRack.open11Door)
        {
            //trigger open animation
            animator.Play("Open");

            if (toggleOnce)
            {
                //update menu texts
                titleText.text = menuHints.roomNames[1];
                hintText.text = menuHints.roomHints[1];
                toggleOnce = false;
            }
        }
    }
}
