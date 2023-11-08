using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour,ICollectible
{
    /*[SerializeField] int _value;
    [SerializeField] ScoreDatas _scoreData;*/
    [SerializeField] Objective objectives;



    public void Collect()
    {
        objectives.ActualValue += 1;
        Destroy(gameObject);

        /*_scoreData.UpdateScoreValue(_value);
        Destroy(gameObject);*/
    }
}
