using System.Collections.Generic;
using System.Linq;
using Autofac;
using ProcessDynamicModel.Helpers.Abstract;
using ProcessDynamicModel.UserModel.Abstract;
using ProcessDynamicModel.ContainerBuilders;
namespace ProcessDynamicModel.Helpers
{
    public class ProcessHelper : IProcessHelper
    {
        string[] Balls = new string[] { "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12", "B13", "B14", "B15" };
        List<string> Containers = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P" };
        int[] countgates = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private string filledpath;
       
        private bool visitFlag { get; set; }

        /// <summary>
        /// Start the Container filling process
        /// </summary>
        public void ContainerProcess()
        {
            string rootGate;
            rootGate = "G1";

            List<string> filledContainers = new List<string>();
            if (Balls != null)
            {
                for (var i = 0; i < Balls.Length; i++)
                {
                    System.Console.WriteLine("Start From" + " " + rootGate + "  passes   " + Balls[i] + " " + visitFlag);
                    filledContainers.Add(FillContainer(Balls[i], rootGate));

                }
            }
            // Find and Print the Container that is empty
            var resultContainerlist = Containers.Except(filledContainers).Select(x => new { Value = x });
            foreach (var emptyContainer in resultContainerlist)
            {
                System.Console.WriteLine("Container" + " " + emptyContainer.Value + " remains Empty");
                System.Console.WriteLine("                                                          ");
                System.Console.WriteLine("                                                          ");
                System.Console.WriteLine("----------------------------------------------------------");
            }
        }

        /// <summary>
        /// Fill the process by passing each Balls
        /// </summary>
        /// <param name="ball"></param>
        /// <param name="gatename"></param>
        /// <returns></returns>
        private  string FillContainer(string ball, string gatename)
        {
            var container = IocContainers.GetIContainer();
            var scope = container.BeginLifetimeScope();
            var nodebranch = scope.Resolve<IBranch>();


            
            var ParentGate = nodebranch.GetSingleGate(gatename);
            var nodeid = nodebranch.GetAllGate().Find(x => x.GateName == gatename).Id;

            countgates[nodeid] = countgates[nodeid] + 1;

            if (countgates[nodeid] % 2 == 0)
            {
                var open = nodebranch.GetAllGate().Find(x => x.Id == nodeid).IsOpen;
                visitFlag = open ? false : true;
            }
            else
            {
                visitFlag = nodebranch.GetAllGate().Find(x => x.Id == nodeid).IsOpen;

            }         


            if (visitFlag)
            {

                if (!string.IsNullOrEmpty(ParentGate.LeftGateName))
                {
                    gatename = ParentGate.LeftGateName;
                    System.Console.Write(ParentGate.LeftGateName + " " + ball + " " + visitFlag + "------>");
                    FillContainer(ball, gatename);
                }
                else
                {
                    System.Console.WriteLine(ParentGate.LeftOutlet + " " + ball + " " + visitFlag);

                    filledpath = ParentGate.LeftOutlet;

                    System.Console.WriteLine("                                                          ");
                    System.Console.WriteLine("                                                          ");
                    System.Console.WriteLine("----------------------------------------------------------");
                }
            }
            else
            {

                if (!string.IsNullOrEmpty(ParentGate.RightGateName))
                {
                    gatename = ParentGate.RightGateName;
                    System.Console.Write(ParentGate.RightGateName + " " + ball + " " + visitFlag + "------>");
                    FillContainer(ball, gatename);
                }
                else
                {
                    System.Console.WriteLine(ParentGate.RightOutlet + " " + ball + " " + visitFlag);

                    filledpath = ParentGate.RightOutlet;

                    System.Console.WriteLine("                                                          ");
                    System.Console.WriteLine("                                                          ");
                    System.Console.WriteLine("----------------------------------------------------------");
                }
            }
            return filledpath;


        }

    }
}
