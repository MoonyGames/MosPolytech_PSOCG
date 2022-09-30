using UnityEngine;
using System;

public class Rotation_1 : MonoBehaviour
{
    [SerializeField] private float r, v, turnovers, angularVelocity;
    float timer = 0, angle;

    private void Update()
    {
        timer += Time.deltaTime;

        angle = ((2 * MathF.PI) / (1 / v)) * timer;

        float x = Mathf.Cos(angle) * r;
        float y = Mathf.Sin(angle) * r;

        turnovers = MathF.Truncate(timer) * v;
        angularVelocity = (2 * MathF.PI) / (1 / v);

        transform.position = new Vector3(x, transform.position.y, y);
    }
}