using ItemPlanner.ConstructorModule.ObjectModule;
using ItemPlanner.ConstructorModule.WallModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemPlanner.ConstructorModule.CreatorModule
{
    public interface ICreatorController 
    {
        void Init();
        void Create(IWallController wall, IObjectController someObject);
        void Delete(IObjectController someObject);
    }
}

