using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject _scoreObj;
    static public int _score = 0;
    void Start()
    {
        
    }

    void Update()
    {
        Text _scoreText = _scoreObj.GetComponent<Text>();
        _scoreText.text = "Score : " + _score.ToString();
    }
}
