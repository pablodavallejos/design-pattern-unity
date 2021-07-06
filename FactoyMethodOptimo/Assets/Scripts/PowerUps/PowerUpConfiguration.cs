using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine;

namespace FactoyMethodOptimo.Assets.Scripts.PowerUps
{
    [CreateAssetMenu(menu = "Custom/Power up configuration")]
    public class PowerUpConfiguration : ScriptableObject
    {
        // vamos a crear una lista 
        [SerializeField] private PowerUp[] _powerUps;
        //crear un diccionario 
        private Dictionary<string, PowerUp> _idToPowerUp;
        private void Awake()
        {
            _idToPowerUp = new Dictionary<string, PowerUp>();
            foreach (var powerUp in _powerUps)
            {
                _idToPowerUp.Add(powerUp.Id, powerUp);
            }
        }

        public PowerUps GetPowerUpPrefabById(string id)
        {
            //PowerUpFactory powerUp;

        if(! _idToPowerUp.TryGetValue(id, out var powerUp))
        {
            throw new ArgumentOutRangeException($"PowerUp with Id {id} does noot exits");
        }
        //el retorno es que lo instaciamos 
        return powerUp;
        
        }
    }
}