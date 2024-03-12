using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Subject", menuName = "ScriptableObjects/NewLesson", order = 1)]
public class Subject1 : ScriptableObject
{
    [Header("GameObject Configuration")]
    public int Lesson = 0;

    [Header("GameObject Configuration")]
    public List<Lección> leccionList;
}
