using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using Unity.Collections;
public class AnswerChecker : MonoBehaviour
{
  
    [SerializeField]
    public string[] correctAnswers;

    [SerializeField]
    public TMP_InputField[] answers;

    [SerializeField]
    public TMP_InputValidator[] validAnswers;

    public Text validationMessageText;
    public bool correctAnswer;
    public bool cleared;
    public QuizManager quizManager;


    public void AnswerCheck()
    {
        if (AllMatch())
        {
            Debug.Log("All input are correct");
            quizManager.NextUpdate();
            AudioManager.Instance.PlaySFX("Right Answer");
        }
        else
        {
            AudioManager.Instance.PlaySFX("Wrong Answer");
            ClearAll();
            
        }

    }
    public bool AllMatch()
    {
        if (answers.Length != correctAnswers.Length)
            return false;

        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i].text != correctAnswers[i])
                return false;
        }

        return true;
    }
    public void ClearAll()
    {
        cleared = true;
       for(int i = 0; i < answers.Length;i++)
        {
            answers[i].text = "";
        }
    }
    public void ButtonValidate()
    {
        
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
