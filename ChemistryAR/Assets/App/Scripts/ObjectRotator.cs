using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Rotate(0f, 50f * Time.deltaTime, 0f);
    }
}