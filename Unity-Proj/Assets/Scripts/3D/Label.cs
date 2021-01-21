using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Label : MonoBehaviour
{
    [SerializeField]
    private GameObject canvas;
    [SerializeField]
    private GameObject cameraObject;
    [SerializeField]
    private GameObject buttonPrefab;
    [SerializeField]
    private GameObject showLabelButton;
    [SerializeField]
    private GameObject labelManager;
    [SerializeField]
    private string label;

    private Camera cam;

    private GameObject button;
    private RectTransform btnRt;

    private void Start()
    {
        cam = cameraObject.GetComponent<Camera>();

        // spawn button
        button = Instantiate(buttonPrefab);
        button.transform.SetParent(canvas.transform);
        btnRt = button.GetComponent<RectTransform>();

        button.GetComponent<LabelButton>().SetupButton(label: label, labelManager);

        // hookup to label label managers
        showLabelButton.GetComponent<LabelVisibilityManager>().AddLabel(button, gameObject);
        labelManager.GetComponent<LabelManager>().AddLabel(label, button);
    }

    private void Update()
    {
        if(Physics.Linecast(cameraObject.transform.position, transform.position))
        {
            button.SetActive(false);
        }
        else
        {
            button.SetActive(true);
            SetButtonPosition();
        }
    }

    private void SetButtonPosition()
    {
        var screenPoint = cam.WorldToScreenPoint(transform.position);
        btnRt.position = screenPoint;
    }
}
