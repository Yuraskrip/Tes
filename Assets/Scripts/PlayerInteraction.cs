using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private Camera _fpcCamera;
    private Ray _ray;
    private RaycastHit _hit;
    [SerializeField] CanvasScript C = new CanvasScript();
    [SerializeField] private float _maxDistanceRay;

    private void Update()
    {
        Ray();
        Open();
    }
    private void Ray()
    {
        _ray = _fpcCamera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
    }


    private void Open()
    {
        if (Physics.Raycast(_ray, out _hit, _maxDistanceRay) && Input.GetKeyDown(KeyCode.E))
        {
            C.Interact();

        }

        
    }
}
