using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkerEnemy : MonoBehaviour
{
    [SerializeField]
    public Transform target;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Kolla om spelaren är åt höger eller vänster
        if (target.position.x < transform.position.x)
        {
            transform.position += -transform.right * speed * Time.deltaTime;
        }
        else if (target.position.x > transform.position.x)   
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealth>().Damaged();
            Destroy(gameObject);
        }
    }
}
