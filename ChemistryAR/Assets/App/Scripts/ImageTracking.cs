using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARTrackedImageManager))]
public class ImageTracking : MonoBehaviour
{
    private ARTrackedImageManager m_trackedImageManager = null;

    private void Awake()
    {
        if (!m_trackedImageManager) m_trackedImageManager = GetComponent<ARTrackedImageManager>();
    }

    private void OnEnable()
    {
        m_trackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    private void OnDisable()
    {
        m_trackedImageManager.trackedImagesChanged -= OnImageChanged;
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
            ObjectLibrary.instance.objects[trackedImage.referenceImage.name].transform.position = trackedImage.transform.position;
            ObjectLibrary.instance.objects[trackedImage.referenceImage.name].transform.rotation = trackedImage.transform.rotation;
        }
        else
        {
            ObjectLibrary.instance.objects[trackedImage.referenceImage.name].SetActive(false);
        }
    }
}