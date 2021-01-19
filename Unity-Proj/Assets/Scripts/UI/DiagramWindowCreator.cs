using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiagramWindowCreator : MonoBehaviour
{
    [SerializeField]
    private GameObject TitleObject;
    [SerializeField]
    private GameObject ImageObject;
    
    public void SetupWindow(string title, Sprite diagramImage)
    {
        // window position setup
        gameObject.transform.localPosition = Vector3.zero;
        gameObject.transform.localScale = Vector3.one;
        RectTransform rt = gameObject.GetComponent<RectTransform>();
        rt.offsetMin = Vector2.zero;
        rt.offsetMax = Vector2.zero;

        TitleObject.GetComponent<TextMeshProUGUI>().text = title;
        ImageObject.GetComponent<Image>().sprite = diagramImage;
    }
}
