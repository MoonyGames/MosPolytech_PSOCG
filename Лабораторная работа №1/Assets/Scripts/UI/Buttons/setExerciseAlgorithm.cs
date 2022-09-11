using UnityEngine;

public class setExerciseAlgorithm : MonoBehaviour
{
    [SerializeField] private moveSphere moveSphere;

    [SerializeField] private moveSphere.Exercise thisExercise;

    private void Start()
    {
        moveSphere.currentExercise = thisExercise;
    }
}
