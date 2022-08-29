using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private Vector3 targetPosition;

    private void Update()
    {
        float stoppingDistance = 0.1f;
        Vector3 moveDirestion = (targetPosition - transform.position).normalized;
        float moveSpeed = 4f;

        if (Vector3.Distance(new Vector3(4, 0, 4), transform.position) < stoppingDistance) return;

        transform.position += moveSpeed * Time.deltaTime * moveDirestion;

        if (Input.GetKeyDown(KeyCode.T))
        {
            Move(new Vector3(4, 0, 4));
        }
    }

    private void Move(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }
}
