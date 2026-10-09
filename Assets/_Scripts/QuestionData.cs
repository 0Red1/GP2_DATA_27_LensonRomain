using UnityEngine;

[CreateAssetMenu(fileName = "newQuestionData", menuName = "ScriptableObject/QuestionData")]
public class QuestionData : ScriptableObject
{
    #region Variables
    [SerializeField] private string question;
    [SerializeField] private string answer1;
    [SerializeField] private string answer2;
    [SerializeField] private string answer3;
    [SerializeField] private string answer4;
    [SerializeField] private int goodAnswer = 0;
    #endregion
    
    #region Properties
    public string Question => question;
    public string Answer1 => answer1;
    public string Answer2 => answer2;
    public string Answer3 => answer3;
    public string Answer4 => answer4;
    public int GoodAnswer => goodAnswer;
    #endregion
}
