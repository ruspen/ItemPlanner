using ItemPlanner.ConstructorModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemPlanner.SceneModels.ExampleRoom
{
    public class ExampleRoomSceneController : MonoBehaviour
    {
        private IConstructorController constructor = new ConstructorController();
        void Start()
        {
            constructor.Init();
            constructor.StartBuilding();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

