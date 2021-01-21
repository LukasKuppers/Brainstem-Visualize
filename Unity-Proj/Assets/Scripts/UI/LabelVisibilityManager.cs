using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LabelVisibilityManager : MonoBehaviour
{
    private static readonly string SHOW_LABEL = "Show Labels";
    private static readonly string HIDE_LABEL = "Hide Labels";

    [SerializeField]
    private bool isHidden = false;

    private List<GameObject> labels = new List<GameObject>();
    private List<GameObject> labelAnchors = new List<GameObject>();

    private TextMeshProUGUI text;

    private void Start()
    {
        text = gameObject.GetComponentInChildren<TextMeshProUGUI>();

        gameObject.GetComponent<Button>().onClick.AddListener(delegate { OnClick(); });
    }

    public void AddLabel(GameObject label, GameObject anchor)
    {
        if (label != null && anchor != null)
        {
            labels.Add(label);
            labelAnchors.Add(anchor);
            anchor.SetActive(!isHidden);
            label.SetActive(!isHidden);
        }
    }

    private void OnClick()
    {
        isHidden = !isHidden;
        SetState(isHidden);
    }

    private void SetState(bool isHidden)
    {
        string displayText = isHidden ? SHOW_LABEL : HIDE_LABEL;
        text.text = displayText;

        foreach(GameObject anchor in labelAnchors)
        {
            anchor.SetActive(!isHidden);
        }

        foreach (GameObject label in labels)
        {
            label.SetActive(!isHidden);
        }
    }
}
