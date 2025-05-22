using Scripts.Services;
using Scripts.StaticData;
using UnityEngine;

namespace Scripts.Infrastructure.States
{
    public class LoadLevelState : IPayloadedState<GameData>
    {
        private const string LEVEL_SCENE_NAME = "Level";
        
        private readonly GameStateMachine _stateMachine;

        private readonly ISceneLoaderService _sceneLoader;
        private readonly IGameFactoryService _gameFactory;
        private readonly ICoroutineRunner _coroutineRunner;

        private GameData _gameData;

        public LoadLevelState
        (
            GameStateMachine gameStateMachine,
            ISceneLoaderService sceneLoader,          
            IGameFactoryService gameFactory,
            ICoroutineRunner coroutineRunner
        )
        {
            _stateMachine = gameStateMachine;
            _sceneLoader = sceneLoader;           
            _gameFactory = gameFactory;
            _coroutineRunner = coroutineRunner;
        }

        public void Enter(GameData gameData)
        {
            Debug.Log("Load Level State");
            _gameData = gameData;
            _gameFactory.Cleanup();         
          
            _sceneLoader.Load(LEVEL_SCENE_NAME , OnLoaded);          
        }

        public void Exit()
        {         
        }
     
        private void OnLoaded()
        { 
            //_gameFactory.CreateHud();   
            _gameFactory.CreateRover(Vector3.zero, _gameData.roverConfig);                        
            
            _sceneLoader.HideLoadingCurtain();

            _stateMachine.Enter<GameLoopState>();                       
        }      
    }
}