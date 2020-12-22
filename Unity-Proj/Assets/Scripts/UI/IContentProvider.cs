using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IContentProvider
{
    public List<string> GetRow(string key);
}
