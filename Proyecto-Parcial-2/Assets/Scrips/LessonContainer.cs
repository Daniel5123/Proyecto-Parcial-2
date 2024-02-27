using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LessonContainer : MonoBehaviour
{
    [Header("GameObject Configuration")]
    public int Lection = 0;
    public int CurrentLession = 0;
    public int TotalLessions = 0;
    public bool AreAllLessonsComplete = false;

    [Header("UI Configuration")]
    public TMP_Text StageTitle;
    public TMP_Text LessonsStage;

    [Header("External GameObject Configuration")]
    public GameObject lessonContainer;

    [Header("Lesson Data")]
    public ScriptableObject LessonData;

    void Start()
    {
      if (lessonContainer != null)
      {
        OnUpdateUI();
      }
      else
      {
        Debug.LogWarning("GameObject Nulo, revida las variables de tipo GameObject lessonContainer");
      }
    }

    public void OnUpdateUI()
    {
        if (StageTitle != null || LessonsStage != null)
        {
            StageTitle.text = "Leccion " + Lection;
            LessonsStage.text = "Leccion " + CurrentLession + "de " + TotalLessions; 
        }
        else
        {
            Debug.LogWarning("GameObject nulo, revisa las variables de tipo TMP_Text");
        }
    }

    //Este metodo activa/desactiva la venta de lessonContainer 

    public void EnableWindow()
    {
        OnUpdateUI();

        if (lessonContainer.activeSelf)
        {
            // Desactiva el objeto si esta activo
            lessonContainer.SetActive(false);
        }
        else
        {
            // Activa el objeto si esta desactivado
            lessonContainer.SetActive(true);
        }
    }
}