using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemPlanner.ConstructorModule.ObjectModule
{
    [Serializable]
    public struct ObjectItem
    {
        public string Name;
        public Sprite Image;
        public ObjectController ObjectPrefab;
    }
}

