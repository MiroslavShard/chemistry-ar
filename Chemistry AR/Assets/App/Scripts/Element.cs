using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Element : MonoBehaviour
{
    public string symbol = "";
    [Space(5)]

    public bool isReactive = false;
    public List<GameObject> molecules = new List<GameObject>();
    [Space(5)]

    [HideInInspector] public bool reacted = false;

    [HideInInspector] public GameObject atom = null;
    [HideInInspector] public Trigger[] triggers = null;
    [HideInInspector] public Dictionary<string, GameObject> reactions = new Dictionary<string, GameObject>();

    private void Awake()
    {
        // Setup rigidbody
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
        rigidbody.isKinematic = true;

        // Get atom gameobject (always first in tree, so index = 0)
        atom = transform.GetChild(0).gameObject;

        // Get all triggers in children objects
        triggers = GetComponentsInChildren<Trigger>();

        // Build reactions dictionary
        foreach (var molecule in molecules)
            reactions.Add(molecule.name, molecule);
    }

    public void React()
    {
        if (isReactive)
        {
            reacted = true;

            List<string> symbols = new List<string>();

            foreach (var symbol in triggers)
                symbols.Add(symbol.element.symbol);

            // H2O
            if (symbols[0] == "H" && symbols[1] == "H")
            {
                atom.SetActive(false);
                triggers[0].element.atom.SetActive(false);
                triggers[1].element.atom.SetActive(false);

                reactions["H2O"].SetActive(true);
            }
        }
    }

    public void Reset()
    {
        if (reacted)
        {
            reacted = false;

            atom.SetActive(true);
            triggers[0].element.atom.SetActive(true);
            triggers[1].element.atom.SetActive(true);

            reactions["H2O"].SetActive(false);
        }
    }
}