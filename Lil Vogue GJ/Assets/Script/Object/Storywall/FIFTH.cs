using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIFTH : MonoBehaviour
{
    private void Update()
    {
        if (PlayerPrefs.GetInt("Artifact") >= 5)
        {
            Destroy(gameObject, 5);
        }
    }
}
