using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class PauseFoodParticleAT : ActionTask {

        public BBParameter<GameObject> currentFoodBBP;

        //This is called once each time the task is enabled.
        //Call EndAction() to mark the action as finished, either in success or failure.
        //EndAction can be called from anywhere.
        protected override void OnExecute() {

            currentFoodBBP.value.GetComponent<FoodScript>().PauseParticleEffect();
            EndAction(true);

        }

	}

}