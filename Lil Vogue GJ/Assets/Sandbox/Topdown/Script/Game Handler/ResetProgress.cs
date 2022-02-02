using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetProgress : MonoBehaviour
{
    public void OnClick()
    {
        PlayerPrefs.DeleteKey("Artifact");
        PlayerPrefs.DeleteKey("ghostCount");
    }
}
