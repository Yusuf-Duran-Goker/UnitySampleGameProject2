using System.Collections;
using System.Collections.Generic;
using Udemy2.Abstracts.Utilities;
using UnityEngine;
namespace Udemy2.Managers
{
    public class GameManager : SingletonMonoBehaviorObject<GameManager>
{
    void Awake()
    {
           SingletonThisObject(this);
    }

    public void StopGame()
    {
       Time.timeScale = 0f;
    }
}

}
