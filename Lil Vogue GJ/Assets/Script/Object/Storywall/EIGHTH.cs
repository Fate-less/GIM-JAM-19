using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EIGHTH : MonoBehaviour
{
    private void Update()
    {
        if (PlayerPrefs.GetInt("Artifact") >= 8)
        {
            Destroy(gameObject, 5);
        }
    }
}
