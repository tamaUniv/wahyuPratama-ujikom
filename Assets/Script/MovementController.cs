using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float moveSpeed = 350;
    public float attackSpeed = 100;
    public Animator animation;
    public GameObject food;

    void Start()
    {

    }

    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");

        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime);

        if(Input.GetKey(KeyCode.D))
        {
            animation.SetBool("RigtWalk", true);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            animation.SetBool("LeftWalk", true);
        }
        else if(Input.GetKeyUp(KeyCode.A))
        {
            animation.SetBool("LeftWalk", false);
        }
        else if(Input.GetKeyUp(KeyCode.D))
        {
            animation.SetBool("RigtWalk", false);
        }

        if(Input.GetKey(KeyCode.Mouse0))
        {
            animation.SetTrigger("Throw");
            // Instantiate(food, transform.position, Quaternion.identity); 
            // transform.Translate(new Vector3(0, 0, 50) * attackSpeed * Time.deltaTime);
        }
    }
}
