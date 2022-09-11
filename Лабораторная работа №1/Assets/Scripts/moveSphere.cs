using UnityEngine;
using System;

public class moveSphere : MonoBehaviour
{
    public enum Exercise
    {
        Exercise1,
        Exercise2,
        Exercise3,
        Exercise41,
        Exercise42,
        Exercise43
    }

    public Exercise currentExercise;

    public float speed = 1f, timePassed = 0f, xCoordinate = 0f, zCoordinate = 0f, acceleration = 0f, xSpeed = 0f, zSpeed = 0f, xAcceleration = 0f, zAcceleration = 0f;

    public bool isMoving = false;

    public string distanceX, distanceZ, time, realDistance;

    public Vector3 acceleratedPosition;

    private void Update()
    {
        if (isMoving)
        {
            switch (currentExercise)
            {
                case Exercise.Exercise1:
                    Exercise1();
                    break;
                case Exercise.Exercise2:
                    Exercise2();
                    break;
                case Exercise.Exercise3:
                    Exercise3();
                    break;
                case Exercise.Exercise41:
                    Exercise41();
                    break;
                case Exercise.Exercise42:
                    Exercise42();
                    break;
                case Exercise.Exercise43:
                    Exercise43();
                    break;
            }

            SetDistance();
            SetRealDistance();
            SetTime();
        }
    }

    private void SetDistance()
    {
        distanceX = Math.Round(transform.position.x, 2).ToString();
        distanceZ = Math.Round(transform.position.z, 2).ToString();
    }

    private void SetTime()
    {
        timePassed += Time.deltaTime;

        time = Math.Round(timePassed, 2).ToString();
    }

    private void SetRealDistance()
    {
        realDistance = Math.Abs(Math.Round(speed * timePassed, 2)).ToString();
    }

    private void Exercise1()
    {
        transform.Translate(new Vector3(speed, 0f, 0f) * Time.deltaTime);
    }

    private void Exercise2()
    {
        transform.Translate(new Vector3(speed, 0f, 0f) * Time.deltaTime);
    }

    private void Exercise3()
    {
        acceleratedPosition = new Vector3(speed * timePassed + ((acceleration * timePassed * timePassed) / 2), 0.5f, 0f);
        transform.position = acceleratedPosition;
    }

    private void Exercise41()
    {
        transform.Translate(new Vector3(xSpeed, 0f, zSpeed) * Time.deltaTime);
    }

    private void Exercise42()
    {
        transform.Translate(new Vector3(xSpeed, 0f, zSpeed) * Time.deltaTime);
    }

    private void Exercise43()
    {
        acceleratedPosition = new Vector3(xSpeed * timePassed + ((xAcceleration * timePassed * timePassed) / 2), 0.5f, zSpeed * timePassed + ((zAcceleration * timePassed * timePassed) / 2));
        transform.position = acceleratedPosition;
    }

    public void StopMoving()
    {
        transform.position = new Vector3(0f, 0.5f, 0f);

        isMoving = false;

        timePassed = 0f;
        time = "";
        realDistance = "";
    }
}
