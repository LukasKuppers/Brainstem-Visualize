﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsvReader : IContentProvider
{
    private readonly TextAsset textData;

    private List<List<string>> dataTable;

    public CsvReader(string path)
    {
        textData = Resources.Load<TextAsset>(path);
        dataTable = new List<List<string>>();

        string[] rows = textData.text.Split(new char[] { '\n' });
        for (int i = 1; i < rows.Length - 1; i++)
        {
            string[] row = rows[i].Split(new char[] { ',' });
            List<string> parsedRow = new List<string>();
            foreach (string cell in row)
            {
                parsedRow.Add(cell);
            }
            dataTable.Add(parsedRow);
        }
    }

    public List<string> GetRow(string key)
    {
        if (key == null || key == "")
        {
            throw new System.ArgumentNullException("Given key cannot be null or empty");
        }

        foreach(List<string> row in dataTable)
        {
            if (row[0].Equals(key))
            {
                return row;
            }
        }
        return null;
    }

    public List<List<string>> GetData()
    {
        return dataTable;
    }

}
