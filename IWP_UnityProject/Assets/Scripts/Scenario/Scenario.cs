using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Reaction
{
    public string keyword;
    [TextArea] public string reaction;
}

[CreateAssetMenu]
public class Scenario : ScriptableObject
{
    #region Scenario Settings
    [Header("Scenario Settings")]

    [Tooltip("Is the client missing information?")]
    public bool isMissing;
    [Tooltip("Is the client's case hopeless?")]
    public bool isHopeless;

    //public bool isLiar;
    // public bool isScared;
    // public bool isSad;
    // public bool isConfused;
    #endregion

    #region Answer Settings
    [Header("Answer Settings")]
    
    [Tooltip("List of good arguments for this case.")]
    public string[] goodArguments;
    #endregion

    #region Story Settings
    [Header("Story Settings")]

    [Tooltip("Name of the client.")]
    public string clientName;

    [Tooltip("Introductionary problem statement of the client.")]
    [TextArea] public string clientintro;

    [Tooltip("Reactions by Keywords")]
    public Reaction[] reactionList;

    #endregion
}
