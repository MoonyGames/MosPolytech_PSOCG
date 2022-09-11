using UnityEngine;
using TMPro;

public class setTime : MonoBehaviour
{
    private TextMeshProUGUI timerText;

    [SerializeField] private moveSphere moveSphere;

    private void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        timerText.text = "Время: " + moveSphere.time;
    }
}
