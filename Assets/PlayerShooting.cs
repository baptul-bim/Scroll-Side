using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Transform projectileSpawner;
    public GameObject[] scrollProjectile;
    public int currentAttack;

    AudioSource source;
    [SerializeField]
    AudioClip shootSfx;

    // Start is called before the first frame update
    void Start()
    {
        currentAttack = 0;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(scrollProjectile[currentAttack], transform.position, Quaternion.identity);
            source.PlayOneShot(shootSfx);


            Vector3 mousePos = Input.mousePosition;
        }
    }
}
