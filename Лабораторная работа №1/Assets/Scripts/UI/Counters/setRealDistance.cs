using UnityEngine;
using TMPro;

public class setRealDistance : MonoBehaviour
{
    private TextMeshProUGUI realDistanceText;

    [SerializeField] private moveSphere moveSphere;

    private void Start()
    {
        realDistanceText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        realDistanceText.text = "Пройденный путь: " + moveSphere.realDistance;
    }
}
