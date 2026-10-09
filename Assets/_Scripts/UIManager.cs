using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    #region Variables

    [SerializeField] private TMP_Text questionTxt;
    [SerializeField] private Button btn1;
    [SerializeField] private Button btn2;
    [SerializeField] private Button btn3;
    [SerializeField] private Button btn4;

    private static UIManager _instance;

    #endregion

    #region Properties

    public static UIManager Instance => _instance;

    #endregion

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
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddUi(string question)
    {
        questionTxt.text = question;
    }

    public void AddBtn1Logic(int answerNb, int goodAnswerNb, string question)
    {
        btn1.onClick.RemoveAllListeners();
        btn1.onClick.AddListener(() => GoodOrBadAnswer(answerNb, goodAnswerNb));
        btn1.GetComponentInChildren<TMP_Text>().text = question;
    }

    public void AddBtn2Logic(int answerNb, int goodAnswerNb, string question)
    {
        btn2.onClick.RemoveAllListeners();
        btn2.onClick.AddListener(() => GoodOrBadAnswer(answerNb, goodAnswerNb));
        btn2.GetComponentInChildren<TMP_Text>().text = question;
    }

    public void AddBtn3Logic(int answerNb, int goodAnswerNb, string question)
    {
        btn3.onClick.RemoveAllListeners();
        btn3.onClick.AddListener(() => GoodOrBadAnswer(answerNb, goodAnswerNb));
        btn3.GetComponentInChildren<TMP_Text>().text = question;
    }

    public void AddBtn4Logic(int answerNb, int goodAnswerNb, string question)
    {
        btn4.onClick.RemoveAllListeners();
        btn4.onClick.AddListener(() => GoodOrBadAnswer(answerNb, goodAnswerNb));
        btn4.GetComponentInChildren<TMP_Text>().text = question;
    }

    private void GoodOrBadAnswer(int answerNb, int goodAnswerNb)
    {
        if (answerNb == goodAnswerNb)
        {
            Debug.Log("Bonne réponse !");
        }
        else
        {
            Debug.Log("Mauvaise réponse...");
        }

        GameManager.Instance.isReplied = true;
    }
}