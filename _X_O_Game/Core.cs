using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;
using System.Threading;

namespace _X_O_Game
{
    public class Core
    {
        Position[,] MainMap,Cursor;
        Graphics g;
        Pen HumanPen, ComputerPen;
        Thread DrawThread;
        bool x_for_computer;
        int StepSize = 1;


        public struct Position
        {
            public char Val;// C for computer and H for human and E for empty
            public int ROW;
            public int COL;
            public int MaxX;
            public int MaxY;
            public int MinX;
            public int MinY;
            public bool state;// true if winning state
        }

        public Graphics G
        {
            get
            {
                return g;
            }
            set
            {
                g = value;
            }
        }

        public bool X_Computer
        {
            set
            {
                x_for_computer = value;
            }
        }

        public Core()
        {
            HumanPen = new Pen(Color.Blue);
            ComputerPen = new Pen(Color.Red);
            DrawThread = new Thread(new ThreadStart(Draw));
            DrawThread.Start();
        }

        public void Distroy()
        {
            if (DrawThread.IsAlive)
                DrawThread.Abort();
        }

        public void Initilize()
        {
            MainMap = new Position[3, 3];
            Cursor = new Position[3, 3];
            StepSize = (int)G.VisibleClipBounds.Width / 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    MainMap[i,j].Val='E';
                    MainMap[i, j].state = false;
                    MainMap[i, j].MaxX = StepSize * j + StepSize;
                    MainMap[i, j].MaxY = StepSize * i + StepSize;
                    MainMap[i, j].MinX = StepSize * j;
                    MainMap[i, j].MinY = StepSize * i;

                    Cursor[i, j].MaxX = StepSize * j + StepSize;
                    Cursor[i, j].MaxY = StepSize * i + StepSize;
                    Cursor[i, j].MinX = StepSize * j;
                    Cursor[i, j].MinY = StepSize * i;
                }
            }

        }

        private Position GetNextMove(Position[,] Map,bool Turn,int Counter)//if turn is true so it is computer turn
        {
            Position Result = new Position();
            Position BestOne = new Position();
            Result.ROW = -1;
            Result.state = false;     
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Map[i, j].Val == 'E')
                    {
                        if (Turn)
                        {
                            Map[i, j].Val = 'C';
                        }
                        else
                        {
                            Map[i, j].Val = 'H';
                        }
                        Map[i, j].ROW = i;
                        Map[i, j].COL = j;
                        int REs=TestWin(Map);
                        if (REs==-1)
                        {
                            Position Pos = new Position();
                            if (!Turn && Counter == 1)
                            {
                                Map[i, j].state = true;
                                Map[i, j].Val = 'N';
                                return Map[i, j];
                            }
                            else
                                Pos.state = false;
                            Result= Pos;                            
                        }
                        else
                        {
                            if (REs == 1)
                            {
                                if (Turn && Counter == 1)
                                {
                                    Map[i, j].state = true;
                                    Map[i, j].Val = 'N';
                                    return Map[i, j];
                                }
                                //else
                                    //Map[i, j].state = true;
                                //Map[i, j].Val = 'N';                               
                                return Map[i, j];
                            }
                            else
                            {
                                Result = GetNextMove(Map, !Turn, Counter+1);
                                if (Result.ROW == -1)
                                {
                                    Map[i, j].state = true;
                                    Map[i,j].Val='T';
                                    Result = Map[i, j];
                                }                                                             
                            }
                        }
                        if (Result.Val == 'N')
                            return Result;
                        if (Result.state)
                        {
                            Map[i, j].state = true;
                            Result= Map[i, j];
                        }
                        Map[i, j].Val = 'E';
                    }
                }
            }
           
            return Result;
        }

        private int TestWin(Position[,] Map)
        {
            int Vert = 0, Hor = 0, vega = 0,vega1=0;
            int Vert2 = 0, Hor2 = 0, vega2 = 0,vega22=0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (Map[i, j].Val == 'C')
                            Vert++;
                        if (Map[j, i].Val == 'C')
                            Hor++;
                        if (Map[i, j].Val == 'C' && i == 2 - j)
                            vega++;
                        if (Map[i, j].Val == 'C' && i == j)
                            vega1++;

                        if (Map[i, j].Val == 'H')
                            Vert2++;
                        if (Map[j, i].Val == 'H')
                            Hor2++;
                        if (Map[i, j].Val == 'H' && i == 2 - j)
                            vega2++;
                        if (Map[i, j].Val == 'H' && i == j)
                            vega22++;
                    }
                    if (Vert == 3)
                        return 1;
                    if (Hor == 3)
                        return 1;
                    if (Vert2 == 3)
                        return -1;
                    if (Hor2 == 3)
                        return -1;
                    Vert = 0;
                    Hor = 0;
                    Vert2 = 0;
                    Hor2 = 0;
                }
                if (vega == 3)
                    return 1;
                if (vega2 == 3)
                    return -1;
                if (vega1 == 3)
                    return 1;
                if (vega22 == 3)
                    return -1;   
            return 0;
        }

        private void Draw()
        {
            while (true)
            {
                DrawPanel();
                DrawMap();
                Thread.Sleep(100);
            }
        }

        public void Move(float X,float Y)
        {
            if (X != -1 && Y != -1)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (X > Cursor[i, j].MinX && X < Cursor[i, j].MaxX && Y > Cursor[i, j].MinY && Y < Cursor[i, j].MaxY)
                        {
                            MainMap[i, j].Val = 'H';
                            break;
                        }
                    }
                }
            }
            if (TestWin(MainMap) == -1)
            {
                System.Windows.Forms.MessageBox.Show("You Win");
                return;
            }
            Position[,] Temp = new Position[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Temp[i, j].Val = MainMap[i, j].Val;
                    Temp[i, j].state = false;
                }
            }
            Position Pos = GetNextMove(Temp, true,0);
            if (Pos.Val == 'N')
            {
                Pos.Val = 'C';
                MainMap[Pos.ROW,Pos.COL].Val='C';
            }
            bool Nowinner = false;
            if (Pos.Val == 'T')
            {
                Nowinner = true;
                Pos.Val = 'C';
                MainMap[Pos.ROW, Pos.COL].Val = 'C';
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Pos.ROW == i && Pos.COL == j)
                        MainMap[i, j] = Pos;
                }
            }
            if (TestWin(MainMap) == 1)
                System.Windows.Forms.MessageBox.Show("I Win");
            if (Nowinner)
            {
                System.Windows.Forms.MessageBox.Show("No body wins today :)");
            }
        }

        private void DrawMap()
        {
            if (MainMap != null)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (MainMap[i, j].Val == 'C' && x_for_computer)
                            G.DrawString("X", new Font(FontFamily.GenericSansSerif, 24, FontStyle.Bold), ComputerPen.Brush, new PointF(j * StepSize + 50, i * StepSize + 50));
                        if (MainMap[i, j].Val == 'C' && !x_for_computer)
                            G.DrawString("O", new Font(FontFamily.GenericSansSerif, 24, FontStyle.Bold), ComputerPen.Brush, new PointF(j * StepSize + 50, i * StepSize + 50));
                        if (MainMap[i, j].Val == 'H' && !x_for_computer)
                            G.DrawString("X", new Font(FontFamily.GenericSansSerif, 24, FontStyle.Bold), ComputerPen.Brush, new PointF(j * StepSize + 50, i * StepSize + 50));
                        if (MainMap[i, j].Val == 'H' && x_for_computer)
                            G.DrawString("O", new Font(FontFamily.GenericSansSerif, 24, FontStyle.Bold), ComputerPen.Brush, new PointF(j * StepSize + 50, i * StepSize + 50));
                    }
                }
            }
        }

        private void DrawPanel()
        {            
            for (int i = 0; i < 3; i++)
            {
                G.DrawLine(new Pen(Color.White), new Point(0, StepSize*i), new Point((int)G.VisibleClipBounds.Width, StepSize*i));
                G.DrawLine(new Pen(Color.White), new Point(StepSize * i, 0), new Point(StepSize * i, (int)G.VisibleClipBounds.Height));
            }
        }

    }
}
