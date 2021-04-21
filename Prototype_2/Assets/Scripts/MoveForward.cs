using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1,0,1) * Time.deltaTime * speed);
    }
}
