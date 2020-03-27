using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrans : MonoBehaviour
{
    public void SceneTrans1_1()
    {
        SceneManager.LoadScene("Scene 1_1");
    }
    public void SceneTrans1_2()
    {
        SceneManager.LoadScene("Scene 1_2");
    }

    public void AddScene()
    {
        SceneManager.LoadScene("Scene 2_2", LoadSceneMode.Additive);
    }

    public void RemoveScene()
    {
        SceneManager.UnloadSceneAsync("Scene 2_2");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
