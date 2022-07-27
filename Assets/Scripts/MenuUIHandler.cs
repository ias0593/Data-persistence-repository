using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;



public class MenuUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void StartHighScores()
    {
        SceneManager.LoadScene(2);
    }

    public void StartSettings()
    {
        SceneManager.LoadScene(3);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()

    {
#if UNITY_EDITOR

        EditorApplication.ExitPlaymode();
#else
            Application.Quit(); // original code to quit Unity player
#endif
    }






}

