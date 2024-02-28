using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    [Header("Level Data")]
    public Subject Lesson;
    [Header("Game Configuration")]
    public int questionAmount = 0;
    public int currentQuestion = 0;
    public string question;
    public string correctAnswer;
    [Header("Current Lesson")]
    public Leccion currentLesson;

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
            correctAnswer = currentLesson.opciones[currentLesson.correctAnswer];
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
}
