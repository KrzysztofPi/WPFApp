using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZalWPF
{
    class Helper
    {

        static String tableName;

        public static String WhatLaws (int index)
        {
            switch (index)
            {
                case 1:
                    {
                        tableName = "Grass_Laws";
                        break;
                    }
                case 2:
                    {
                        tableName = "Indoor_Laws";
                        break;
                    }
                case 3:
                    {
                        tableName = "Beach_Laws";
                        break;
                    }
            }
            return tableName;
        }

    }
}
