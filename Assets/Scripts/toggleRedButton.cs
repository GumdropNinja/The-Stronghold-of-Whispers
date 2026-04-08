using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class toggleRedButton : MonoBehaviour
{
    //test bool
    public bool isOn = false;

    //toggle once bool
    public bool toggleOnce = true;

    //get renderer
    MeshRenderer cubeRenderer;

    //get materials
    public Material red;
    public Material brightRed;

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
            cubeRenderer.material = brightRed;
            puzzle.puzzleArray.Add(1);
        }

        //reset this piece
        if (puzzle.reset) {
            cubeRenderer.material = red;
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
            cubeRenderer.material = brightRed;
            puzzle.puzzleArray.Add(1);
        }
    }
}
