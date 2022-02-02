using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [HideInInspector]
    public int ghostCount;

    public void Start()
    {
        ghostCount = PlayerPrefs.GetInt("ghostCount");
        Debug.Log("Total ghost: " + ghostCount);
    }
    public void GhostSpawn()
    {
        ++ghostCount;
        PlayerPrefs.SetInt("ghostCount", ghostCount);
    }

    public void GhostDespawn()
    {
        ghostCount -= 1;
        PlayerPrefs.SetInt("ghostCount", ghostCount);
    }


}
