using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 mouseOffset;

    private float mouseZ;

    void OnMouseDown()
    {
        mouseZ = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mouseOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mouseZ;

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }

    void OnMouseDrag()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        gameObject.GetComponent<Rigidbody>().angularVelocity = new Vector3(0,0,0);
        transform.position = GetMouseWorldPos() +mouseOffset;
    }
}
