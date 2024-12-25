using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Udemy2.Abstracts.Inputs
{
    public interface IInputReader 
 {
     float Horizontal { get;  }
     bool isJump { get;  }
 }

}
