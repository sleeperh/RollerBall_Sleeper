using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position; // calculate camera 3D offset
    }

    // LateUpdate runs every frame but after all other updates have ran
    void LateUpdate() 
    {
        transform.position = player.transform.position + offset; // use offset to position camera 
    }
}
