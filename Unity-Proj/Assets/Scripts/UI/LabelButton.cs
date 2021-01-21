using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LabelButton : MonoBehaviour
{
    [SerializeField]
    private GameObject labelObject;
    [SerializeField]
    private GameObject textObject;

    private bool isHidden;

    public void SetupButton(string label)
    {
        isHidden = true;

        // button setup
        Button button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(delegate { OnClick(); });

        // label setup
        textObject.GetComponent<TextMeshProUGUI>().text = label;

        SetState(isHidden);
    }

    private void OnClick()
    {
        isHidden = !isHidden;
        SetState(isHidden);
    }

    private void SetState(bool isHidden)
    {
        labelObject.SetActive(!isHidden);
    }
}
