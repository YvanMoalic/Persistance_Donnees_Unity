using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objectives")]
public class Objective : ScriptableObject
{
    [SerializeField] public string Name;
    [SerializeField] public int MaxValue;
    [SerializeField] public int StartValue;
    [SerializeField] public int ActualValue;
    [SerializeField] public bool IsFinished;
    [SerializeField] public string CollectibleType;
}
