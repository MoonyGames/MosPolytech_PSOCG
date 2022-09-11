using UnityEngine;
using System;
using TMPro;

public class setCoordinate : MonoBehaviour
{
    private TMP_InputField inputField;

    [SerializeField] private moveSphere moveSphere;

    private void Start()
    {
        inputField = GetComponent<TMP_InputField>();
    }

    public void SetEnteredCoordinate()
    {
        moveSphere.xCoordinate = Convert.ToInt32(inputField.text);

        moveSphere.transform.position = new Vector3(moveSphere.xCoordinate, 0.5f, 0f);
    }
}
