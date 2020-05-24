using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemPlanner.ConstructorModule.WallModule
{
    public interface IWallController
    {
        Vector3 GetCentre();
        void Select();
        void Deselect();
    }
}


