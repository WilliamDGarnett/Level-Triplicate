using UnityEngine;

public class Coin_Collider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("Coin collected!");
    }
}
