using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI gameOverText;
    public float Health = 5f;
    AudioSource source;
    [SerializeField]
    AudioClip deathSfx;
    bool isPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Health <= 0)
        {
            Time.timeScale = 0;
            gameOverText.text = "GAME OVER";
            if (!source.isPlaying && isPlayed == false)
            {
                source.PlayOneShot(deathSfx);
                isPlayed = true;
            }
            
        }
    }
    public void Damaged()
    {
        Health -= 5;
        
    }
}
