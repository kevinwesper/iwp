using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing_OpenPopUp : MonoBehaviour
{
    public void ActivatePopUp(GameObject _popUp)
    {
        _popUp.SetActive(!_popUp.activeSelf);
    }
}
