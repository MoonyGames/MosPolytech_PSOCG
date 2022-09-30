using UnityEngine;
using System;

public class Rotation_3 : MonoBehaviour
{
    [SerializeField] private float r, v, turnAngle, linearVelocity;
    [SerializeField] private string coordinate;
    float timer = 0, angle;

    private void Update()
    {
        timer += Time.deltaTime;

        angle = ((2 * MathF.PI) / (1 / v)) * timer;

        float x = Mathf.Cos(angle) * r;
        float y = Mathf.Sin(angle) * r;

        turnAngle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
        coordinate = transform.position.x.ToString() + ", " + transform.position.z.ToString();
        linearVelocity = 2 * Mathf.PI * r * v;

        transform.position = new Vector3(x, transform.position.y, y);
    }
}