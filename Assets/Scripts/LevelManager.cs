using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private ScoreDatas _ScoreData;

    private void Start()
    {
        _ScoreData.InitScoreValue(0);
    }
}
