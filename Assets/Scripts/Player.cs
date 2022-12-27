using UnityEngine;

public class Player : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Coin coin))
        {
            Destroy(coin.gameObject);
        }
    }

}
