using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Raycast : MonoBehaviour
{
    GameManager _gameManager;
    public Camera _mainCamera;
    Vector3 pos = new Vector3(200, 200, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        _mainCamera = GetComponent<Camera>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            CameraRaycast();
        }    
    }

    void CameraRaycast()
    {
        RaycastHit hit;
        Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
        
        if(Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point);
            if(hit.transform.gameObject.layer == 3)
            {
                _gameManager.Contador();
                _gameManager.Esfera();
            }
            if(hit.transform.gameObject.layer == 6)
            {
                _gameManager.Contador();
                _gameManager.Cube1();
            }
            if(hit.transform.gameObject.layer == 7)
            {
                _gameManager.Contador();
                _gameManager.Cube2();
            }
        }
    }
}
