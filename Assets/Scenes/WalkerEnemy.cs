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
        // Kolla på spelaren och fixa rotation.
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
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
