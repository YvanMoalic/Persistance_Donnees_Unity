using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    [SerializeField] private ScoreDatas _ScoreData;

    [SerializeField] private Objective _ObjectiveCuivre;
    [SerializeField] private Objective _ObjectiveFer;
    [SerializeField] private Objective _ObjectiveOr;

    [SerializeField] private QuestStarted _QuestStarted;

    public GameObject questUI;

    private void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            _ObjectiveCuivre.InitActualValue();
            _ObjectiveFer.InitActualValue();
            _ObjectiveOr.InitActualValue();

            _ScoreData.InitScoreValue(0);

            _QuestStarted.InitQuestStarted();

            SceneManager.LoadScene("Niveau1");
        }

        else
        {
            _ScoreData.UpdateScoreUI();


            if(_QuestStarted.startedQuest == true)
            {
                questUI.SetActive(true);
                _ObjectiveCuivre.UpdateActualValueUI();
                _ObjectiveFer.UpdateActualValueUI();
                _ObjectiveOr.UpdateActualValueUI();
            }
            
        }
    }
}
