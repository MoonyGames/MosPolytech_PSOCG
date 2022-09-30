using UnityEngine;
using System;

public class Rotation_2 : MonoBehaviour
{
    [SerializeField] private float r, v, turnAngle, distance;
    float timer = 0, angle;

    private void Update()
    {
        timer += Time.deltaTime;

        angle = ((2 * MathF.PI) / (1 / v)) * timer;

        float x = Mathf.Cos(angle) * r;
        float y = Mathf.Sin(angle) * r;

        turnAngle = (2 * MathF.PI) / (1 / v);
        distance = 2 * Mathf.PI * r * (timer * v);

        transform.position = new Vector3(x, transform.position.y, y);
    }
}