using System.Collections;
using System.Collections.Generic;
using Udemy2.Controllers;
using UnityEngine;

namespace Udemy2.Movemets{
    
public class HorizontalMover 
{
   PlayerController _playerController;
 
   public HorizontalMover (PlayerController playerController)
   {
    _playerController = playerController;
   }
   
   public void TickFixed(float horizontal,float moveSpeed){
    
    if(horizontal == 0f) return;

    _playerController.transform.Translate(Vector3.right * horizontal * Time.deltaTime * moveSpeed); 

   }
}
}

