using UnityEngine;
using TMPro;

public class setRealSpeed : MonoBehaviour
{
    private TextMeshProUGUI realSpeedText;

    [SerializeField] private moveSphere moveSphere;

    private void Start()
    {
        realSpeedText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        realSpeedText.text = "Cкорость: " + moveSphere.acceleratedPosition.x.ToString();
    }
}
