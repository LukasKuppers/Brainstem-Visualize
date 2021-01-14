using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementController : MonoBehaviour
{
    [SerializeField]
    private float sensitivity = 0.5f;

    private MouseInput mouseInput;

    private GameObject cameraRoot;
    private Vector3 rotState;

    void Start()
    {
        mouseInput = gameObject.AddComponent<MouseInput>();
        cameraRoot = gameObject;
        rotState = new Vector3(0, 0, 0);
    }

    void Update()
    {
        // set rotation
        cameraRoot.transform.rotation = Quaternion.Euler(rotState);

        // update state based on inputs
        rotState = ApplyInput(rotState);
    }

    private Vector3 ApplyInput(Vector3 state)
    {
        float dHorizontal = mouseInput.GetHorizontalDrag();
        float dVertial = mouseInput.GetVerticalDrag();

        state.y += dHorizontal * sensitivity;
        state.x -= dVertial * sensitivity;

        state.x = Mathf.Clamp(state.x, -90, 90);

        return state;
    }
}
