using ItemPlanner.ConstructorModule.ObjectModule;
using ItemPlanner.ConstructorModule.WallModule;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemPlanner.ConstructorModule.ConstructorUIModule
{
    public interface IConstructorUIController
    {
        event Action<IWallController> OnWallSelected;
        event Action<IObjectController> OnObjectChosen;
        event Action OnClickCreateButton;
        void Init();
        void ShowConfirmPanel();
        void HideConfirmButton();
    }
}

