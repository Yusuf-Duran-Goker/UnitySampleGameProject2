using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    PlayerMoverController player;
    [SerializeField]
    Collider2D boundsBox; 

    float halfYukseklik,halfGenislik;


    Vector2 sonPos;
    [SerializeField]
    Transform backgrounds;

    private void Awake()
    {
        player = Object.FindAnyObjectByType<PlayerMoverController>();
    }

    private void Start()
    {
        halfYukseklik = Camera.main.orthographicSize;
        

        halfGenislik = halfYukseklik * Camera.main.aspect;
       
    }

    private void Update ()
    {
        if (player != null)
        {
            transform.position =new Vector3(

            Mathf.Clamp(player.transform.position.x,boundsBox.bounds.min.x+halfGenislik,boundsBox.bounds.max.x-halfGenislik),

            Mathf.Clamp(player.transform.position.y,boundsBox.bounds.min.y +halfYukseklik,boundsBox.bounds.max.y-halfYukseklik),

            transform.position.z);
        }

        BackgroundsHaraketFNC();
    }
    
    void BackgroundsHaraketFNC()
    {
       Vector2 aradakiFark= new Vector2(transform.position.x -sonPos.x,transform.position.y -sonPos.y);

       backgrounds.position += new Vector3 (aradakiFark.x,aradakiFark.y,0f);

       sonPos = transform.position;
    }

}
