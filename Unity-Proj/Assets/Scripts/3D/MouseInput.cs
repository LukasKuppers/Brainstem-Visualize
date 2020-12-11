using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    private Vector3 prevMousePos;
    private float dx;
    private float dy;

    private void Start()
    {
        prevMousePos = Input.mousePosition;
    }

    private void Update()
    {
        Vector3 current = Input.mousePosition;

        dx = current.x - prevMousePos.x;
        dy = current.y - prevMousePos.y;

        prevMousePos.x = current.x;
        prevMousePos.y = current.y;
    }

    private void OnMouseDown()
    {
        prevMousePos = Input.mousePosition;
    }

    public float GetVerticalDrag()
    {
        return Input.GetMouseButton(button: 0) ? dy : 0f;
    }

    public float GetHorizontalDrag()
    {
        return Input.GetMouseButton(button: 0) ? dx : 0f;
    }
}
