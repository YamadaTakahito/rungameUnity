using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        Vector3 newPostion = player.transform.position;
        newPostion.z = -10;
        this.transform.position = newPostion;
    }
}
