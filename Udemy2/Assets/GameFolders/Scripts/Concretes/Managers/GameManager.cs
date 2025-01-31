using System.Collections;
using Udemy2.Abstracts.Utilities;
using Udemy2.ScriptableObjects;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Udemy2.Managers
{
    public class GameManager : SingletonMonoBehaviorObject<GameManager>


    {
        [SerializeField] LevelDifficultyData[] _levelDifficultyDatas;

        public LevelDifficultyData LevelDifficultyData => _levelDifficultyDatas[DifficultyIndex];

        int _difficultyIndex;

        public int DifficultyIndex
        {
            get => _difficultyIndex;
            set
            {
              if (_difficultyIndex < 0 || _difficultyIndex > _levelDifficultyDatas.Length)
            
              {
                LoadSceneAsync("Menu");
              }
              else
              {
                _difficultyIndex = value;
              }
            }
        }



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
            Time.timeScale = 1f;
            yield return SceneManager.LoadSceneAsync(sceneName);
        }


        public void ExitGame()
        {
            Debug.Log("Exit on Cliced");
            Application.Quit();
        }


    }

}
