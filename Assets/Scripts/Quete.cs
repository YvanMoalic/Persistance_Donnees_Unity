using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quete : MonoBehaviour
{
    [SerializeField] private int i = 0;
    [SerializeField] Objective[] _objective;
    [SerializeField] QuestStarted _questStarted;
    public GameObject questUI;

    public void StartQuest()
    {
        if(_questStarted.finishedQuest == false)
        {
            if (_questStarted.startedQuest == true)
            {
                CheckObjectiv();
            }
            else
            {

                questUI.SetActive(true);
                _objective[0].UpdateActualValueUI();
                _questStarted.startedQuest = true;

            }
        }                
    }

    public void CheckObjectiv()
    {
        if (i < _objective.Length)
        {
            if (_objective[i].IsFinished == true)
            {
                i++;
                CheckObjectiv();
            }
            else
            {
                return;
            }
        }
        else
        {
            QuestFinish();
        }
    }

    private void QuestFinish()
    {
        _questStarted.finishedQuest = true;
        _questStarted.startedQuest = false;
        questUI.SetActive(false);
        print("Vous avez réussi la quête");
    }

}
