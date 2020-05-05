using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private Transform _player;
    [SerializeField]
    private Vector3 _offset = new Vector3();

    // Update is called once per frame
    private void Update()
    {
        transform.position = _player.position +  _offset;
    }
}
