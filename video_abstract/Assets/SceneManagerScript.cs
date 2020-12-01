using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public void GoToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GoToApproachScene()
    {
        SceneManager.LoadScene("ApproachScene");
    }

    public void GoToResultsScene()
    {
        SceneManager.LoadScene("ResultsScene");
    }

    public void GoToIntroScene()
    {
        SceneManager.LoadScene("IntroScene");
    }

    public void GoToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void GoToWorldScene()
    {
        SceneManager.LoadScene("WorldScene");
    }

    public void GoToFiguresScene()
    {
        SceneManager.LoadScene("FiguresScene");
    }

    public void GoToFigures2Scene()
    {
        SceneManager.LoadScene("Figures2Scene");
    }

}
