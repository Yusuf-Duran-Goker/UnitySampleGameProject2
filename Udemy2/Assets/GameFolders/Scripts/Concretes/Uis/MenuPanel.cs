using System.Collections;
using System.Collections.Generic;
using Udemy2.Managers;
using UnityEngine;

namespace Udemy2.Uis
{
    public class MenuPanel : MonoBehaviour
{
    public void StartButton()
    {
      GameManager.Instance.LoadScene("Game");
    }

    public void ExitButton()
    {
       GameManager.Instance.ExitGame();
    }
}

}
