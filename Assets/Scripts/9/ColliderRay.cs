using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderRay : MonoBehaviour
{
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if(GetComponent<Collider>().Raycast(ray, out hit, 100f))
        {
            transform.localScale = Vector3.one * 1.2f;
            if(Input.GetMouseButtonDown(0))
            {
                GetComponent<Renderer>().material.color = Color.white * 0.65f;
            }
        } else
        {
            transform.localScale = Vector3.one * 1f;
        }
    }
}
