using ItemPlanner.ConstructorModule.ObjectModule;
using ItemPlanner.ConstructorModule.WallModule;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ItemPlanner.ConstructorModule.ConstructorUIModule
{
    public class ConstructorUIController : MonoBehaviour, IConstructorUIController
    {
        public event Action<IWallController> OnWallSelected;
        public event Action<IObjectController> OnObjectChosen;
        public event Action OnClickCreateButton;

        [SerializeField]
        private Button buttonItem;
        [SerializeField]
        private List<ObjectItem> objectItems;
        [SerializeField]
        private Transform buttonsPanel;
        [SerializeField]
        private Button createButton;


        public void Init()
        {
            CreateObjectButtons();
            createButton.onClick.AddListener(() => 
            {
                OnClickCreateButton?.Invoke();
            });
        }

        public void ShowConfirmPanel()
        {
            createButton.gameObject.SetActive(true);
        }

        public void HideConfirmButton()
        {
            createButton.gameObject.SetActive(false);
        }


        void Update()
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                if (hit.collider.gameObject.GetComponent<WallController>())
                {
                    OnWallSelected?.Invoke(hit.collider.gameObject.GetComponent<WallController>());
                }
            }
        }


        private void CreateObjectButtons()
        {
            foreach (var item in objectItems)
            {
               Button newButton = Instantiate<Button>(buttonItem, buttonsPanel);
                newButton.onClick.AddListener(() =>
                {
                    OnObjectChosen?.Invoke(item.ObjectPrefab);
                });
                newButton.image.sprite = item.Image;
            }
        }

    }
}

