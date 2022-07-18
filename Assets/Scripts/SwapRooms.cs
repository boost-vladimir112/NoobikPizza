using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapRooms : MonoBehaviour
{
    [SerializeField] GameObject _kitchen;
    [SerializeField] GameObject _clientRoom;

    [SerializeField]MouseController _mouseController;
    private Vector2 _startPos;
    private Camera _cam;

    private bool _isGameObjectedChoosen;

    void Start()
    {
        
         _cam = GetComponent<Camera>();
        //_cam.transform.position = new Vector3(5.59f, 0, -10) ;
        
    }
    private void Update()
    {
        _isGameObjectedChoosen = _mouseController.IsGameObjectChoose;

        if (Input.GetMouseButtonDown(0))
        {
            _startPos = _cam.ScreenToWorldPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButton(0))
        {

                float _pos = _cam.ScreenToWorldPoint(Input.mousePosition).x - _startPos.x;
                if (!_isGameObjectedChoosen)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x - _pos, -5.77f, 5.59f), transform.position.y, transform.position.z);
                }

                if (_cam.transform.position.x < 5f)
                {
                    _kitchen.SetActive(true);
                    _clientRoom.SetActive(false);
                }
                if (_cam.transform.position.x > -5f)
                {
                    _kitchen.SetActive(false);
                    _clientRoom.SetActive(true);
                }
            }

        }
   
    




}
