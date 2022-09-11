using UnityEngine;
using TMPro;

public class setZDistance : MonoBehaviour
{
    private TextMeshProUGUI distanceText;

    [SerializeField] private moveSphere moveSphere;

    private void Start()
    {
        distanceText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        distanceText.text = "Координата Z: " + moveSphere.distanceZ;
    }
}

