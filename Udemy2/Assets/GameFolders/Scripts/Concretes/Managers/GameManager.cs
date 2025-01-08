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
        public event System.Action OnGameStop;
    void Awake()
    {
           SingletonThisObject(this);
    }

    public void StopGame()
    {
       Time.timeScale = 0f;

            //if (OnGameStoped != null)
            //{
            //    OnGameStoped();
            //}
            //alttaki kisa hali

            OnGameStop?.Invoke();
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
