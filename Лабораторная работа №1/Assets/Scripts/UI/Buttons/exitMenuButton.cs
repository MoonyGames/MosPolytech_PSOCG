using UnityEngine;

public class exitMenuButton : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;

    [SerializeField] private moveSphere moveSphere;

    public void ExitMenu(GameObject menuToClose)
    {
        mainMenu.SetActive(true);
        menuToClose.SetActive(false);

        moveSphere.StopMoving();
    }
}
