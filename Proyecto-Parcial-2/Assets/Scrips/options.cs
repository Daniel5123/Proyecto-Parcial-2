using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class options : MonoBehaviour
{
    public int OptionID;
    public string OptionName;
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).GetComponent<TMP_Text>().text = OptionName;
        
    }

    // Update is called once per frame
    public void UpdateText()
    {
        transform.GetChild(0).GetComponent<TMP_Text>().text = OptionName;
    }

    public void SelectOption()
    {
        LevelManager.Instance.SetPlayerAnswer(OptionID);
    }
}
