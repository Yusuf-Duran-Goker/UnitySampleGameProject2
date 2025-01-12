using System;
using System.Collections;
using System.Collections.Generic;
using Udemy2.Abstracts.Controllers;
using Udemy2.Enums;
using Udemy2.Managers;
using Udemy2.Movemets;
using UnityEngine;

namespace Udemy2.Controllers
{
    public class EnemyController : MyCharacterController, IEntityController
    {
        
        [SerializeField] float _maxLife = 10f;
        [SerializeField] EnemyEnum _enemyEnum;

      VerticalMover _mover;
        float _currentLifeTime = 0f;   
        public EnemyEnum  EnemyType => _enemyEnum;   

        void Awake () 
   {
    _mover = new VerticalMover (this);
   }
 
   void Update() 
   {
       _currentLifeTime += Time.deltaTime;

       if (_currentLifeTime > _maxLife)
       {
        _currentLifeTime = 0f;
        KillYourself();
       }
   }
        void FixedUpdate()
  {
   _mover.FixedTick();
  }


 private void KillYourself()
  {
           EnemyManager.Instance.SetPool(this);
  }

    
 }
}

