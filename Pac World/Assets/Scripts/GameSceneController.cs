using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    public void ClickOptionA()
    {
        PlayerPrefs.SetInt("selected_option", 2);
        PlayerPrefs.Save();
        SceneManager.LoadScene("SecondScene");
    }
    public void ClickOptionB()
    {
        PlayerPrefs.SetInt("selected_option", 3);
        PlayerPrefs.Save();
        SceneManager.LoadScene("SecondScene");
    }
}
