using Udemy2.Managers;
using Udemy2.ScriptableObjects;
using UnityEngine;

namespace Udemy2.Controllers
{
    public class LevelInitializerController : MonoBehaviour
    {
        private LevelDifficultyData _levelDifficultyData;

        private void Awake()
        {
            _levelDifficultyData = GameManager.Instance.LevelDifficultyData;
        }

        private void Start()
        {
            RenderSettings.skybox = _levelDifficultyData.SkybocMaterial;
            Instantiate(_levelDifficultyData.FloorPrefab);
            Instantiate(_levelDifficultyData.SpawnerPrefab);
            EnemyManager.Instance.SetMoveSpeed(_levelDifficultyData.MoveSpeed);
            EnemyManager.Instance.SetAddDelayTime(_levelDifficultyData.AddDelayTime);
        }
    }
}
