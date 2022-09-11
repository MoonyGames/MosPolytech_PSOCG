using UnityEngine;
using TMPro;

public class setRealXZSpeed : MonoBehaviour
{
    private TextMeshProUGUI realSpeedText;

    [SerializeField] private moveSphere moveSphere;
    [SerializeField] private SetXZDistance setXZDistance;

    private void Start()
    {
        realSpeedText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        realSpeedText.text = "Cкорость: " + (setXZDistance.totalDistance / moveSphere.timePassed);
    }
}
