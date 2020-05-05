using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _rigidbody;
    [SerializeField]
    private float _forwardForce = 2000f;
    [SerializeField]
    private float _sidewaysForce = 500f;

    // Update is called once per frame
    private void FixedUpdate()
    {
        _rigidbody.AddForce(0, 0, _forwardForce * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(_sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(-_sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (_rigidbody.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
