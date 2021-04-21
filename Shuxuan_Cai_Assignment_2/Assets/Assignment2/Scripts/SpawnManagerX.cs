using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22.0f;
    private float spawnLimitXRight = 7.0f;
    private float spawnPosY = 30.0f;

    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Use invoke here, just call this method after startDelay time once.
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        //Include 3.0f seconds and include 5.0f seconds, random range between them.
        float spawnInterval = Random.Range(3.0f, 5.0f);

        //Invoke again, random time to call this method.
        Invoke("SpawnRandomBall", spawnInterval);

        //Random index range to display different balls
        int index = Random.Range(0, 3);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
    }

}
