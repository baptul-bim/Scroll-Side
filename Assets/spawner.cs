using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public int created = 0;
    [SerializeField]
    public Transform spawnLocation;
    [SerializeField]
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (created == 0)
        {
            created += 1;
            Instantiate(enemy, spawnLocation.position, transform.rotation);
        }
    }
}
