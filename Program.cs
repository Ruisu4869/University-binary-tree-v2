using System;

namespace University_binary_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            PositionTree rector = new PositionTree();
            rector.NameEmployed = "Rector";
            rector.SalaryEmployed = 1000;
            rector.Percentage = 20;

            PositionTree vicFinan = new PositionTree();
            vicFinan.NameEmployed = "Vicerector financiero";
            vicFinan.SalaryEmployed = 750;
            vicFinan.Percentage = 15;

            PositionTree contador = new PositionTree();
            contador.NameEmployed = "Contador";
            contador.SalaryEmployed = 500;
            contador.Percentage = 12;

            PositionTree secret1 = new PositionTree();
            secret1.NameEmployed = "Secretaria 1";
            secret1.SalaryEmployed = 350;
            secret1.Percentage = 26;

            PositionTree secret2 = new PositionTree();
            secret2.NameEmployed = "Secretaria 2";
            secret2.SalaryEmployed = 310;
            secret2.Percentage = 3;

            PositionTree jefeFin = new PositionTree();
            jefeFin.NameEmployed = "Jefe financiero";
            jefeFin.SalaryEmployed = 610;
            jefeFin.Percentage = 16;

            PositionTree vicAcad = new PositionTree();
            vicAcad.NameEmployed = "Vicerector Académico";
            vicAcad.SalaryEmployed = 780;
            vicAcad.Percentage = 18;

            PositionTree jefeReg = new PositionTree();
            jefeReg.NameEmployed = "Jefe de registro";
            jefeReg.SalaryEmployed = 640;
            jefeReg.Percentage = 5;

            PositionTree secretReg2 = new PositionTree();
            secretReg2.NameEmployed = "Secretaria de registro 2";
            secretReg2.SalaryEmployed = 360;
            secretReg2.Percentage = 13;

            PositionTree secretReg1 = new PositionTree();
            secretReg1.NameEmployed = "Secretaria de registro 1";
            secretReg1.SalaryEmployed = 400;
            secretReg1.Percentage = 6;

            PositionTree asist2 = new PositionTree();
            asist2.NameEmployed = "Asistente 2";
            asist2.SalaryEmployed = 170;
            asist2.Percentage = 23;

            PositionTree msn = new PositionTree();
            msn.NameEmployed = "Mensajero";
            msn.SalaryEmployed = 90;
            msn.Percentage = 12;

            PositionTree asist1 = new PositionTree();
            asist1.NameEmployed = "Asistente 1";
            asist1.SalaryEmployed = 250;
            asist1.Percentage = 14;

          

            UniversityBinaryTree universityTree = new UniversityBinaryTree();
            universityTree.AddPosition(null, rector, null);

            universityTree.AddPosition(universityTree.RootNode, vicFinan, rector.NameEmployed);
            universityTree.AddPosition(universityTree.RootNode, contador, vicFinan.NameEmployed);
            universityTree.AddPosition(universityTree.RootNode, secret1, contador.NameEmployed);
            universityTree.AddPosition(universityTree.RootNode, secret2, contador.NameEmployed);
            universityTree.AddPosition(universityTree.RootNode, jefeFin, vicFinan.NameEmployed);

            universityTree.AddPosition(universityTree.RootNode, vicAcad, rector.NameEmployed);
            universityTree.AddPosition(universityTree.RootNode, jefeReg, vicAcad.NameEmployed);
            universityTree.AddPosition(universityTree.RootNode, secretReg2, jefeReg.NameEmployed);
            universityTree.AddPosition(universityTree.RootNode, secretReg1, jefeReg.NameEmployed);
            universityTree.AddPosition(universityTree.RootNode, asist2, secretReg1.NameEmployed);
            universityTree.AddPosition(universityTree.RootNode, msn, asist2.NameEmployed);
            universityTree.AddPosition(universityTree.RootNode, asist1, secretReg1.NameEmployed);


            universityTree.PrintTree(universityTree.RootNode);

            int nodesTotal = universityTree.SumatoryNode(universityTree.RootNode);
            float totalSumSalaries = universityTree.SumSalaries(universityTree.RootNode);
            float totalSumOther = universityTree.OtherSumatory(universityTree.RootNode.Left.Right);
            float longestSal = universityTree.OtherSumatory(universityTree.RootNode.Right);
            float percentage = universityTree.Percentage(universityTree.RootNode);
            float average = universityTree.AverageSalary(nodesTotal, universityTree.RootNode);

            Console.WriteLine("---*---*---*---*---*---*---*---*---");
            Console.WriteLine("Total salaries: " + totalSumSalaries);
            Console.WriteLine("---*---*---*---*---*---*---*---*---");
            Console.WriteLine("Total other salary: " + totalSumOther);
            Console.WriteLine("---*---*---*---*---*---*---*---*---");
            Console.WriteLine(" ");
            Console.WriteLine("Longest salary: " + longestSal);
            Console.WriteLine("---*---*---*---*---*---*---*---*---");
            universityTree.PrintTree(universityTree.RootNode.Right);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("---*---*---*---*---*---*---*---*---");
            Console.WriteLine("Percentage sum: " + percentage);
            Console.WriteLine("---*---*---*---*---*---*---*---*---");
            Console.WriteLine("Average salary: " + average);
            Console.ReadLine();
        }
    }
}
