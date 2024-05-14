using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform cameraTarget;
    [SerializeField] private Vector3 CamOffset = new Vector3(0, 0, -10);


    void LateUpdate()
    {
        cameraTarget = PlayerCharacter.Instance.character.GetComponent<Transform>();
        Camera.main.transform.position = cameraTarget.position + CamOffset;
    }

    public void SetCameraTarget(Transform newCameraTarget)
    {
        cameraTarget = newCameraTarget;
    }
}
