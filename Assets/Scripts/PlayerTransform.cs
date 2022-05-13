using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerTransform : MonoBehaviour
{
    public Vector3 PlayerPosition;
    public float rotationSpeed;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPosition = transform.position + new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(-movementSpeed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(movementSpeed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(0, 0, -movementSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0, 0, movementSpeed);
        }
    }
}
