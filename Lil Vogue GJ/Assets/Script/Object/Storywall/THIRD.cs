using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THIRD : MonoBehaviour
{
    private void Update()
    {
        if (PlayerPrefs.GetInt("Artifact") >= 3)
        {
            Destroy(gameObject, 5);
        }
    }
}
