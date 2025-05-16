using UnityEngine;

[CreateAssetMenu(fileName = "BikeData", menuName = "Bike/Create New Bike")]
public class BikeData : ScriptableObject
{
    public string bikeName;
    public float moveSpeed;
    public float turnSpeed;
    public float jumpForce;
    
    public GameObject bikePrefab;
}