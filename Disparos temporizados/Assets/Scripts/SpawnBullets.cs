using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullets : MonoBehaviour
{
    public GameObject munition;
    public float delaySpawn = 2f;
    public float intervalSpawn = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBullet", delaySpawn, intervalSpawn);
    }

    private void SpawnBullet()
    {
        Instantiate(munition, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
