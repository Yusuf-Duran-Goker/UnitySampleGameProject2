using System.Collections;
using System.Collections.Generic;
using Udemy2.Controllers;
using UnityEngine;

namespace Udemy2.Movemets{
    
public class HorizontalMover 
{
   PlayerController _playerController;
   float _moveSpeed;
   float _moverBoundary;
 
   public HorizontalMover (PlayerController playerController)
   {
    _playerController = playerController;
    _moveSpeed =_playerController.MoveSpeed;
    _moverBoundary = playerController.MoverBoundary;
   }
   
   public void TickFixed(float horizontal){
    
    if(horizontal == 0f) return;

    _playerController.transform.Translate(Vector3.right * horizontal * Time.deltaTime * _moveSpeed); 


    float xBoundary = Mathf.Clamp(_playerController.transform.position.x,-_moverBoundary,_moverBoundary);
    _playerController.transform.position = new Vector3(xBoundary,_playerController.transform.position.y,0f);
   }
}
}

