using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedSlider : MonoBehaviour
{
    public static float speedValue;
    private float maxSpeed = 15.0f;

    public void SetSpeed(float valMultiplier)
    {
        speedValue = maxSpeed * valMultiplier;
    }

}
