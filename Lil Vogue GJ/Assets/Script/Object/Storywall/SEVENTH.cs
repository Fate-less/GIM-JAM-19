using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEVENTH : MonoBehaviour
{
    private void Update()
    {
        if (PlayerPrefs.GetInt("Artifact") >= 7)
        {
            Destroy(gameObject, 5);
        }
    }
}
