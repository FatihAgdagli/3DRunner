using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float runningSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + runningSpeed * Time.deltaTime);
        transform.position = newPosition;
    }
}
