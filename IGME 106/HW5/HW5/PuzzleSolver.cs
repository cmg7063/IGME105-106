using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class PuzzleSolver
    {
        // Attributes            
        private Form1 form1;
        public List<Peg> pegList;
        private Random rng = new Random(); // Use random num generator to select jumps until a solution is eventually found           
        private bool gameOver;
        private bool solved = false;
        private int movesLeft;
        public string startPos;
        public string displayMoves;
        public string divider;

        // Number holes in board from 0 to 14, 0 being the top peg hole
        private Peg pegZero;
        private Peg pegOne;
        private Peg pegTwo;
        private Peg pegThree;
        private Peg pegFour;
        private Peg pegFive;
        private Peg pegSix;
        private Peg pegSeven;
        private Peg pegEight;
        private Peg pegNine;
        private Peg pegTen;
        private Peg pegEleven;
        private Peg pegTwelve;
        private Peg pegThirteen;
        private Peg pegFourteen;

        // Bools for determining whether or not peg has been moved, all will initialized as true
        private bool pegZeroMoved;
        private bool pegOneMoved;
        private bool pegTwoMoved;
        private bool pegThreeMoved;
        private bool pegFourMoved;
        private bool pegFiveMoved;
        private bool pegSixMoved;
        private bool pegSevenMoved;
        private bool pegEightMoved;
        private bool pegNineMoved;
        private bool pegTenMoved;
        private bool pegElevenMoed;
        private bool pegTwelveMoved;
        private bool pegThirteenMoved;
        private bool pegFourteenMoved;

        // Properties
        public bool Solved
        {
            get { return solved; }
            set { solved = value; }
        }
        public string DisplayInTextBox
        {
            set { form1.Display(value); }
        }
        public PuzzleSolver(Form1 form1)
        {
            this.form1 = form1;

            pegZero = new Peg(0);
            pegOne = new Peg(1);
            pegTwo = new Peg(2);
            pegThree = new Peg(3);
            pegFour = new Peg(4);
            pegFive = new Peg(5);
            pegSix = new Peg(6);
            pegSeven = new Peg(7);
            pegEight = new Peg(8);
            pegNine = new Peg(9);
            pegTen = new Peg(10);
            pegEleven = new Peg(11);
            pegTwelve = new Peg(12);
            pegThirteen = new Peg(13);
            pegFourteen = new Peg(14);

            // Initialize pegList
            pegList = new List<Peg>();

            // Establish edges between Pegs; refer to HW5 doc figure... Like a tree
            // Also populate pegList with each peg
            pegZero.DownLeft = pegOne;
            pegZero.DownRight = pegTwo;
            pegList.Add(pegZero);

            pegOne.DownRight = pegFour;
            pegOne.DownLeft = pegThree;
            pegOne.UpRight = pegZero;
            pegOne.Right = pegTwo;
            pegList.Add(pegOne);      

            pegTwo.DownRight = pegFive;
            pegTwo.DownLeft = pegFour;
            pegTwo.UpLeft = pegZero;
            pegTwo.Left = pegOne;
            pegList.Add(pegTwo);
            
            pegThree.DownRight = pegSeven;
            pegThree.DownLeft = pegSix;
            pegThree.UpRight = pegOne;
            pegThree.Right = pegFour;
            pegList.Add(pegThree);

            pegFour.DownRight = pegEight;
            pegFour.DownLeft = pegSeven;
            pegFour.UpRight = pegTwo;
            pegFour.UpLeft = pegOne;
            pegFour.Right = pegFive;            
            pegFour.Left = pegThree;
            pegList.Add(pegFour);

            pegFive.DownRight = pegNine;
            pegFive.DownLeft = pegEight;
            pegFive.UpLeft = pegTwo;
            pegFive.Left = pegFour;
            pegList.Add(pegFive);

            pegSix.DownRight = pegEleven;
            pegSix.DownLeft = pegTen;
            pegSix.UpRight = pegThree;
            pegSix.Right = pegSeven;
            pegList.Add(pegSix);
                     
            pegSeven.DownRight = pegTwelve;
            pegSeven.DownLeft = pegEleven;
            pegSeven.UpRight = pegFour;
            pegSeven.UpLeft = pegThree;
            pegSeven.Right = pegEight;            
            pegSeven.Left = pegSix;
            pegList.Add(pegSeven);

            pegEight.DownRight = pegThirteen;
            pegEight.DownLeft = pegTwelve;
            pegEight.UpRight = pegFive;
            pegEight.UpLeft = pegFour;
            pegEight.Right = pegNine;        
            pegEight.Left = pegSeven;
            pegList.Add(pegEight);

            pegNine.DownRight = pegFourteen;
            pegNine.DownLeft = pegThirteen;
            pegNine.UpLeft = pegFive;
            pegNine.Left = pegEight;
            pegList.Add(pegNine);
            
            pegTen.UpRight = pegSix;
            pegTen.Right = pegEleven;
            pegList.Add(pegTen);

            pegEleven.UpRight = pegSeven;
            pegEleven.UpLeft = pegSix;
            pegEleven.Right = pegTwelve;
            pegEleven.Left = pegTen;
            pegList.Add(pegEleven);

            pegTwelve.UpRight = pegEight;
            pegTwelve.UpLeft = pegSeven;
            pegTwelve.Right = pegThirteen;
            pegTwelve.Left = pegEleven;
            pegList.Add(pegTwelve);
            
            pegThirteen.UpRight = pegNine;
            pegThirteen.UpLeft = pegEight;
            pegThirteen.Right = pegFourteen;
            pegThirteen.Left = pegTwelve;
            pegList.Add(pegThirteen);

            pegFourteen.UpLeft = pegNine;
            pegFourteen.Left = pegThirteen;
            pegList.Add(pegFourteen);   
        }



        public void SolvePuzzle(int startPeg)
        {
            divider = "================================================";
            startPos = "Position Done: " + startPeg;
            displayMoves = Environment.NewLine + "Moves: ";

            foreach(Peg peg in pegList)
            {
                peg.IsEmpty = false;
            }

            pegZeroMoved = true;
            pegOneMoved = true;
            pegTwoMoved = true;
            pegThreeMoved = true;
            pegFourMoved = true;
            pegFiveMoved = true;
            pegSixMoved = true;
            pegSevenMoved = true;
            pegEightMoved = true;
            pegNineMoved = true;
            pegTenMoved = true;
            pegElevenMoed = true;
            pegTwelveMoved = true;
            pegThirteenMoved = true;
            pegFourteenMoved = true;

            movesLeft = 14; //14 pegs, 1 empty hole
            pegList[startPeg].IsEmpty = true;
            gameOver = false;

            while (!gameOver)
            {
                int random = rng.Next(0, 15);
                // Check Peg 0 to see if we can jump to this position
                if(random == 0)
                {
                    if(pegZero.IsEmpty == false) // If pegZero is at position 0 (start of graph)
                    {
                        if(pegZero.DownLeft.IsEmpty == false && pegZero.DownLeft.DownLeft.IsEmpty == true) // Check edges of pegZero to see if it is possible to jump to that position
                        {
                            pegZero.IsEmpty = true; // Representative of peg jumping and removing peg at DownLeft position
                            pegZero.DownLeft.IsEmpty = true;
                            pegZero.DownLeft.DownLeft.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegZero.NumPeg + " to " + pegZero.DownLeft.DownLeft.NumPeg; // Update displayMoves to be printed when egLeft = 0
                            movesLeft--;
                            continue;
                        }
                        if (pegZero.DownRight.IsEmpty == false && pegZero.DownRight.DownRight.IsEmpty == true) // Check DownRight edge
                        {
                            pegZero.IsEmpty = true;
                            pegZero.DownRight.IsEmpty = true;
                            pegZero.DownRight.DownRight.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegZero.NumPeg + " to " + pegZero.DownRight.DownRight.NumPeg;
                            movesLeft--;
                            continue;
                        }
                    }
                    pegZeroMoved = false;
                }
                // Check Peg 1
                else if (random == 1)
                {
                    if (pegOne.IsEmpty == false)
                    {
                        if (pegOne.DownLeft.IsEmpty == false && pegOne.DownLeft.DownLeft.IsEmpty == true)
                        {
                            pegOne.IsEmpty = true;
                            pegOne.DownLeft.IsEmpty = true;
                            pegOne.DownLeft.DownLeft.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegOne.NumPeg + " to " + pegOne.DownLeft.DownLeft.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegOne.DownRight.IsEmpty == false && pegOne.DownRight.DownRight.IsEmpty == true)
                        {
                            pegOne.IsEmpty = true;
                            pegOne.DownRight.IsEmpty = true;
                            pegOne.DownRight.DownRight.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegOne.NumPeg + " to " + pegOne.DownRight.DownRight.NumPeg;
                            movesLeft--;
                            continue;
                        }
                    }
                    pegOneMoved = false;
                }
                // Check Peg 2
                else if (random == 2)
                {
                    if (pegTwo.IsEmpty == false)
                    {
                        if (pegTwo.DownLeft.IsEmpty == false && pegTwo.DownLeft.DownLeft.IsEmpty == true)
                        {
                            pegTwo.IsEmpty = true;
                            pegTwo.DownLeft.IsEmpty = true;
                            pegTwo.DownLeft.DownLeft.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegTwo.NumPeg + " to " + pegTwo.DownLeft.DownLeft.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegTwo.DownRight.IsEmpty == false && pegTwo.DownRight.DownRight.IsEmpty == true)
                        {
                            pegTwo.IsEmpty = true;
                            pegTwo.DownRight.IsEmpty = true;
                            pegTwo.DownRight.DownRight.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegTwo.NumPeg + " to " + pegTwo.DownRight.DownRight.NumPeg;
                            movesLeft--;
                            continue;
                        }
                    }
                    pegTwoMoved = false;
                }
                // Check Peg 3
                else if (random == 3)
                {
                    if (pegThree.IsEmpty == false)
                    {
                        if (pegThree.DownLeft.IsEmpty == false && pegThree.DownLeft.DownLeft.IsEmpty == true)
                        {
                            pegThree.IsEmpty = true;
                            pegThree.DownLeft.IsEmpty = true;
                            pegThree.DownLeft.DownLeft.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegThree.NumPeg + " to " + pegThree.DownLeft.DownLeft.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegThree.DownRight.IsEmpty == false && pegThree.DownRight.DownRight.IsEmpty == true)
                        {
                            pegThree.IsEmpty = true;
                            pegThree.DownRight.IsEmpty = true;
                            pegThree.DownRight.DownRight.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegThree.NumPeg + " to " + pegThree.DownRight.DownRight.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegThree.UpRight.IsEmpty == false && pegThree.UpRight.UpRight.IsEmpty == true)
                        {
                            pegThree.IsEmpty = true;
                            pegThree.UpRight.IsEmpty = true;
                            pegThree.UpRight.UpRight.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegThree.NumPeg + " to " + pegThree.UpRight.UpRight.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegThree.Right.IsEmpty == false && pegThree.Right.Right.IsEmpty == true)
                        {
                            pegThree.IsEmpty = true;
                            pegThree.Right.IsEmpty = true;
                            pegThree.Right.Right.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegThree.NumPeg + " to " + pegThree.Right.Right.NumPeg;
                            movesLeft--;
                            continue;
                        }
                    }
                    pegThreeMoved = false;
                }
                // Check Peg 4
                else if (random == 4)
                {
                    if (pegFour.IsEmpty == false)
                    {
                        if (pegFour.DownLeft.IsEmpty == false && pegFour.DownLeft.DownLeft.IsEmpty == true)
                        {
                            pegFour.IsEmpty = true;
                            pegFour.DownLeft.IsEmpty = true;
                            pegFour.DownLeft.DownLeft.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegFour.NumPeg + " to " + pegFour.DownLeft.DownLeft.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegFour.DownRight.IsEmpty == false && pegFour.DownRight.DownRight.IsEmpty == true)
                        {
                            pegFour.IsEmpty = true;
                            pegFour.DownRight.IsEmpty = true;
                            pegFour.DownRight.DownRight.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegFour.NumPeg + " to " + pegFour.DownRight.DownRight.NumPeg;
                            movesLeft--;
                            continue;
                        }
                    }
                    pegFourMoved = false;
                }
                // Check Peg 5
                else if (random == 5)
                {
                    if (pegFive.IsEmpty == false)
                    {
                        if (pegFive.DownLeft.IsEmpty == false && pegFive.DownLeft.DownLeft.IsEmpty == true)
                        {
                            pegFive.IsEmpty = true;
                            pegFive.DownLeft.IsEmpty = true;
                            pegFive.DownLeft.DownLeft.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegFive.NumPeg + " to " + pegFive.DownLeft.DownLeft.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegFive.DownRight.IsEmpty == false && pegFive.DownRight.DownRight.IsEmpty == true)
                        {
                            pegFive.IsEmpty = true;
                            pegFive.DownRight.IsEmpty = true;
                            pegFive.DownRight.DownRight.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegFive.NumPeg + " to " + pegFive.DownRight.DownRight.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegFive.UpLeft.IsEmpty == false && pegFive.UpLeft.UpLeft.IsEmpty == true)
                        {
                            pegFive.IsEmpty = true;
                            pegFive.UpLeft.IsEmpty = true;
                            pegFive.UpLeft.UpLeft.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegFive.NumPeg + " to " + pegFive.UpLeft.UpLeft.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegFive.Left.IsEmpty == false && pegFive.Left.Left.IsEmpty == true)
                        {
                            pegFive.IsEmpty = true;
                            pegFive.Left.IsEmpty = true;
                            pegFive.Left.Left.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegFive.NumPeg + " to " + pegFive.Left.Left.NumPeg;
                            movesLeft--;
                            continue;
                        }
                    }
                    pegFiveMoved = false;
                }
                // Check Peg 6
                else if (random == 6)
                {
                    if (pegSix.IsEmpty == false)
                    {
                        if (pegSix.UpRight.IsEmpty == false && pegSix.UpRight.UpRight.IsEmpty == true)
                        {
                            pegSix.IsEmpty = true;
                            pegSix.UpRight.IsEmpty = true;
                            pegSix.UpRight.UpRight.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegSix.NumPeg + " to " + pegSix.UpRight.UpRight.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegSix.Right.IsEmpty == false && pegSix.Right.Right.IsEmpty == true)
                        {
                            pegSix.IsEmpty = true;
                            pegSix.Right.IsEmpty = true;
                            pegSix.Right.Right.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegSix.NumPeg + " to " + pegSix.Right.Right.NumPeg;
                            movesLeft--;
                            continue;
                        }
                    }
                    pegSixMoved = false;
                }
                // Check Peg 7
                else if (random == 7)
                {
                    if (pegSeven.IsEmpty == false)
                    {                    
                        if (pegSeven.Right.IsEmpty == false && pegSeven.Right.Right.IsEmpty == true)
                        {
                            pegSeven.IsEmpty = true;
                            pegSeven.Right.IsEmpty = true;
                            pegSeven.Right.Right.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegSeven.NumPeg + " to " + pegSeven.Right.Right.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegSeven.UpRight.IsEmpty == false && pegSeven.UpRight.UpRight.IsEmpty == true)
                        {
                            pegSeven.IsEmpty = true;
                            pegSeven.UpRight.IsEmpty = true;
                            pegSeven.UpRight.UpRight.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegSeven.NumPeg + " to " + pegSeven.UpRight.UpRight.NumPeg;
                            movesLeft--;
                            continue;
                        }
                    }
                    pegSevenMoved = false;
                }
                // Check Peg 8
                else if (random == 8)
                {
                    if (pegEight.IsEmpty == false)
                    {
                        if (pegEight.UpLeft.IsEmpty == false && pegEight.UpLeft.UpLeft.IsEmpty == true)
                        {
                            pegEight.IsEmpty = true;
                            pegEight.UpLeft.IsEmpty = true;
                            pegEight.UpLeft.UpLeft.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegEight.NumPeg + " to " + pegEight.UpLeft.UpLeft.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegEight.Left.IsEmpty == false && pegEight.Left.Left.IsEmpty == true)
                        {
                            pegEight.IsEmpty = true;
                            pegEight.Left.IsEmpty = true;
                            pegEight.Left.Left.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegEight.NumPeg + " to " + pegEight.Left.Left.NumPeg;
                            movesLeft--;
                            continue;
                        }
                    }
                    pegEightMoved = false;
                }
                // Check Peg 9
                else if (random == 9)
                {
                    if (pegNine.IsEmpty == false)
                    {
                        if (pegNine.UpLeft.IsEmpty == false && pegNine.UpLeft.UpLeft.IsEmpty == true)
                        {
                            pegNine.IsEmpty = true;
                            pegNine.UpLeft.IsEmpty = true;
                            pegNine.UpLeft.UpLeft.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegNine.NumPeg + " to " + pegNine.UpLeft.UpLeft.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegNine.Left.IsEmpty == false && pegNine.Left.Left.IsEmpty == true)
                        {
                            pegNine.IsEmpty = true;
                            pegNine.Left.IsEmpty = true;
                            pegNine.Left.Left.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegNine.NumPeg + " to " + pegNine.Left.Left.NumPeg;
                            movesLeft--;
                            continue;
                        }
                    }
                    pegNineMoved = false;
                }
                // Check Peg 10
                else if (random == 10)
                {
                    if (pegTen.IsEmpty == false)
                    {
                        if (pegTen.UpRight.IsEmpty == false && pegTen.UpRight.UpRight.IsEmpty == true)
                        {
                            pegTen.IsEmpty = true;
                            pegTen.UpRight.IsEmpty = true;
                            pegTen.UpRight.UpRight.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegTen.NumPeg + " to " + pegTen.UpRight.UpRight.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegTen.Right.IsEmpty == false && pegTen.Right.Right.IsEmpty == true)
                        {
                            pegTen.IsEmpty = true;
                            pegTen.Right.IsEmpty = true;
                            pegTen.Right.Right.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegTen.NumPeg + " to " + pegTen.Right.Right.NumPeg;
                            movesLeft--;
                            continue;
                        }
                    }
                    pegTenMoved = false;
                }
                // Check Peg 11
                else if (random == 11)
                {
                    if (pegEleven.IsEmpty == false)
                    {
                        if (pegEleven.UpRight.IsEmpty == false && pegEleven.UpRight.UpRight.IsEmpty == true)
                        {
                            pegEleven.IsEmpty = true;
                            pegEleven.UpRight.IsEmpty = true;
                            pegEleven.UpRight.UpRight.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegEleven.NumPeg + " to " + pegEleven.UpRight.UpRight.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegEleven.Right.IsEmpty == false && pegEleven.Right.Right.IsEmpty == true)
                        {
                            pegEleven.IsEmpty = true;
                            pegEleven.Right.IsEmpty = true;
                            pegEleven.Right.Right.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegEleven.NumPeg + " to " + pegEleven.Right.Right.NumPeg;
                            movesLeft--;
                            continue;
                        }
                    }
                    pegElevenMoed = false;
                }
                // Check Peg 12
                else if (random == 12)
                {
                    if (pegTwelve.IsEmpty == false)
                    {
                        if (pegTwelve.UpRight.IsEmpty == false && pegTwelve.UpRight.UpRight.IsEmpty == true)
                        {
                            pegTwelve.IsEmpty = true;
                            pegTwelve.UpRight.IsEmpty = true;
                            pegTwelve.UpRight.UpRight.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegTwelve.NumPeg + " to " + pegTwelve.UpRight.UpRight.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegTwelve.UpLeft.IsEmpty == false && pegTwelve.UpLeft.UpLeft.IsEmpty == true)
                        {
                            pegTwelve.IsEmpty = true;
                            pegTwelve.UpLeft.IsEmpty = true;
                            pegTwelve.UpLeft.UpLeft.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegTwelve.NumPeg + " to " + pegTwelve.UpLeft.UpLeft.NumPeg;
                            movesLeft--;
                            continue;
                        }
                    }
                    pegTwelveMoved = false;
                }
                // Check Peg 13
                else if (random == 13)
                {
                    if (pegThirteen.IsEmpty == false)
                    {
                        if (pegThirteen.UpLeft.IsEmpty == false && pegThirteen.UpLeft.UpLeft.IsEmpty == true)
                        {
                            pegThirteen.IsEmpty = true;
                            pegThirteen.UpLeft.IsEmpty = true;
                            pegThirteen.UpLeft.UpLeft.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegThirteen.NumPeg + " to " + pegThirteen.UpLeft.UpLeft.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegThirteen.Left.IsEmpty == false && pegThirteen.Left.Left.IsEmpty == true)
                        {
                            pegThirteen.IsEmpty = true;
                            pegThirteen.Left.IsEmpty = true;
                            pegThirteen.Left.Left.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegThirteen.NumPeg + " to " + pegThirteen.Left.Left.NumPeg;
                            movesLeft--;
                            continue;
                        }
                    }
                    pegThirteenMoved = false;
                }
                // Check Peg 14
                else if (random == 14)
                {
                    if (pegFourteen.IsEmpty == false)
                    {
                        if (pegFourteen.UpLeft.IsEmpty == false && pegFourteen.UpLeft.UpLeft.IsEmpty == true)
                        {
                            pegFourteen.IsEmpty = true;
                            pegFourteen.UpLeft.IsEmpty = true;
                            pegFourteen.UpLeft.UpLeft.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegFourteen.NumPeg + " to " + pegFourteen.UpLeft.UpLeft.NumPeg;
                            movesLeft--;
                            continue;
                        }
                        if (pegFourteen.Left.IsEmpty == false && pegFourteen.Left.Left.IsEmpty == true)
                        {
                            pegFourteen.IsEmpty = true;
                            pegFourteen.Left.IsEmpty = true;
                            pegFourteen.Left.Left.IsEmpty = false;
                            displayMoves += Environment.NewLine + "From: " + pegFourteen.NumPeg + " to " + pegFourteen.Left.Left.NumPeg;
                            movesLeft--;
                            continue;
                        }
                    }
                    pegFourteenMoved = false;
                }
                if (pegZeroMoved == false && pegOneMoved == false && pegTwoMoved == false && pegThreeMoved == false && pegFourMoved == false && pegFiveMoved == false && pegSixMoved == false && pegSevenMoved == false && pegEightMoved == false && pegNineMoved == false && pegTenMoved == false && pegElevenMoed == false && pegTwelveMoved == false && pegThirteenMoved == false && pegFourteenMoved == false)
                {
                    if(movesLeft == 1)
                    {
                        solved = true;
                        displayMoves += Environment.NewLine + "Pegs Left: " + movesLeft;
                        DisplayInTextBox = divider + startPos + displayMoves;
                        break;
                    }
                    displayMoves = "";
                    gameOver = true;
                }
            }
        }
    }
}
