using UnityEngine;

public class DestroyCreature : MonoBehaviour
{
    //timer to destroy creature
    float timer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        //update timer
        timer += Time.deltaTime;

        //destroy creature if timer is up
        if (timer > 1.5f)
        {
            Destroy(gameObject);
        }
    }
}
