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

    public delegate void ScoreUpdate(int value);
    public static event ScoreUpdate OnValueUpdate;


    public void InitActualValue()
    {
        ActualValue= StartValue;
        IsFinished = false;
    }

    public void UpdateScoreValue(int value)
    {
        ActualValue = Mathf.Clamp(ActualValue + value, 0, 9999);
        UpdateActualValueUI();

        if (ActualValue >= MaxValue)
        {
            IsFinished = true;
        }
    }

    public void UpdateActualValueUI()
    {
        OnValueUpdate?.Invoke(1);
    }
}
