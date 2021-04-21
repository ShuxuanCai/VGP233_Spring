using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    void Start()
    {
        Debug.Log("");
    }
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > -10.0f && transform.position.z > 17.55f)
        {
            Destroy(gameObject);
        }
    }
}
