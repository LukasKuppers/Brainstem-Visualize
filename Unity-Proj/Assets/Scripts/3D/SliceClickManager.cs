using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliceClickManager : MonoBehaviour
{
    [SerializeField]
    private GameObject windowPrefab;
    [SerializeField]
    private GameObject canvas;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnClick();
        }
    }

    private void OnClick()
    {
        GameObject newWindow = Instantiate(windowPrefab);
        newWindow.name = "My New Window!";
        newWindow.transform.SetParent(canvas.transform);
    }
}
