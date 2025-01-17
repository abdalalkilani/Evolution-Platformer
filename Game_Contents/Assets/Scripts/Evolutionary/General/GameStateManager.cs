using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    [SerializeField]
    private CameraMovement Camera;

    [SerializeField]
    public string TrackName;

    public UIController UIController { get; set; }

    public static GameStateManager Instance { get; private set; }

    private CarController prevBest, prevSecondBest;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("Multiple GameStateManagers in the Scene.");
            return;
        }
        Instance = this;

        SceneManager.LoadScene("GUI", LoadSceneMode.Additive);
        SceneManager.LoadScene(TrackName, LoadSceneMode.Additive);
    }

    void Start()
    {
        TrackManager.Instance.BestCarChanged += OnBestCarChanged;
        EvolutionManager.Instance.StartEvolution();
    }

    private void OnBestCarChanged(CarController bestCar)
    {
        if (bestCar == null)
            Camera.SetTarget(null);
        else
            Camera.SetTarget(bestCar.gameObject);

        if (UIController != null)
            UIController.SetDisplayTarget(bestCar);
    }
}
