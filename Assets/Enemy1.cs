using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    
   
    public Transform target;
    [SerializeField]
    public float speed = 3f;
    public int enemyHealth = 3;
    


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        //rotate to look at the player
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);//correcting the original rotation

      
        //move towards the player
        if (Vector3.Distance(transform.position, target.position) > 1f)
        {//move if distance from target is greater than 1
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        // damage on player collision
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealth>().Damaged();
            Destroy(gameObject);

           

        }
        //damage to enemy on bullet hit.
        if (collision.gameObject.tag == "bullet0")
            {
            enemyHealth -= 1 ;
        } 
        if (enemyHealth == 0)
        {
           Destroy(gameObject);
        }
    }
}
