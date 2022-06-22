using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObstacle : MonoBehaviour
{
    [SerializeField] float rotateSpeed;

    
    private void Update()
    {
      RotateObstacle();
    }


    private void RotateObstacle()
    {
          transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeed);
    }
    
    
    
}
