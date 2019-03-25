using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Testing_Chatbot : MonoBehaviour
{
    [SerializeField] private Text playerInputText;

    [SerializeField] private Transform textSpawnTransform;

    private Scenario scenario;

    private void Awake()
    {
        scenario = FindObjectOfType<Settings>().pickedScenario;
        SpawnText("Hallo, ik ben " + scenario.clientName);
        SpawnText(scenario.clientintro);
    }

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
        for (int i = 0; i < scenario.reactionList.Length; i++)
        {
            if (playerInputText.text.Contains(scenario.reactionList[i].keyword))
            {
                SpawnText(scenario.reactionList[i].reaction);
            }
            else
            {
                SpawnText("Sorry, ik begrijp niet wat je bedoelt.");
            }
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
