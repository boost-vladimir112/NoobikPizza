using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public float distance = 10f;
    public Vector3 startpos;
    private bool _isGameObjectChoose;

    public bool IsGameObjectChoose { get => _isGameObjectChoose; set => _isGameObjectChoose = value; }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
        _isGameObjectChoose = true;
    }
    void OnMouseUp()
    {
        Vector3 objPosition = startpos;
        _isGameObjectChoose = false;
    }
}
