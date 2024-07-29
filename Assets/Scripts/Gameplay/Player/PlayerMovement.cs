using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Vector3 targetPosition;
    public LayerMask solidObjects;

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if(IsWalkable(targetPosition))
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * GlobalVariableManager.movementSpeed);
        }
    }

    private bool IsWalkable(Vector3 _targetPosition)
    {
        if(Physics2D.OverlapCircle(_targetPosition, 0.2f, solidObjects) != null)
        {
            return false;
        }

        return true;
    }
}
