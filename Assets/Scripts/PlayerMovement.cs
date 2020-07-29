using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] 
    public float movementSpeed;
    public float rotationSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        //if(Input.GetKey(KeyCode.D))
        //{
        //    transform.position += new Vector3(1, 0, 0) * Time.deltaTime * movementSpeed;
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * movementSpeed;
        //}

        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position += new Vector3(0, 0, 1) * Time.deltaTime * movementSpeed;
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += new Vector3(0, 0, -1) * Time.deltaTime * movementSpeed;
        //}

        if (Input.GetKey(KeyCode.Keypad8))
        {
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(KeyCode.Keypad2))
        {
            transform.position += new Vector3(0, -1, 0) * Time.deltaTime * movementSpeed;
        }

        float translation = Input.GetAxis("Vertical") * movementSpeed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }
}
