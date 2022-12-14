using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Transform projectileSpawner;
    public GameObject[] scrollProjectile;
    public int currentAttack;

    // Start is called before the first frame update
    void Start()
    {
        currentAttack = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(scrollProjectile[currentAttack], transform.position, Quaternion.identity);


            Vector3 mousePos = Input.mousePosition;
        }
    }
}
