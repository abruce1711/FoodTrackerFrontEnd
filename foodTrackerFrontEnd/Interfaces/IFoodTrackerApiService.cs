﻿namespace foodTrackerFrontEnd.Interfaces
{
    public interface IFoodTrackerApiService<T>
    {
        Task<IEnumerable<T>> List(int household);
    }
}