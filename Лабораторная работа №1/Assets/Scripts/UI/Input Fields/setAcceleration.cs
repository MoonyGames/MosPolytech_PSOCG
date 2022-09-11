using UnityEngine;
using System;
using TMPro;

public class setAcceleration : MonoBehaviour
{
    private TMP_InputField inputField;

    [SerializeField] private moveSphere moveSphere;

    private void Start()
    {
        inputField = GetComponent<TMP_InputField>();
    }

    public void SetEnteredAcceleration()
    {
        moveSphere.acceleration = Convert.ToInt32(inputField.text);
    }
}