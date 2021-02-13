using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeToggle : MonoBehaviour
{
    public Toggle sizeToggle;
    public static bool sizeOn;
    public void SizeChange()
    {
        if (sizeToggle.isOn)
            sizeOn = true;
        else
            sizeOn = false;
    }
}
