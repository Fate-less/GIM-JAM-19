using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager soundManager;
    private AudioSource audioSrc;
    public AudioClip Pickup;
    public AudioClip Heartbeat;

    // Start is called before the first frame update
    private void Awake()
    {
        if (soundManager == null)
        {
            soundManager = this;
        }
        else if (soundManager != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PickupArtifact()
    {
        audioSrc.PlayOneShot(Pickup);
    }

    public void LowHP()
    {
        if (!audioSrc.isPlaying)
        {
            audioSrc.PlayOneShot(Heartbeat);
        }
    }

    public void HighHP()
    {
        audioSrc.Stop();
    }
}
