using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class toggleYellowButton : MonoBehaviour
{
    //test bool
    public bool isOn = false;

    //toggle once bool
    public bool toggleOnce = true;

    //get renderer
    MeshRenderer cubeRenderer;

    //get materials
    public Material yellow;
    public Material brightYellow;

    //get puzzle object
    public colourCodePuzzle puzzle;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get renderer component
        cubeRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //unity editor test with bool
        if (isOn && toggleOnce) {
            toggleOnce = false;
            cubeRenderer.material = brightYellow;
            puzzle.puzzleArray.Add(2);
        }

        //reset this piece
        if (puzzle.reset) {
            cubeRenderer.material = yellow;
            isOn = false;
            toggleOnce = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //toggle button
        if ((other.CompareTag("Hand") && toggleOnce))
        {
            //once toggle so we dont add multiple to array key
            toggleOnce = false;
            cubeRenderer.material = brightYellow;
            puzzle.puzzleArray.Add(2);
        }
    }
}
