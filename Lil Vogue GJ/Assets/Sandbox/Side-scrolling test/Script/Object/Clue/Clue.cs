using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : MonoBehaviour
{
    public GameObject Scroll;

    private void Start()
    {
        Scroll.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Scroll.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
            Scroll.SetActive(false);
    }
}
