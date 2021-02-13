using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    void Start()
    {
        GetComponent<Renderer>().material.color = new Color(DataManager.redV, DataManager.greenV, DataManager.blueV, DataManager.alphaV);
    }
}
