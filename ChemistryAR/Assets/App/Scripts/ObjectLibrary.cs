using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLibrary : MonoBehaviour
{
    [SerializeField] private List<GameObject> objectLibrary = new List<GameObject>();

    [HideInInspector] public Dictionary<string, GameObject> objects = new Dictionary<string, GameObject>();

    #region Singleton activation
    [HideInInspector] public static ObjectLibrary instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }
    #endregion

    public void GenerateLibrary()
    {
        foreach (var gameObject in objectLibrary)
        {
            objects.Add(gameObject.name, gameObject);
        }
    }
}