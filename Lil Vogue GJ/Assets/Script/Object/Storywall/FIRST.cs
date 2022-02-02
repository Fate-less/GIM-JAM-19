using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIRST : MonoBehaviour
{
    private void Update()
    {
        if (PlayerPrefs.GetInt("Artifact") >= 1)
        {
            Destroy(gameObject, 5);
        }
    }
}
