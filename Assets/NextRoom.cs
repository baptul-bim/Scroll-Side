using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRoom : MonoBehaviour
{

    public Transform player1;
    public int enemyAlive;
    float scrollSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player1.position.x >= 12f && enemyAlive <= 0)
        {
            transform.position = transform.position -= transform.right * scrollSpeed * Time.deltaTime;
            if (player1.position.x >= -12f)
            {
                Update();
            }
        }
    }
}
