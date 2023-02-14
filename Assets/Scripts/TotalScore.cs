using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TotalScore : MonoBehaviour
{
    [SerializeField] TMP_Text _ScoreText;
    public void SetUp(string score)
    {
        _ScoreText.text = score;
    }
}
