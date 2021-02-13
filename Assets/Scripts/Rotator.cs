using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float spin;
   
    private float randomSpin;
    private float randOffset;

    private void Start()
    {
        randOffset = Random.Range(0.0f, 50.0f);
        randomSpin = spin - randOffset;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, randomSpin) * Time.deltaTime);
    }

}
