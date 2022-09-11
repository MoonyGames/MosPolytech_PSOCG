using UnityEngine;
using TMPro;

public class setPause : MonoBehaviour
{
    private TextMeshProUGUI buttonText;

    private int switcher = 0;

    private void Start()
    {
        buttonText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
    }

    public void PauseGame()
    {
        switcher++;

        if (switcher % 2 != 0)
        {
            Time.timeScale = 0f;

            buttonText.text = "Продолжить";
        }

        else
        {
            Time.timeScale = 1f;

            buttonText.text = "Пауза";
        }
    }
}
