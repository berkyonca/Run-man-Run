using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{

    int eksenDegis = 1;
    [SerializeField] float platformSpeed;
    [SerializeField] float platformTime;

    private void Start()
    {
       // StartCoroutine(yonDegis());
    }
    private void Update()
    {
        PlayerMovement();
    }
    private void OnTriggerEnter(Collider other)
    {
        eksenDegis *= -1;
    }


    private void PlayerMovement()
    {
        transform.Translate(0, 0, -eksenDegis * Time.deltaTime * platformSpeed);
    }
        

    }
