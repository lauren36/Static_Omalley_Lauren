using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Omalley_Lauren
{
    static class Calculate
    {

        public static float result = 0.0f;

        static Calculate()
        {
            result = 0.0f;
        }

        // Integers
        public static int Add(int x, int y) // Adds two integers together and returns the result
        {
            return x + y;
        }

        public static int Sub(int x, int y) // Subtracts two integers and returns the result
        {
            return x - y;
        }

        public static int Mult(int x, int y) // Multuply two integers together and returns the result
        {
            return x * y;
        }

        public static int Div(int x, int y) // Divides two integers and returns the result
        {
            return x / y;
        }

        // Floaters
        public static float Add(float x, float y) // Adds two floats together and returns the result
        {
            return x + y;
        }

        public static float Sub(float x, float y) // Subtracts two floats and returns the result
        {
            return x - y;
        }

        public static float Mult(float x, float y) // Multuply two floats together and returns the result
        {
            return x * y;
        }

        public static float Div(float x, float y) // Divides two floats and returns the result
        {
            return x / y;
        }

    }

}
