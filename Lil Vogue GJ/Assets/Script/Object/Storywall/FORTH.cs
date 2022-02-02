using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FORTH : MonoBehaviour
{
    private void Update()
    {
        if (PlayerPrefs.GetInt("Artifact") >= 4)
        {
            Destroy(gameObject, 5);
        }
    }
}
