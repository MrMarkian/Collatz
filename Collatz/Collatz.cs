using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Numerics;
using System.Runtime;
using System.Windows.Forms;


namespace Collatz
{
    public class Collatz
    {
        private BigInteger startingNumber = new();
        private BigInteger currentIteration;
        private Boolean isRunning;
        private BigInteger HigestValueReached;
        private ListBox outPutList;
        private Boolean calculatingNegatives;
        
        public Collatz()
        {
            
        }
        
        public Collatz(String startingNo)
        {
            startingNumber = BigInteger.Parse(startingNo);
            if (startingNumber < 0)
            {
                calculatingNegatives = true;
            }
            outPutList = Application.OpenForms["Form1"]?.Controls["ResultsList"] as ListBox;
            
        }

        public void BeginCalculation()
        {
            outPutList.Items.Clear();
            if (startingNumber.IsZero) return;
            Calculate(startingNumber);
        }
        
        private void Calculate(BigInteger input)
        {
            // If the input is odd then multiply by 3 and add 1
            // If the input is even then divide by 2.

            currentIteration ++;
            String outString = "On Iteration:" + currentIteration.ToString() + " Current Input:" + input.ToString();
            
            outPutList.Items.Add(outString);

            if (calculatingNegatives == true )
            {
                if (input == -5 || input ==-1 || input ==-17)
                 return;
            }
            

            if (input == 1)
            {
                PrintResults();
                return;
            }
            
            if (input.IsEven)
            {
                Calculate(input / 2);
            }
            else
            {
                if (input > HigestValueReached)
                {
                    HigestValueReached = input;
                }
                
                Calculate(input * 3 + 1);
            }
            
        }

        public void PrintResults()
        {
            Console.Write(@"Higest Number Found: ");
            Console.WriteLine(HigestValueReached);
        }

        public BigInteger CurrentIteration => currentIteration;
    }
}