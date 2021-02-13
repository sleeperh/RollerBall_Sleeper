using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ColorPicker : MonoBehaviour
{

    public Dropdown dropDown;

    public static float redVal;
    public static float greenVal;
    public static float blueVal;
    public static float alphaVal;
    public void ColorChange()
    {
        switch(dropDown.value)
        {
            case 0: // grey
                redVal = 0.5f;
                greenVal = 0.5f;
                blueVal = 0.5f;
                alphaVal = 1.0f;
                break;
            case 1: // red
                redVal = 1.0f;
                greenVal = 0.0f;
                blueVal = 0.0f;
                alphaVal = 1.0f;
                break;
            case 2: //blue
                redVal = 0.0f;
                greenVal = 0.0f;
                blueVal = 1.0f;
                alphaVal = 1.0f;
                break;
            case 3: // green
                redVal = 0.14f;
                greenVal = 0.37f;
                blueVal = 0.14f;
                alphaVal = 1.0f;
                break;
            case 4: // purple
                redVal = 0.5f;
                greenVal = 0.0f;
                blueVal = 0.8f;
                alphaVal = 1.0f;
                break;
            default: // grey
                redVal = 0.5f;
                greenVal = 0.5f;
                blueVal = 0.5f;
                alphaVal = 1.0f;
                break;
        }
    }
}
