using System;
using System.Collections.Generic;
using System.Text;

namespace HiQTest
{
    class Car
    {
        public int positionY;
        public int positionX;
        public int heading;

        public Car(int _startpositionY, int _startpositionX, int _heading)
        {
            positionX = _startpositionY;
            positionY = _startpositionX;
            heading = _heading;
        }

        public void Move(string _command)
        {
            if (_command.Equals("F") || _command.Equals("B")) {
                Drive(_command);
            }
            else {
                Turn(_command);
            }
        }

        private void Drive(string _move)
        {
            string axleToMoveOn = CheckAxleToMoveOn();
            Boolean moveForward = CheckDirectionToMove(_move);

            if (axleToMoveOn.Equals("x")) {
                if (moveForward && heading == 90 || !moveForward && heading == 270) {
                    positionX = positionX + 1;
                }
                else {
                    positionX = positionX - 1;
                }
            }
            else {
                if (moveForward && heading == 0 || !moveForward && heading == 180) {
                    positionY = positionY + 1;
                }
                else {
                    positionY = positionY - 1;
                }
            }
        }

        private void Turn(string _direction)
        {
            if (_direction.Equals("R")) {
                heading = heading + 90;
            }
            else {
                heading = heading - 90;
            }

            if (heading < 0) {
                heading = 270;
            }

            if (heading > 270) {
                heading = 0;
            }
        }

        private string CheckAxleToMoveOn()
        {
            string axleToMoveOn = "";

            if (heading == 90 || heading == 270) {
                axleToMoveOn = "x";
            }
            else {
                axleToMoveOn = "y"; 
            }
            return axleToMoveOn;
        }

        private Boolean CheckDirectionToMove(string _direction)
        {
            Boolean moveForward = true;

            if (_direction.Equals("B")) {
                moveForward = false;
            }
            return moveForward;
        }
    }
}
