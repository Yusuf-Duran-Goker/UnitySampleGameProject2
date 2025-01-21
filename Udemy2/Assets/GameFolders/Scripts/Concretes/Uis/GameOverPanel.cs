using System;
using System.Collections;
using System.Collections.Generic;
using Udemy2.Managers;
using UnityEngine;

namespace Udemy2.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButton()
        {
            
            GameManager.Instance.LoadScene("Game");
        }

        public void NoButton()
        {
            GameManager.Instance.LoadScene("Menu");
        }
    }

}
