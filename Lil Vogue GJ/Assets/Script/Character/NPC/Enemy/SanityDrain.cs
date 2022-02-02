using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanityDrain : MonoBehaviour
{
    public Sanity sanity;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Drain(5);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Drain(5);
        }
    }

    void Drain(float drain)
    {
        sanity.currentHealth -= drain;
    }
}
