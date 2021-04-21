using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefebs;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", startDelay, spawnInterval);
    }

    private void SpawnAnimal()
    {
        int animalIndex = Random.Range(0, 2);
        Instantiate(animalPrefebs[animalIndex], new Vector3(0, 0, 20), animalPrefebs[animalIndex].transform.rotation);
    }
}
