using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    public List<GameObject> Questions = new List<GameObject>();
    public int questionIndex;
    public GameObject gameWin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        questionIndex = 0;
        Questions[questionIndex].SetActive(true);
    }

    // Update is called once per frame
    public void NextUpdate()
    {
        Questions[questionIndex].SetActive(false);
        questionIndex++;
        if(questionIndex > Questions.Count-1)
        {
            gameWin.SetActive(true);
            AudioManager.Instance.PlaySFX("Level Complete");
        }
        Questions[questionIndex].SetActive(true);

    }
    
}
