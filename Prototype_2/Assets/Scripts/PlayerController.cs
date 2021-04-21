using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject projectilePrefeb;
    public float projectilePrefebOffset = 0.7f;

    private float horizontalInput;

    void Start()
    {
        Debug.Log("");
    }

    // Update is called once per frame
    void Update()
    {
        //Translates the player left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        
        //Keep the player in bounds
        if(transform.position.x > 11.38f && transform.position.z > 17.6f)
        {
            transform.position = new Vector3(11.38f, transform.position.y, 17.6f);
        }

        else if(transform.position.x < -1.29f && transform.position.z < -7.89f)
        {
            transform.position = new Vector3(-1.29f, transform.position.y, -7.89f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a cake/food/projectile
            Instantiate(projectilePrefeb, new Vector3(transform.position.x, transform.position.y + projectilePrefebOffset, transform.position.z), projectilePrefeb.transform.rotation);
        }
    }
}
