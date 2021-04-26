using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HiQTest
{
    public partial class form : Form
    {
        private string roomY = "0";
        private string roomX = "0";
        private string carY = "0";
        private string carX = "0";
        private string startDir = "";
        List<string> commands = new List<string>();

        public form()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            ClearErrors();
            if (CheckRoomTb() && CheckStartposTb() && CheckCommandTb()) {                
                Room room = new Room(Int32.Parse(roomY),Int32.Parse(roomX));
                Car car = new Car(Int32.Parse(carY), Int32.Parse(carX), SetStartDirection());
                Simulation simulation = new Simulation(commands, car, room);
                MessageBox.Show(simulation.RunSimulation(), "Simulation result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Boolean CheckRoomTb()
        {         
            string roomSize = roomTb.Text;
            if (roomSize.Length == 3)
            {
                roomY = roomSize[0].ToString();
                string space = roomSize[1].ToString();
                roomX = roomSize[2].ToString();

                Regex regex = new Regex("[1-9]");
                Regex regex2 = new Regex(" ");

                if (regex.IsMatch(roomY) && regex.IsMatch(roomX) && regex2.IsMatch(space))
                {

                    return true;
                }
                else {
                    roomErrorLbl.Text = "Must be two integers between 1-9 seperated with a space.";
                    return false;
                }
            }
            else { 
                roomErrorLbl.Text = "Must be two integers between 1-9 seperated with a space.";
                return false;
            }
        }
        private Boolean CheckStartposTb()
        {
            string startpos = startposTb.Text;
            if (startpos.Length == 5) {
                carY = startpos[0].ToString();
                string space = startpos[1].ToString();
                carX = startpos[2].ToString();
                string space2 = startpos[3].ToString();
                startDir = startpos[4].ToString();

                Regex regex = new Regex("[0-9]");
                Regex regex2 = new Regex(" ");
                Regex regex3 = new Regex("[N|S|W|E]");

                if (regex.IsMatch(carY) && regex.IsMatch(carX) && regex2.IsMatch(space) && regex2.IsMatch(space2) && regex3.IsMatch(startDir)) {
                    if (Int32.Parse(carX) < 0 || Int32.Parse(carY) < 0 || Int32.Parse(roomX) <= Int32.Parse(carX) || Int32.Parse(roomY) <= Int32.Parse(carY)) {
                        startposErrorLbl.Text = "The car must be placed in the room.";
                        return false;
                    }
                    else {
                        return true;
                    }
                }
                else {
                    startposErrorLbl.Text = "Must be two integers between 0-9 and one of the letters N, W, S or E seperated with a space.";
                    return false;
                }
            }
            else {
                startposErrorLbl.Text = "Must be two integers between 0-9 and one of the letters N, W, S or E seperated with a space.";
                return false;
            }
        }
        private Boolean CheckCommandTb()
        {
            commands.Clear();
            string inputedCommands = commandTb.Text;
            int executedCommands = 0;
            int amountOfCommands = inputedCommands.Length;
            Regex regex = new Regex("[F|B|L|R]");
            Boolean executeble = true;
            if (amountOfCommands < 1) {
                commandErrorLbl.Text = "You most ad at least one command. The commands can be F, B, L or R.";
                executeble = false;
            }
            else {
                while (amountOfCommands > executedCommands)
                {
                    string commandToAdd = inputedCommands[executedCommands].ToString();
                    if (regex.IsMatch(commandToAdd))
                    {
                        commands.Add(commandToAdd);
                        executedCommands++;
                    }
                    else
                    {
                        commandErrorLbl.Text = "All commands must be in series without space. The commands can be F, B, L or R.";
                        executeble = false;
                        break;
                    }
                }
            }
            return executeble;
        }
        private void ClearErrors()
        {
            roomErrorLbl.Text = "";
            startposErrorLbl.Text = "";
            commandErrorLbl.Text = "";
        }
        private int SetStartDirection() 
        {
            if (startDir.Equals("N")) {
                return 0;
            }
            else if (startDir.Equals("E")) {
                return 90;
            }
            else if (startDir.Equals("S")) {
                return 180;
            }
            else {
                return 270;
            }
        }
    }
}
