using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [HideInInspector] public Element element;

    private void OnTriggerEnter(Collider other)
    {
        if (!element) element = other.GetComponentInParent<Element>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (element) element = null;
    }
}