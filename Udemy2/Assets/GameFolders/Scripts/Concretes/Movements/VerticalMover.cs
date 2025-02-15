using System.Collections;
using System.Collections.Generic;
using Udemy2.Abstracts.Controllers;
using Udemy2.Abstracts.Movements;
using Udemy2.Controllers;
using UnityEngine;

namespace Udemy2.Movemets
{
    
    public class VerticalMover : IMover
{
        IEntityController _entityController;
       

   public VerticalMover(IEntityController entityController)
   {
            _entityController = entityController;
            

        }
   
   public void FixedTick(float vertical =1)
   {
            _entityController.transform.Translate(Vector3.back * vertical * _entityController.MoveSpeed * Time.deltaTime);
   }

}

}
