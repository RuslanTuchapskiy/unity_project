using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    

    private void Update()
    {
        float horizontalInput  = Input.GetAxis("Horizontal");
        float verticalInput  = Input.GetAxis("Vertical");

      
        _rigidbody.velocity =new  Vector3(horizontalInput,0f ,verticalInput) * _speed * Time.fixedDeltaTime;
         

    }
}
