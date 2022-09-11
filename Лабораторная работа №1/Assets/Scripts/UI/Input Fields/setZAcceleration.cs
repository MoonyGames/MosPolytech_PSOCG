using UnityEngine;
using System;
using TMPro;

public class setZAcceleration : MonoBehaviour
{
    private TMP_InputField inputField;

    [SerializeField] private moveSphere moveSphere;

    private void Start()
    {
        inputField = GetComponent<TMP_InputField>();
    }

    public void SetEnteredAcceleration()
    {
        moveSphere.zAcceleration = Convert.ToInt32(inputField.text);
    }
}
