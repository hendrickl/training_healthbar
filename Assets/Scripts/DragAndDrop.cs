using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 _screenPosition;
    private Vector3 _offset;

    void OnMouseDown()
    {
        _screenPosition = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        _offset = gameObject.transform.position -
        Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _screenPosition.z));
    }

    void OnMouseDrag()
    {
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _screenPosition.z);
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + _offset;
        transform.position = currentPosition;
    }
}
