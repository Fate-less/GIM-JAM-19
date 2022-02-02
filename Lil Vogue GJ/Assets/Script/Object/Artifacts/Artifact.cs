using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artifact : MonoBehaviour
{
    public int artifactNumber;
    private int artifactCount;
    public SoundManager soundManager;
    public Spawn Spawner;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Input.GetKey(KeyCode.F))
        {
            PlayerPrefs.SetInt("Artifact", artifactNumber);
            soundManager.PickupArtifact();
            Destroy(gameObject);
            Spawner.GhostDespawn();
        }
    }

    private void Update()
    {
        artifactCount = PlayerPrefs.GetInt("Artifact");
        if (artifactCount >= artifactNumber)
        {
            Destroy(gameObject);
        }
    }
}
