using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliceClickManager : MonoBehaviour
{
    private static readonly string WINDOW_NAME = "Primary Diagram Window";

    [SerializeField]
    private GameObject windowPrefab;
    [SerializeField]
    private GameObject canvas;

    [SerializeField]
    private Sprite image;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnClick();
        }
    }

    private void OnClick()
    {
        // destroy old window
        GameObject oldWindow = GameObject.Find(WINDOW_NAME);
        if (oldWindow != null)
        {
            Destroy(oldWindow);
        }

        // create new window
        GameObject newWindow = Instantiate(windowPrefab);
        newWindow.name = WINDOW_NAME;
        newWindow.transform.SetParent(canvas.transform);

        // window setup
        newWindow.transform.GetChild(0).GetComponent<Image>().sprite = image;
    }
}
