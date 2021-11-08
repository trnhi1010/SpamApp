using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PhysicsController))]
public class ShakeDetector : MonoBehaviour
{
    
    public float ShakeDetectionThreshold;
    public float MinShakeInterval;
    public bool isShake = false;

    private float sqrShakeDetectionThreshold;
    private float timeSinceLastShake;

    private PhysicsController physicsController;

    private static ShakeDetector _instance;

    public static ShakeDetector Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<ShakeDetector>();
            }

            return _instance;
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        sqrShakeDetectionThreshold = Mathf.Pow(ShakeDetectionThreshold, 2);
        physicsController = GetComponent<PhysicsController>();
    }

    void Update()
    {
        if (Input.acceleration.sqrMagnitude >= sqrShakeDetectionThreshold
            && Time.unscaledTime >= timeSinceLastShake + MinShakeInterval)
        {
            isShake = true;
            physicsController.ShakeRigidbodies(Input.acceleration);
            timeSinceLastShake = Time.unscaledTime;
        }
        
    }
}
