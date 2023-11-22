using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour,ICollectible
{
    [SerializeField] int _value;
    [SerializeField] ScoreDatas _scoreData;
    public Objective objectives;

    public void Collect()
    {
        objectives.UpdateScoreValue(1);

        _scoreData.UpdateScoreValue(_value);
        this.gameObject.SetActive(false);
    }
}
