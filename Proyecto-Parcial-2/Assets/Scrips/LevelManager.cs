using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    [Header("Level Data")]
    public Subject Lesson;
    [Header("Game Configuration")]
    public TMP_Text QuestionTxt;
   
    public int questionAmount = 0;
    public int currentQuestion = 0;
    public string question;
    public string correctAnswer;
    public int answerFromPlayer;
    [Header("Current Lesson")]
    public Leccion currentLesson;

    private void Awake()
    {
        if(Instance != null)
        {
            return;
        }
        else
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        questionAmount = Lesson.leccionList.Count;
        LoadQuestion();
    }

    // Update is called once per frame
    void LoadQuestion()
    {
        if (currentQuestion < questionAmount)
        {
            //Establecemos la leccion actual
            currentLesson = Lesson.leccionList[currentQuestion];
            //Establecemos la pregunta
            question = currentLesson.lessons;
            //Establecemos la respuesta correcta
            correctAnswer = currentLesson.Opciones[currentLesson.correctAnswer];
            //Establecer la pregunta en UI
            QuestionTxT.text = question;
            //Establecer las opciones
            for(int i = 0; i < currentLesson.Opciones.Count; i++)
            {
                Options[i].GetComponent<options>().OptionName = currentLesson.Opciones[i];
                Options[i].GetComponent<options>().OptionID = i;
                Options[i].GetComponent<options>().UpdateText();

            }
        }
        else
        {
            //si llegamos al final de las preguntas
            Debug.Log("Fin de las preguntas");
        }
    }

    public void NextQuestion()
    {
        if (currentQuestion < questionAmount)
        {
            //Incrementamos el indice de la pregunta actual
            currentQuestion++;
            //Cargar la nueva pregunta
            LoadQuestion();
        }
        else
        {
            //cambio de escena
        }
    }

    public void SetPlayerAnswer(int _answer)
    {
        answerFromPlayer = _answer;
    }
}
