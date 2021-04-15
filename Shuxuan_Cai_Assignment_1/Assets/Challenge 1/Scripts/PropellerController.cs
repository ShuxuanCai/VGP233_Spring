using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerController : MonoBehaviour
{
    // can be change on the unity
    public float rotationSpeed = 1000.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // tilt the propeller
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
