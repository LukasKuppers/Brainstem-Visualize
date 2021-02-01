using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGenerator
{
    private IContentProvider rawData;

    public TextGenerator(string dataPath, int keyCol)
    {
        rawData = new TsvReader(dataPath, keyCol);
    }

    public string GetText(string key, string name)
    {
        List<string> row = rawData.GetRow(key);
        string description = row[2];
        string pathology = row[3];

        string text = "<font=\"RobotoMono-VariableFont_wght SDF\"><b>" + name + ": </b></font> \n";
        text += description;

        if (pathology != null && pathology != "")
        {
            text += "\n\n<font=\"RobotoMono-VariableFont_wght SDF\"><b>Pathology:</b></font> \n";
            text += pathology;
        }

        return text;
    }
}
