using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaadres
{
   abstract class GameObject
    {
        public GameObjectPalce GameObjectPalce { get; set; }
        public char Figure { get; set; }
        public GameObjectType GameObjectType { get; set; }
    }
}
