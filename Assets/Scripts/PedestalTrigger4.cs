using UnityEngine;

public class PedestalTrigger4 : MonoBehaviour
{
    //test bool
    public bool isGem4Placed = false;

    //gem renderer
    public MeshRenderer gemRenderer;

    //get materials
    public Material shadow;
    public Material gemColour;

    //gem 4 
    public GameObject gem4;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get renderer component
        gemRenderer.material = shadow;
    }

    private void OnTriggerEnter(Collider other)
    {
        //toggle button
        if (other.CompareTag("Gem4"))
        {
            gemRenderer.material = gemColour;
            isGem4Placed = true;
            Destroy(gem4);
        }
    }
}
