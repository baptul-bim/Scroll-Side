using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    float playerSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //horizontal movement
        if (Input.GetKey("d"))
        {
            transform.position = transform.position += transform.right * playerSpeed * Time.deltaTime;

        }

        if (Input.GetKey("a"))
        {
            transform.position = transform.position -= transform.right * playerSpeed * Time.deltaTime;

        }

    }
}
