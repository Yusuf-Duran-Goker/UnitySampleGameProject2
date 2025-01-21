using System.Collections;
using System.Collections.Generic;
using Udemy2.Controllers;
using UnityEngine;

namespace Udemy2.ScriptableObjects
{
    [CreateAssetMenu(fileName = "Level Difficulty", menuName = "Create Difficulty/Create New", order = 1)]
    public class LevelDifficultyData : ScriptableObject
    {
        [SerializeField] FloorController _floorPrefab;
        [SerializeField] GameObject _spawnersPrefab; // Yazým hatasý düzeltildi (_spaenersPrefab -> _spawnersPrefab)
        [SerializeField] Material _skyboxMaterial;
        [SerializeField] float _moveSpeed = 10f;
        [SerializeField] float _addDelayTime = 50f;

        public FloorController FloorPrefab => _floorPrefab;
        public GameObject SpawnerPrefab => _spawnersPrefab;
        public Material SkybocMaterial => _skyboxMaterial;
        public float MoveSpeed => _moveSpeed;
        public float AddDelayTime => _addDelayTime;
    }

    
}
