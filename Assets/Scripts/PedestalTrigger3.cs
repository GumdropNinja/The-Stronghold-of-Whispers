using UnityEngine;

public class PedestalTrigger3 : MonoBehaviour
{
    //test bool
    public bool isGem3Placed = false;

    //gem renderer
    public MeshRenderer gemRenderer;

    //get materials
    public Material shadow;
    public Material gemColour;

    //gem 3
    public GameObject gem3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get renderer component
        gemRenderer.material = shadow;
    }

    private void OnTriggerEnter(Collider other)
    {
        //toggle button
        if (other.CompareTag("Gem3"))
        {
            gemRenderer.material = gemColour;
            isGem3Placed = true;
            Destroy(gem3);
        }
    }
}
