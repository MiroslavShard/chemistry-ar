using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARTrackedImageManager))]
public class ImageTracking : MonoBehaviour
{
    private Dictionary<string, GameObject> atom = null;

    private ARTrackedImageManager trackedImageManager;

    private void Awake()
    {
        if (!trackedImageManager)
        {
            trackedImageManager = GetComponent<ARTrackedImageManager>();
        }
    }

    private void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += ImageChanged;
    }

    private void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= ImageChanged;
    }

    private void ImageChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var trackedImage in eventArgs.removed)
        {
            Destroy(atom[trackedImage.name]);
        }

        foreach (var trackedImage in eventArgs.added)
        {
            atom.Add(trackedImage.name, Instantiate(ObjectLibrary.instance.objects[trackedImage.referenceImage.name], trackedImage.transform));
            atom[trackedImage.name].GetComponent<Atom>().target = trackedImage.transform;
        }
    }
}