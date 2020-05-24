using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemPlanner.ConstructorModule.WallModule
{
    public class WallController : MonoBehaviour, IWallController
    {

        private Collider mainCollider;
        private MeshRenderer mainMeshRenderer;


        public Vector3 GetCentre()
        {
            return mainCollider.bounds.center;
        }

        public void Select()
        {
            mainMeshRenderer.materials[0] = Resources.Load<Material>(WallData.WALL_SELECTED_MATERIAL_PATH);
        }

        public void Deselect()
        {
            mainMeshRenderer.materials[0] = Resources.Load<Material>(WallData.WALL_MATERIAL_PATH);
        }


        private void Start()
        {
            mainCollider = GetComponent<Collider>();
            mainMeshRenderer = GetComponent<MeshRenderer>();
        }
    }
}

