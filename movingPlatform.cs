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
        transform.Translate(0, 0, -eksenDegis * Time.deltaTime * platformSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        eksenDegis *= -1;
    }



        /* IEnumerator yonDegis()
         {
             eksenDegis *= -1;
             yield return new WaitForSeconds(platformTime);
             StartCoroutine(yonDegis());
         } */


    }
