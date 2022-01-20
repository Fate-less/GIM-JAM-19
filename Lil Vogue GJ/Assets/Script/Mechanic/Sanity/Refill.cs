using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refill : MonoBehaviour
{
    public SanityBar sanityBar;
    public Sanity sanity;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Heal(50);
            Destroy(gameObject, 1);
        }
    }

    void Heal(float heal)
    {
        sanity.currentHealth += heal;
    }
}
