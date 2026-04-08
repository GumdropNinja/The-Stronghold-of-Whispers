using TMPro;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Room1Door : MonoBehaviour
{
    //get reference to bookshelf puzzle
    public Room1Puzzle bookshelf;

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
        //if books are placed on the bookshelf
        if (bookshelf.open12Door)
        {
            //trigger open animation
            animator.Play("Open");

            if (toggleOnce)
            {
                //update menu texts
                titleText.text = menuHints.roomNames[2];
                hintText.text = menuHints.roomHints[2];
                toggleOnce = false;
            }
        }
    }
}
