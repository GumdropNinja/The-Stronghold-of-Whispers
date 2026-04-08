using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Jumpscare : MonoBehaviour
{
    //audio source
    AudioSource jumpscare; 

    //creature gameobject
    public GameObject jumpscareCreature;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get audio source
        jumpscare = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
        //trigger if player enters trigger
        if (other.CompareTag("Player"))
        { 
            //spawn creature
            Instantiate(jumpscareCreature, transform.position, Quaternion.identity);

            //play sound
            jumpscare.Play(); 
        }
    }
}
