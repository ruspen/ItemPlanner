using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemPlanner.ConstructorModule.ObjectModule
{
    public class ObjectController : MonoBehaviour, IObjectController
    {
        public event Action OnColliderEnter;
        public event Action OnColliderExit;

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }

        public void InstantObject(Vector3 instantPosition)
        {
            GameObject.Instantiate(this, instantPosition, Quaternion.identity);
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        
    }
}

