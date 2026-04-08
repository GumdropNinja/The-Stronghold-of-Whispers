using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(AudioSource))]
public class WalkingSound : MonoBehaviour
{
    //Audio Source
    AudioSource walking;

    //testing bool
    public bool isWalking = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get audio source
        walking = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb for player to check velocity
        //0.1 due to either deadzone or analog stick sensitivity
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp) || isWalking) {
            walking.enabled = true; //using enabled due to loop
        }
        else {
            walking.enabled = false; //using enabled due to loop
        }
    }
}
