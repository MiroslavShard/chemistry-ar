using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARTrackedImageManager))]
public class ImageTracking : MonoBehaviour
{
    private ARTrackedImageManager trackedImageManager;

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
        foreach (var trackedImage in eventArgs.added)
        {
            GameObject parent = trackedImage.transform.GetChild(0).gameObject;

            if (trackedImage.trackingState != TrackingState.None)
            {
                switch (trackedImage.referenceImage.name)
                {
                    default:
                        break;
                }
            }
        }
    }
}