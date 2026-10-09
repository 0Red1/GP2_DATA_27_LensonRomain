using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Variables

    [SerializeField] private List<QuestionData> questionDatas = new List<QuestionData>();

    [SerializeField] private int _currentQuestion = 0;
    public bool isReplied = false;

    private static GameManager _instance;

    #endregion

    public static GameManager Instance => _instance;


    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameLoop();
    }

    // Update is called once per frame
    void Update()
    {
        if (isReplied)
        {
            _currentQuestion++;
            
            if (_currentQuestion > questionDatas.Count)
            {
                Debug.Log("Partie terminé !");
                return;
            }
            
            GameLoop();
            isReplied = false;
        }
    }

    void GameLoop()
    {
        UIManager.Instance.AddUi(questionDatas[0].Question);
        UIManager.Instance.AddBtn1Logic(0, questionDatas[_currentQuestion].GoodAnswer,
            questionDatas[_currentQuestion].Answer1);
        UIManager.Instance.AddBtn2Logic(1, questionDatas[_currentQuestion].GoodAnswer,
            questionDatas[_currentQuestion].Answer2);
        UIManager.Instance.AddBtn3Logic(2, questionDatas[_currentQuestion].GoodAnswer,
            questionDatas[_currentQuestion].Answer3);
        UIManager.Instance.AddBtn4Logic(3, questionDatas[_currentQuestion].GoodAnswer,
            questionDatas[_currentQuestion].Answer4);
    }
}