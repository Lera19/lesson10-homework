﻿using System;

namespace Homework10
{
    public interface IThing
    {
        string Name { get; }
        void PrintInfo();
        string ToString();
        double Price { get; }
        int ShelLife { get; }
        DateTime CreationDate { get; set; }
    }
}
