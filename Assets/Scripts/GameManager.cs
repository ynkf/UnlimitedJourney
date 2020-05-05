using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private float _restartDelay = 1f;
    [SerializeField]
    private Score _score;
    
    private bool _hasGameEnded = false;
    public void EndGame()
    {
        if (!_hasGameEnded)
        {
            _hasGameEnded = true;
            _score.enabled = false;
            Debug.Log("GAME OVER");

            Invoke(nameof(RestartGame), _restartDelay);
        }
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
