using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform cameraTarget;
    private Transform camT;
    [SerializeField] private Vector3 CamOffset = new Vector3(0, 0, -10);
    void Start()
    {
        if (Camera.main != null) camT = Camera.main.transform;
    }

    void LateUpdate()
    {
        var position = transform.position;
        position.z = -10;
        Camera.main.transform.position = cameraTarget.position + CamOffset;
        //camT.position = cameraTarget.position + CamOffset;
        //transform.position = cameraTarget.position + CamOffset;
    }
}
