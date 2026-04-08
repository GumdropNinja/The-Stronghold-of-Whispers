using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //use playclipatpoint and an array of sounds to play different sounds around the player
    //the sounds will be played randomly from the array
    //the chance will be roughly 1 sound per 30 seconds
    //get ghost/haunted/horror sounds


    public AudioClip[] audioSources = new AudioClip[10];

    //sound variables
    int soundIndex = 0;
    int soundChance = 0;

    //left or right to determine sound direction
    int leftOrRight = 0;
    int transformSound = 0;

    private void Start()
    {
        //set target frame rate
        Application.targetFrameRate = 90;
    }

    // Update is called once per frame
    void Update()
    {
        //sound chance roughly 1 sound per 30 seconds if game running at 90fps
        soundChance = Random.Range(0, 2700);

        //if sound chance succeeds
        if (soundChance == 0) {
            
            //choose sound
            soundIndex = Random.Range(0, audioSources.Length);

            //choose direction
            leftOrRight = Random.Range(0, 2);
            if (leftOrRight == 1)
            {
                transformSound = 1;
            }
            else
            {
                transformSound = -1;
            }

            //play sound on player either left or right
            AudioSource.PlayClipAtPoint(audioSources[soundIndex], transform.position + transform.right * transformSound, 1.0f);
        }
    }
}
