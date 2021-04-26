using System;
using System.Collections.Generic;
using System.Text;

namespace HiQTest
{
    class Simulation
    {
        public List<string> commands;
        public Car car;
        public Room room;

        public Simulation(List<string> _commands, Car _car, Room _room)
        {
            commands = _commands;
            car = _car;
            room = _room;
        }

        public string RunSimulation()
        {
            string returnMsg = "Something went wrong with the simulation";

            foreach (var c in commands) {
                car.Move(c);

                returnMsg = "The cars position is now [" + car.positionY + "," + car.positionX + "]";
                
                if (!checkIfStillInRoom()) {
                    returnMsg = "You drow in to the wall while trying to get to [" + car.positionY + "," + car.positionX + "]";
                    break;
                }   
            }
            return returnMsg;
        }

        private Boolean checkIfStillInRoom()
        {
            Boolean stillInTheRoom = true;

            if (car.positionX < 0 || car.positionY < 0 || room.xSize <= car.positionX || room.ySize <= car.positionY) {
                stillInTheRoom = false;
            }
            return stillInTheRoom;
        }
    }
}