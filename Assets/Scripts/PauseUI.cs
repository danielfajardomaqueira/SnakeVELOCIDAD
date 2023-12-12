using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseUI : MonoBehaviour
{

    public static PauseUI Instance { get; private set; }

    [SerializeField] private Button resumeButton;
    [SerializeField] private Button quitButton;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("More than one Instance");
        }

        Instance = this;


        resumeButton.onClick.AddListener(() =>
        {
            GameManager.Instance.ResumeGame();
        });

        quitButton.onClick.AddListener(() =>
        {
            Time.timeScale = 1f;
            Loader.Load(Loader.Scene.MainMenu);
        });

        Hide();
    }

    public void Show()
    {
        gameObject.SetActive(true);

    }

    public void Hide()
    {
        gameObject.SetActive(false);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
