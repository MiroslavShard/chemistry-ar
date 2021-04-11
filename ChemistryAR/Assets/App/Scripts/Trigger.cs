using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Element element;

    private void OnTriggerEnter(Collider other)
    {
        element = other.GetComponentInParent<Element>();
    }

    private void OnTriggerExit(Collider other)
    {
        element = null;
    }
}