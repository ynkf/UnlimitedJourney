using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Transform _player;
    [SerializeField]
    private Text _score;
    // Update is called once per frame
    private void Update()
    {
        _score.text = _player.position.z.ToString("0");
    }
}
