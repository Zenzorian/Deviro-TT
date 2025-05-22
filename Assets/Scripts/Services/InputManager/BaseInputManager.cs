using UnityEngine;

namespace Scripts.Services
{
    public abstract class BaseInputManager : IInputManagerService
    { 
        public Vector2 LeftStickValue { get; private set; }
        public Vector2 RightStickValue { get; private set; }       
       
        public abstract void Update(); 
        
        public virtual void Reset()
        {
            LeftStickValue = Vector2.zero;
            RightStickValue = Vector2.zero;
        }

        public virtual void SwitchToKeyboard() { }
        public virtual void SwitchToGamepad() { }

        protected void UpdateLeftStickValue(Vector2 newLeftStickValue)
        {              
            if (newLeftStickValue == LeftStickValue)return;
            
            LeftStickValue = newLeftStickValue;                          
        }

        protected void UpdateRightStickValue(Vector2 newRightStickValue)
        {  
            if (newRightStickValue == RightStickValue)return;
            
            RightStickValue = newRightStickValue;           
        } 
    }
}
