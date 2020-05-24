using ItemPlanner.ConstructorModule.ObjectModule;
using ItemPlanner.ConstructorModule.WallModule;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
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
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (!IsPointerOverUIObject() && hit.collider.gameObject.GetComponent<WallController>())
                    {
                        Debug.Log("hit");
                        OnWallSelected?.Invoke(hit.collider.gameObject.GetComponent<WallController>());
                    }
                }
            }
        }

        private bool IsPointerOverUIObject()
        {
            PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
            eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
            return results.Count > 0;
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
                newButton.GetComponentInChildren<Text>().text = item.Name;
            }
        }

    }
}

