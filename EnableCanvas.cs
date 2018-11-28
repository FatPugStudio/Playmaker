// License: Attribution 4.0 International (CC BY 4.0)
/*--- __ECO__ __PLAYMAKER__ __ACTION__ ---*/

using UnityEngine;

namespace HutongGames.PlayMaker.Actions

{
    [ActionCategory(ActionCategory.Physics)]
    [Tooltip("Enables or disables Canvas")]
    [HelpUrl("")]
    public class EnableCanvas : ComponentAction<Canvas>
    
    {
        [RequiredField]
        [CheckForComponent(typeof(Canvas))]
        [Tooltip("Canvas to enable.")]
        public FsmOwnerDefault gameObject;
	
	[Tooltip("Enabled")]
        public FsmBool enabled;
       
        public override void Reset()
	
        {
            gameObject = null;
	    enabled = false;
        }

        public override void OnEnter()
        
	{   
	    DoChange();
        }

        void DoChange()
        
	{
            var go = Fsm.GetOwnerDefaultTarget(gameObject);
            Canvas canvas = go.GetComponent<Canvas>();
	    canvas.enabled = enabled.Value;         
        }
    }
}
