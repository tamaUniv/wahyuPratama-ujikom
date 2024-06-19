using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] objectToSpawn;
    public float spawnRate = 2f;
    public float xMin = -5f;
    public float xMax = 5f;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= spawnRate)
        {
            timer = 0;
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        GameObject objToSpawn = objectToSpawn[Random.Range(0, objectToSpawn.Length)];
        float x = Random.Range(xMin, xMax);
        Vector3 position = new Vector3(x, transform.position.y, transform.position.z);
        Instantiate(objToSpawn, position, transform.rotation);
    }   
}
