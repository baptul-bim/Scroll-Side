using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile0Script : MonoBehaviour
{
    [SerializeField]
    float projectileSpeed;

    Vector3 worldPos;

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
        //åker framåt
        transform.position += transform.up * Time.deltaTime * projectileSpeed;
        Destroy(gameObject, 7);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //går sönder när den rör en vägg
        if (collision.gameObject.tag == ("Terrain"))
        {
            Destroy(gameObject);
        }
    }
}
