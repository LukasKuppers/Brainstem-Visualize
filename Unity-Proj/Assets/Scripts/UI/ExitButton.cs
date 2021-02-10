using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    private Button button;

    private void Start()
    {
        button = gameObject.GetComponent<Button>();

        button.onClick.AddListener(delegate { OnClick(); });
    }

    private void OnClick()
    {
        Application.Quit();
    }
}
