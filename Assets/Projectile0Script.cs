using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile0Script : MonoBehaviour
{
    [SerializeField]
    float projectileSpeed;
    public Camera cam;

    Vector3 worldPos;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        //transform.LookAt(worldPos);
        Vector3 direction = worldPos - transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction) - 90;
        transform.eulerAngles = new Vector3(0, 0, angle);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.up * Time.deltaTime * projectileSpeed;
        Destroy(gameObject, 15);
    }
}
