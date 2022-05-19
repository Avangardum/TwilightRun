using UnityEngine;

namespace Avangardum.TwilightRun
{
    class GameManager : MonoBehaviour, IGameManager
    {
        private ILevelGenerator _standardLevelGenerator;
        private ILevelGenerator _tutorialLevelGenerator;
        private IPlayerCharactersController _playerCharactersController;
        private IInputManager _inputManager;

        public void InjectDependencies(ILevelGenerator standardLevelGenerator, ILevelGenerator tutorialLevelGenerator, 
            IPlayerCharactersController playerCharactersController, IInputManager inputManager)
        {
            _standardLevelGenerator = standardLevelGenerator;
            _tutorialLevelGenerator = tutorialLevelGenerator;
            _playerCharactersController = playerCharactersController;
            _inputManager = inputManager;
        }

        public void StartGame()
        {
            throw new System.NotImplementedException();
        }

        public void StartTutorial()
        {
            throw new System.NotImplementedException();
        }
    }
}