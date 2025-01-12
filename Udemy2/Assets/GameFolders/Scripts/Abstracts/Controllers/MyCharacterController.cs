using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Udemy2.Abstracts.Controllers
{
    public abstract class MyCharacterController : MonoBehaviour
    {
        [SerializeField] float _moverBounary = 4.5f;
        [SerializeField] float _moveSpeed = 10f;

        public float MoveSpeed => _moveSpeed;
        public float MoverBoundary =>_moverBounary;
    }
}
