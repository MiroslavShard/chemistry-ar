using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atom : MonoBehaviour
{
    public Transform target;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * 1f);
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.05f, transform.position.z);
    }
}