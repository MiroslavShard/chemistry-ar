using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARTrackedImageManager))]
public class ImageTracking : MonoBehaviour
{
    public GameObject currentAtom = null;

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
            Destroy(currentAtom);
        }

        foreach (var trackedImage in eventArgs.added)
        {
            currentAtom = Instantiate(ObjectLibrary.instance.objects[trackedImage.referenceImage.name], trackedImage.transform);
            currentAtom.GetComponent<Atom>().target = trackedImage.transform;
        }
    }
}