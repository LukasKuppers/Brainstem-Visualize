using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowReferencesButton : MonoBehaviour
{
    private static readonly string SHOW_TEXT = "Show References";
    private static readonly string HIDE_TEXT = "Hide References";

    [SerializeField]
    private GameObject textObject;

    private Button button;
    private TextMeshProUGUI buttonText;

    private bool isHidden = true;

    private void Start()
    {
        button = gameObject.GetComponent<Button>();
        buttonText = gameObject.GetComponentInChildren<TextMeshProUGUI>();

        button.onClick.AddListener(delegate { OnClick(); });
        SetState(isHidden);
    }

    private void OnClick()
    {
        isHidden = !isHidden;
        SetState(isHidden);
    }

    private void SetState(bool isHidden)
    {
        textObject.SetActive(!isHidden);

        string display = isHidden ? SHOW_TEXT : HIDE_TEXT;
        buttonText.text = display;
    }
}
