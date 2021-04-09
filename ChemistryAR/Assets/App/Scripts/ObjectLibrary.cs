using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLibrary : MonoBehaviour
{
    public List<Object> objectLibrary = new List<Object>();

    public Dictionary<string, GameObject> objects = new Dictionary<string, GameObject>();

    #region Singleton activation
    [HideInInspector] public static ObjectLibrary instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            GenerateLibrary();
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }
    #endregion

    private void GenerateLibrary()
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