using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health;
    private Dictionary<string, float> healthbyName = new Dictionary<string, float>() {
        {"Deer", 200},
        {"Dog", 100},
        {"Horse", 200},
        {"Cow", 300},
    };

    private Dictionary<string, float> speedbyName = new Dictionary<string, float>() {
        {"Deer", 250},
        {"Dog", 300},
        {"Horse", 300},
        {"Cow", 150},
    };

    private Dictionary<string, float> scorebyName = new Dictionary<string, float>() {
        {"Deer", 1},
        {"Dog", 2},
        {"Horse", 5},
        {"Cow", 5},
    };
    // Start is called before the first frame update
    void Start()
    {
        if (healthbyName.ContainsKey(gameObject.name))
        {
            health = healthbyName[gameObject.name];
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speedbyName[gameObject.name] * Time.deltaTime);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }   
    }
}
