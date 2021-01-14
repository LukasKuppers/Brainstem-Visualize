using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SliceDisplayManager : MonoBehaviour
{
    private static readonly string SHOW_TEXT = "Show Slices";
    private static readonly string HIDE_TEXT = "Hide Slices";

    [SerializeField]
    private List<GameObject> slices;
    [SerializeField]
    private string buttonName;
    [SerializeField]
    private bool isHidden;

    private Button toggleBtn;

    private void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        toggleBtn = root.Q<Button>(name: buttonName);

        Button newbtn = new Button();
        newbtn.text = "this is a procedurally produced button";
        newbtn.transform.position = new Vector3(50, 50, 50);
        root.Add(newbtn);

        SetState(isHidden);
        RegisterToggleButton();
    }

    private void SetState(bool isHidden)
    {
        foreach (GameObject slice in slices)
        {
            slice.SetActive(!isHidden);
        }

        string btnText = isHidden ? SHOW_TEXT : HIDE_TEXT;
        toggleBtn.text = btnText;
    }

    private void RegisterToggleButton()
    {
        toggleBtn.RegisterCallback<ClickEvent>(ev =>
        {
            isHidden = !isHidden;
            SetState(isHidden);
        });
    }
}
