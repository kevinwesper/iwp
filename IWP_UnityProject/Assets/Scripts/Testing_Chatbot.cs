using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Testing_Chatbot : MonoBehaviour
{
    [SerializeField] private Text PlayerText;

    public void Typing()
    {
        Debug.Log("Still typing...");

    }

    public void Done()
    {
        Debug.Log("Done typing");
        CheckText();
    }

    private void CheckText()
    {
        if (PlayerText.text.Contains("test") || PlayerText.text.Contains("Test"))
        {
            Debug.Log("contains test or Test");
        }
    }
}
