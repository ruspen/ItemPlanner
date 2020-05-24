using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemPlanner.ConstructorModule.ObjectModule
{
    public interface IObjectController
    {
        event Action OnColliderEnter;
        event Action OnColliderExit;
        void Init(Vector3 instantPosition);
        void Delete();
    }
}

