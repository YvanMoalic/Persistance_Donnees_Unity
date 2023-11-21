using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIQuete : MonoBehaviour
{
    [SerializeField] private TMP_Text _cuivreActualText;
    [SerializeField] private TMP_Text _ferActualText;
    [SerializeField] private TMP_Text _orActualText;

    [SerializeField] private Objective _objectiveCuivre;
    [SerializeField] private Objective _objectiveFer;
    [SerializeField] private Objective _objectiveOr;

    [SerializeField] private int cuivrePreValue = 0;
    [SerializeField] private int ferPreValue = 0;
    [SerializeField] private int orfPreValue = 0;

    public void OnEnable()
    {
        Objective.OnValueUpdate += MiseEnFormeActualValue;
    }

    private void OnDisable()
    {
        Objective.OnValueUpdate -= MiseEnFormeActualValue;
    }

    public void MiseEnFormeActualValue(int scoreValue)
    {
        if(_objectiveCuivre.ActualValue != cuivrePreValue)
        {
            _cuivreActualText.text = _objectiveCuivre.ActualValue.ToString();
            cuivrePreValue = _objectiveCuivre.ActualValue;
        }

        if (_objectiveFer.ActualValue != ferPreValue)
        {
            _ferActualText.text = _objectiveFer.ActualValue.ToString();
            ferPreValue= _objectiveFer.ActualValue;
        }

        if (_objectiveOr.ActualValue != orfPreValue)
        {
            _orActualText.text = _objectiveOr.ActualValue.ToString();
            orfPreValue= _objectiveOr.ActualValue;
        }
    }
}
