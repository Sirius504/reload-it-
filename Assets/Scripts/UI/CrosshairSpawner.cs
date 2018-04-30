using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ReloadIt.UI
{
    public class CrosshairSpawner : MonoBehaviour
    {
        public Image crosshair;

        public void Init()
        {
            // do nothing, lol
        }

        public void EnableCrosshair(Vector2 position)
        {
            crosshair.rectTransform.position = position;
            if (!crosshair.enabled)
                crosshair.gameObject.SetActive(true);
        }

        public void DisableCrosshair()
        {
            crosshair.gameObject.SetActive(false);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            //throw new NotImplementedException();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            //throw new NotImplementedException();
        }
    }
}