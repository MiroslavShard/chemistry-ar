using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARTrackedImageManager))]
public class ImageTracking : MonoBehaviour
{
    private Dictionary<string, GameObject> atoms = null;

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
        trackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    private void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnImageChanged;
    }

    private void Start()
    {
        ObjectLibrary.instance.GenerateLibrary();
    }

    private void OnImageChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var added in eventArgs.added)
        {
            AddObject(added.referenceImage.name);
        }

        foreach (var updated in eventArgs.updated)
        {
            UpdateObject(updated);
        }

        foreach (var removed in eventArgs.removed)
        {
            Destroy(removed.gameObject);
        }
    }

    private void AddObject(string id)
    {
        ObjectLibrary.instance.objects[id].SetActive(true);
    }

    private void UpdateObject(ARTrackedImage trackedImage)
    {
        if (trackedImage.trackingState == TrackingState.Tracking)
        {
            ObjectLibrary.instance.objects[trackedImage.referenceImage.name].SetActive(true);
            ObjectLibrary.instance.objects[trackedImage.referenceImage.name].transform.position = new Vector3(trackedImage.transform.position.x, trackedImage.transform.position.y + 0.04f, trackedImage.transform.position.z);
            ObjectLibrary.instance.objects[trackedImage.referenceImage.name].transform.rotation = trackedImage.transform.rotation;
        }
        else
        {
            ObjectLibrary.instance.objects[trackedImage.referenceImage.name].SetActive(false);
        }
    }
}