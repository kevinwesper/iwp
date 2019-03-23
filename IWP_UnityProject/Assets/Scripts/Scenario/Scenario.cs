using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //[Serializable]

[CreateAssetMenu]
public class Scenario : ScriptableObject
{
    [Header("Answer settings")]
    [Tooltip("Is the client missing information?")]
    public bool isMissing;
    [Tooltip("Is the client's case hopeless?")]
    public bool isHopeless;
    [Tooltip("Is the client lying?")]
    public bool isLiar;

    // public bool isScared;
    // public bool isSad;
    // public bool isConfused;

    [Tooltip("List of good arguments for this case.")]
    public string[] goodArguments;

    [Header("Story settings")]
    [Tooltip("Name of the client.")]
    public string clientName;
    [Tooltip("Introductionary problem statement of the client.")]
    [TextArea] public string clientintro;
}
