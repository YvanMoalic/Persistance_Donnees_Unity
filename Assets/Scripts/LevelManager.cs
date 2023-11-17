using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private ScoreDatas _ScoreData;

    private void Start()
    {
        _ScoreData.InitScoreValue(0);
        SceneManager.LoadScene("Niveau1");
    }
}
