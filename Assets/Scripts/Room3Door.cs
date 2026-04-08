using TMPro;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Room3Door : MonoBehaviour
{
    //drink scripts for detecting drink collisions
    public Drink1Pos drink1;
    public Drink2Pos drink2;
    public Drink3Pos drink3;
    public Drink4Pos drink4;
    public Drink5Pos drink5;
    public Drink6Pos drink6;
    public Drink7Pos drink7;
    public Drink8Pos drink8;

    //for testing
    public bool openDoor = false;

    //animator variable
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
        //get animator
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if all drinks are in their positions
        if ((drink1.isDrinkHere1 && drink2.isDrinkHere2 && drink3.isDrinkHere3 && drink4.isDrinkHere4 && 
            drink5.isDrinkHere5 && drink6.isDrinkHere6 && drink7.isDrinkHere7 && drink8.isDrinkHere8) || openDoor) {

            //open door
            animator.Play("Open");

            if (toggleOnce)
            {
                //update menu texts
                titleText.text = menuHints.roomNames[4];
                hintText.text = menuHints.roomHints[4];
                toggleOnce = false;
            }
        }
    }
}
