using System.Collections;
using System.Collections.Generic;
using Udemy2.Managers;
using UnityEngine;

namespace Udemy2.Uis
{
    public class MenuPanel : MonoBehaviour
    {
        public void SelectAndStartButton(int index)
        {
            
            GameManager.Instance.DifficultyIndex = index; // Zorluk seviyesini ayarla
            GameManager.Instance.LoadScene("Game"); // Oyunu başlat

        }

        public void ExitButton()
        {
            GameManager.Instance.ExitGame();
        }
    }

}
