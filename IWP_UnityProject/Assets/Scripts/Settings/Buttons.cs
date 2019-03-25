using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void ChangeScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void ChooseScenario(Scenario scenario)
    {
        FindObjectOfType<Settings>().pickedScenario = scenario;
    }
}
