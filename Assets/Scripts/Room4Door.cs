using TMPro;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Room4Door : MonoBehaviour
{
    //get puzzle
    public colourCodePuzzle puzzle;

    //get animator
    Animator animator;

    //menuhints script and text to update menu
    public MenuHints menuHints;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI hintText;

    //toggle once for menu text update
    bool toggleOnce = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzle.openDoor31) { 
            animator.Play("Open");

            if (toggleOnce)
            {
                //update menu texts
                titleText.text = menuHints.roomNames[5];
                hintText.text = menuHints.roomHints[5];
                toggleOnce = false;
            }
        }
    }
}
