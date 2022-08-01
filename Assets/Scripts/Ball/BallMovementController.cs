using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    [SerializeField] private BallDataTransmiter ballDataTransmiter;
    [SerializeField] private float ballmoveSpeed;

    private void Update()
    {
        SetBallMovement();
    }

    private void SetBallMovement()
    {
        transform.position += ballDataTransmiter.GetBallDirection() * ballmoveSpeed * Time.deltaTime;
    }
}
