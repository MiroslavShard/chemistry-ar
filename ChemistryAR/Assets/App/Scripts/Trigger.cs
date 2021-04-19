using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [HideInInspector] public Element m_element;

    private void OnTriggerEnter(Collider other)
    {
        if (!m_element) m_element = other.GetComponentInParent<Element>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (m_element) m_element = null;
    }
}