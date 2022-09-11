using UnityEngine;

public class selectExercise : MonoBehaviour
{
    public void openExercise(GameObject exerciseToOpen)
    {
        exerciseToOpen.SetActive(true);
        gameObject.SetActive(false);
    }
}
