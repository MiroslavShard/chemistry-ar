using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    [SerializeField] private float speed = 50f;

    private void Update()
    {
        transform.Rotate(0f, speed * Time.deltaTime, 0f);
    }
}