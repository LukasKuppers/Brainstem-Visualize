using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliceVisibilityManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> slices;

    private static readonly string TEXT_SHOW = "Show Slices";
    private static readonly string TEXT_HIDE = "Hide Slices";

    private Button button;
    private TextMeshProUGUI btnText;

    private bool isHidden = false;

    private void Start()
    {
        button = gameObject.GetComponent<Button>();
        btnText = gameObject.GetComponentInChildren<TextMeshProUGUI>();

        button.onClick.AddListener(delegate { OnClick(); });
        SetState(isHidden);
    }

    public void OnClick()
    {
        isHidden = !isHidden;
        SetState(isHidden);
    }

    private void SetState(bool isHIdden)
    {
        foreach (var slice in slices)
        {
            slice.SetActive(!isHidden);
        }

        string text = isHidden ? TEXT_SHOW : TEXT_HIDE;
        btnText.text = text;
    }
}
