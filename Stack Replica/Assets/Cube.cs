using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _speed;

    public static Cube CurrentCube { get; private set; }
    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnEnable()
    {
        CurrentCube = this;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * _speed;
    }
    public void Stop()
    {
        transform.position = transform.position;
    }
}
