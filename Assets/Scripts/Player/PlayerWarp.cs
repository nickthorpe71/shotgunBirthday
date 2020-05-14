using UnityEngine;
using System.Collections;

public class PlayerWarp : MonoBehaviour
{
    Vector3 newPosition;

    public GameObject warpEffect;

    void Start()
    {
        newPosition = transform.position;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                WarpEffect(transform.position);

                newPosition = hit.point;
                transform.position = new Vector3(newPosition.x, transform.position.y, newPosition.z);

                WarpEffect(newPosition);


            }
        }
    }

    void WarpEffect(Vector3 pos)
    {
        Vector3 newPos = new Vector3(pos.x, 0, pos.z);
        Quaternion rotation =  Quaternion.Euler (-90, 0, 0);

        GameObject effect = Instantiate(warpEffect, newPos, rotation);
        Destroy(effect, 2);
    }
}