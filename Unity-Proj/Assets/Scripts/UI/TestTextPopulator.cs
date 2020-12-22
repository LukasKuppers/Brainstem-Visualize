using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TestTextPopulator : MonoBehaviour
{
    [SerializeField]
    private string textKey;

    private Label text;

    public void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        text = root.Q<Label>(textKey);
        SetTextFromRes();
    }

    private void SetTextFromRes()
    {
        IContentProvider res = new CsvReader("brainstem_data");
        var data = res.GetData();

        // populate label
        string textString = "";
        foreach (List<string> row in data)
        {
            foreach (string cell in row)
            {
                textString += cell;
            }
            textString += "\n\n";
        }
        Debug.Log(textString);
        text.text = textString;
    }
}
