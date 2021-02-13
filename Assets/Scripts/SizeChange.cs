using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChange : MonoBehaviour
{
    public static bool isOn;
        
    // Start is called before the first frame update
    void Start()
    {
        isOn = DataManager.sizeBool;
        if(isOn)
        {
            transform.localScale = new Vector3(2f, 2f, 2f);
        }    
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
