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

    private string label;
    private GameObject labelManager;

    public void SetupButton(string label, GameObject labelManager)
    {
        this.label = label;
        this.labelManager = labelManager;

        // button setup
        Button button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(delegate { OnClick(); });

        // label setup
        textObject.GetComponent<TextMeshProUGUI>().text = label;
    }

    private void OnClick()
    {
        labelManager.GetComponent<LabelManager>().ToggleLabel(label);
    }
}
