using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLibrary : MonoBehaviour
{
    public List<Object> objectLibrary = new List<Object>();

    public Dictionary<string, GameObject> objects = new Dictionary<string, GameObject>();

    private void Awake()
    {
        foreach (var gameObject in objectLibrary)
        {
            objects.Add(gameObject.name, gameObject.prefab);
        }
    }
}

[System.Serializable]
public class Object
{
    public string name;
    public GameObject prefab;
}