using System.Collections;
using System.Collections.Generic;
using Udemy2.Abstracts.Movements;
using Udemy2.Controllers;
using UnityEngine;

namespace Udemy2.Movemets
{
    
    public class JumpWithRigidbody : IJump
{
    Rigidbody _rigidbody;
    public bool CanJump =>_rigidbody.velocity.y != 0f;

    public JumpWithRigidbody (PlayerController playerController)
    {
        _rigidbody =playerController.GetComponent<Rigidbody>();
    }

    public void FixedTick (float jumpForce) 
    {
        if(CanJump) return;
        
          _rigidbody.velocity = Vector3.zero;
          _rigidbody.AddForce(Vector3.up * Time.deltaTime * jumpForce);
    }
}

}
