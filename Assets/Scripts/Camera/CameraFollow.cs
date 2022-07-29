using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] Vector3 offset;
    [SerializeField] private float lerpValue;

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, lerpValue);
    }
}
