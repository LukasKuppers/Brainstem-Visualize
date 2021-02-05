using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementController : MonoBehaviour
{
    [SerializeField]
    private float sensitivity = 0.5f;
    [SerializeField]
    private bool invertYAxis = false;
    [SerializeField]
    private bool invertXAxis = false;

    private MouseInput mouseInput;

    private GameObject cameraRoot;

    private float invertX = 1f;
    private float invertY = 1f;

    void Start()
    {
        invertX = invertXAxis ? -1f : 1f;
        invertY = invertYAxis ? -1f : 1f;

        mouseInput = gameObject.AddComponent<MouseInput>();
        cameraRoot = gameObject;
    }

    void Update()
    {
        cameraRoot.transform.RotateAround(cameraRoot.transform.position, cameraRoot.transform.up,
            mouseInput.GetHorizontalDrag() * sensitivity * invertX);

        cameraRoot.transform.RotateAround(cameraRoot.transform.position, Vector3.right,
            mouseInput.GetVerticalDrag() * sensitivity * invertY);
    }
}
