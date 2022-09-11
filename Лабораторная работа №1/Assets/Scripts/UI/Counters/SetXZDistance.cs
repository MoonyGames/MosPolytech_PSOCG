using UnityEngine;
using TMPro;
using System;

public class SetXZDistance : MonoBehaviour
{
    private Vector3 lastPosition;
    public float totalDistance = 0f;

    [SerializeField] private moveSphere moveSphere;

    private TextMeshProUGUI distanceText;

    private void Start()
    {
        lastPosition = moveSphere.transform.position;

        distanceText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(lastPosition, moveSphere.transform.position);
        totalDistance += distance;

        lastPosition = moveSphere.transform.position;

        if (moveSphere.isMoving) distanceText.text = "Пройденный путь: " + Math.Round(totalDistance, 2).ToString();
        else totalDistance = 0f;
    }
}
