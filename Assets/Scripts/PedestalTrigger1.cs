using UnityEngine;

public class PedestalTrigger1 : MonoBehaviour
{
    //test bool
    public bool isGem1Placed = false;

    //gem renderer
    public MeshRenderer gemRenderer;

    //get materials
    public Material shadow;
    public Material gemColour;

    //gem 1 
    public GameObject gem1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get renderer component
        gemRenderer.material = shadow;
    }

    private void OnTriggerEnter(Collider other)
    {
        //toggle button
        if (other.CompareTag("Gem1"))
        {
            gemRenderer.material = gemColour;
            isGem1Placed = true;
            Destroy(gem1);
        }
    }
}
