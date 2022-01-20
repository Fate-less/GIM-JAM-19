using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sanity : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;

    public SanityBar sanityBar;

    private void Start()
    {
        currentHealth = maxHealth;
        sanityBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
        TakeDamage(1 * Time.deltaTime);
    }

    void TakeDamage(float damage)
    {
        currentHealth -= damage;
        sanityBar.SetHealth(currentHealth);
    }
}
