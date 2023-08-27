using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceManager : MonoBehaviour
{
    public void React()
    {
        foreach (KeyValuePair<string, GameObject> element in ObjectLibrary.instance.objects)
            element.Value.GetComponent<Element>().React();
    }

    public void Reset()
    {
        foreach (KeyValuePair<string, GameObject> element in ObjectLibrary.instance.objects)
            element.Value.GetComponent<Element>().Reset();
    }
}