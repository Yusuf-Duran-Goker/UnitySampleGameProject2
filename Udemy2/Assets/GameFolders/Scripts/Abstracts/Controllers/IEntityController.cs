
using UnityEngine;

namespace Udemy2.Abstracts.Controllers
{
    public interface IEntityController

    {
        public Transform transform { get;  }
         float MoveSpeed { get; }
        float MoverBoundary {  get; }
    }
}
