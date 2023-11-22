using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "QuestStarted")]
public class QuestStarted : ScriptableObject
{
    public bool startedQuest = false;
    public bool finishedQuest = false;

    public void InitQuestStarted()
    {
        startedQuest = false;
        finishedQuest = false;
    }

}
