using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public float speed = 50f;

    private void FixedUpdate()
    {
        transform.Rotate(0f, speed * Time.deltaTime, 0f);
    }
}