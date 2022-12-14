using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0,180.0f * Time.deltaTime,0);
    }
}
