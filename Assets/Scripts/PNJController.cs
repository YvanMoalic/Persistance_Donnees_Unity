using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJController : MonoBehaviour, ITalk
{
    private DialogueSystem _dialogueSystem;
    [SerializeField] private int _startSentece;
    [SerializeField] private int _intermediateSentence;
    [SerializeField] private int _endSentece;
    [SerializeField] private QuestStarted _questStarted;

    private void Start()
    {
        _dialogueSystem = GetComponent<DialogueSystem>();
    }

    public void Talk()
    {
        if(_questStarted.startedQuest)
        {
            if(_questStarted.finishedQuest)
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
}
