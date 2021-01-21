using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Structure", menuName = "Structure Button")]
public class StructureButton : ScriptableObject
{
    public float xRatio;
    public float yRatio;
    public string title;
    public string dataKey;
}
