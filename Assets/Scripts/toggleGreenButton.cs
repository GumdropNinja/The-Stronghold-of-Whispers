using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class toggleGreenButton : MonoBehaviour
{
    //test bool
    public bool isOn = false;

    //toggle once bool
    public bool toggleOnce = true;

    //get renderer
    MeshRenderer cubeRenderer;

    //get materials
    public Material green;
    public Material brightGreen;

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
            cubeRenderer.material = brightGreen;
            puzzle.puzzleArray.Add(3);
        }

        //reset this piece
        if (puzzle.reset) { 
            cubeRenderer.material = green;
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
            cubeRenderer.material = brightGreen;
            puzzle.puzzleArray.Add(3);
        }
    }
}
