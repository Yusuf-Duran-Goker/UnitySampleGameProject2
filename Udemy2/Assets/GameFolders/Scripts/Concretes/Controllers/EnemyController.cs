using System;
using System.Collections;
using System.Collections.Generic;
using Udemy2.Movemets;
using UnityEngine;

namespace Udemy2.Controllers
{
    public class EnemyController : MonoBehaviour
 {
    [SerializeField] float _moveSpeed = 50f;
    [SerializeField] float _maxLife = 10f;
   VerticalMover _mover;
   float _currentLifeTime = 0f;

   public float MoveSpeed => _moveSpeed;      

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
   _mover.FixTick();
  }


 private void KillYourself()
  {
           Destroy(this.gameObject);
  }

    
 }
}

