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
        // Kolla om spelaren �r �t h�ger eller v�nster
        if (target.position.x < transform.position.x)
        {
            
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
