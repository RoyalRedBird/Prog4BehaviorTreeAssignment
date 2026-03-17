using UnityEngine;

public class FoodScript : MonoBehaviour
{

    float foodLeft = 10f;
    [SerializeField] ParticleSystem foodParticleSys;

    public void EatFood()
    {

        if(!foodParticleSys.isPlaying)
        {

            foodParticleSys.Play();

        }

        foodLeft -= Time.deltaTime;

        if(foodLeft <= 0)
        {

            Destroy(gameObject);

        }

    }

}
