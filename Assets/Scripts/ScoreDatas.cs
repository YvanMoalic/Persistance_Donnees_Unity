using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "NewScore")]
public class ScoreDatas : ScriptableObject
{
    public int ScoreValue;

    public delegate void ScoreUpdate(int value);
    public static event ScoreUpdate OnUpdate;

    private void Start()
    {
        UpdateScoreUI();
    }

    public void UpdateScoreValue(int value)
    {
        ScoreValue = Mathf.Clamp(ScoreValue + value, 0, 9999);
        UpdateScoreUI();
    }

    public void InitScoreValue(int initValue)
    {
        ScoreValue = Mathf.Clamp(initValue, 0, 9999);
        UpdateScoreUI();
    }

    public void UpdateScoreUI()
    {
        OnUpdate?.Invoke(ScoreValue);
    }
}
