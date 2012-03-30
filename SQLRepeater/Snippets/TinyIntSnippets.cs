﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLRepeater.Snippets
{
    public class TinyIntSnippets 
    {
        public static System.Collections.ObjectModel.ObservableCollection<ValueCreatorDelegate> Snippets { get; set; }

        static TinyIntSnippets()
        {
            Snippets = new System.Collections.ObjectModel.ObservableCollection<ValueCreatorDelegate>();
            Snippets.Add(UpCounter);
           // Snippets.Add(DownCounter);
            Snippets.Add(RandomSmallInt);
        }

        public static string UpCounter(int n)
        {
            return (n % byte.MaxValue).ToString();
        }

        //public static string DownCounter(int n)
        //{
        //    return (1 - (n % byte.MaxValue)).ToString();
        //}

        public static string RandomSmallInt(int n)
        {
            return (RandomSupplier.Randomer.Next() % byte.MaxValue).ToString(); 
        }
    }
}
