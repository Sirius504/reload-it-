using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IngameGui : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    CrosshairSpawner crosshairSpawner;

    // Use this for initialization
    public void Init()
    {
        crosshairSpawner = GetComponentInChildren<CrosshairSpawner>();
        crosshairSpawner.Init();
    }

    Ray ray;

    public void OnPointerClick(PointerEventData eventData)
    {
        Vector3 target;
        RaycastHit hit;
        ray = Camera.main.ScreenPointToRay(eventData.position);
        int layerMask = 1 << 8;
        if (Physics.Raycast(ray, out hit, layerMask) && hit.transform != App.Game.player.transform)            
            target = hit.point;
        else
            return;
        crosshairSpawner.EnableCrosshair(eventData.position);
        target.y = 1.5f;
        Debug.Log(target);
        App.Game.player.Shoot(target);
    }

    private void Update()
    {
        Debug.DrawRay(ray.origin, ray.direction, Color.red, 1000);
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }
}
