using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    class DFS
    {
        public static Boolean searshpath(int[,] maze, int x, int y, List<int> path)
        {
            if (maze[y,x] == 0)//not-visited node
            {
                    maze[y,x] = 2;//visited node
                    int dx = -1; int dy = 0;
                    if (searshpath(maze, x + dx, y + dy, path))
                    {
                        path.Add(x);
                        path.Add(y);
                        return true;
                    }
                    dx = 1; dy = 0;
                    if (searshpath(maze, x + dx, y + dy, path))
                    {
                        path.Add(x);
                        path.Add(y);
                        return true;
                    }
                    dx = 0; dy = -1;
                    if (searshpath(maze, x + dx, y + dy, path))
                    {
                        path.Add(x);
                        path.Add(y);
                        return true;
                    }
                    dx = 0; dy = 1;
                    if (searshpath(maze, x + dx, y + dy, path))
                    {
                        path.Add(x);
                        path.Add(y);
                        return true;
                    }
            }

            //check target node 
            if (maze[y,x] == 9)
            {
                path.Add(x);
                path.Add(y);
                return true;
            }
            return false;
        }
    }
    }