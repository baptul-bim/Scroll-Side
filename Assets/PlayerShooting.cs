using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Transform projectileSpawner;
    public GameObject scrollProjectile0;
    public GameObject scrollProjectile1;
    public GameObject scrollProjectile2;
    public int currentAttack;

    // Start is called before the first frame update
    void Start()
    {
        currentAttack = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (currentAttack == 0)
            {

            }
            if (currentAttack == 1)
            {

            }
            if (currentAttack == 2)
            {

            }
        }
    }
}
