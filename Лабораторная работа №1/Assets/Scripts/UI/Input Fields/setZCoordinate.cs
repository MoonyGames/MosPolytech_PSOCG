using UnityEngine;
using System;
using TMPro;

public class setZCoordinate : MonoBehaviour
{
    private TMP_InputField inputField;

    [SerializeField] private moveSphere moveSphere;

    private void Start()
    {
        inputField = GetComponent<TMP_InputField>();
    }

    public void SetEnteredCoordinate()
    {
        moveSphere.zCoordinate = Convert.ToInt32(inputField.text);

        moveSphere.transform.position = new Vector3(moveSphere.transform.position.x, 0.5f, moveSphere.zCoordinate);
    }
}
