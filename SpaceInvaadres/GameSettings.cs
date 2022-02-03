using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaadres
{
    class GameSettings
    {
        public int ConsoleWidth { get; set; } = 80;
        public int ConsoleHidth { get; set; } = 30;

        public int NumberOfSwarmRows { get; set; } = 2;
        public int NumberOfSwarmColls { get; set; } = 60;


        public int SwrmStartXCoordinate { get; set; } = 10;
        public int SwrmStartYCoordinate { get; set; } = 2;

        public char AlienShip { get; set; } = 'O';

        public int SwrmSpeed { get; set; } = 20;

        public int PlayerShipSartXCoordinate { get; set; } = 40;
        public int PlayerShipSartYCoordinate { get; set; } = 19;
        
        public int GroundShipSartXCoordinate { get; set; } = 1;
        public int GroundShipSartYCoordinate { get; set; } = 20;

        public char Ground { get; set; } = 'П';

        public int NumberOfGroundRows { get; set; } = 1;
        public int NumberOfGroundColls { get; set; } = 80;

        public char PlayerMissile { get; set; } = '|';
        public int PlayerMissileSpeed { get; set; } = 5;

        public int GameSpeed { get; set; } = 100;


    }
}
