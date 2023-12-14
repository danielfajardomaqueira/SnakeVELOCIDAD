using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneDifficult()
    {
        SceneManager.LoadScene(2);
    }


    public void ChangeSceneHowToPlay()
    {
        SceneManager.LoadScene(4);
    }

    public void ChangeSceneMainMenu()
    {
        SceneManager.LoadScene(3);
    }
}
