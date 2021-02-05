using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenToWorldPositioner : MonoBehaviour
{
    [SerializeField]
    private float panelRatio;
    [SerializeField]
    private GameObject camObject;

    private Camera cam;

    private void Start()
    {
        cam = camObject.GetComponent<Camera>();

        // find screen position
        float xRatio = ((1f - panelRatio) / 2f) + panelRatio;
        Vector3 screenPos = new Vector3(Screen.width * xRatio, Screen.height / 2f, 10);

        // position object
        Vector3 worldPos = cam.ScreenToWorldPoint(screenPos);
        transform.position = worldPos;
    }

}
