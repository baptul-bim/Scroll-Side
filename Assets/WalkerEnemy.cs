using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float speed = 2f; // adjust this to change the enemy's walking speed
    public Transform player; // drag the player's transform component here

    void Update()
    {
        // calculate the distance between the enemy and the player on the x axis
        float distance = player.position.x - transform.position.x;

        // if the distance is greater than 0 (i.e. the player is to the right of the enemy)
        if (distance > 0)
        {
            // move the enemy towards the player on the x axis
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        // if the distance is less than 0 (i.e. the player is to the left of the enemy)
        else if (distance < 0)
        {
            // move the enemy towards the player on the x axis
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
}
