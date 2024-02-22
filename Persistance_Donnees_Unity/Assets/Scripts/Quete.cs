using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quete : MonoBehaviour, ITalk
{
    private DialogueSystem _dialogueSystem;
    [SerializeField] private int _startSentece;
    [SerializeField] private int _intermediateSentence;
    [SerializeField] private int _endSentece;
    [SerializeField] private QuestStarted _questStarted;

    [SerializeField] private int i = 0;
    [SerializeField] Objective[] _objective;
    public GameObject questUI;

    private void Start()
    {
        _dialogueSystem = GetComponent<DialogueSystem>();
    }

    public void Talk()
    {
        if (_questStarted.startedQuest)
        {
            if (_questStarted.finishedQuest)
            {
                _dialogueSystem.StartTalking(_endSentece);
                print("end");
            }
            else
            {
                _dialogueSystem.StartTalking(_intermediateSentence);
                print("mid");
            }
        }
        else
        {
            _dialogueSystem.StartTalking(_startSentece);
            print("start");
        }
    }

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
                Talk();
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
                Talk();
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
        Talk();
        _questStarted.startedQuest = false;        
        questUI.SetActive(false);
        print("Vous avez réussi la quête");
    }

}
