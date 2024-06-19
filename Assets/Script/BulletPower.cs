using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPower : MonoBehaviour
{
    public float damage = 25;
    public Target Target;

    void Start()
    {

    }

    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Target.TakeDamage(damage);
            Debug.Log("Hit");
        }
    }
}
