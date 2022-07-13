using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapRooms : MonoBehaviour
{

    [SerializeField]
    GameObject Kitchen;
    [SerializeField]
    GameObject ClientRoom;
    private Vector2 _startPos;
    private Camera _cam;


    void Start()
    {
        _cam = GetComponent<Camera>();
        //_cam.transform.position = new Vector3(5.59f, 0, -10) ;


    }
    private void Update()
    {

        if (Input.GetMouseButtonDown(0)) _startPos = _cam.ScreenToWorldPoint(Input.mousePosition);
        else if (Input.GetMouseButton(0))
        {
   
            float _pos = _cam.ScreenToWorldPoint(Input.mousePosition).x - _startPos.x;
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - _pos,-5.77f, 5.59f), transform.position.y, transform.position.z);
            
        }
        if(_cam.transform.position.x < 5f)
        {
            Kitchen.SetActive(true);
            ClientRoom.SetActive(false);
        }
        if(_cam.transform.position.x > -5f)
        {
            Kitchen.SetActive(false);
            ClientRoom.SetActive(true);
        }
    }




}
