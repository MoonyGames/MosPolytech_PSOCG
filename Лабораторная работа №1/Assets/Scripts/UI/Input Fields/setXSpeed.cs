using UnityEngine;
using System;
using TMPro;

public class setXSpeed : MonoBehaviour
{
    private TMP_InputField inputField;

    [SerializeField] private moveSphere moveSphere;

    private void Start()
    {
        inputField = GetComponent<TMP_InputField>();
    }

    public void SetEnteredXSpeed()
    {
        moveSphere.xSpeed = Convert.ToInt32(inputField.text);

        moveSphere.StopMoving();

        moveSphere.timePassed = 0f;
    }
}
