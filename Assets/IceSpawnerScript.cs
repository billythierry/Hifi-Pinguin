using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpawnerScript : MonoBehaviour
{
    public GameObject ice;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnIce();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnIce();
            timer = 0;
        }

    }

    void spawnIce()
    {
        float lowesPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset; 


        Instantiate(ice, new Vector3(transform.position.x, Random.Range(lowesPoint, highestPoint), 0), transform.rotation);
    }
}
