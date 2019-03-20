using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Testing_Chatbot : MonoBehaviour
{
    [SerializeField] private Text playerInputText;

    [SerializeField] private Transform textSpawnTransform;

    public void Typing()
    {
        Debug.Log("Still typing...");

    }

    public void Done()
    {
        Debug.Log("Done typing");
        SpawnText(playerInputText.text, true);
        CheckText();
    }

    private void CheckText()
    {
        if (playerInputText.text.Contains("404"))
        {
            SpawnText("Hallo, ik had een afspraak. Mijn naam is <GenericName>.");
            SpawnText("Ik heb een probleem met het maken van deze game.");
        }
        else if (playerInputText.text.Contains("probleem"))
        {
            SpawnText("Het probleem is dat de code een bende wordt en ik nog geen idee heb hoe ik het schoon kan houden.");
        }
        else if (playerInputText.text.Contains("vaktaal"))
        {
            SpawnText("Ik kan ook nog niet goed bezig omdat ik nog geen voorbeeld heb van een casus.");
        }
        else
        {
            SpawnText("Sorry, ik begrijp niet goed wat u zegt, kunt u het misschien anders verwoorden?");
        }
    }

    private void SpawnText(string _output, bool _player = false)
    {
        GameObject _newText = new GameObject(_output.Replace(" ", "-"), typeof(RectTransform));
        var _newTextComp = _newText.AddComponent<Text>();

        _newTextComp.text = _output;
        _newTextComp.font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
        _newTextComp.color = Color.black;
        _newTextComp.horizontalOverflow = HorizontalWrapMode.Wrap;
        _newTextComp.verticalOverflow = VerticalWrapMode.Overflow;

        if (_player)
        {
            _newTextComp.alignment = TextAnchor.UpperRight;
        }

        _newText.GetComponent<RectTransform>().sizeDelta = new Vector2(260, 32);      
        _newText.transform.SetParent(textSpawnTransform);
    }
}
