using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HealtUi : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI HealthUi;
    PlayerHealth Health;
    // Start is called before the first frame update
    void Start()
    {
        Health = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthUi.text = "Health:" + Health.Health;
    }
}
