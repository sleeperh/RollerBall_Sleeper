using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static float redV;
    public static float greenV;
    public static float blueV;
    public static float alphaV;
    public static float speed;
    public static bool sizeBool;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    private void Update()
    {
        redV = ColorPicker.redVal;
        greenV = ColorPicker.greenVal;
        blueV = ColorPicker.blueVal;
        alphaV = ColorPicker.alphaVal;
        speed = SpeedSlider.speedValue;
        sizeBool = SizeToggle.sizeOn;
    }
}
