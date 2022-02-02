using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SECOND : MonoBehaviour
{
    private void Update()
    {
        if (PlayerPrefs.GetInt("Artifact") >= 2)
        {
            Destroy(gameObject, 5);
        }
    }
}
