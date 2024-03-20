using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public static SaveSystem Instance;


    public void Start()
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
}
