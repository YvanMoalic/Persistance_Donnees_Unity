using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] private DialogueDatas _DialogDatas;
    [SerializeField] private UIDialogueLong _UIDialog;
    [SerializeField] private UIDialogueAnswers _UIDialogAnswer;

    public void StartTalking(int DialogueSentenceNumber)
    {
        _UIDialog.ShowLongDialog(_DialogDatas.sentences[DialogueSentenceNumber].LongaSentence);
        string[] answers = new string[2];
        if (_DialogDatas.sentences[DialogueSentenceNumber].Answer1 != -1)
        {
            answers[0] = _DialogDatas.sentences[_DialogDatas.sentences[DialogueSentenceNumber].Answer1].ShortSentence;
        }
        else
        {
            answers[0] = "";
        }

        if (_DialogDatas.sentences[DialogueSentenceNumber].Answer2 != -1)
        {
            answers[0] = _DialogDatas.sentences[_DialogDatas.sentences[DialogueSentenceNumber].Answer2].ShortSentence;
        }
        else
        {
            answers[0] = "";
        }

        _UIDialogAnswer.ShowAnswers(answers);
    }
}
