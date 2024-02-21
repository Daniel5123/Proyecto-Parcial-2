using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Leccion 
{
    public int ID;
    public List<string> lessons;
    public List<string> opciones;
    public int correctAnswer;

}

[CreateAssetMenu(fileName = "New Subject", menuName = "ScriptableObjects/NewLesson", order = 1)]
public class Subject : ScriptableObject
{
    public List<Leccion> leccionList;
}