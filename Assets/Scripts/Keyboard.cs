using NUnit.Framework.Interfaces;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
public class Keyboard : MonoBehaviour
{
    public AnswerChecker checker;
    public int i;
    private void Start()
    {
        i = 0;
    }

    public void Update()
    {
        if(checker.cleared)
        {
            i = 0;
            checker.cleared = false;
        }
    }
    public void ClickButton(string letter)
    {
            if (checker.answers[i].text.Length != checker.answers[i].characterLimit)
            {
                checker.answers[i].text = letter.ToUpper();
                i++;
            }
    }

    public void DeleteLine()
    {
        int indexToDelete = i - 1;
        checker.answers[indexToDelete].text = "";
        i--;

    }


}
