using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Udemy2.Uis
{
    public class TimeCounter : MonoBehaviour
{
    TMP_Text _text;
    float _currentTime;

    public void Awake()
    {
       _text = GetComponent< TMP_Text>();
    }

    public void Update ()
    {
        _currentTime += Time.deltaTime;
        _text.text = _currentTime.ToString("0");
    }
}

}
