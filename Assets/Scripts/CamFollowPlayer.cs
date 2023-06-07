using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform transformToFollow;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float speed = 10f;
    [SerializeField] private Transform LookAt;

    private void LateUpdate()
    {
        Vector3 cameraPosition = transformToFollow.position + offset;

        transform.position = Vector3.Lerp(transform.position, cameraPosition, speed * Time.deltaTime);

        transform.LookAt(LookAt.position);
    }
}
