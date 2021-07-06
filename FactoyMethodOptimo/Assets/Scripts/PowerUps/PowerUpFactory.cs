//la clase factory se caracterisa por tener un metodo de creacion 
// en esta version no vamos a tener que tocar nada de codigo de construcion 
// si quier agregar un nuevo porwer up lo unico que tengo que hacer es crear un objeto y 
//dentro del spawner poner el objeto dentro del swich
 
using Objet=UnityEngine.Objet;

namespace FACTORYmethod.Assets.Scripts.PowerUps
{
    public class PowerUpFactory
    {
   private readonly PowerUpConfiguration _powerUpConfiguration;
   public PowerUpFactory(PowerUpConfiguration powerUpConfiguration){
       _powerUpConfiguration = powerUpConfiguration;
   }
   

    public PowerUp Create(string id)
    {
       var powerUp = _powerUpConfiguration.GetPowerUpPrefabById(id); 
       return Objet.Instantiate(PowerUp);
    }

    }
}