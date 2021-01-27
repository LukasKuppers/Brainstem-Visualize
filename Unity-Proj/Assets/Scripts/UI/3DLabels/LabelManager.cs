using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LabelManager : MonoBehaviour
{
    [SerializeField]
    private Color enabledColor;
    [SerializeField]
    private Color disabledColor;

    private Dictionary<string, GameObject> labels = new Dictionary<string, GameObject>();

    public void AddLabel(string name, GameObject label)
    {
        if (name != "" && label != null)
        {
            labels.Add(name, label);
            GetChild(label).SetActive(false);
        }
    }

    public void ToggleLabel(string name)
    {
        var label = labels[name];
        if (GetChild(labels[name]).activeSelf)
        {
            label.GetComponent<Image>().color = disabledColor;
            GetChild(labels[name]).SetActive(false);
        }
        else
        {
            foreach(var labelPair in labels)
            {
                labelPair.Value.GetComponent<Image>().color = disabledColor;
                GetChild(labelPair.Value).SetActive(false);
            }
            label.GetComponent<Image>().color = enabledColor;
            GetChild(label).SetActive(true);
        }
    }

    private GameObject GetChild(GameObject obj)
    {
        return obj.transform.GetChild(0).gameObject;
    }
}
