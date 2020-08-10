using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RobosVsDinos
{
    class Fleet
    {
        public Fleet()
        { 
            List<Robot> robots = new List<Robot>();

            Robot firstRobot = new Robot("");
            Robot secondRobot = new Robot("");
            Robot thirdRobot = new Robot("");

            robots.Add(firstRobot);
            robots.Add(secondRobot);
            robots.Add(thirdRobot);
        }
    }
}
