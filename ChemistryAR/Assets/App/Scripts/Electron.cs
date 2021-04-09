using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electron : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Rotate(0f, 90f * Time.deltaTime, 0f);
    }
}