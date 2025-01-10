using System.Collections;
using System.Collections.Generic;
using Udemy2.Abstracts.Controllers;
using Udemy2.Abstracts.Movements;
using Udemy2.Controllers;
using UnityEngine;

namespace Udemy2.Movemets{
    
public class HorizontalMover : IMover
{
   IEntityController _playerController;
   float _moveSpeed;
   float _moverBoundary;
 
   public HorizontalMover (IEntityController entityController)
   {
    _playerController = entityController;
            //_moveSpeed =entityController.MoveSpeed;
            //_moverBoundary = entityController.MoverBoundary;
        }

        public void FixedTick(float horizontal){
    
    if(horizontal == 0f) return;

    _playerController.transform.Translate(Vector3.right * horizontal * Time.deltaTime * _moveSpeed); 


    float xBoundary = Mathf.Clamp(_playerController.transform.position.x,-_moverBoundary,_moverBoundary);
    _playerController.transform.position = new Vector3(xBoundary,_playerController.transform.position.y,0f);
   }
}
}

