using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiagramWindowCreator : MonoBehaviour
{
    [SerializeField]
    private GameObject titleObject;
    [SerializeField]
    private GameObject imageObject;
    [SerializeField]
    private GameObject textObject;

    [SerializeField]
    private GameObject diagramButtonPrefab;
    
    public void SetupWindow(string title, Sprite diagramImage, List<StructureButton> structures)
    {
        // window position setup
        gameObject.transform.localPosition = Vector3.zero;
        gameObject.transform.localScale = Vector3.one;
        RectTransform rt = gameObject.GetComponent<RectTransform>();
        rt.offsetMin = Vector2.zero;
        rt.offsetMax = Vector2.zero;

        titleObject.GetComponent<TextMeshProUGUI>().text = title;
        imageObject.GetComponent<Image>().sprite = diagramImage;

        // create structure buttons
        CreateDiagramButtons(structures);
    }

    private void CreateDiagramButtons(List<StructureButton> structures)
    {
        foreach(StructureButton structure in structures)
        {
            CreateButton(structure);

            if (structure.mirror)
            {
                StructureButton mirrored = ScriptableObject.CreateInstance<StructureButton>();
                mirrored.yRatio = structure.yRatio;
                mirrored.title = structure.title;
                mirrored.dataKey = structure.dataKey;

                mirrored.xRatio = 1.0f - structure.xRatio;

                CreateButton(mirrored);
            }
        }
    }

    private void CreateButton(StructureButton data)
    {
        GameObject newBtn = Instantiate(diagramButtonPrefab);
        newBtn.name = "DiagramButton_" + data.title;
        newBtn.transform.SetParent(imageObject.transform);

        newBtn.GetComponent<DiagramButton>().SetupButton(data, textObject);
    }
}
