using UnityEngine;

namespace Scripts.Services
{
    public class InputManagerService : IInputManagerService
    {            
        private IInputManagerService _inputManagerService;
       
        public Vector2 LeftStickValue => _inputManagerService.LeftStickValue;
        public Vector2 RightStickValue => _inputManagerService.RightStickValue;
      
        public void Update()        
            =>_inputManagerService.Update();        

        public void Reset()
            =>_inputManagerService.Reset();        

        public void SwitchToKeyboard()
            =>_inputManagerService = new KeyboardInputManager();        

        public void SwitchToGamepad()
            =>_inputManagerService = new GamepadInputManager();
    }
}