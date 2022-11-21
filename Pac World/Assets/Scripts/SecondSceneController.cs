using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SecondSceneController : MonoBehaviour
{
    public Text bigText;
    // Start is called before the first frame update
    void Start()
    {
        int selected = PlayerPrefs.GetInt("selected_option");
        if (selected == 2)
        {
            bigText.text = "Selected Option A";
        }
        else if (selected == 3)
        {
            bigText.text = "Selected Option B";
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}