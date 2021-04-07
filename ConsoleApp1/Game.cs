using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Game
    {
        private Player _player;
        private Map _map;
        private Enemy _enemy;
        public int TurnCount { get; set; }

        public void Init()
        {
            int Height = 3;
            int Width = 3;

            TurnCount = 0;

            _player = new Player();
            _player.CurrentHealth = 10;
            _player.InitPlayer(Height, Width);

            _map = new Map();
            _map.Height = Height;
            _map.Width = Width;
            _map.InitMap();

            _enemy = new Enemy();
            _enemy.InitEnemy(Height, Width);

        }
        public void DecidePlayerAction(String action)
        {
            if (action.Equals("search"))
            {
                Search(_player.Location);
            } else
            {
                MovePlayer(action);
            }
        }

        public void MovePlayer(String direction)
        {
            _player.Move(direction);
        }

        public void Search(Location location)
        {
            var items = _map.Search(location);

            if (items != "")
            {
                _player.Items.Add(items);
            } else
            {
                items = "nothing";
            }
            Console.WriteLine("You found " + items + ".");
        }

        public void PerformEnemyActions()
        {
            MoveEnemy();
            IsEnemyAdjToPlayer();
            IsEnemyInSameRoomAsPlayer();
            // If item is available, kill enemy
            // If not, take damage
        }

        public void MoveEnemy()
        {
            if (TurnCount%2 == 0)
            {
                _enemy.MoveEnemy();
            }
        }

        public bool IsEnemyInSameRoomAsPlayer()
        {
            var isSameRoom = false;

            if (_enemy.Location.X == _player.Location.X && _enemy.Location.Y == _player.Location.Y)
            {
                isSameRoom = true;
                Console.WriteLine("The enemy found you. Type [use] to use an item you have, or any direction to flee.");
            }

            return isSameRoom;
        }

        public void IsEnemyAdjToPlayer()
        {
            var isAdj = _enemy.CheckIfAdjToPlayer(_player.Location);
            if (isAdj)
            {
                Console.WriteLine("You feel a presence...");
            }
        }
    }
}
