using System;
using System.Collections;
using System.Collections.Generic;
using Udemy2.Abstracts.Inputs;
using Udemy2.Inputs;
using Udemy2.Managers;
using Udemy2.Movemets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

namespace Udemy2.Controllers
{
public class PlayerController : MonoBehaviour

  {
    [SerializeField] float _moverBoundary = 4.5f;
     [SerializeField] float _moveSpeed = 10f;
    [SerializeField] float _jumpForce =1500f;
    

    HorizontalMover _horizontalMover;
    JumpWithRigidbody _jump;
    IInputReader _input;
    float _horizontal;
    bool _isJump;
    bool _isDead = false;
    
    public float MoveSpeed => _moveSpeed;
    public float MoverBoundary => _moverBoundary; 


    private void Awake()
{
    _horizontalMover = new HorizontalMover(this);
    _jump = new JumpWithRigidbody(this);
    _input = new InputReader(GetComponent<PlayerInput>());
    
}

      void Update()
      {
        if(_isDead) return;

       _horizontal= _input.Horizontal;

       if (_input.isJump)
       {
        _isJump = true;
       }
      }
  
 private void FixedUpdate()
   {
       _horizontalMover.TickFixed(_horizontal);

      if(_isJump)
      {
           _jump.TickFixed(_jumpForce);
      }
       _isJump =false;
   }
  
  void OnTriggerEnter (Collider other)
  {
    EnemyController enemyController = other.GetComponent<EnemyController>();

    if (enemyController != null)

    {
      _isDead = true;
    
      GameManager.Instance.StopGame();
    }
  }

 }
 
}
