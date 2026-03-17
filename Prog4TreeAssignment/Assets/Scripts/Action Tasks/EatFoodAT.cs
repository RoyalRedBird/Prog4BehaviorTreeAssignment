using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class EatFoodAT : ActionTask {

		public BBParameter<GameObject> currentFoodBBP;

		//Called once per frame while the action is active.
		protected override void OnUpdate() {

			if(currentFoodBBP != null)
			{

				currentFoodBBP.value.GetComponent<FoodScript>().EatFood();

			}
			else
			{

                EndAction(true);

            }
			
		}

	}

}