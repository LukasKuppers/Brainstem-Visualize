using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IContentProvider
{
    List<string> GetRow(string key);

    List<List<string>> GetData();
}
