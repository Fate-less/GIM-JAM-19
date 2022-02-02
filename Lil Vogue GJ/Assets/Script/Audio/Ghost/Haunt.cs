using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haunt : MonoBehaviour
{
    public AudioSource ghost;
    public AudioClip ghost2;
    public int ghostNumber;
    public GameObject ghostObj;
    public Spawn Spawner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && !ghost.isPlaying)
        {
            ghost.PlayOneShot(ghost2);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !ghost.isPlaying)
        {
            ghost.PlayDelayed(5);
        }
    }

    private void Update()
    {
        if (Spawner.ghostCount < ghostNumber)
        {
            Destroy(gameObject);
        }
    }
}
