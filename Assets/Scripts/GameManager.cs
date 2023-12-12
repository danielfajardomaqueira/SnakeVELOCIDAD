using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public const int POINTS = 100; // Cantidad de puntos que ganamos al comer comida

    private int score; // Puntuación del jugador
    
    private LevelGrid levelGrid;
    private Snake snake;

    //private ScoreUI scoreUIScript; //Pendiente
    
    private void Awake()
    {
        // Singleton
        if (Instance != null)
        {
            Debug.LogError("There is more than one Instance");
        }

        Instance = this;
    }
    
    private void Start()
    {
        // Configuración de la cabeza de serpiente
        GameObject snakeHeadGameObject = new GameObject("Snake Head");
        SpriteRenderer snakeSpriteRenderer = snakeHeadGameObject.AddComponent<SpriteRenderer>();
        snakeSpriteRenderer.sprite = GameAssets.Instance.snakeHeadSprite;
        snake = snakeHeadGameObject.AddComponent<Snake>();
        
        // Configurar el LevelGrid
        levelGrid = new LevelGrid(20,20);
        snake.Setup(levelGrid);
        levelGrid.Setup(snake);


        Score.InitializeStaticScore();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Loader.Load(Loader.Scene.Game);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void SnakeDied()
    {
        GameOverUI.Instance.Show();
    }

    public void PauseGame()
    {
        
        Time.timeScale = 0f;
        PauseUI.Instance.Show();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        PauseUI.Instance.Hide();
    }

}
