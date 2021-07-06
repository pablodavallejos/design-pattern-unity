//la clase factory se caracterisa por tener un metodo de creacion 
//PROBLEMA DE ESTE CASO 
/**
cada vez que tengamos que crear un nuevo prefaps tendremos que añador un nuevo atributo 
y agregar un nuevo caso a swich. 
 

*/ 
using UnityEngine;
namespace FACTORYmethod.Assets.Scripts.PowerUp
{
    public class PowerUpFactory:MonoBehaviour
    {
        
    [SerializeField] private PowerUp _speedPowerUp;
    [SerializeField] private PowerUp _drunkPowerUp;
    
    public PowerUp Create(string id)
    {
        switch(id){
            
        case "Speed":
            return Instatiate(_speedPowerUp);
         default:
         throw new ArgumentOutRangeException($"PowerUp with Id {id} does noot exits");
        
        case "Drunk":
            return Instatiate(_drunkPowerUp);
         default:
         throw new ArgumentOutRangeException($"PowerUp with Id {id} does noot exits");
        }
        }

    }
}