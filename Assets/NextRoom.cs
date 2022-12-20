using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRoom : MonoBehaviour
{

    public Transform player1;
    public int enemyAlive;
    public int currentRoom;
    [SerializeField]
    float scrollSpeed;
    int test = 0;

    public GameObject[] room;

    // Start is called before the first frame update
    void Start()
    {
        player1 = FindObjectOfType<PlayerMovement>().transform;
    }


    IEnumerator Change()
    {
        for (int i = 0; i < 4; i++)
        {
            transform.position -= transform.right * scrollSpeed;
            yield return new WaitForSeconds(0.03125f);
        }
       yield return null;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player1.position.x >= 12f && enemyAlive <= 0)
        {
            if (room.Length > 0)
            {
                if (room[currentRoom] != null)
                {
                    Instantiate(room[currentRoom], new Vector3(24, 0, 0), transform.rotation);
                }
            }
           
           
            StartCoroutine(Change());
            

        }
        test = 0;
    }
}
