using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    public Transform Pointer;
    public Selectable CurrentSelectable;

    private void LateUpdate()
    {
        //Ray ray = new Ray(); // куда смотрит прицел
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // по клику мыши
        ray.origin = transform.position;
        ray.direction = transform.forward;
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.yellow);

        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            Pointer.position = hit.point;

            Selectable selectable = hit.collider.gameObject.GetComponent<Selectable>();
            if (selectable)
            {
                if(CurrentSelectable && CurrentSelectable != selectable)
                {
                    CurrentSelectable.Deselect();
                }
                CurrentSelectable = selectable;
                selectable.Select();
            }
            else
            {
                if (CurrentSelectable)
                {
                    CurrentSelectable.Deselect();
                    CurrentSelectable = null;
                }
            }
        }
        else
        {
            if (CurrentSelectable)
            {
                CurrentSelectable.Deselect();
                CurrentSelectable = null;
            }
        }
    }
}
