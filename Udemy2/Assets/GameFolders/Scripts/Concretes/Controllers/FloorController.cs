using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Udemy2.Controllers
{
    public class FloorController : MonoBehaviour
{   
    [Range(0.5f,2f)]
    [SerializeField] float _moveSpeed =1.2f;
    Material _material;

    void Awake(){

        _material = GetComponentInChildren<MeshRenderer>().material;
    }

    void Update ()
    {
        _material.mainTextureOffset += Vector2.down * Time.deltaTime * _moveSpeed;

    }
}

}
