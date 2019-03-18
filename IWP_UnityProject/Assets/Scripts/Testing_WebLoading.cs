using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Testing_WebLoading : MonoBehaviour
{
    public void ButtonClick(string url)
    {
        Application.OpenURL(url);
    }
}
