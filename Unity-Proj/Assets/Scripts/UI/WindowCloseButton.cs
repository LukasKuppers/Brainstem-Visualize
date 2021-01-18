using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowCloseButton : MonoBehaviour
{
    [SerializeField]
    private GameObject buttonObject;

    private Button button;

    private void Start()
    {
        button = buttonObject.GetComponent<Button>();

        button.onClick.AddListener(delegate { OnClick(); });
    }

    private void OnClick()
    {
        // destroy parent gameobject
        Destroy(gameObject);
    }
}
