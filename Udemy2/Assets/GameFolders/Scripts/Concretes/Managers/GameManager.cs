using System.Collections;
using System.Collections.Generic;
using Udemy2.Abstracts.Utilities;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Udemy2.Managers
{
    public class GameManager : SingletonMonoBehaviorObject<GameManager>
{
    void Awake()
    {
           SingletonThisObject(this);
    }

    public void StopGame()
    {
       Time.timeScale = 0f;
    }

    public void LoadScene(string sceneName)
{
    StartCoroutine(LoadSceneAsync(sceneName));
}

private IEnumerator LoadSceneAsync(string sceneName)

{
    Time.timeScale =1f;
    yield return SceneManager.LoadSceneAsync(sceneName);
}


    public void ExitGame()
    {
        Debug.Log ("Exit on Cliced");
         Application.Quit();
    }


}

}
