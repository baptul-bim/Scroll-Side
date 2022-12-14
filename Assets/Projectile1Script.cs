using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile1Script : MonoBehaviour
{
    [SerializeField]
    float projectileSpeed;

    [SerializeField]
    ParticleSystem explosionParticle;

    Vector3 worldPos;
    float explodeTimer;

    // Start is called before the first frame update
    void Start()
    {
        //skjuter mot muspekaren
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector3 direction = worldPos - transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction) - 90;
        transform.eulerAngles = new Vector3(0, 0, angle);
    }

    // Update is called once per frame
    void Update()
    {
        explodeTimer = explodeTimer + Time.deltaTime;
        //åker framåt
        transform.position = Vector3.Lerp(transform.position, worldPos, projectileSpeed * Time.deltaTime);

        if (explodeTimer >= 1)
        {
            Instantiate(explosionParticle, transform.position, transform.rotation, transform.parent);

            Destroy(gameObject);


        }

        Destroy(gameObject, 7);
    }
}
