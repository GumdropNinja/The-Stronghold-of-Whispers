using UnityEngine;

public class PedestalTrigger2 : MonoBehaviour
{
    //test bool
    public bool isGem2Placed = false;

    //gem renderer
    public MeshRenderer gemRenderer;

    //get materials
    public Material shadow;
    public Material gemColour;

    //gem 2
    public GameObject gem2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get renderer component
        gemRenderer.material = shadow;
    }

    private void OnTriggerEnter(Collider other)
    {
        //toggle button
        if (other.CompareTag("Gem2"))
        {
            gemRenderer.material = gemColour;
            isGem2Placed = true;
            Destroy(gem2);
        }
    }
}
