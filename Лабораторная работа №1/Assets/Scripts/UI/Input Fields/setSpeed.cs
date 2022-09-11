using UnityEngine;
using System;
using TMPro;

public class setSpeed : MonoBehaviour
{
    private TMP_InputField inputField;

    [SerializeField] private moveSphere moveSphere;

    private void Start()
    {
        inputField = GetComponent<TMP_InputField>();
    }

    public void SetEnteredSpeed()
    {
        moveSphere.speed = Convert.ToInt32(inputField.text);

        moveSphere.StopMoving();

        moveSphere.timePassed = 0f;
    }
}
