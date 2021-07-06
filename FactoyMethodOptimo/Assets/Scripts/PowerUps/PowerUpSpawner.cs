using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// este el consumidor de la factory

namespace FACTORYmethod.Assets.Scripts.PowerUps
{
    public class PowerUpSpawner: MonoBehaviour

    {
    [SerializeField] private PowerUpConfiguration _powerUpConfiguration; 
    private PowerUpFactory _powerUpFactory;
    //ACA SE CREAN LOS POWERUPS 
    //por medio de las teclas 1 2 
    private void Awake(){
        _powerUpFactory= new PowerUpFactory(Instantiate(_powerUpConfiguration));
    }
    private void Update(){
        if (Input.GetKey(Key.Alpha1))
        {
            _powerUpFactory.Create("Speed");
        }
        else if (Input.GetKey(Key.Alpha2))
        {
            _powerUpFactory.Create("Drunk");
        }
    }
    }
}