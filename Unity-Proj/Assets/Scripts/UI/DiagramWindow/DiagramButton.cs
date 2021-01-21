using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiagramButton : MonoBehaviour
{
    private StructureButton buttonInfo;

    private GameObject textObject;

    public void SetupButton(StructureButton buttonInfo, GameObject textObject)
    {
        this.buttonInfo = buttonInfo;
        this.textObject = textObject;

        // set button position
        RectTransform rt = gameObject.GetComponent<RectTransform>();
        Vector2 anchor = new Vector2(buttonInfo.xRatio, buttonInfo.yRatio);
        rt.anchorMin = anchor;
        rt.anchorMax = anchor;
        rt.anchoredPosition = Vector2.zero;

        // set onclick
        Button button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(delegate { OnClick(); });
    }

    private void OnClick()
    {
        string text = "<b>TITLE</b>\n";
        text += buttonInfo.dataKey;
        textObject.GetComponent<TextMeshProUGUI>().text = text;
    }
}
