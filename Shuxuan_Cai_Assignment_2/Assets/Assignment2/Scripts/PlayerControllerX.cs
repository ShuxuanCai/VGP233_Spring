using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    //Player needs to wait 2.0s and then shoot again
    private float t1 = 2.0f;
    //Another timer to time
    private float t2;

    // Update is called once per frame
    void Update()
    {
        
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (Time.time - t2 > 0))
        {
            t2 = Time.time + t1;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
