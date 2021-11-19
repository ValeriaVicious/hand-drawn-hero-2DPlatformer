using UnityEngine;


namespace Heroes2DPlatformer
{
    public class ParalaxManager : IExecute
    {
        #region Fields

        private Transform _camera;
        private Transform _back;
        private Vector3 _backStartPosition;
        private Vector3 _cameraStartPosition;

        private const float _coefficient = 0.3f;

        #endregion


        #region ClassLifeCycles

        public ParalaxManager(Transform camera, GameObject background)
        {
            _camera = camera;
            _back = Object.Instantiate(background).transform;
            _backStartPosition = _back.transform.position;
            _cameraStartPosition = _camera.transform.position;
        }

        #endregion


        #region Methods

        public void Execute(float deltaTime)
        {
            _back.position = _backStartPosition + (_camera.position -
                _cameraStartPosition) * _coefficient;
        }

        #endregion
    }
}