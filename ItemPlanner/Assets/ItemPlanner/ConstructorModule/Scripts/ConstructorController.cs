using ItemPlanner.ConstructorModule.ConstructorUIModule;
using ItemPlanner.ConstructorModule.CreatorModule;
using ItemPlanner.ConstructorModule.ObjectModule;
using ItemPlanner.ConstructorModule.WallModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemPlanner.ConstructorModule
{
    public class ConstructorController : IConstructorController
    {
        private IConstructorUIController constructorUIcontroller;
        private ICreatorController creatorController;

        private bool isChosenObject;
        private bool isChosenWall;
        private IObjectController lastChosenObject;
        private IWallController lastChosenWall;

        public void Init()
        {
            creatorController = new CreatorController();
        }

        public void StartBuilding()
        {
            constructorUIcontroller = GameObject.Instantiate(Resources.Load<ConstructorUIController>(ConstructorUIData.CONSTRUCTOR_UI_PREFAB_PATH));
            constructorUIcontroller.Init();
            constructorUIcontroller.OnObjectChosen += ObjectChosen;
            constructorUIcontroller.OnWallSelected += WallSelected;
            constructorUIcontroller.OnClickCreateButton += CreateObject;

            creatorController.Init();
        }

        private void ObjectChosen(IObjectController chosenObject)
        {
            Debug.Log("CC ObjectChosen");
            isChosenObject = true;
            lastChosenObject = chosenObject;
            ShowCreateButton();
        }

        private void WallSelected(IWallController wall)
        {
            Debug.Log("CC WallChosen");
            isChosenWall = true;
            lastChosenWall?.Deselect();
            lastChosenWall = wall;
            lastChosenWall.Select();
            ShowCreateButton();
        }

        private void ShowCreateButton()
        {
            if (isChosenObject && isChosenWall)
            {
                constructorUIcontroller.ShowConfirmPanel();
            }
            else
            {
                constructorUIcontroller.HideConfirmButton();
            }
        }

        private void CreateObject()
        {
            creatorController.Create(lastChosenWall, lastChosenObject);
        }


        
    }
}

