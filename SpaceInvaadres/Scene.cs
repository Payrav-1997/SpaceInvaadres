using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaadres
{
    class Scene
    {
        List<GameObject> _swarm;
        List<GameObject> _ground;
        GameObject _playerShip;
        List<GameObject> __playerShipMissile;

        private static Scene _scene;

        private Scene()
        {

        }

        public static Scene GetScene()
        {
            if(_scene == null)
            {
                   
            }
            return _scene;
        }

    }
}
