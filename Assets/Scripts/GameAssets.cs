using UnityEngine;

public class GameAssets : MonoBehaviour
{
    public static GameAssets Instance { get; private set; }

    public Sprite snakeHeadSprite;
    public Sprite snakeBodySprite;
    public Sprite foodSprite;

    public AudioClip buttonClickClip;
    public AudioClip buttonOverClip;
    public AudioClip buttonDieClip;
    public AudioClip buttonEatClip;
    public AudioClip buttonMoveClip;

    private void Awake()
    {
        // Singleton
        if (Instance != null)
        {
            Debug.LogError("There is more than one Instance");
        }

        Instance = this;
    }
}
