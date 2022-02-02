using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SIXTH : MonoBehaviour
{
    private void Update()
    {
        if (PlayerPrefs.GetInt("Artifact") >= 6)
        {
            Destroy(gameObject, 5);
        }
    }
}
