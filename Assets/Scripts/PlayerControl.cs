using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float runningSpeed = 2f;
    [SerializeField] private float xSpeed;
    [SerializeField] private float limitX;
    private float touchXDelta = 0f;
    private float newX = 0f;
    private float newZ = 0f;


    void Start()
    {
        
    }


    void Update()
    {
        SwipeCheck();
    }

    private void SwipeCheck()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            touchXDelta = Input.GetTouch(0).deltaPosition.x / Screen.width;
        }
        else if(Input.GetMouseButton(0))
        {
            touchXDelta = Input.GetAxis("Mouse X");
        }
        else
        {
            touchXDelta = 0f;
        }

        newX = transform.position.x + xSpeed * touchXDelta * Time.deltaTime;
        newX = Mathf.Clamp(newX, -limitX, limitX);

        newZ = transform.position.z + runningSpeed * Time.deltaTime;

        Vector3 newPosition = new Vector3(newX, transform.position.y, newZ);

        transform.position = newPosition;
    }
}
