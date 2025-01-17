using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Canvas Canvas { get; private set; }

    private UISimulationController simulationUI;
    private UIStartMenuController startMenuUI;

    void Awake()
    {
        if (GameStateManager.Instance != null)
            GameStateManager.Instance.UIController = this;

        Canvas = GetComponent<Canvas>();
        simulationUI = GetComponentInChildren<UISimulationController>(true);
        startMenuUI = GetComponentInChildren<UIStartMenuController>(true);

        simulationUI.Show();
    }

    public void SetDisplayTarget(CarController target)
    {
        simulationUI.Target = target;
    }
}
