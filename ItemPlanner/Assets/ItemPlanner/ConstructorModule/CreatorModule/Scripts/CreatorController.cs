using ItemPlanner.ConstructorModule.ObjectModule;
using ItemPlanner.ConstructorModule.WallModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemPlanner.ConstructorModule.CreatorModule
{
    public class CreatorController : ICreatorController
    {
        public void Init()
        {
            
        }

        public void Create(IWallController wall, IObjectController someObject)
        {
            someObject.Init(wall.GetCentre());
        }

        public void Delete(IObjectController someObject)
        {
            
        }

    }
}

