using UnityEngine;
using System;

namespace Scripts.Services
{
    public interface IInputManagerService
    {
        Vector2 LeftStickValue { get; }
        Vector2 RightStickValue { get; } 
     
        void Update();
        void Reset();
        void SwitchToKeyboard();
        void SwitchToGamepad();
    }
} 