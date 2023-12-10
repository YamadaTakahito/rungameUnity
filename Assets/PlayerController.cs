using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    void Start()
    {
        this.GetComponent<Animator>().Play("SkipAnim");
    }
    
    void FixedUpdate()
    {
        this.transform.Translate(0.014f, 0, 0);
    }
}
